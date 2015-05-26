using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTend.Entites
{
    public class Region : BaseEntity
    {
        public string Name { get; set; }

        public Country Country { get; set; }
    }
}
