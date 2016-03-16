using MyTend.Entites;
using MyTend.Services.Common;
using MyTender.Security;
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

        /// <summary>
        /// Все мои тендеры
        /// </summary>
        /// <returns></returns>
        public OpenCloseTenders GetMy()
        {
            var tenders = new OpenCloseTenders();

            var all = Tender.FindAll()
                .Where(x => x.User.Id == this.Auth.User.Id)
                .OrderBy(x => x.CreatedDateTime)
                .ToList();

            tenders.Close = all.Where(x => x.IsActive == false)
                .ToList();
            tenders.Open = all.Where(x => x.IsActive == true)
                .ToList();

            return tenders;
        }

        /// <summary>
        /// Список тендеров с моими придложениями
        /// </summary>
        /// <returns></returns>
        public OpenCloseTenders GetList()
        {
            var tenders = new OpenCloseTenders();

            var all = TenderMessage.FindAll()
                .Where(x => x.User.Id != this.Auth.User.Id)
                .Select(x => x.Tender)
                .OrderBy(x => x.CreatedDateTime)
                .ToList();

            tenders.Close = all.Where(x => x.IsActive == false)
                .ToList();
            tenders.Open = all.Where(x => x.IsActive == true)
                .ToList();

            return tenders;
        }

        /// <summary>
        /// Тендеры где я победил
        /// </summary>
        /// <returns></returns>
        public List<Tender> GetWinner()
        {
            var all = Tender.FindAll()
                .Where(x => x.User.Id != this.Auth.User.Id)
                .Where(x => x.Winner != null && x.Winner.Id == this.Auth.User.Id)
                .OrderBy(x => x.CreatedDateTime)
                .ToList();

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
                .ToList();

            var tenderResult = new List<Tender>();

            tenders.ForEach(x =>
            {
                var exist = TenderMessage.FindAll()
                    .Any(y => y.User.Id == x.Id);

                if (!exist)
                {
                    tenderResult.Add(x);
                }
            });

            return tenderResult;
        }
    }

    public class OpenCloseTenders
    {
        public List<Tender> Open { get; set; }

        public List<Tender> Close { get; set; }
    }
}
