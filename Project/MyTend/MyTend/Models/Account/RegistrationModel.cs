namespace MyTend.Models
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
        public string RegionId { get; set; }

        public string CityId { get; set; }

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
                Email = this.Login,
                Login = this.Login,
                Name = this.Name,
                Password = this.Password,
                City = City.FindAllByProperty("Name", this.CityId).FirstOrDefault(),// GetById(),
                Region = Region.FindAllByProperty("Name", this.RegionId).FirstOrDefault()
            };

            if (obj.IsValid())
            {
                obj.Create();

                return true;
            }

            this.Errors = obj.Errors;

            return false;
        }
    }
}
