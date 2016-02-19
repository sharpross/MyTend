using MyTend.Entites;
using MyTender.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTend.Models
{
    public class MyTendersModel
    {
        public List<Tender> OpenTenders { get; set; }

        public List<Tender> CloseTenders { get; set; }

        public MyTendersModel()
        {
            var authService = new AuthService();

            this.OpenTenders = new List<Tender>();
            this.CloseTenders = new List<Tender>();

            var my = new TenderService().GetMy();

            this.OpenTenders = my.Open;
            this.CloseTenders = my.Close;
        }
    }
}
