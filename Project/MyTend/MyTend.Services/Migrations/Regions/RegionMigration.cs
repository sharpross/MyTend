using MyTend.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTend.Services.Migrations.Regions
{
    public class RegionMigration : IMigration
    {
        public string Code
        {
            get { return "Создание регионов/городов"; }
        }

        public void Migrate()
        {
            var rus = new Country() { Name = "Россия" };
            rus.Create();

            var tatarstan = new Region() { Country = rus, Name = "Республика Татарстан", NomberSort = 0, IsMillion = true };
            tatarstan.Create();
            var listRu = new List<City>();
            listRu.Add(new City() { Name = "Агрыз", Region = tatarstan });
            listRu.Add(new City() { Name = "Азнакаево", Region = tatarstan });
            listRu.Add(new City() { Name = "Аксубаево", Region = tatarstan });
            listRu.Add(new City() { Name = "Актаныш", Region = tatarstan });
            listRu.Add(new City() { Name = "Алексеевское", Region = tatarstan });
            listRu.Add(new City() { Name = "Базарные Матаки", Region = tatarstan });
            listRu.Add(new City() { Name = "Альметьевск", Region = tatarstan });
            listRu.Add(new City() { Name = "Апастово", Region = tatarstan });
            listRu.Add(new City() { Name = "Арск", Region = tatarstan });
            listRu.Add(new City() { Name = "Большая Атня", Region = tatarstan });
            listRu.Add(new City() { Name = "Бавлы", Region = tatarstan });
            listRu.Add(new City() { Name = "Балтаси", Region = tatarstan });
            listRu.Add(new City() { Name = "Бугульма", Region = tatarstan });
            listRu.Add(new City() { Name = "Буинск", Region = tatarstan });
            listRu.Add(new City() { Name = "Верхний Услон", Region = tatarstan });
            listRu.Add(new City() { Name = "Высокая Гора", Region = tatarstan });
            listRu.Add(new City() { Name = "Старое Дрожжаное", Region = tatarstan });
            listRu.Add(new City() { Name = "Елабуга", Region = tatarstan });
            listRu.Add(new City() { Name = "Заинск", Region = tatarstan });
            listRu.Add(new City() { Name = "Зеленодольск", Region = tatarstan });
            listRu.Add(new City() { Name = "Большие Кайбицы", Region = tatarstan });
            listRu.Add(new City() { Name = "Камское Устье", Region = tatarstan });
            listRu.Add(new City() { Name = "Кукмор", Region = tatarstan });
            listRu.Add(new City() { Name = "Лаишево", Region = tatarstan });
            listRu.Add(new City() { Name = "Лениногорск", Region = tatarstan });
            listRu.Add(new City() { Name = "Мамадыш", Region = tatarstan });
            listRu.Add(new City() { Name = "Менделеевск", Region = tatarstan });
            listRu.Add(new City() { Name = "Мензелинск", Region = tatarstan });
            listRu.Add(new City() { Name = "Муслюмово", Region = tatarstan });
            listRu.Add(new City() { Name = "Нижнекамск", Region = tatarstan });
            listRu.Add(new City() { Name = "Новошешминск", Region = tatarstan });
            listRu.Add(new City() { Name = "Нурлат", Region = tatarstan });
            listRu.Add(new City() { Name = "Пестрецы", Region = tatarstan });
            listRu.Add(new City() { Name = "Рыбная Слобода", Region = tatarstan });
            listRu.Add(new City() { Name = "Богатые Сабы", Region = tatarstan });
            listRu.Add(new City() { Name = "Сарманово", Region = tatarstan });
            listRu.Add(new City() { Name = "Болгар", Region = tatarstan });
            listRu.Add(new City() { Name = "Тетюши", Region = tatarstan });
            listRu.Add(new City() { Name = "Набережные Челны", Region = tatarstan });
            listRu.Add(new City() { Name = "Тюлячи", Region = tatarstan });
            listRu.Add(new City() { Name = "Черемшан", Region = tatarstan });
            listRu.Add(new City() { Name = "Уруссу", Region = tatarstan });
            listRu.Add(new City() { Name = "Васильево", Region = tatarstan });
            listRu.Add(new City() { Name = "Набережные Челны", Region = tatarstan });
            listRu.Add(new City() { Name = "Альметьевск", Region = tatarstan });
            listRu.Add(new City() { Name = "Чистополь", Region = tatarstan });
            listRu.Add(new City() { Name = "Камские Поляны", Region = tatarstan });
            listRu.Add(new City() { Name = "Нижняя Мактама", Region = tatarstan });
            listRu.Add(new City() { Name = "Джалиль", Region = tatarstan });
            this.Create(listRu);

            /*var tatarstan = new Region() { Country = rus, Name = "Татарстан", NomberSort = 1 };
            tatarstan.Create();
            listRu = new List<City>();
            listRu.Add(new City() { Name = "Казань", Region = tatarstan });
            listRu.Add(new City() { Name = "Альметьевск", Region = tatarstan });
            this.Create(listRu);*/
            
        }

        public bool NeedMigrate()
        {
            return true;
        }

        private void Create(List<City> list)
        {
            foreach (var rec in list)
            {
                rec.Create();
            }
        }
    }
}
