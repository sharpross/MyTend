using MyTend.Entites;
using MyTend.Services.File;
using MyTender.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTend.Models
{
    public class TenderDetailsModel : Tender
    {
        public List<TenderMessage> Messages { get; set; }

        public AuthService Auth { get; set; }

        public List<FileSystem> Files { get; set; }

        public TenderDetailsModel(int id)
        {
            this.Load(id);
        }

        private void Load(int id)
        {
            var tender = Tender.GetById(id);

            if (tender == null)
            {
                throw new Exception("Тендер не найден.");
            }

            this.Id = tender.Id;
            this.IsOpen = tender.IsOpen;
            this.AllowWriteMe = tender.AllowWriteMe;
            this.City = tender.City;
            this.Cost = tender.Cost;
            this.CreatedDateTime = tender.CreatedDateTime;
            this.DateEnd = tender.DateEnd;
            this.Message = tender.Message;
            this.Region = tender.Region;
            this.Theme = tender.Theme;
            this.Title = tender.Title;
            this.User = tender.User;
            this.Winner = tender.Winner;
            this.Messages = this.LoadMessages();

            this.LoadFiles(tender);
        }

        private void LoadFiles(Tender tender)
        {
            var service = new FileControllerService();

            this.Files = service.Get(tender);
        }

        private List<TenderMessage> LoadMessages()
        {
            var messages = new List<TenderMessage>();

            messages = TenderMessage
                .FindAll()
                .Where(x => x.Tender.Id == this.Id)
                .OrderBy(x => x.Date)
                .ToList();


            return messages;
        }
    }
}
