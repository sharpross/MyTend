using System.Security.Cryptography;
using System.Text;
using System.Web.Mvc;
using MyTend.Services.Common;

namespace MyTend.Controllers
{
    public class PayController : BaseController
    {
        // GET: Pay
        public ActionResult Index()
        {
            return Redirect("/home/index");
            this.ViewBag.NoIndexing = true;

            //ViewBag.PayScript = GetPayString();
            ViewBag.PayHistory = new PayService(this.Auth.User).GetHistory();
            ViewBag.PayEnd = new PayService(this.Auth.User).GetDatePayEnd();

            return View();
        }

        /*private string GetPayString()
        {
            var payService = new PayService(this.Auth.User);

            var priceRub = int.Parse(ConfigurationManager.AppSettings["PayValue"]);
            var orderId = payService.PrepareAccount();
            var customerEmail = this.Auth.User.Login;

            string redirectUrl =
                string.Format("<a id=\"gopay\" class=\"btn btn-custom-green\" href=\"{0}\" disabled >Оплатить</a>",
                Robokassa.GetRedirectUrl(priceRub, orderId, customerEmail, this.Auth.User.Id.ToString()));
            
            return redirectUrl;

        }*/

        /*[HttpGet]
        public string Result(RobokassaConfirmationRequest confirmationRequest)
        {
            try
            {
                var log = new Log()
                {
                    Context = "Pay",
                    Level = Entites.Enums.LogLevel.Critical,
                    Message = this.Request.RawUrl,
                    UserName = this.Auth.User != null ? this.Auth.User.Login : "System",
                    Addr = this.Request.ServerVariables["REMOTE_ADDR"],
                    Agent = this.Request.ServerVariables["HTTP_USER_AGENT"],
                    Query = this.Request.ServerVariables["QUERY_STRING"]
                };

                log.Create();
            }
            catch (Exception ex)
            {
            }

            try
            {

                if (confirmationRequest.IsQueryValid(RobokassaQueryType.ResultURL))
                {
                    var userId = int.Parse(confirmationRequest.Shp_item);

                    var dateBegin = DateTime.Now;
                    var dateEnd = DateTime.Now.AddMonths(1);

                    var user = UserSystem.GetById(userId); 

                    if (user != null)
                    {
                        var payService = new PayService(user);
                        payService.MakePay(confirmationRequest.InvId);

                        try
                        {
                            var service = new EmailService(this.Auth.User.Email);
                            service.MakePay(this.Auth.User.Login, this.Auth.User.FullName, DateTime.Now.ToString(), Constants._SUB_SUM.ToString());
                        }
                        catch
                        { }
                    }

                    return "OK"; 
                }
            }
            catch (Exception) 
            {
                return "False";
            }

            return "False";
        }*/

        /*public ActionResult Success(RobokassaConfirmationRequest confirmationRequest)
        {
            this.ViewBag.NoIndexing = true;

            return View();
        }*/

        public ActionResult Fail()
        {
            this.ViewBag.NoIndexing = true;

            return View();
        }

        private bool IsValid()
        {
            string sMrchPass2 = "my-tend2016";

            // HTTP parameters
            string sOutSum = GetPrm("OutSum");
            string sInvId = GetPrm("InvId");
            string Shp_item = GetPrm("Shp_item");
            string sCrc = GetPrm("SignatureValue");

            string sCrcBase = string.Format("{0}:{1}:{2}:Shp_item={3}",
                                             sOutSum, sInvId, sMrchPass2, Shp_item);

            // build own CRC
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] bSignature = md5.ComputeHash(Encoding.ASCII.GetBytes(sCrcBase));

            StringBuilder sbSignature = new StringBuilder();
            foreach (byte b in bSignature)
                sbSignature.AppendFormat("{0:x2}", b);

            string sMyCrc = sbSignature.ToString();

            if (sMyCrc.ToUpper() != sCrc.ToUpper())
            {
                return false;
            }

            return true;
        }

        private string GetPrm(string sName)
        {
            string sValue = string.Empty;

            if ((this.Request.Params[sName] as string) != null)
                return this.Request.Params[sName] as string;

            if ((this.Request[sName] as string) != null)
                return this.Request[sName] as string;

            if ((this.Request.QueryString[sName] as string) != null)
                return this.Request.QueryString[sName] as string;

            return sValue;
        }
    }
}