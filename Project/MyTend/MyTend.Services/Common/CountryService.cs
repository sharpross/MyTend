using MyTend.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTend.Services
{
    public static class CountryService
    {
        public static List<Country> GetAll()
        {
            var result = new List<Country>();

            var all = Country.FindAll();
            var rus = all.Where(x => x.Name == "Россия");
            var any = all.Where(x => x != rus);

            result.AddRange(rus);
            result.AddRange(any);

            return result;
        }
    }
}
