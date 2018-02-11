namespace MyTender.Security
{
    using MyTend.Entites;
    using MyTender.Core;
    using MyTender.Security.Utils;
    using System;
    using System.Linq;
    using System.Web;
    using System.Web.Security;

    public class AuthService
    {
        private UserSystem CurrentSystemUser { get; set; }
        
        public UserSystem User
        { 
            get 
            {
                try
                {
                    HttpCookie authCookie = System.Web.HttpContext.Current.Request.Cookies.Get(Constants._COOKIE_NAME);
                    if (authCookie != null && !string.IsNullOrEmpty(authCookie.Value))
                    {
                        var ticket = FormsAuthentication.Decrypt(authCookie.Value);

                        this.CurrentSystemUser = UserSystem.FindAll()
                            .FirstOrDefault(x => x.Login.ToLower() == ticket.Name.ToLower());
                    }
                }
                catch(Exception e)
                {
                    return null;
                }

                return this.CurrentSystemUser;
            } 
        }

        public void Login(string login, string password)
        {
            var user = UserSystem.FindAll()
                .FirstOrDefault(x => x.Login.ToLower() == login.ToLower());

            if (user != null)
            {
                var pswd = MD5Helper.GetMD5String(password);

                if (user.Password != pswd)
                {
                    throw new Exception(Constants._UNKNOW_USER);
                }

                this.CreateCookie(user.Login);
            }
            else
            {
                throw new Exception(Constants._UNKNOW_USER);
            }
        }

        public void Login(string login)
        {
            var user = UserSystem.GetByProp("Login", login.ToLower()).FirstOrDefault();

            if (user != null)
            {
                this.CreateCookie(user.Login);
            }

            throw new Exception(Constants._UNKNOW_USER);
        }

        public void Logout()
        {
            var httpCookie = System.Web.HttpContext.Current.Response.Cookies[Constants._COOKIE_NAME];

            if (httpCookie != null)
            {
                httpCookie.Value = string.Empty;
                FormsAuthentication.SignOut();
            }
        }

        private void CreateCookie(string userName, bool isPersistent = false)
        {
            var issuer = DateTime.Now.AddDays(30);

            var ticket = new FormsAuthenticationTicket(
                  1,
                  userName,
                  DateTime.Now,
                  issuer,
                  isPersistent,
                  string.Empty,
                  FormsAuthentication.FormsCookiePath);

            // Encrypt the ticket.
            var encTicket = FormsAuthentication.Encrypt(ticket);

            // Create the cookie.
            var AuthCookie = new HttpCookie(Constants._COOKIE_NAME)
            {
                Value = encTicket,
                Expires = DateTime.Now.Add(new TimeSpan(30, 0, 0, 0))
            };

            System.Web.HttpContext.Current.Response.Cookies.Set(AuthCookie);
        }
    }
}
