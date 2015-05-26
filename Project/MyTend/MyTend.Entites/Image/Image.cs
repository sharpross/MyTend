using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTend.Entites
{
    public class Image : BaseEntity
    {
        public string Name { get; set; }

        public byte[] Data { get; set; }

        public string MimeType { get; set; }
    }
}
