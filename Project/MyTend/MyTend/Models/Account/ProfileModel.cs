namespace MyTend.Models
{
    using MyTend.Entites;
    using MyTend.Services;
    using MyTend.Services.Common;
    using MyTend.Services.File;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class ProfileModel : UserSystem
    {
        public string PasswordRetry { get; set; }

        public Dictionary<string, List<TenderTheme>> TenderThemes { get; set; }

        public List<Region> SubRegions { get; set; }

        public List<City> SubCitys { get; set; }

        public HttpPostedFileBase[] AvatarFile { get; set; }

        public HttpPostedFileBase[] ProfileFiles { get; set; }

        public FileSystem[] Portfolios { get; set; }

        public List<Country> ListCountrys { get; set; }

        public ProfileModel()
        {
            this.ListCountrys = RegionService.CountryAll();
        }

        public ProfileModel(UserSystem user)
        {
            this.Avatar = user.Avatar;
            this.AboutFull = user.AboutFull;
            this.AboutShort = user.AboutShort;
            this.City = user.City;
            this.Email = user.Email;
            this.Facebook = user.Facebook;
            this.VKontakte = user.VKontakte;
            this.Id = user.Id;
            this.Instagram = user.Instagram;
            this.Login = user.Login;
            this.Phone = user.Phone;
            this.Phone2 = user.Phone2;
            this.Portfolio = user.Portfolio;
            this.Region = user.Region;
            this.Site = user.Site;
            this.Skype = user.Skype;
            this.FullName = user.FullName;
            this.ListCountrys = RegionService.CountryAll();
            this.TenderThemes = this.GetListTenderTheme();
            this.SubCitys = new List<City>();
            this.SubRegions = new List<Region>();
            this.Portfolios = new List<FileSystem>().ToArray();
            this.Youtube = user.Youtube;

            var filter = new RegionFilterService(user);

            foreach (var city in filter.GetCitys())
            {
                this.SubCitys.Add(city);
            }

            foreach (var region in filter.GetRegions())
            {
                this.SubRegions.Add(region);
            }

            var obj = UserSystem.GetById(this.Id);

            this.LoadPortfolios(obj);
        }

        public void RemovePortfile(int id, int userId)
        {
            var user = UserSystem.GetById(userId);

            if (user == null)
            {
                throw new Exception("Пользователь не найден.");
            }

            if (this.Id != user.Id)
            {
                throw new Exception("Не допустимая операция.");
            }

            var service = new FileControllerService();
            service.DeletePortFile(id, user);
        }

        public void LoadPortfolios(UserSystem user)
        {
            var service = new FileControllerService();

            this.Portfolios = service.Get(user, true).ToArray();
        }

        public Dictionary<string, List<TenderTheme>> GetListTenderTheme()
        {
            var result = new Dictionary<string, List<TenderTheme>>();

            var themes = TenderTheme
                .FindAll()
                .GroupBy(x => x.Theme)
                .ToList();

            foreach (var theme in themes)
            {
                var temp = theme
                    .OrderBy(x => x.NomberInList)
                    .ToList();
                result.Add(theme.Key, temp);
            }

            return result;
        }

        public bool UpdateProfile()
        {
            var user = UserSystem.GetByProp("Login", this.Login).FirstOrDefault();

            if (user == null)
            {
                throw new Exception("Не известный пользователь.");
            }

            if(!string.IsNullOrEmpty(this.Password) && !string.IsNullOrEmpty(this.PasswordRetry))
            {
                if (this.Password != this.PasswordRetry)
                {
                    throw new Exception("Пароли не совпадают.");
                }

                user.Password = this.Password;
            }

            return this.SaveProfile(user);
        }

        private bool SaveProfile(UserSystem user)
        {
            try
            {
                user.FullName = this.FullName;
                user.Facebook = this.Facebook;
                user.Phone = this.Phone;
                user.Phone2 = this.Phone2;
                user.Site = this.Site;
                user.Skype = this.Skype;
                user.AboutShort = this.AboutShort;
                user.Instagram = this.Instagram;
                user.VKontakte = this.VKontakte;
                user.Youtube = this.Youtube;

                if (user.IsValid())
                {
                    if (this.AvatarFile != null)
                    {
                        var newAvatar = this.UpdateAvatar(user);
                        user.Avatar = newAvatar;
                    }

                    user.Update();

                    return true;
                }

                this.Errors = user.Errors;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }

            return false;
        }

        public void UpdateAbout(string portfolio)
        {
            var user = UserSystem.GetById(this.Id);

            if (user != null)
            {
                user.Portfolio = portfolio;

                user.Update();
            }
        }

        public FileSystem UpdateAvatar(UserSystem user)
        {
            FileSystem file = null;

            var service = new FileControllerService();

            file = service.UpdateAvatar(this.AvatarFile, user);

            return file;
        }

        public void AddProfile(UserSystem user)
        {
            var service = new FileControllerService();

            service.UpdateFiles(this.ProfileFiles, user);
        }

        public void UpdateSubTenders()
        {
            throw new NotImplementedException();
        }

        public void UpdateSubRegions()
        {
            throw new NotImplementedException();
        }
    }

    public class SubRegions
    {
        public string Name { get; set; }

        public bool IsCity { get; set; }
    }

    public class SubTender
    {
        public string Name { get; set; }

        public bool IsTheme { get; set; }
    }
}
