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
            var list = new List<Region>();

            var rus = new Country() { Name = "Россия" };
            rus.Save();

            list.Add(new Region() { Country = rus, Name = "Москва", NomberSort = 0 });
        }

        public bool NeedMigrate()
        {
            return true;
        }
    }
}
