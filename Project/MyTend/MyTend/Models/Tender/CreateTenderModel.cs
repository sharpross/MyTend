namespace MyTend.Models
{
    using MyTend.Entites;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CreateTenderModel : Tender
    {
        public string ThemeString { get; set; }

        public string TitleString { get; set; }

        public List<Country> ListCountrys { get; set; }

        public CreateTenderModel(int themeId)
        {
            var theme = TenderTheme.FindAll()
                .FirstOrDefault(x => x.Id == themeId);

            if (theme == null)
            {
                throw new Exception("Не известный тендер.");
            }

            this.ThemeString = theme.Title;
        }

        public bool IsValid()
        {
            var tender = this.GetObj();

            var isValid = tender.IsValid();

            if (!isValid) 
            {
                this.Errors = tender.Errors;
            }

            return isValid;
        }

        public void Save()
        {
            var obj = this.GetObj();

            obj.Save();
        }

        private Tender GetObj()
        {
            var newTender = new Tender()
            {
                IsOpen = this.IsOpen,
                AllowWriteMe = this.AllowWriteMe,
                City = this.City,
                Cost = this.Cost,
                DateEnd = this.DateEnd,
                Message = this.Message,
                Region = this.Region,
                Theme = this.Theme,
                Title = this.Title,
                User = this.User
            };

            return newTender;
        }
    }
}
