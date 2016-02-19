namespace MyTend.Services.Common
{
    using MyTend.Entites;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// 
    /// </summary>
    public class TenderFilterService
    {
        public UserSystem User { get; set; }

        public TenderFilterService(UserSystem user)
        {
            this.User = user;
        }

        public List<Tender> GetByListTenders(List<Tender> tenders)
        {
            var result = new List<Tender>();

            var filtres = this.GetListSubs();

            foreach (var filter in filtres)
            {
                var aa = tenders
                    .Where(x => x.Theme.Id == filter.Theme.Id)
                    .ToList();

                result.AddRange(aa);
            }

            result = result
                .OrderBy(x => x.CreatedDateTime)
                .ToList();

            return result;
        }

        public List<TenderFilter> GetListSubs()
        {
            var filtres = TenderFilter
                .FindAll()
                .Where(x => x.User.Id == this.User.Id)
                .ToList();

            return filtres;
        }

        /// <summary>
        /// Обновлет/сохраняет список подписок на темы тендера
        /// </summary>
        /// <param name="filtres"></param>
        public void SaveFiltres(List<int> filtres)
        {
            if (filtres != null)
            {
                this.ClearAllFiltres();

                foreach (var id in filtres)
                {
                    var theme = TenderTheme.GetById(id);

                    if (theme != null)
                    {
                        var newFilter = new TenderFilter()
                        {
                            User = this.User,
                            Theme = theme
                        };

                        if (!this.Exist(newFilter))
                        {
                            newFilter.Create();
                        }
                    }
                }
            }
        }

        private bool Exist(TenderFilter filter)
        {
            var exist = TenderFilter
                .FindAll()
                .Where(x => x.User.Id == this.User.Id)
                .Where(x => x.Theme.Id == filter.Id)
                .Any();

            return exist;
        }

        private void ClearAllFiltres()
        {
            var filtres = TenderFilter
                .FindAll()
                .Where(x => x.User.Id == this.User.Id);

            foreach (var filter in filtres)
            {
                var f = TenderFilter.GetById(filter.Id);

                f.Delete();
            }
        }

        public bool HasSubs()
        {
            var exist = TenderFilter
                .FindAll()
                .Where(x => x.User.Id == this.User.Id)
                .Any();

            return exist;
        }
    }
}
