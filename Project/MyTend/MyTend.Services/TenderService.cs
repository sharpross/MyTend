using MyTend.Entites;
using MyTend.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTend.Services
{
    public class TenderService
    {
        private UserSystem User { get; set; }

        private RegionFilterService RegionFilter { get; set; }

        private TenderFilterService TendersFilter { get; set; }

        public TenderService(UserSystem user)
        {
            this.User = user;
        }

        public int GetCountTenders()
        {
            var count = this.GetTenders().Count;



            return count;
        }

        public List<Tender> GetTenders()
        {
            this.RegionFilter = new RegionFilterService(this.User);
            this.TendersFilter = new TenderFilterService(this.User);

            var regionFiltered = this.RegionFilter.GetTenders();
            var tenders = this.TendersFilter.GetByListTenders(regionFiltered);

            return tenders;
        }
    }
}
