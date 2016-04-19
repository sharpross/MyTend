namespace MyTend.Models
{
    using MyTend.Entites;
    using MyTender.Security;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TenderMessageModel : TenderMessage
    {
        public int TenderId { get; set; }

        public AuthService Auth { get; set; }

        public TenderMessageModel()
        {
            this.Auth = new AuthService();
        }

        public bool IsValid()
        {
            var message = this.GetObj();

            if (!message.IsValid())
            {
                this.Errors = message.Errors;

                return false;
            }

            return true;
        }

        public void Save()
        {
            var message = this.GetObj();

            message.Create();
        }

        public TenderMessage GetObj()
        {
            var tender = Tender.GetById(this.TenderId);

            if (tender == null)
            {
                throw new Exception("Тендер не найден");
            }

            this.Tender = tender;

            var tenderMessage = new TenderMessage() 
            {
                User = this.Auth.User,
                Message = this.Message,
                Date = DateTime.Now,
                CreatedDateTime = DateTime.Now,
                Tender = tender
            };

            return tenderMessage;
        }
    }
}
