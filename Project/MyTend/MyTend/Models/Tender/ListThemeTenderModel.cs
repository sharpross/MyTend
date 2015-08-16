namespace MyTend.Models
{
    using MyTend.Entites;
    using System.Collections.Generic;
    using System.Linq;

    public class ListThemeTenderModel
    {
        public List<TenderTheme> Themes { get; set; }

        public ListThemeTenderModel()
        {
            this.Themes = new List<TenderTheme>();

            var themes = TenderTheme.FindAll()
                .GroupBy(x => x.Theme)
                .ToList();

            foreach (var aa in themes)
            {
                var exist = this.Themes.Any(x => x.Theme == aa.Key);

                if(!exist)
                {
                    this.Themes.Add(aa.FirstOrDefault());
                }
            }
        }
    }
}
