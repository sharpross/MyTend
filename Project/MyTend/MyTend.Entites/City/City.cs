using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTend.Entites
{
    public class City : BaseEntity
    {
        public string Name { get; set; }

        public Region Region { get; set; }
    }
}
