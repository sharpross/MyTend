namespace MyTend.Models
{
    using MyTend.Entites;
    using MyTend.Services.Common;
    using MyTender.Security;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ActiveTenderListModel
    {
        public List<Tender> OpenTenders { get; set; }

        public List<Tender> CloseTenders { get; set; }

        private AuthService Auth { get; set; }

        private RegionFilterService RegionFilter { get; set; }

        private TenderFilterService TendersFilter { get; set; }

        private List<Tender> MyActivetenders { get; set; }

        public ActiveTenderListModel()
        {
            var tenders = this.GetAll();

            this.MyActivetenders = this.GetActiveTenders();

            this.OpenTenders = this.GetOpenTenders(this.MyActivetenders);
            this.CloseTenders = this.GetCloseTenders(this.MyActivetenders);
        }

        private List<Tender> GetActiveTenders()
        {
            var result = new List<Tender>();

            var activeTenders = TenderMessage
                .FindAll()
                .Where(x => x.Tender.User.Id != this.Auth.User.Id)
                .Where(x => x.User.Id == this.Auth.User.Id)
                .GroupBy(x => x.Tender)
                .Select(x => x.Key)
                .OrderBy(x => x.CreatedDateTime)
                .ToList();

            result.AddRange(activeTenders);

            return result;
        }

        private List<Tender> GetAll()
        {
            this.Auth = new AuthService();
            this.RegionFilter = new RegionFilterService(Auth.User);
            this.TendersFilter = new TenderFilterService(Auth.User);

            var regionFiltered = this.RegionFilter.GetTenders();
            var tenders = this.TendersFilter.GetByListTenders(regionFiltered);

            return tenders;
        }

        private List<Tender> GetOpenTenders(List<Tender> tenders)
        {
            var open = tenders
                .Where(x => x.IsActive == true)
                .ToList();

            return open;
        }

        private List<Tender> GetCloseTenders(List<Tender> tenders)
        {
            var close = tenders
                .Where(x => x.IsActive == false)
                .ToList();

            return close;
        }
    }
}
