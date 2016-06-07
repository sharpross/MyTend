namespace MyTend.Models
{
    using MyTend.Entites;
    using MyTend.Services;
    using MyTend.Services.File;
    using MyTender.Security;
    using NHibernate.Criterion;
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Web;

    public class CreateTenderModel : Tender
    {
        public string AllowWrite { get; set; }

        public string ActiveTime { get; set; }

        public string CountryId { get; set; }

        public string RegionId { get; set; }

        public string CityId { get; set; }

        //public CloseTenderTimeEnum CloseTime { get; set; }

        public List<TenderTheme> ListThemes { get; set; }

        public int ThemeId { get; set; }

        public int TitleId { get; set; }

        //public string IconTheme { get; set; }

        public string TenderType { get; set; }

        public List<Country> ListCountrys { get; set; }

        public HttpPostedFileBase[] ListFiles { get; set; }

        private bool IsSub { get; set; }

        public CreateTenderModel()
        {

        }

        public CreateTenderModel(int themeId)
        {
            var theme = TenderTheme.FindAll()
                .FirstOrDefault(x => x.Id == themeId);

            if (theme == null)
            {
                throw new Exception("Не известный тендер.");
            }

            var listSubThemes = TenderTheme.FindAll(Expression.Eq("Theme", theme.Theme))
                //.Where(x => x.Theme == theme.Theme)
                .OrderBy(x => x.NomberInList)
                .ToList();

            this.Theme = theme;

            this.ListThemes = listSubThemes;
            //this.IconTheme = theme.ImageName;
            this.ListCountrys = RegionService.CountryAll();
        }

        public bool IsValid()
        {
            var tender = this.GetObj();

            var isValid = tender.IsValid();

            if (!isValid) 
            {
                this.Errors = tender.Errors;
            }

            var count = this.GetCountTendersToday(tender.User);
            var maxCount = 0;

            if (this.IsSub)
            {
                maxCount = int.Parse(ConfigurationManager.AppSettings["MaxTendersSub"]);
            }
            else
            {
                maxCount = int.Parse(ConfigurationManager.AppSettings["MaxTenders"]);
            }

            if (count >= maxCount)
            {
                this.Errors.Add(string.Format(ConfigurationManager.AppSettings["MaxTenderMessage"], maxCount));
                isValid = false;
            }

            var theme = TenderTheme.FindAll()
                .FirstOrDefault(x => x.Id == this.ThemeId);

            if (theme == null)
            {
                throw new Exception("Не известный тендер.");
            }

            var listSubThemes = TenderTheme.FindAll(Expression.Eq("Theme", theme.Theme))
                //.Where(x => x.Theme == theme.Theme)
                .OrderBy(x => x.NomberInList)
                .ToList();

            this.Theme = theme;

            this.ListThemes = listSubThemes;
            //this.IconTheme = theme.ImageName;
            this.ListCountrys = RegionService.CountryAll();

            return isValid;
        }

        private int GetCountTendersToday(UserSystem user)
        {
            var begin = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            var end = begin.AddHours(23).AddMinutes(59).AddSeconds(59);

            var count = Tender.FindAll(Expression.Eq("User", user))
                //.Where(x => x.User.Id == user.Id)
                .Where(x => x.CreatedDateTime >= begin && x.CreatedDateTime <= end)
                .Count();

            return count;
        }

        public void Save(bool isSub)
        {
            this.IsSub = isSub;

            var obj = this.GetObj();

            obj.Create();

            this.SaveFiles(obj);

            this.Id = obj.Id;
        }

        private void SaveFiles(Tender tender)
        {
            if (this.ListFiles != null && this.ListFiles.Length > 0)
            {
                var service = new FileControllerService();

                service.SaveFileTender(this.ListFiles, tender);
            }
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
                User = this.User,
            };

            switch (this.ActiveTime)
            {
                case "3 дня":
                    newTender.DateEnd = DateTime.Now.AddDays(3);
                    break;
                case "7 дней":
                    newTender.DateEnd = DateTime.Now.AddDays(7);
                    break;
                case "14 дней":
                    newTender.DateEnd = DateTime.Now.AddDays(14);
                    break;
                case "21 день":
                    newTender.DateEnd = DateTime.Now.AddDays(21);
                    break;
            }

            switch (this.TenderType)
            {
                case "Открытые торги":
                    newTender.IsOpen = true;
                    break;
                case "Закрытые торги":
                    newTender.IsOpen = false;
                    break;
            }

            var theme = TenderTheme.GetById(this.TitleId);

            if (theme == null)
            {
                //throw new Exception("Не известная тема тендера");
            }

            newTender.Theme = theme;

            var region = Region.FindFirst(Expression.Eq("Name", this.RegionId));
                //.FirstOrDefault(x => x.Name == this.RegionId);

            if (region == null)
            {
                //throw new Exception("Не известный региион");
            }

            var city = City.FindAll(Expression.Eq("Name", this.CityId))
                .FirstOrDefault(x => x.Name == this.CityId && 
                    x.Region.Id == region.Id);

            if (city == null)
            {
                //throw new Exception("Не известный город");
            }

            newTender.Region = region;
            newTender.City = city;

            var authService = new AuthService();

            newTender.User = authService.User;

            switch (this.AllowWrite)
            {
                case "on":
                    newTender.AllowWriteMe = true;
                    break;
                default:
                    newTender.AllowWriteMe = false;
                    break;
            }

            return newTender;
        }
    }
}
