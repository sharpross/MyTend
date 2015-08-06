﻿namespace MyTend.Models
{
    using MyTend.Entites;
    using MyTend.Services;
    using MyTend.Services.Common;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ProfileModel : UserSystem
    {
        public string PasswordRetry { get; set; }

        public Dictionary<string, List<TenderTheme>> TenderThemes { get; set; }

        public List<string> SubRegions { get; set; }

        public List<string> SubCitys { get; set; }

        public List<Country> ListCountrys { get; set; }

        public ProfileModel()
        {
            this.ListCountrys = RegionService.CountryAll();
        }

        public ProfileModel(UserSystem user)
        {
            this.AboutFull = user.AboutFull;
            this.AboutShort = user.AboutShort;
            this.City = user.City;
            this.Email = user.Email;
            this.Facebook = user.Facebook;
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
            this.SubCitys = new List<string>();
            this.SubRegions = new List<string>();

            var filter = new RegionFilterService(user);

            foreach (var city in filter.GetCitys())
            {
                this.SubCitys.Add(city.Name);
            }

            foreach (var region in filter.GetRegions())
            {
                this.SubRegions.Add(region.Name);
            }
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
                result.Add(theme.Key, theme.ToList());
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
                user.Instagram = this.Instagram;
                user.VKontakte = this.VKontakte;
                
                if (user.IsValid())
                {
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

        public void UpdatePortfolio(string portfolio)
        {
            var user = UserSystem.GetById(this.Id);

            user.Portfolio = portfolio;

            user.Update();
        }

        public void UpdateAvatar()
        {
            
        }

        public void UpdateSubTenders()
        {
            
        }

        public void UpdateSubRegions()
        {

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
