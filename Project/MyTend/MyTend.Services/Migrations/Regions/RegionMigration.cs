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

            var adug = new Region() { Country = rus, Name = "Республика Адыгея", NomberSort = 0, IsMillion = false };
            adug.Create();
            var listRu2 = new List<City>();
            listRu2.Add(new City() { Name = "Адыгейск", Region = adug });
            listRu2.Add(new City() { Name = "Гиагинская", Region = adug });
            listRu2.Add(new City() { Name = "Дондуковская", Region = adug });
            listRu2.Add(new City() { Name = "Каменномостский", Region = adug });
            listRu2.Add(new City() { Name = "Кошехабль", Region = adug });
            listRu2.Add(new City() { Name = "Красногвардейское", Region = adug });
            listRu2.Add(new City() { Name = "Краснооктябрьский", Region = adug });
            listRu2.Add(new City() { Name = "Майкоп", Region = adug });
            listRu2.Add(new City() { Name = "Понежукай", Region = adug });
            listRu2.Add(new City() { Name = "Тахтамукай", Region = adug });
            listRu2.Add(new City() { Name = "Тлюстенхабль", Region = adug });
            listRu2.Add(new City() { Name = "Тульский", Region = adug });
            listRu2.Add(new City() { Name = "Хакуринохабль", Region = adug });
            listRu2.Add(new City() { Name = "Ханская", Region = adug });
            listRu2.Add(new City() { Name = "Энем", Region = adug });
            listRu2.Add(new City() { Name = "Яблоновский", Region = adug });
            this.Create(listRu2);

            var altay = new Region() { Country = rus, Name = "Республика Алтай", NomberSort = 0, IsMillion = false };
            altay.Create();
            var listRu3 = new List<City>();

            listRu3.Add(new City() { Name = "Акташ", Region = altay });
            listRu3.Add(new City() { Name = "Горно-Алтайск", Region = altay });
            listRu3.Add(new City() { Name = "Кош-Агач", Region = altay });
            listRu3.Add(new City() { Name = "Кызыл-Озёк", Region = altay });
            listRu3.Add(new City() { Name = "Майма", Region = altay });
            listRu3.Add(new City() { Name = "Онгудай", Region = altay });
            listRu3.Add(new City() { Name = "Турочак", Region = altay });
            listRu3.Add(new City() { Name = "Улаган", Region = altay });
            listRu3.Add(new City() { Name = "Усть-Кан", Region = altay });
            listRu3.Add(new City() { Name = "Усть-Кокса", Region = altay });
            listRu3.Add(new City() { Name = "Чемал", Region = altay });
            listRu3.Add(new City() { Name = "Чоя", Region = altay });
            listRu3.Add(new City() { Name = "Шебалино", Region = altay });
            this.Create(listRu3);

            var tuva = new Region() { Country = rus, Name = "Республика Тыва", NomberSort = 0, IsMillion = false };
            tuva.Create();
            var listRu4 = new List<City>();
            listRu4.Add(new City() { Name = "Ак-Довурак", Region = tuva });
            listRu4.Add(new City() { Name = "Бай-Хаак", Region = tuva });
            listRu4.Add(new City() { Name = "Балгазын", Region = tuva });
            listRu4.Add(new City() { Name = "Каа-Хем", Region = tuva });
            listRu4.Add(new City() { Name = "Кунгуртуг", Region = tuva });
            listRu4.Add(new City() { Name = "Кызыл", Region = tuva });
            listRu4.Add(new City() { Name = "Кызыл-Мажалык", Region = tuva });
            listRu4.Add(new City() { Name = "Мугур-Аксы", Region = tuva });
            listRu4.Add(new City() { Name = "Самагалтай", Region = tuva });
            listRu4.Add(new City() { Name = "Сарыг-Сеп", Region = tuva });
            listRu4.Add(new City() { Name = "Суг-Аксы", Region = tuva });
            listRu4.Add(new City() { Name = "Сукпак", Region = tuva });
            listRu4.Add(new City() { Name = "Тоора-Хем", Region = tuva });
            listRu4.Add(new City() { Name = "Туран", Region = tuva });
            listRu4.Add(new City() { Name = "Тээли", Region = tuva });
            listRu4.Add(new City() { Name = "Хандагайты", Region = tuva });
            listRu4.Add(new City() { Name = "Хову-Аксы", Region = tuva });
            listRu4.Add(new City() { Name = "Чаа-Холь", Region = tuva });
            listRu4.Add(new City() { Name = "Чадан", Region = tuva });
            listRu4.Add(new City() { Name = "Шагонар", Region = tuva });
            listRu4.Add(new City() { Name = "Эрзин", Region = tuva });
            this.Create(listRu4);

            var ymur = new Region() { Country = rus, Name = "Республика Удмуртия", NomberSort = 0, IsMillion = false };
            ymur.Create();
            var listRu5 = new List<City>();

            listRu5.Add(new City() { Name = "Алнаши", Region = ymur });
            listRu5.Add(new City() { Name = "Балезино", Region = ymur });
            listRu5.Add(new City() { Name = "Вавож", Region = ymur });
            listRu5.Add(new City() { Name = "Воткинск", Region = ymur });
            listRu5.Add(new City() { Name = "Глазов", Region = ymur });
            listRu5.Add(new City() { Name = "Грахово", Region = ymur });
            listRu5.Add(new City() { Name = "Дебёсы", Region = ymur });
            listRu5.Add(new City() { Name = "Завьялово", Region = ymur });
            listRu5.Add(new City() { Name = "Игра", Region = ymur });
            listRu5.Add(new City() { Name = "Камбарка", Region = ymur });
            listRu5.Add(new City() { Name = "Каракулино", Region = ymur });
            listRu5.Add(new City() { Name = "Кез", Region = ymur });
            listRu5.Add(new City() { Name = "Кизнер", Region = ymur });
            listRu5.Add(new City() { Name = "Киясово", Region = ymur });
            listRu5.Add(new City() { Name = "Красногорское", Region = ymur });
            listRu5.Add(new City() { Name = "Малая Пурга", Region = ymur });
            listRu5.Add(new City() { Name = "Можга", Region = ymur });
            listRu5.Add(new City() { Name = "Селты", Region = ymur });
            listRu5.Add(new City() { Name = "Сигаево", Region = ymur });
            listRu5.Add(new City() { Name = "Сюмси", Region = ymur });
            listRu5.Add(new City() { Name = "Ува", Region = ymur });
            listRu5.Add(new City() { Name = "Шаркан", Region = ymur });
            listRu5.Add(new City() { Name = "Юкаменское", Region = ymur });
            listRu5.Add(new City() { Name = "Якшур-Бодья", Region = ymur });
            listRu5.Add(new City() { Name = "Яр", Region = ymur });
            this.Create(listRu5);

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
