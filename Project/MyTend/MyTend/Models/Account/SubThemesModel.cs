using MyTend.Entites;
using MyTend.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTend.Models
{
    public class SubThemesModel
    {
        public List<ThemeModel> ListThemes { get; set; }

        public void Save(UserSystem user)
        {
            var services = new TenderFilterService(user);

            var ids = this.ListThemes.Select(x => x.Id).ToList();

            services.SaveFiltres(ids);
        }

        public void Load(UserSystem user)
        {
            var services = new TenderFilterService(user);

            this.ListThemes = new List<ThemeModel>();

            services.GetListSubs().ForEach(x => this.ListThemes.Add(new ThemeModel() {
                Id = x.Theme.Id,
                Parent = x.Id
            }));
        }

        public class ThemeModel
        {
            public int Id { get; set; }
            
            public int Parent { get; set; }
        }
    }
}
