using MyTend.Entites;
using MyTend.Entites.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTend.Models
{
    public class ListContactModel
    {
        public List<UserSystem> Users { get; set; }

        public ListContactModel()
        {
            this.Users = new List<UserSystem>();

            var contacts = Contact
                .FindAll()
                .Select(x => x.Friend)
                .ToList();

            this.Users = contacts;
        }
    }
}
