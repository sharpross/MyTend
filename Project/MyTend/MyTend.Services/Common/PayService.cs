using MyTend.Entites;
using MyTender.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTend.Services.Common
{
    public class PayService
    {
        private UserSystem User { get; set; }

        public PayService(UserSystem user)
        {
            this.User = user;
        }

        public void MakePay()
        {
            var isFirst = !PayInfo.FindAll()
                .Any(x => x.User.Id == this.User.Id);

            var newPay = new PayInfo()
            {
                PayDay = DateTime.Now,
                PayEnd = isFirst ? DateTime.Now.AddMonths(2) : DateTime.Now.AddMonths(1),
                Sum = Constants._SUB_SUM,
                User = this.User
            };

            newPay.Save();
        }

        public List<PayInfo> GetHistory()
        {
            var pays = PayInfo
                .FindAll()
                .Where(x => x.User.Id == this.User.Id)
                .ToList();

            return pays;
        }

        public DateTime? GetDatePayEnd()
        {
            if (this.HasPay())
            {
                var has = PayInfo
                    .FindAll()
                    .Where(x => x.User.Id == this.User.Id)
                    .OrderBy(x => x.PayEnd)
                    .First();

                return has != null ? (DateTime?)has.PayEnd : null;
            }

            return null;
        }

        public bool HasPay()
        {
            var has = PayInfo
                .FindAll()
                .Where(x => x.User.Id == this.User.Id)
                .Where(x => DateTime.Now <= x.PayEnd)
                .Any();

            return has;
        }

        public string PayEnd()
        {
            var end = string.Empty;

            if (this.HasPay())
            {
                var date = this.GetDatePayEnd();

                end = date.Value.ToString("dd.MM.yyyy");
            }

            return end;
        }
    }
}
