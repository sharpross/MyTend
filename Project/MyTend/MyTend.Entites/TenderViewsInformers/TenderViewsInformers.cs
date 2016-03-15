using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTend.Entites.TenderViewsInformers
{
    public class TenderViewsInformers
    {
        public UserSystem User { get; set; }

        public Tender Tender { get; set; }
    }

    public enum TenderViewsInformerType
    {
        Active = 0,
        List = 1
    }
}
