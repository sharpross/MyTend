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
        public List<Tender> Tenders { get; set; }

        public MyTendersModel()
        {
            var authService = new AuthService();

            this.Tenders = Tender.FindAll()
                .Where(x => x.User.Id == authService.User.Id)
                .OrderBy(x => x.CreatedDateTime)
                .ToList();
        }
    }
}
