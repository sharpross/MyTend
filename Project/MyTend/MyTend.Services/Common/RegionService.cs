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
            var rus = all.Where(x => x.Name == "Россия");
            var any = all.Where(x => x.Id != rus.FirstOrDefault().Id)
                .OrderBy(x => x.Name);

            result.AddRange(rus);
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

            var all = Region.FindAll()
                .OrderBy(x => x.Name);

            result.AddRange(all);

            return result;
        }

        public static List<Region> RegionById(int id)
        {
            var result = new List<Region>();

            try
            {
                var all = Region
                    .FindAllByProperty("Country", id)
                    //.Where(x => x.Country.Id == id)
                    .OrderBy(x => x.Name)
                    .OrderByDescending(x => x.IsMillion);

                result.AddRange(all);
            }
            catch
            { 
            }

            return result;
        }
        
        public static List<City> CityByRegionId(int id)
        {
            var result = new List<City>();

            var all = City.FindAllByProperty("Region", id)
                //.Where(x => x.Region.Id == id)
                .OrderBy(x => x.Name);

            result.AddRange(all);

            return result;
        }

        public static List<City> CityById(int id)
        {
            var result = new List<City>();

            try
            {
                var all = City.FindAllByProperty("Region", id)
                    //.Where(x => x.Region.Id == id)
                    .OrderBy(x => x.Name)
                    .ToList();

                result.AddRange(all);
            }
            catch
            {
            }

            return result;
        }
    }
}
