using System.Collections.Generic;
using System.Linq;
using MyTend.Entites;
using MyTend.Services;
using MyTend.Services.Common;
using MyTender.Security;

namespace MyTend.Models
{
    public class ListTendersModel
    {
        public List<Tender> Tenders { get; set; }

        public Dictionary<string, List<TenderTheme>> TenderThemases { get; set; }

        public Dictionary<string, List<City>> GroupCitys { get; set; }

        public AuthService Auth { get; set; }

        public RegionFilterService RegionFilter { get; set; }

        public TenderFilterService TendersFilter { get; set; }

        public FilterContext Context { get; set; }

        public ListTendersModel()
        {
            
        }

        public ListTendersModel(FilterContext context)
        {
            this.Auth = new AuthService();

            context = PrepareContext(context);

            Tenders = new List<Tender>();

            var regionFilter = new RegionFilterService(this.Auth.User);
            var themeFilter = new TenderFilterService(this.Auth.User);

            var tenders = Tender.FindAll(NHibernate.Criterion.Expression.Eq("IsActive", true));

            var a = regionFilter.GetTenders();
            var b = themeFilter.GetByListTenders(a);

            foreach (var tender in b)
            {
                if (context.Citys != null && context.Citys.Count > 0)
                {
                    if (!context.Citys.Contains(tender.City.Id))
                    {
                        continue;
                    }
                }

                if (context.Themes != null && context.Themes.Count > 0)
                {
                    if (!context.Themes.Contains(tender.Theme.Id))
                    {
                        continue;
                    }
                }

                Tenders.Add(tender);
            }

            if ((context.Citys == null || context.Citys.Count == 0) && (context.Themes == null || context.Themes.Count == 0))
            {
                if (Tenders.Count == 0)
                {
                    Tenders.AddRange(tenders);
                }
            }

            this.TenderThemases = this.GetListTenderTheme();
            this.GroupCitys = new Dictionary<string, List<City>>();
            this.GetCitys();

            Context = context;
        }

        private void SetTenders()
        {
            
        }

        private FilterContext PrepareContext(FilterContext context)
        {
            var result = new FilterContext();

            if (context == null)
            {
                context = new FilterContext();
            }

            var filterCitys = new RegionFilterService(this.Auth.User);
            var filterThemes = new TenderFilterService(this.Auth.User);

            if (context.IsClear)
            {
                filterCitys.Clear();
                filterThemes.Clear();
            }

            SingleClear(filterCitys, filterThemes, context);

            if (context.Citys != null && context.Citys.Count > 0)
            {
                context.Citys = context.Citys.Distinct().ToList<int>();
                filterCitys.Save(context.Citys, new List<string>());
            }
            context.Citys.Clear();
            filterCitys.GetCitys().ForEach(x => result.Citys.Add(x.Id));

            
            if (context.Themes != null && context.Themes.Count > 0)
            {
                context.Themes = context.Themes.Distinct().ToList();
                filterThemes.SaveFiltres(context.Themes);
            }

            context.Themes.Clear();
            filterThemes.GetListSubs().ForEach(x => result.Themes.Add(x.Theme.Id));

            return result;
        }

        private void SingleClear(RegionFilterService regFitlter, TenderFilterService tendFilter, FilterContext context)
        {
            if (context.Citys != null && context.Citys.Count > 0 && context.Themes != null && context.Themes.Count == 0)
            {
                tendFilter.Clear();
            }

            if (context.Themes != null && context.Themes.Count > 0 && context.Citys != null && context.Citys.Count == 0)
            {
                regFitlter.Clear();
            }
        }

        public Dictionary<string, List<TenderTheme>> GetListTenderTheme()
        {
            var result = new Dictionary<string, List<TenderTheme>>();

            var themes = TenderTheme
                .FindAll()
                .GroupBy(x => x.Theme)
                .ToList();

            foreach (var theme in themes)
            {
                var temp = theme
                    .OrderBy(x => x.NomberInList)
                    .ToList();
                result.Add(theme.Key, temp);
            }

            return result;
        }

        public void GetCitys()
        {
            var allCitys = RegionService.CityAll()
                    .GroupBy(x => x.Region.Name);

            foreach (var kvp in allCitys)
            {
                this.GroupCitys.Add(kvp.Key, kvp.ToList());
            }
        }
    }
}
