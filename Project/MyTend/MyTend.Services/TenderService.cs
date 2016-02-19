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

        public RegionFilterService RegionFilter { get; set; }

        public TenderFilterService TendersFilter { get; set; }

        public TenderService(UserSystem user)
        {
            this.User = user;
            this.RegionFilter = new RegionFilterService(this.User);
            this.TendersFilter = new TenderFilterService(this.User);
        }

        public int GetCountTenders()
        {
            var count = this.GetTenders()
                .Where(x => x.Winner == null)
                .ToList()
                .Count;

            return count;
        }

        public List<Tender> GetTenders()
        {
            var regionFiltered = this.RegionFilter.GetTenders();
            var tenders = this.TendersFilter.GetByListTenders(regionFiltered)
                .Where(x => x.IsActive)
                .ToList();

            var tenderResult = new List<Tender>();

            tenders.ForEach(x =>
            {
                var exist = TenderMessage.FindAll()
                    .Any(y => y.User.Id == x.Id);

                if (!exist)
                {
                    tenderResult.Add(x);
                }
            });

            return tenderResult;
        }
    }
}
