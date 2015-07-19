namespace MyTend.Models
{
    using MyTend.Entites;
    using System.Collections.Generic;
    using System.Linq;

    public class ListThemeTenderModel
    {
        public TenderTheme[] Themes { get; set; }

        public ListThemeTenderModel()
        {
            this.Themes = TenderTheme.FindAll()
                .Where(x => x.IsTitle == true)
                .ToArray();
        }
    }
}
