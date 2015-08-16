namespace MyTend.Models
{
    using MyTend.Entites;
    using MyTend.Services;
    using MyTend.Services.File;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Web;

    public class RegistrationModel : UserSystem
    {
        public string RegionId { get; set; }

        public string CityId { get; set; }

        public CloseTenderTimeEnum ClosePeriod { get; set; }

        public List<Country> ListCountrys { get; set; }

        public HttpPostedFileBase[] Files { get; set; }

        public RegistrationModel() : base()
        {
            this.ListCountrys = RegionService.CountryAll();
        }

        public bool TryRegistry()
        {
            var obj = new UserSystem() 
            {
                AboutShort = this.AboutShort,
                Email = this.Login.ToLower(),
                Login = this.Login,
                FullName = this.FullName,
                Password = this.Password,
                City = City.FindAllByProperty("Name", this.CityId).FirstOrDefault(),
                Region = Region.FindAllByProperty("Name", this.RegionId).FirstOrDefault()
            };

            if (obj.IsValid())
            {
                obj.Create();

                var avar = this.UpdateAvatar(obj);

                obj.Avatar = avar;
                obj.Update();

                return true;
            }

            this.Errors = obj.Errors;

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
