using System.Collections.Generic;
using System.Threading;
using MyTend.Entites;

namespace MyTend.Services.Migrations.Regions
{
    public class RegionMigration2 : IMigration
    {
        public string Code
        {
            get { return "Создание регионов/городов"; }
        }

        public void Migrate()
        {

            var rus = new Country() { Name = "Россия" };

            var Tatarstan = new Region() { Country = rus, Name = "Республика Татарстан", NomberSort = 0, IsMillion = false };
            //Tatarstan.Create();
            var listRu17 = new List<City>();

            listRu17.Add(new City() { Name = "Агрыз", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Азнакаево", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Аксубаево", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Актаныш", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Алексеевское", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Альметьевск", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Апастово", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Арск", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Бавлы", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Базарные Матаки", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Балтаси", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Богатые Сабы", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Болгар", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Большая Атня", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Большие Кайбицы", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Бугульма", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Буинск", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Васильево", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Верхний Услон", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Высокая Гора", Region = Tatarstan });
            listRu17.Add(new City() { Name = "НабережныеЧелны", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Джалиль", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Елабуга", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Заинск", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Зеленодольск", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Казань", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Камские Поляны", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Камское Устье", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Кукмор", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Лаишево", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Лениногорск", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Мамадыш", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Менделеевск", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Мензелинск", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Муслюмово", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Нижнекамск", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Нижняя Мактама", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Новошешминск", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Нурлат", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Пестрецы", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Рыбная Слобода", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Сарманово", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Старое Дрожжаное", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Тетюши", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Тюлячи", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Уруссу", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Черемшан", Region = Tatarstan });
            listRu17.Add(new City() { Name = "Чистополь", Region = Tatarstan });
            this.Create(listRu17);

            var bashkortostan = new Region() { Country = rus, Name = "Республика Башкортостан", NomberSort = 0, IsMillion = false };
            //bashkortostan.Create();
            var listRu3 = new List<City>();

            listRu3.Add(new City() { Name = "Агидель", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Акъяр", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Архангельское", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Аскарово", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Аскино", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Баймак", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Бакалы", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Белебей", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Белорецк", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Бижбуляк", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Бирск", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Благовещенск", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Большеустьикинское", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Буздяк", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Бураево", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Верхнеяркеево", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Верхние Киги", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Верхние Татышлы", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Давлеканово", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Дюртюли", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Ермекеево", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Ермолаево", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Зилаир", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Иглино", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Исянгулово", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Ишимбай", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Калтасы", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Кандры", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Караидель", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Кармаскалы", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Киргиз-Мияки", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Красная Горка", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Красноусольский", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Кумертау", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Кушнаренково", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Малояз", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Межгорье", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Мелеуз", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Месягутово", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Мишкино", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Мраково", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Нефтекамск", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Николо-Берёзовка", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Новобелокатай", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Октябрьский", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Приютово", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Раевский", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Салават", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Сибай", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Старобалтачево", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Старосубхангулово", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Стерлибашево", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Стерлитамак", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Толбазы", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Туймазы", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Уфа", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Учалы", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Фёдоровка", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Чекмагуш", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Чишмы", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Шаран", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Языково", Region = bashkortostan });
            listRu3.Add(new City() { Name = "Янаул", Region = bashkortostan });
            this.Create(listRu3);

            var Samara = new Region() { Country = rus, Name = "Самарская область", NomberSort = 0, IsMillion = false };
            Samara.Create();
            var listRu65 = new List<City>();

            listRu65.Add(new City() { Name = "Алексеевка", Region = Samara });
            listRu65.Add(new City() { Name = "Безенчук", Region = Samara });
            listRu65.Add(new City() { Name = "Богатое", Region = Samara });
            listRu65.Add(new City() { Name = "Большая Глушица", Region = Samara });
            listRu65.Add(new City() { Name = "Большая Черниговка", Region = Samara });
            listRu65.Add(new City() { Name = "Борское", Region = Samara });
            listRu65.Add(new City() { Name = "Елховка", Region = Samara });
            listRu65.Add(new City() { Name = "Жигулёвск", Region = Samara });
            listRu65.Add(new City() { Name = "Исаклы", Region = Samara });
            listRu65.Add(new City() { Name = "Камышла", Region = Samara });
            listRu65.Add(new City() { Name = "Кинель", Region = Samara });
            listRu65.Add(new City() { Name = "Кинель-Черкассы", Region = Samara });
            listRu65.Add(new City() { Name = "Клявлино", Region = Samara });
            listRu65.Add(new City() { Name = "Кошки", Region = Samara });
            listRu65.Add(new City() { Name = "Красноармейское", Region = Samara });
            listRu65.Add(new City() { Name = "Красный Яр", Region = Samara });
            listRu65.Add(new City() { Name = "Нефтегорск", Region = Samara });
            listRu65.Add(new City() { Name = "Новокуйбышевск", Region = Samara });
            listRu65.Add(new City() { Name = "Октябрьск", Region = Samara });
            listRu65.Add(new City() { Name = "Отрадный", Region = Samara });
            listRu65.Add(new City() { Name = "Пестравка", Region = Samara });
            listRu65.Add(new City() { Name = "Похвистнево", Region = Samara });
            listRu65.Add(new City() { Name = "Приволжье", Region = Samara });
            listRu65.Add(new City() { Name = "Рощинский", Region = Samara });
            listRu65.Add(new City() { Name = "Самара", Region = Samara });
            listRu65.Add(new City() { Name = "Сергиевск", Region = Samara });
            listRu65.Add(new City() { Name = "Суходол", Region = Samara });
            listRu65.Add(new City() { Name = "Сызрань", Region = Samara });
            listRu65.Add(new City() { Name = "Тольятти", Region = Samara });
            listRu65.Add(new City() { Name = "Усть-Кинельский", Region = Samara });
            listRu65.Add(new City() { Name = "Хворостянка", Region = Samara });
            listRu65.Add(new City() { Name = "Чапаевск", Region = Samara });
            listRu65.Add(new City() { Name = "Челно-Вершины", Region = Samara });
            listRu65.Add(new City() { Name = "Шентала", Region = Samara });
            listRu65.Add(new City() { Name = "Шигоны", Region = Samara });
            this.Create(listRu65);

            var maryiel = new Region() { Country = rus, Name = "Республика Марий Эл", NomberSort = 0, IsMillion = false };
            //maryiel.Create();
            var listRu13 = new List<City>();

            listRu13.Add(new City() { Name = "Волжск", Region = maryiel });
            listRu13.Add(new City() { Name = "Звенигово", Region = maryiel });
            listRu13.Add(new City() { Name = "Йошкар-Ола", Region = maryiel });
            listRu13.Add(new City() { Name = "Килемары", Region = maryiel });
            listRu13.Add(new City() { Name = "Козьмодемьянск", Region = maryiel });
            listRu13.Add(new City() { Name = "Красногорский", Region = maryiel });
            listRu13.Add(new City() { Name = "Краснооктябрьский", Region = maryiel });
            listRu13.Add(new City() { Name = "Куженер", Region = maryiel });
            listRu13.Add(new City() { Name = "Мари-Турек", Region = maryiel });
            listRu13.Add(new City() { Name = "Медведево", Region = maryiel });
            listRu13.Add(new City() { Name = "Морки", Region = maryiel });
            listRu13.Add(new City() { Name = "Новый Торъял", Region = maryiel });
            listRu13.Add(new City() { Name = "Оршанка", Region = maryiel });
            listRu13.Add(new City() { Name = "Параньга", Region = maryiel });
            listRu13.Add(new City() { Name = "Приволжский", Region = maryiel });
            listRu13.Add(new City() { Name = "Руэм", Region = maryiel });
            listRu13.Add(new City() { Name = "Семёновка", Region = maryiel });
            listRu13.Add(new City() { Name = "Сернур", Region = maryiel });
            listRu13.Add(new City() { Name = "Советский", Region = maryiel });
            listRu13.Add(new City() { Name = "Сурок", Region = maryiel });
            listRu13.Add(new City() { Name = "Суслонгер", Region = maryiel });
            listRu13.Add(new City() { Name = "Юрино", Region = maryiel });
            this.Create(listRu13);

            var Chuvashiia = new Region() { Country = rus, Name = "Чувашская Республика", NomberSort = 0, IsMillion = false };
            Chuvashiia.Create();
            var listRu22 = new List<City>();

            listRu22.Add(new City() { Name = "Алатырь", Region = Chuvashiia });
            listRu22.Add(new City() { Name = "Аликово", Region = Chuvashiia });
            listRu22.Add(new City() { Name = "Батырево", Region = Chuvashiia });
            listRu22.Add(new City() { Name = "Вурнары", Region = Chuvashiia });
            listRu22.Add(new City() { Name = "Ибреси", Region = Chuvashiia });
            listRu22.Add(new City() { Name = "Ишлеи", Region = Chuvashiia });
            listRu22.Add(new City() { Name = "Канаш", Region = Chuvashiia });
            listRu22.Add(new City() { Name = "Козловка", Region = Chuvashiia });
            listRu22.Add(new City() { Name = "Комсомольское", Region = Chuvashiia });
            listRu22.Add(new City() { Name = "Красноармейское", Region = Chuvashiia });
            listRu22.Add(new City() { Name = "Красные Четаи", Region = Chuvashiia });
            listRu22.Add(new City() { Name = "Кугеси", Region = Chuvashiia });
            listRu22.Add(new City() { Name = "Мариинский Посад", Region = Chuvashiia });
            listRu22.Add(new City() { Name = "Моргауши", Region = Chuvashiia });
            listRu22.Add(new City() { Name = "Новое Атлашево", Region = Chuvashiia });
            listRu22.Add(new City() { Name = "Новочебоксарск", Region = Chuvashiia });
            listRu22.Add(new City() { Name = "Новые Лапсары", Region = Chuvashiia });
            listRu22.Add(new City() { Name = "Порецкое", Region = Chuvashiia });
            listRu22.Add(new City() { Name = "Урмары", Region = Chuvashiia });
            listRu22.Add(new City() { Name = "Цивильск", Region = Chuvashiia });
            listRu22.Add(new City() { Name = "Чебоксары", Region = Chuvashiia });
            listRu22.Add(new City() { Name = "Шемурша", Region = Chuvashiia });
            listRu22.Add(new City() { Name = "Шумерля", Region = Chuvashiia });
            listRu22.Add(new City() { Name = "Шыгырдан", Region = Chuvashiia });
            listRu22.Add(new City() { Name = "Ядрин", Region = Chuvashiia });
            listRu22.Add(new City() { Name = "Янтиково", Region = Chuvashiia });
            this.Create(listRu22);

            var Nijegorod = new Region() { Country = rus, Name = "Нижегородская область", NomberSort = 0, IsMillion = false };
            Nijegorod.Create();
            var listRu55 = new List<City>();

            listRu55.Add(new City() { Name = "Ардатов", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Арзамас", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Арья ", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Балахна", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Ближне-Песочное", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Богородск", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Большое Козино", Region = Nijegorod });
            listRu55.Add(new City() { Name = "БольшоеМурашкино ", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Бор", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Бутурлино", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Варнавино ", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Васильсурск", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Вахтан", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Вача ", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Велетьма", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Ветлуга", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Ветлужский", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Виля", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Вознесенское", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Володарск", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Воротынец", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Ворсма", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Воскресенское", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Выкса", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Гавриловка", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Горбатов", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Горбатовка", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Городец", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Гремячево", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Дальнее Константиново ", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Дзержинск", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Досчатое", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Желнино", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Заволжье", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Ильиногорск", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Катунки", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Княгинино", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Ковернино", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Красная Горка", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Красные Баки", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Кстово", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Кулебаки", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Лесогорск", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Лукино", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Лукоянов", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Лысково", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Макарьево", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Мухтолово", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Навашино", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Нижний Новгород", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Павлово", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Первое Мая", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Первомайск", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Первомайский", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Перевоз", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Пижма", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Пильна", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Пыра", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Решетиха", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Саров", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Сатис ", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Семёнов", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Сергач", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Смолино", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Сокольское", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Сосновское ", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Сухобезводное", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Сява", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Тёша", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Тонкино ", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Тоншаево", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Тумботино", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Урень", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Фролищи", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Центральный", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Чистое", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Чкаловск", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Шайгино ", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Шаранга", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Шатки", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Шахунья", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Шиморское", Region = Nijegorod });
            listRu55.Add(new City() { Name = "Юганец", Region = Nijegorod });
            this.Create(listRu55);

            var Kirov = new Region() { Country = rus, Name = "Кировская область", NomberSort = 0, IsMillion = false };
            Kirov.Create();
            var listRu46 = new List<City>();
            listRu46.Add(new City() { Name = "Арбаж", Region = Kirov });
            listRu46.Add(new City() { Name = "Афанасьево", Region = Kirov });
            listRu46.Add(new City() { Name = "Белая Холуница", Region = Kirov });
            listRu46.Add(new City() { Name = "Богородское", Region = Kirov });
            listRu46.Add(new City() { Name = "Вахруши", Region = Kirov });
            listRu46.Add(new City() { Name = "Верхошижемье", Region = Kirov });
            listRu46.Add(new City() { Name = "Восточный", Region = Kirov });
            listRu46.Add(new City() { Name = "ВятскиеПоляны", Region = Kirov });
            listRu46.Add(new City() { Name = "Даровской", Region = Kirov });
            listRu46.Add(new City() { Name = "Демьяново", Region = Kirov });
            listRu46.Add(new City() { Name = "Зуевка", Region = Kirov });
            listRu46.Add(new City() { Name = "Кикнур", Region = Kirov });
            listRu46.Add(new City() { Name = "Кильмезь", Region = Kirov });
            listRu46.Add(new City() { Name = "Киров", Region = Kirov });
            listRu46.Add(new City() { Name = "Кирово-Чепецк", Region = Kirov });
            listRu46.Add(new City() { Name = "Кирс", Region = Kirov });
            listRu46.Add(new City() { Name = "Котельнич", Region = Kirov });
            listRu46.Add(new City() { Name = "Красная Поляна", Region = Kirov });
            listRu46.Add(new City() { Name = "Кумёны", Region = Kirov });
            listRu46.Add(new City() { Name = "Лебяжье", Region = Kirov });
            listRu46.Add(new City() { Name = "Ленинское", Region = Kirov });
            listRu46.Add(new City() { Name = "Лесной", Region = Kirov });
            listRu46.Add(new City() { Name = "Луза", Region = Kirov });
            listRu46.Add(new City() { Name = "Малмыж", Region = Kirov });
            listRu46.Add(new City() { Name = "Мураши", Region = Kirov });
            listRu46.Add(new City() { Name = "Мурыгино", Region = Kirov });
            listRu46.Add(new City() { Name = "Нагорск", Region = Kirov });
            listRu46.Add(new City() { Name = "Нема", Region = Kirov });
            listRu46.Add(new City() { Name = "Нолинск", Region = Kirov });
            listRu46.Add(new City() { Name = "Омутнинск", Region = Kirov });
            listRu46.Add(new City() { Name = "Опарино", Region = Kirov });
            listRu46.Add(new City() { Name = "Оричи", Region = Kirov });
            listRu46.Add(new City() { Name = "Орлов", Region = Kirov });
            listRu46.Add(new City() { Name = "Первомайский", Region = Kirov });
            listRu46.Add(new City() { Name = "Пижанка", Region = Kirov });
            listRu46.Add(new City() { Name = "Подосиновец", Region = Kirov });
            listRu46.Add(new City() { Name = "Рудничный", Region = Kirov });
            listRu46.Add(new City() { Name = "Санчурск", Region = Kirov });
            listRu46.Add(new City() { Name = "Свеча", Region = Kirov });
            listRu46.Add(new City() { Name = "Слободской", Region = Kirov });
            listRu46.Add(new City() { Name = "Советск", Region = Kirov });
            listRu46.Add(new City() { Name = "Сосновка", Region = Kirov });
            listRu46.Add(new City() { Name = "Суна", Region = Kirov });
            listRu46.Add(new City() { Name = "Тужа", Region = Kirov });
            listRu46.Add(new City() { Name = "Уни", Region = Kirov });
            listRu46.Add(new City() { Name = "Уржум", Region = Kirov });
            listRu46.Add(new City() { Name = "Фалёнки", Region = Kirov });
            listRu46.Add(new City() { Name = "Юрья", Region = Kirov });
            listRu46.Add(new City() { Name = "Яранск", Region = Kirov });
            this.Create(listRu46);

            var Uljanovsk = new Region() { Country = rus, Name = "Ульяновская область", NomberSort = 0, IsMillion = false };
            Uljanovsk.Create();
            var listRu75 = new List<City>();

            listRu75.Add(new City() { Name = "БазарныйСызган", Region = Uljanovsk });
            listRu75.Add(new City() { Name = "Барыш", Region = Uljanovsk });
            listRu75.Add(new City() { Name = "Большое Нагаткино", Region = Uljanovsk });
            listRu75.Add(new City() { Name = "Вешкайма", Region = Uljanovsk });
            listRu75.Add(new City() { Name = "Димитровград", Region = Uljanovsk });
            listRu75.Add(new City() { Name = "Инза", Region = Uljanovsk });
            listRu75.Add(new City() { Name = "Ишеевка", Region = Uljanovsk });
            listRu75.Add(new City() { Name = "Карсун", Region = Uljanovsk });
            listRu75.Add(new City() { Name = "Кузоватово", Region = Uljanovsk });
            listRu75.Add(new City() { Name = "Майна", Region = Uljanovsk });
            listRu75.Add(new City() { Name = "Мулловка", Region = Uljanovsk });
            listRu75.Add(new City() { Name = "Николаевка", Region = Uljanovsk });
            listRu75.Add(new City() { Name = "Новая Майна", Region = Uljanovsk });
            listRu75.Add(new City() { Name = "Новая Малыкла", Region = Uljanovsk });
            listRu75.Add(new City() { Name = "Новоспасское", Region = Uljanovsk });
            listRu75.Add(new City() { Name = "Новоульяновск", Region = Uljanovsk });
            listRu75.Add(new City() { Name = "Октябрьский", Region = Uljanovsk });
            listRu75.Add(new City() { Name = "Павловка", Region = Uljanovsk });
            listRu75.Add(new City() { Name = "Радищево", Region = Uljanovsk });
            listRu75.Add(new City() { Name = "Сенгилей", Region = Uljanovsk });
            listRu75.Add(new City() { Name = "СтараяКулатка", Region = Uljanovsk });
            listRu75.Add(new City() { Name = "Старая Майна", Region = Uljanovsk });
            listRu75.Add(new City() { Name = "Сурское", Region = Uljanovsk });
            listRu75.Add(new City() { Name = "Тереньга", Region = Uljanovsk });
            listRu75.Add(new City() { Name = "Ульяновск", Region = Uljanovsk });
            listRu75.Add(new City() { Name = "Чердаклы", Region = Uljanovsk });
            this.Create(listRu75);
        }

        public bool NeedMigrate()
        {
            return true;
        }

        private void Create(List<City> list)
        {
            foreach (var rec in list)
            {
                rec.Name = rec.Name.Trim();

                rec.Create();
                Thread.Sleep(200);
            }
        }
    }
}
