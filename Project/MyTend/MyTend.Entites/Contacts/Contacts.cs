using Castle.ActiveRecord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTend.Entites.Contacts
{
    [ActiveRecord("Contacts")]
    public class Contact : BaseEntity<Contact>
    {
        public UserSystem User { get; set; }

        public List<UserSystem> Contacts { get; set; }
    }
}
