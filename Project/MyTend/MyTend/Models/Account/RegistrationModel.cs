﻿namespace MyTend.Models
{
    using MyTend.Entites;
    using MyTend.Services;
    using MyTend.Services.File;
    using MyTender.Security.Utils;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Web;
    using MyTend.Services.Common;

    public class RegistrationModel : UserSystem
    {
        public string RegionId { get; set; }

        public string Password2 { get; set; }

        public string IsAllowRules { get; set; }

        public string IsAllowPublic { get; set; }

        public string CityId { get; set; }

        public CloseTenderTimeEnum ClosePeriod { get; set; }

        public List<Country> ListCountrys { get; set; }

        public HttpPostedFileBase[] Files { get; set; }

        public List<Region> ListRegions { get; set; }

        public RegistrationModel() : base()
        {
            this.ListCountrys = RegionService.CountryAll();
            this.ListRegions = RegionService.RegionAll();
        }

        public bool TryRegistry()
        {
            if (this.Login == null)
            {
                this.Login = string.Empty;
            }
            if (this.Password == null)
            {
                this.Password = string.Empty;
            }

            var obj = new UserSystem() 
            {
                AboutShort = this.AboutShort,
                Email = this.Login.ToLower(),
                Login = this.Login,
                FullName = this.FullName,
                Phone = this.Phone,
                Password = MD5Helper.GetMD5String(this.Password),
                City = City.FindAllByProperty("Name", this.CityId).FirstOrDefault(),
                Region = Region.FindAllByProperty("Name", this.RegionId).FirstOrDefault()
            };

            if (obj.IsValid())
            {
                var next = true;
                var users = UserSystem.FindAllByProperty("Phone", obj.Phone);

                if (users.Any())
                {
                    this.Errors.Add("Пользователь с иаким номером телефона зарегистрирован. Пожалуйста воспользуйтесь восстановлением аккаунта.");
                    next = false;
                }

                if (this.Password != this.Password2)
                {
                    this.Errors.Add("Пароли не совпадают.");
                    next = false;
                }

                if (this.IsAllowRules != "on")
                {
                    this.Errors.Add("Вы не согласились с правилами сайта.");
                    next = false;
                }
                
                if (next)
                {
                    obj.Create();

                    var avar = this.UpdateAvatar(obj);

                    if (avar != null)
                    {
                        obj.Avatar = avar;
                        obj.Update();
                    }

                    return true;
                }
            }

            this.Errors.AddRange(obj.Errors);

            return false;
        }
        
        public FileSystem UpdateAvatar(UserSystem user)
        {
            FileSystem file = null;

            var service = new FileControllerService();

            file = service.UpdateAvatar(this.Files, user);

            return file;
        }
    }
}
