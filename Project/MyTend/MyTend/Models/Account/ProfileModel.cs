namespace MyTend.Models
{
    using MyTend.Entites;
    using MyTend.Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ProfileModel : UserSystem
    {
        public string PasswordRetry { get; set; }

        public List<SubTender> SubTenders { get; set; }

        public List<SubRegions> SubRegions { get; set; }

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

            return this.Save(user);
        }

        private bool Save(UserSystem user)
        {
            try
            {
                user.FullName = this.FullName;
                user.Facebook = this.Facebook;
                user.Phone = this.Phone;
                user.Phone2 = this.Phone2;
                user.Site = this.Site;
                user.Skype = this.Skype;
                //user.City = this.City;
                //user.Region = this.Region;

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
