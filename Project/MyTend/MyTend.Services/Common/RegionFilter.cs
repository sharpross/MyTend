using MyTend.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTend.Services.Common
{
    public static class RegionFilter
    {
        public static List<Region> ListRegion(UserSystem user)
        {
            var regions = new List<Region>();

            if (user == null)
            {
                throw new Exception("Не указан пользователь.");
            }

            return regions;
        }

        public static List<City> ListCitys(UserSystem user)
        {
            var regions = new List<City>();

            if (user == null)
            {
                throw new Exception("Не указан пользователь.");
            }

            return regions;
        }
    }
}
