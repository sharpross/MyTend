using Castle.ActiveRecord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTend.Entites
{
    [ActiveRecord("users")]
    public class UserSystem : BaseEntity
    {
        [Property]
        public string Name { get; set; }

        [Property]
        public string Login { get; set; }

        [Property]
        public string Password { get; set; }

        [Property]
        public string Email { get; set; }

        [Property]
        public string Organization { get; set; }

        [Property]
        public string Skype { get; set; }

        [Property]
        public string VKontakte { get; set; }

        [Property]
        public string Facebook { get; set; }

        [Property]
        public string Phone { get; set; }
    }
}
