namespace MyTend.Services.Common
{
    using MyTend.Entites;
    using MyTend.Entites.Enums;
    using MyTender.Core;
    using NHibernate.Criterion;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Configuration;

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

        public bool HasSubs()
        {
            return RegionFilter.FindAll(Expression.Eq("User", user))
                .Any();
        }

        /// <summary>
        /// Удалить город из фильтров
        /// </summary>
        /// <param name="city">город</param>
        public void Remove(City city)
        {
            var record = RegionFilter.FindAll(Expression.Eq("User", user))
                .FirstOrDefault(x => x.City == city);

            if (record != null)
            {
                record.Delete();
            }
        }

        /// <summary>
        /// Сохранить список подписанных городов и регионов
        /// </summary>
        /// <param name="citys"></param>
        /// <param name="regions"></param>
        public void Save(List<int> citys, List<string> regions)
        {
            var allFilters = RegionFilter.FindAll(Expression.Eq("User", user))
               .ToList();

            foreach (var filter in allFilters)
            {
                filter.Delete();
            }

            var maxCitys = int.Parse(ConfigurationManager.AppSettings["MaxCitySub"]);

            foreach (var city in citys.Skip(Math.Max(0, citys.Count - maxCitys)))
            {
                var cityObj = City.GetById(city);

                if (cityObj != null)
                {
                    this.Save(cityObj);
                }
            }

            foreach (var region in regions.Skip(Math.Max(0, regions.Count - Constants._MAX_SUB_REGIONS)))
            {
                var regionObj = Region.GetByProp("Name", region)
                    .FirstOrDefault();

                if (regionObj != null)
                {
                    this.Save(regionObj);
                }
            }
        }

        /// <summary>
        /// Удалить купшщт из фильтров
        /// </summary>
        /// <param name="region">регион</param>
        public void Remove(Region region)
        {
            var record = RegionFilter.FindAll(Expression.Eq("User", user))
                .FirstOrDefault(x => x.Region.Id == region.Id);

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
            var newFilter = new RegionFilter()
            {
                City = city,
                User = this.user,
                Type = SubRegionType.City
            };

            newFilter.Create();
        }

        /// <summary>
        /// Добавить регион в фильтр
        /// </summary>
        /// <param name="region">регион</param>
        public void Save(Region region)
        {
            var newFilter = new RegionFilter()
            {
                Region = region,
                User = this.user,
                Type = SubRegionType.Region
            };

            newFilter.Create();
        }

        /// <summary>
        /// Получить тендеры по подписаным городам и регионам
        /// </summary>
        /// <returns>Список тендеров</returns>
        public List<Tender> GetTenders()
        {
            var tenders = new List<Tender>();
            
            var tendersByCitys = this.GetTenderByCitys();
            
            return tendersByCitys.ToList();
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
                var tendersByRegion = Tender.FindAll(Expression.Eq("Region", region));

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

            if (citys.Count == 0)
            {
                citys = City.FindAll().ToList();
            }

            var recs = Tender.FindAll(Expression.Eq("IsActive", true));

            foreach (var rec in recs)
            {
                foreach (var city in citys)
                {
                    if (rec.City.Id == city.Id)
                    {
                        tenders.Add(rec);
                    }
                }
            }
            
            return tenders;
        }

        /// <summary>
        /// Получить список подписанных регионов
        /// </summary>
        /// <returns>Список подписанных регионов</returns>
        public List<Region> GetRegions()
        {
            var records = RegionFilter.FindAll(Expression.Eq("User", user))
                .Where(x => x.Type == SubRegionType.Region )
                .Select(x => x.Region)
                .ToList();

            return records;
        }

        /// <summary>
        /// Получить список подписанных городов
        /// </summary>
        /// <returns>Список подписанных городов</returns>
        public List<City> GetCitys()
        {
            var records = RegionFilter.FindAll(Expression.Eq("User", user))
                .Where(x => x.Type == SubRegionType.City)
                .Select(x => x.City)
                .ToList();

            if (records.Count == 0)
            {
                //return City.FindAll().ToList();
            }

            return records;
        }

        public void Clear()
        {
            var data = RegionFilter.FindAll();

            foreach (var rec in data)
            {
                rec.Delete();
            }

            //RegionFilter.DeleteAll();
        }
    }
}
