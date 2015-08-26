using MyTend.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTend.Models
{
    public class UserMessagesListModel
    {
        public UserSystem User { get; set; }

        public int Unreaded { get; set; }
    }
}
