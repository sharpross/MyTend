using MyTend.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTend.Services.Migrations.Regions
{
    public class RegionMigration : IMigration
    {
        public string Code
        {
            get { return "Создание регионов/городов"; }
        }

        public void Migrate()
        {
            var rus = new Country() { Name = "Россия" };
            rus.Create();

            var mosckow = new Region() { Country = rus, Name = "Москва", NomberSort = 0 };
            mosckow.Create();
            var listRu = new List<City>();
            listRu.Add(new City() { Name = "Пекин", Region = mosckow });
            listRu.Add(new City() { Name = "Пекин2", Region = mosckow });
            this.Create(listRu);

            var tatarstan = new Region() { Country = rus, Name = "Татарстан", NomberSort = 1 };
            tatarstan.Create();
            listRu = new List<City>();
            listRu.Add(new City() { Name = "Казань", Region = tatarstan });
            listRu.Add(new City() { Name = "Альметьевск", Region = tatarstan });
            this.Create(listRu);
            
        }

        public bool NeedMigrate()
        {
            return true;
        }

        private void Create(List<City> list)
        {
            foreach (var rec in list)
            {
                rec.Create();
            }
        }
    }
}
