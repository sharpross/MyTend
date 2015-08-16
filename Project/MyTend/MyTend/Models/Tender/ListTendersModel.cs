using MyTend.Entites;
using MyTend.Services.Common;
using MyTender.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTend.Models
{
    public class ListTendersModel 
    {
        public List<Tender> Tenders { get; set; }

        public AuthService Auth { get; set; }

        public RegionFilterService RegionFilter { get; set; }

        public TenderFilterService TendersFilter { get; set; }

        public ListTendersModel()
        {
            this.Auth = new AuthService();
            this.RegionFilter = new RegionFilterService(Auth.User);
            this.TendersFilter = new TenderFilterService(Auth.User);

            var regionFiltered = this.RegionFilter.GetTenders();
            var tenders = this.TendersFilter.GetByListTenders(regionFiltered);

            this.Tenders = tenders;
        }
    }
}
