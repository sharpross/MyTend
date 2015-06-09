using MyTend.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTend.Services
{
    public static class RegionService
    {
        public static List<Country> CountryAll()
        {
            var result = new List<Country>();

            var all = Country.FindAll();
            var rus = all.Where(x => x.Name == "Россия").FirstOrDefault();
            var any = all.Where(x => x.Id != rus.Id)
                .OrderBy(x => x.Name);

            result.Add(rus);
            result.AddRange(any);

            return result;
        }

        public static List<Country> CountryById(int id)
        {
            var result = new List<Country>();

            try
            {
                var all = Country.Find(id);

                result.Add(all);
            }
            catch
            {
            }

            return result;
        }

        public static List<Region> RegionAll()
        {
            var result = new List<Region>();

            var all = Region.FindAll();

            result.AddRange(all);

            return result;
        }

        public static List<Region> RegionById(int id)
        {
            var result = new List<Region>();

            try
            {
                var all = Region.Find(id);

                result.Add(all);
            }
            catch
            { 
            }

            return result;
        }
        
        public static List<City> CityAll()
        {
            var result = new List<City>();

            var all = City.FindAll();

            result.AddRange(all);

            return result;
        }

        public static List<City> CityById(int id)
        {
            var result = new List<City>();

            try
            {
                var all = City.Find(id);

                result.Add(all);
            }
            catch
            {
            }

            return result;
        }
    }
}
