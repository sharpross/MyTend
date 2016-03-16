namespace MyTend.Models
{
    using MyTend.Entites;
    using MyTender.Security;
    using System.Collections.Generic;
    using System.Linq;

    public class WinnerTenderModel
    {
        public AuthService Auth { get; set; }

        public List<Tender> Tenders { get; set; }

        public WinnerTenderModel()
        {
            this.Tenders = new List<Tender>();
            this.Auth = new AuthService();
        }

        public void Load()
        {
            this.Tenders = new TenderService().GetWinner();
        }
    }
}
