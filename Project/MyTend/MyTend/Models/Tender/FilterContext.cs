using System.Collections.Generic;

namespace MyTend.Models
{
    public class FilterContext
    {
        public List<int> Citys { get; set; }

        public List<int> Themes { get; set; }

        public bool IsClear { get; set; }

        public FilterContext()
        {
            Citys = new List<int>();
            Themes = new List<int>();
        }
    }
}