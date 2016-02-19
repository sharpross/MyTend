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
            var service = new TenderService().GetList();

            this.OpenTenders = new List<Tender>();
            this.CloseTenders = new List<Tender>();

            this.OpenTenders.AddRange(service.Open);
            this.CloseTenders.AddRange(service.Close);
        }
    }
}
