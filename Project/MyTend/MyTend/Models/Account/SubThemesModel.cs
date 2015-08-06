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
        public List<int> ListThemes { get; set; }

        public void Save(UserSystem user)
        {
            var services = new TenderFilterService(user);

            services.SaveFiltres(this.ListThemes);
        }

        public void Load(UserSystem user)
        {
            var services = new TenderFilterService(user);

            var sel = services.GetListSubs()
                .Select(x => x.Theme.Id)
                .ToList();

            this.ListThemes = sel;
        }
    }
}
