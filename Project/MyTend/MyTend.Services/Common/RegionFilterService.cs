namespace MyTend.Services.Common
{
    using MyTend.Entites;
    using MyTend.Entites.Enums;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Сервис для управления подписками и получение списка тендеро
    /// по подписанным городам и регионам
    /// </summary>
    public class RegionFilterService
    {
        private UserSystem user { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="user">пользователь</param>
        public RegionFilterService(UserSystem user)
        {
            this.user = user;
        }

        /// <summary>
        /// Удалить город из фильтров
        /// </summary>
        /// <param name="city">город</param>
        public void Remove(City city)
        {
            var record = RegionFilter.FindAll()
                .Where(x => x.User == user)
                .FirstOrDefault(x => x.City == city);

            if (record != null)
            {
                record.Delete();
            }
        }

        /// <summary>
        /// Удалить купшщт из фильтров
        /// </summary>
        /// <param name="region">регион</param>
        public void Remove(Region region)
        {
            var record = RegionFilter.FindAll()
                .Where(x => x.User == user)
                .FirstOrDefault(x => x.Region == region);

            if (record != null)
            {
                record.Delete();
            }
        }

        /// <summary>
        /// Добавить город в фильтр
        /// </summary>
        /// <param name="city">Город</param>
        public void Save(City city)
        {
            var exist = RegionFilter.FindAll()
                .FirstOrDefault(x => x.City == city);

            if (exist == null)
            {
                var newFilter = new RegionFilter()
                {
                    City = city,
                    User = this.user,
                    Type = SubRegionType.City
                };

                newFilter.Create();
            }
        }

        /// <summary>
        /// Добавить регион в фильтр
        /// </summary>
        /// <param name="region">регион</param>
        public void Save(Region region)
        {
            var exist = RegionFilter.FindAll()
                .FirstOrDefault(x => x.Region == region);

            if (exist == null)
            {
                var newFilter = new RegionFilter()
                {
                    Region =region,
                    User = this.user,
                    Type = SubRegionType.Region
                };

                newFilter.Create();
            }
        }

        /// <summary>
        /// Получить тендеры по подписаным городам и ррегионам
        /// </summary>
        /// <returns>Список тендеров</returns>
        public List<Tender> GetTenders()
        {
            var tenders = new List<Tender>();

            var tendersByRegions = this.GetTenderByRegions();
            var tendersByCitys = this.GetTenderByCitys();

            tenders.AddRange(tendersByRegions);

            var citys = this.GetCitys();
            var regions = this.GetRegions();

            foreach (var city in citys)
            {
                var contain = regions.Contains(city.Region);

                if (!contain)
                {
                    var tendersCity = tendersByCitys
                        .Where(x => x.City == city)
                        .ToList();

                    tenders.AddRange(tendersCity);
                }
            }

            return tenders;
        }

        /// <summary>
        /// Получение тендеров по подписанным регионам
        /// </summary>
        /// <returns>Список тендеров по регионам</returns>
        public List<Tender> GetTenderByRegions()
        {
            var tenders = new List<Tender>();

            var regions = this.GetRegions();

            foreach (var region in regions)
            {
                var tendersByRegion = Tender.FindAll()
                    .Where(x => x.Region == region);

                tenders.AddRange(tendersByRegion);
            }

            return tenders;
        }

        /// <summary>
        /// Получение тендеров по подписанным городам
        /// </summary>
        /// <returns>Список тендеров по городам</returns>
        public List<Tender> GetTenderByCitys()
        {
            var tenders = new List<Tender>();

            var citys = this.GetCitys();

            foreach (var city in citys)
            {
                var tendersByRegion = Tender.FindAll()
                    .Where(x => x.City == city);

                tenders.AddRange(tendersByRegion);
            }

            return tenders;
        }

        /// <summary>
        /// Получить список подписанных регионов
        /// </summary>
        /// <returns>Список подписанных регионов</returns>
        public List<Region> GetRegions()
        {
            var regions = new List<Region>();

            var records = RegionFilter.FindAll()
                .Where(x => x.User == this.user && x.Type == SubRegionType.Region );

            foreach (var record in records)
            {
                regions.Add(record.Region);
            }

            return regions;
        }

        /// <summary>
        /// Получить список подписанных городов
        /// </summary>
        /// <returns>Список подписанных городов</returns>
        public List<City> GetCitys()
        {
            var citys = new List<City>();

            var records = RegionFilter.FindAll()
                .Where(x => x.User == this.user && x.Type == SubRegionType.City);

            foreach (var record in records)
            {
                citys.Add(record.City);
            }

            return citys;
        }
    }
}
