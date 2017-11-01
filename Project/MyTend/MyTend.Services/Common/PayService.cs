using System;
using System.Linq;
using MyTend.Entites;
using MyTender.Core;
using NHibernate.Criterion;

namespace MyTend.Services.Common
{
    public class PayService
    {
        private UserSystem User { get; set; }

        public PayService(UserSystem user)
        {
            this.User = user;
        }
        
        public void MakePay(PayInfo payInfo)
        {
            var user = payInfo.User;

            user.SubToDate = DateTime.Now.AddDays(30);
            user.Save();
        }

        public PayInfo Notify(string label, string parametres)
        {
            var user = UserSystem.Find(int.Parse(label));

            var newPay = new PayInfo()
            {
                PayDay = DateTime.Now,
                PayEnd = DateTime.Now.AddDays(30),
                Sum = Constants._SUB_SUM,
                User = user,
                IsPayed = false
            };

            newPay.Save();

            return newPay;
        }

    }
}
