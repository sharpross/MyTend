using System;
using System.Security.Cryptography;
using System.Text;
using System.Web.Mvc;
using MyTend.Entites;
using MyTend.Services.Common;

namespace MyTend.Controllers
{
    public class PayController : BaseController
    {
        // GET: Pay
        public ActionResult Index()
        {
            if (this.Auth.User == null)
            {
                return RedirectToRoute("Home");
            }

            this.ViewBag.NoIndexing = true;
            this.ViewBag.UserId = this.Auth.User.Id;

            return View();
        }

        public ActionResult GetYandexForm()
        {
            var form = "";

            return JsonSuccess(form);
        }

        [HttpPost]
        public void Paid(string notification_type, string operation_id, string label, string datetime,
            decimal amount, decimal withdraw_amount, string sender, string sha1_hash, string currency, bool codepro)
        {
            string key = "t40EFlYqHufXpZN/Nm2P3JQJ";

            string paramString = String.Format("{0}&{1}&{2}&{3}&{4}&{5}&{6}&{7}&{8}",
                notification_type, operation_id, amount, currency, datetime, sender,
                codepro.ToString().ToLower(), key, label);

            string paramStringHash1 = GetHash(paramString);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            var user = UserSystem.Find(int.Parse(label));

            var payService = new PayService(user);
            var payInfo = payService.Notify(label, paramString);

            if (comparer.Compare(paramStringHash1, sha1_hash) == 0)
            {
                payService.MakePay(payInfo);
            }
        }

        private string GetHash(string val)
        {
            SHA1 sha = new SHA1CryptoServiceProvider();
            byte[] data = sha.ComputeHash(Encoding.Default.GetBytes(val));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}