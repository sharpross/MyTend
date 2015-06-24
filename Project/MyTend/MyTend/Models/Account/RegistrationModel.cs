﻿namespace MyTend.Models
{
    using MyTend.Entites;
    using MyTend.Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RegistrationModel : UserSystem
    {
        public CloseTenderTimeEnum ClosePeriod { get; set; }

        public List<Country> ListCountrys { get; set; }

        public RegistrationModel() : base()
        {
            this.ListCountrys = RegionService.CountryAll();
        }

        public bool TryRegistry()
        {
            var obj = new UserSystem() 
            {
                AboutShort = this.AboutShort,
                City = this.City,
                Email = this.Login,
                Login = this.Login,
                Name = this.Name,
                Password = this.Password,
                Region = this.Region
            };

            obj = this as UserSystem;

            if (UserSystem.IsValid(obj))
            {
                base.Create();
                return true;
            }

            return false;
        }
    }
}
