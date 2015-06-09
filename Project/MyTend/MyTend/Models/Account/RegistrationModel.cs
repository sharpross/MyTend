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
        public CloseTenderTimeEnum ClosePeriod { get; set; }

        public List<Country> ListCountrys { get; set; }

        public RegistrationModel() : base()
        {
            this.ListCountrys = RegionService.CountryAll();
        }

        public override void Save()
        {
            base.Save();
        }
    }
}
