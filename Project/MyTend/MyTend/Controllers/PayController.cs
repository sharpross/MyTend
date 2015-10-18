using MyTend.Entites;
using MyTend.Services.Common;
using MyTender.Security;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MyTend.Controllers
{
    public class PayController : BaseController
    {
        // GET: Pay
        public ActionResult Index()
        {
            ViewBag.PayScript = GetPayString();
            ViewBag.PayHistory = new PayService(this.Auth.User).GetHistory();
            ViewBag.PayEnd = new PayService(this.Auth.User).GetDatePayEnd();

            return View();
        }

        private string GetPayString()
        {
            // your registration data
            string sMrchLogin = "my-tend.com";
            string sMrchPass1 = "my-tend2015";
            // order properties
            decimal nOutSum = 10M;
            int nInvId = 0;
            string sDesc = "desc";

            string sOutSum = nOutSum.ToString("0.00", CultureInfo.InvariantCulture);
            string sCrcBase = string.Format("{0}:{1}:{2}:{3}:Shp_item={4}",
                                             sMrchLogin, sOutSum, nInvId, sMrchPass1, this.Auth.User.Id);

            // build CRC value
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] bSignature = md5.ComputeHash(Encoding.ASCII.GetBytes(sCrcBase));

            StringBuilder sbSignature = new StringBuilder();
            foreach (byte b in bSignature)
                sbSignature.AppendFormat("{0:x2}", b);

            string sCrc = sbSignature.ToString();

            // build URL
            return "<a class=\"btn btn-two\" href=\"https://auth.robokassa.ru/Merchant/Index.aspx?" +
                                                "MrchLogin=" + sMrchLogin +
                                                "&OutSum=" + sOutSum +
                                                "&InvId=" + nInvId +
                                                "&Desc=" + sDesc +
                                                "&Shp_item=" + this.Auth.User.Id +
                                                "&SignatureValue=" + sCrc + "\">Оплатить</a>";

        }

        public ActionResult Success()
        {
            return View();
        }

        public ActionResult Fail()
        {
            return View();
        }

        public ActionResult sjrfhgsiueh()
        {
            return null;
            /*var payService = new PayService();
            var userService = new UserSystemService();

            var records = payService.GetAll();

            var list = new List<PayInfoModel>();

            foreach (var rec in records)
            {
                list.Add(new PayInfoModel()
                {
                    UserMail = userService.GetAll().Where(x => x.Id == rec.UserId).FirstOrDefault().Login,
                    PayDay = rec.DateBegin,
                    PayEnd = rec.DateEnd
                });
            }

            return View(list);*/
        }

        public ActionResult Payresult()
        {
            //return null;
            try
            {
                if (this.IsValid())
                {
                    var userId = GetPrm("Shp_item");

                    var dateBegin = DateTime.Now;
                    var dateEnd = DateTime.Now.AddMonths(1);

                    var user = UserSystem.GetById(int.Parse(userId));

                    if (user != null)
                    {
                        var payService = new PayService(user);

                        payService.MakePay();
                    }

                    return RedirectToAction("Success");
                }
                else
                {
                    return RedirectToAction("Fail");
                }
            }
            catch (Exception ex)
            {
                ViewBag.IsTruePay = ex.StackTrace;
            }

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