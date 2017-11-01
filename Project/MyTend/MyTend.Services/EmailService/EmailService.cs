namespace MyTend.Services.EmailService
{
    using FluentEmail;
    using MyTend.Entites;
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Linq;
    using System.Net;
    using System.Net.Mail;
    using System.Text;
    using System.Threading.Tasks;

    public class EmailService
    {
        private EmailTemplates Templates { get; set; }

        private string _from { get; set; }
        private string _email { get; set; }

        public EmailService(string email)
        {
            this.Templates = new EmailTemplates();
            this._from = ConfigurationManager.AppSettings["EmailServiceFrom"];
            this._email = email;
        }

        public SmtpClient GetClient()
        {
            var smtpClient = new SmtpClient(
                ConfigurationManager.AppSettings["EmailServiceHost"],
                int.Parse(ConfigurationManager.AppSettings["EmailServicePort"]));
            smtpClient.Credentials = new NetworkCredential(
                ConfigurationManager.AppSettings["EmailServiceName"], 
                ConfigurationManager.AppSettings["EmailServicePassword"]);
            smtpClient.EnableSsl = ConfigurationManager.AppSettings["EmailServiceSsl"] == "true" ? true : false;

            return smtpClient;
        }

        public void Registration(string name, string login, string password)
        {
            try
            {
                Email.From(this._from)
                .To(this._email)
                .Subject("Спасибо за регистрацию")
                .UsingCultureTemplateFromFile("~\\Content\\email\\registration.html", new { Login = login, Password = password, Name = name })
                .UsingClient(this.GetClient())
                .Send();
            }
            catch (Exception e)
            {
                var logRec = new Log()
                {
                    Context = "Registration",
                    Level = MyTend.Entites.Enums.LogLevel.Info,
                    Message = e.Message,
                    Stack = e.StackTrace,
                    UserName = null
                };

                logRec.Save();
            }
        }

        public void Winner(string tenderId, string name, string tenderTitle)
        {
            try
            {
                Email.From(this._from)
                .To(this._email)
                .Subject("Вы победитель конкурсного-торга")
                .UsingCultureTemplateFromFile("~\\Content\\email\\winner.html", new { TenderId = tenderId, Title = tenderTitle, Name = name })
                .UsingClient(this.GetClient())
                .Send();
            }
            catch (Exception e)
            {
                var logRec = new Log()
                {
                    Context = "Winner",
                    Level = MyTend.Entites.Enums.LogLevel.Info,
                    Message = e.Message,
                    Stack = e.StackTrace,
                    UserName = null
                };

                logRec.Save();
            }
        }

        public void SelectredWinner(string tenderId, string name, string tenderTitle)
        {
            try
            {
                Email.From(this._from)
                .To(this._email)
                .Subject("Вы победитель конкурсного-торга")
                .UsingCultureTemplateFromFile("~\\Content\\email\\selecedwinner.html", new { TenderId = tenderId, Title = tenderTitle, Name = name })
                .UsingClient(this.GetClient())
                .Send();
            }
            catch (Exception e)
            {
                var logRec = new Log()
                {
                    Context = "Winner",
                    Level = MyTend.Entites.Enums.LogLevel.Info,
                    Message = e.Message,
                    Stack = e.StackTrace,
                    UserName = null
                };

                logRec.Save();
            }
        }

        public void AddComment(string to,string tenderId, string name, string tenderTitle)
        {
            try
            {
                /*Email.From(this._from)
                .To(this._email)
                .Subject("Новый коментарий в конкурсном-торге:" + tenderTitle)
                .UsingCultureTemplateFromFile("~\\Content\\email\\getresponce.html", new {To = to, TenderId = tenderId, Title = tenderTitle, Name = name })
                .UsingClient(this.GetClient())
                .Send();*/
            }
            catch (Exception e)
            {
                var logRec = new Log()
                {
                    Context = "AddComment",
                    Level = MyTend.Entites.Enums.LogLevel.Info,
                    Message = e.Message,
                    Stack = e.StackTrace,
                    UserName = null
                };

                logRec.Save();
            }
        }

        public void CreateTender(string tenderId, string title)
        {
            try
            {
                Email.From(this._from)
                .To(ConfigurationManager.AppSettings["TenderEmail"])
                .Subject("Создан торг")
                .UsingCultureTemplateFromFile("~\\Content\\email\\create.html", new { TenderId = tenderId, Title = title })
                .UsingClient(this.GetClient())
                .Send();
            }
            catch (Exception e)
            {
                var logRec = new Log()
                {
                    Context = "CreateTender",
                    Level = MyTend.Entites.Enums.LogLevel.Info,
                    Message = e.Message,
                    Stack = e.StackTrace,
                    UserName = null
                };

                logRec.Save();
            }
        }

        public void MakePay(string login, string name, string time, string sum)
        {
            try
            {
                Email.From(this._from)
                .To(ConfigurationManager.AppSettings["ManyEmail"])
                .Subject("Произведена оплата")
                .UsingCultureTemplateFromFile("~\\Content\\email\\makepay.html", new { Login = login, Fullname = name, Date = time, Sum = sum })
                .UsingClient(this.GetClient())
                .Send();
            }
            catch (Exception e)
            {
                var logRec = new Log()
                {
                    Context = "MakePay",
                    Level = MyTend.Entites.Enums.LogLevel.Info,
                    Message = e.Message,
                    Stack = e.StackTrace,
                    UserName = null
                };

                logRec.Save();
            }
        }
    }
}
