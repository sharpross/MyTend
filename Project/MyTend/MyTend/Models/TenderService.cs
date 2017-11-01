using MyTend.Entites;
using MyTend.Services.Common;
using MyTender.Security;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTend.Models
{
    public class TenderService
    {
        public AuthService Auth { get; set; }

        public RegionFilterService RegionFilter { get; set; }

        public TenderFilterService TendersFilter { get; set; }

        public TenderService()
        {
            this.Auth = new AuthService();
            this.RegionFilter = new RegionFilterService(Auth.User);
            this.TendersFilter = new TenderFilterService(Auth.User);
        }

        public Tender GetTender(int id)
        {
            return Tender.GetById(id);
        }

        private List<Tender> Filtering(List<Tender> tenders)
        {
            var result = new List<Tender>();

            var filtresByUser = TenderHide.FindAll(Expression.Eq("User", this.Auth.User))
                //.Where(x => x.User.Id == this.Auth.User.Id)
                .ToList();
            
            tenders.ForEach(x => {
                var exist = filtresByUser
                    .FirstOrDefault(f => f.Tender.Id == x.Id);

                if (exist == null)
                {
                    result.Add(x);
                }
            });

            return result;
        }

        /// <summary>
        /// Все мои тендеры
        /// </summary>
        /// <returns></returns>
        public OpenCloseTenders GetMy()
        {
            var tenders = new OpenCloseTenders();

            var all = Tender.FindAll(Expression.Eq("User", this.Auth.User))
                //.Where(x => x.User.Id == this.Auth.User.Id)
                .OrderByDescending(x => x.CreatedDateTime)
                .ToList();

            tenders.Close = all.Where(x => x.IsActive == false)
                .ToList();
            tenders.Open = all.Where(x => x.IsActive == true)
                .ToList();

            tenders.Close = this.Filtering(tenders.Close);
            tenders.Open = this.Filtering(tenders.Open);

            return tenders;
        }

        /// <summary>
        /// Список тендеров с моими придложениями
        /// </summary>
        /// <returns></returns>
        public OpenCloseTenders GetList()
        {
            var tenders = new OpenCloseTenders();

            var all = TenderMessage.FindAll(Expression.Eq("User", this.Auth.User))
                //.Where(x => x.User.Id == this.Auth.User.Id)
                .GroupBy(x => x.Tender)
                .Select(x => x.Key)
                .OrderByDescending(x => x.CreatedDateTime)
                .ToList();

            tenders.Close = all.Where(x => x.IsActive == false)
                .ToList();
            tenders.Open = all.Where(x => x.IsActive == true)
                .ToList();

            tenders.Close = this.Filtering(tenders.Close);
            tenders.Open = this.Filtering(tenders.Open);

            return tenders;
        }

        /// <summary>
        /// Тендеры где я победил
        /// </summary>
        /// <returns></returns>
        public List<Tender> GetWinner()
        {
            var all = Tender.FindAll(Expression.Not(Expression.Eq("User", this.Auth.User)))
                //.Where(x => x.User.Id != this.Auth.User.Id)
                .Where(x => x.Winner != null && x.Winner.Id == this.Auth.User.Id)
                .OrderByDescending(x => x.CreatedDateTime)
                .ToList();

            all = this.Filtering(all);

            return all;
        }

        /// <summary>
        /// Список тендеров
        /// </summary>
        /// <returns></returns>
        public List<Tender> GetActive()
        {
            var regionFiltered = this.RegionFilter.GetTenders();
            var tenders = this.TendersFilter.GetByListTenders(regionFiltered)
                .Where(x => x.IsActive)
                .OrderByDescending(x => x.CreatedDateTime)
                .ToList();

            if (this.Auth != null && this.Auth.User != null)
            {
                tenders = tenders
                .Where(x => x.User.Id != this.Auth.User.Id)
                .ToList();
            }

            var tenderResult = new List<Tender>();

            tenders.ForEach(x =>
            {
                var exist = TenderMessage.FindAll(Expression.Eq("Tender", x))
                    .Any();

                //if (!exist)
                {
                    tenderResult.Add(x);
                }
            });

            tenderResult = this.Filtering(tenderResult);

            return tenderResult;
        }
    }

    public class OpenCloseTenders
    {
        public List<Tender> Open { get; set; }

        public List<Tender> Close { get; set; }
    }
}
