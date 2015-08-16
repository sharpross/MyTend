namespace MyTend.Services.Migrations
{
    using Castle.ActiveRecord;
    using MyTend.Data;
    using MyTend.Entites;
    using System.Collections.Generic;

    public class TenderThemesMigration : IMigration
    {
        public string Code
        {
            get { return "Создание тем тендера."; }
        }

        public void Migrate()
        {
            var list = new List<TenderTheme>();

            var t1 = "Авто, Автоперевозки";
            list.Add(new TenderTheme() { ImageName = "1.png", IsTitle = true, NomberInList = 1, Theme = t1, Title = "Ищу з/ч к авто" });
            list.Add(new TenderTheme() { ImageName = "1.png", IsTitle = false, NomberInList = 2, Theme = t1, Title = "Ищу з/ч от кузова" });
            list.Add(new TenderTheme() { ImageName = "1.png", IsTitle = false, NomberInList = 3, Theme = t1, Title = "Ищу з/ч от двигателя" });
            list.Add(new TenderTheme() { ImageName = "1.png", IsTitle = false, NomberInList = 4, Theme = t1, Title = "Ищу з/ч от электронного оборудования" });

            var t2 = "Недвижимость-сделки, Аренда";
            list.Add(new TenderTheme() { ImageName = "2.png", IsTitle = true, NomberInList = 1, Theme = t2, Title = "Квартиры" });
            list.Add(new TenderTheme() { ImageName = "2.png", IsTitle = false, NomberInList = 2, Theme = t2, Title = "Купить/продать квартиру" });
            list.Add(new TenderTheme() { ImageName = "2.png", IsTitle = false, NomberInList = 3, Theme = t2, Title = "Снять квартиру на несколько месяцев" });
            list.Add(new TenderTheme() { ImageName = "2.png", IsTitle = false, NomberInList = 4, Theme = t2, Title = "Снять квартиру на несколько часов/суток" });

            var t3 = "Услуги кредитования";
            list.Add(new TenderTheme() { ImageName = "3.png", IsTitle = false, NomberInList = 1, Theme = t3, Title = "Поиск кредита , микро-займ" });

            var t4 = "Аренда, прокат";
            list.Add(new TenderTheme() { ImageName = "4.png", IsTitle = false, NomberInList = 1, Theme = t4, Title = "Авто, мото" });
            list.Add(new TenderTheme() { ImageName = "4.png", IsTitle = false, NomberInList = 2, Theme = t4, Title = "Спецтехника" });
            list.Add(new TenderTheme() { ImageName = "4.png", IsTitle = false, NomberInList = 3, Theme = t4, Title = "Инструменты, электростанции и т.д." });
            list.Add(new TenderTheme() { ImageName = "4.png", IsTitle = false, NomberInList = 4, Theme = t4, Title = "Лодки, яхты, теплоходы" });
            list.Add(new TenderTheme() { ImageName = "4.png", IsTitle = false, NomberInList = 5, Theme = t4, Title = "Легкомоторные самолеты" });
            list.Add(new TenderTheme() { ImageName = "4.png", IsTitle = false, NomberInList = 6, Theme = t4, Title = "Свадебные платья" });
            list.Add(new TenderTheme() { ImageName = "4.png", IsTitle = false, NomberInList = 7, Theme = t4, Title = "Карнавальные, исторические костюмы" });
            list.Add(new TenderTheme() { ImageName = "4.png", IsTitle = false, NomberInList = 8, Theme = t4, Title = "Спортивный инвентарь" });
            list.Add(new TenderTheme() { ImageName = "4.png", IsTitle = false, NomberInList = 9, Theme = t4, Title = "Туристический инвентарь" });
            list.Add(new TenderTheme() { ImageName = "4.png", IsTitle = false, NomberInList = 10, Theme = t4, Title = "Звуковая-световая аппаратура" });
            list.Add(new TenderTheme() { ImageName = "4.png", IsTitle = false, NomberInList = 11, Theme = t4, Title = "Фото,видео камеры,студийное оборудование в аренду, студии" });

            var t5 = "Репетиторы";
            list.Add(new TenderTheme() { ImageName = "5.png", IsTitle = false, NomberInList = 1, Theme = t5, Title = "Поиск репетитора по математике, алгебре" });
            list.Add(new TenderTheme() { ImageName = "5.png", IsTitle = false, NomberInList = 2, Theme = t5, Title = "Поиск репетитора по геометрии" });
            list.Add(new TenderTheme() { ImageName = "5.png", IsTitle = false, NomberInList = 2, Theme = t5, Title = "Поиск репетитора по физике" });
            list.Add(new TenderTheme() { ImageName = "5.png", IsTitle = false, NomberInList = 2, Theme = t5, Title = "Поиск репетитора по химии" });
            list.Add(new TenderTheme() { ImageName = "5.png", IsTitle = false, NomberInList = 2, Theme = t5, Title = "Поиск репетитора по английскому языку" });
            list.Add(new TenderTheme() { ImageName = "5.png", IsTitle = false, NomberInList = 2, Theme = t5, Title = "Поиск репетитора по французскому языку" });
            list.Add(new TenderTheme() { ImageName = "5.png", IsTitle = false, NomberInList = 2, Theme = t5, Title = "Поиск репетитора по немецкому языку" });
            list.Add(new TenderTheme() { ImageName = "5.png", IsTitle = false, NomberInList = 2, Theme = t5, Title = "Поиск репетитора по испанскому языку" });
            list.Add(new TenderTheme() { ImageName = "5.png", IsTitle = false, NomberInList = 2, Theme = t5, Title = "Поиск репетитора по китайскому языку" });
            list.Add(new TenderTheme() { ImageName = "5.png", IsTitle = false, NomberInList = 2, Theme = t5, Title = "Поиск репетитора по японскому языку" });
            list.Add(new TenderTheme() { ImageName = "5.png", IsTitle = false, NomberInList = 2, Theme = t5, Title = "Поиск репетитора по другим языкам" });
            list.Add(new TenderTheme() { ImageName = "5.png", IsTitle = false, NomberInList = 2, Theme = t5, Title = "Прочие консультации по разным дисциплинам" });

            var t6 = "Деловые услуги для бизнеса";
            list.Add(new TenderTheme() { ImageName = "6.png", IsTitle = true, NomberInList = 1, Theme = t6, Title = "Правовая  защита интересов бизнеса" });
            list.Add(new TenderTheme() { ImageName = "6.png", IsTitle = false, NomberInList = 2, Theme = t6, Title = "Мне нужен юрист, адвокат по гражданским делам" });
            list.Add(new TenderTheme() { ImageName = "6.png", IsTitle = false, NomberInList = 3, Theme = t6, Title = "Мне нужен юрист, адвокат  по уголовным делам" });
            list.Add(new TenderTheme() { ImageName = "6.png", IsTitle = false, NomberInList = 4, Theme = t6, Title = "Мне нужен юрист, адвокат  по административным делам" });
            list.Add(new TenderTheme() { ImageName = "6.png", IsTitle = false, NomberInList = 5, Theme = t6, Title = "Мне нужен юрист, адвокат  по трудовым спорам" });
            list.Add(new TenderTheme() { ImageName = "6.png", IsTitle = false, NomberInList = 6, Theme = t6, Title = "Мне нужен юрист, адвокат  по корпоративным спорам" });
            list.Add(new TenderTheme() { ImageName = "6.png", IsTitle = true, NomberInList = 7, Theme = t6, Title = "Прочие услуги для бизнеса" });
            list.Add(new TenderTheme() { ImageName = "6.png", IsTitle = false, NomberInList = 8, Theme = t6, Title = "Мне нужен бухгалтер, аудитор" });
            list.Add(new TenderTheme() { ImageName = "6.png", IsTitle = false, NomberInList = 9, Theme = t6, Title = "Мне нужно открыть/закрыть ИП, ООО" });
            list.Add(new TenderTheme() { ImageName = "6.png", IsTitle = false, NomberInList = 10, Theme = t6, Title = "Мне нужен эксперт , оценщик" });
            list.Add(new TenderTheme() { ImageName = "6.png", IsTitle = false, NomberInList = 11, Theme = t6, Title = "Мне нужен специалист патентного права" });
            list.Add(new TenderTheme() { ImageName = "6.png", IsTitle = false, NomberInList = 12, Theme = t6, Title = "Мне нужен программист, web разработка,web-дизайн" });
            list.Add(new TenderTheme() { ImageName = "6.png", IsTitle = false, NomberInList = 13, Theme = t6, Title = "Мне нужен дизайнер (все направления)" });
            list.Add(new TenderTheme() { ImageName = "6.png", IsTitle = false, NomberInList = 14, Theme = t6, Title = "Мне нужен специалист по страхованию" });
            list.Add(new TenderTheme() { ImageName = "6.png", IsTitle = false, NomberInList = 15, Theme = t6, Title = "Мне нужно разработать фирменный стиль,создать логотип" });
            list.Add(new TenderTheme() { ImageName = "6.png", IsTitle = false, NomberInList = 16, Theme = t6, Title = "Мне нужна реклама, PR , размещение, раскрутка , промоутеры и т.д." });
            list.Add(new TenderTheme() { ImageName = "6.png", IsTitle = false, NomberInList = 17, Theme = t6, Title = "Мне нужен переводчик (перевод литературы, перевод переговоров,встречи)" });
            list.Add(new TenderTheme() { ImageName = "6.png", IsTitle = false, NomberInList = 18, Theme = t6, Title = "Мне нужен интернет , IT ,связь" });
            list.Add(new TenderTheme() { ImageName = "6.png", IsTitle = false, NomberInList = 19, Theme = t6, Title = "Мне нужен архитектор, инженер" });
            list.Add(new TenderTheme() { ImageName = "6.png", IsTitle = false, NomberInList = 20, Theme = t6, Title = "Мне нужны услуги охранного предприятия, телохранитель" });
            list.Add(new TenderTheme() { ImageName = "6.png", IsTitle = false, NomberInList = 21, Theme = t6, Title = "Мне нужна организация встреч, презентаций, конференций и т.д." });
            list.Add(new TenderTheme() { ImageName = "6.png", IsTitle = false, NomberInList = 22, Theme = t6, Title = "Мне нужна полиграфия, печать, лазерная резка ,рекламная продукция и т.д." });
            list.Add(new TenderTheme() { ImageName = "6.png", IsTitle = false, NomberInList = 23, Theme = t6, Title = "Мне нужны услуги сео оптимизации, реклама в интернете" });
            list.Add(new TenderTheme() { ImageName = "6.png", IsTitle = false, NomberInList = 24, Theme = t6, Title = "Мне нужно изготовление спец. одежды" });

            var t7 = "Услуги частным лицам";
            list.Add(new TenderTheme() { ImageName = "7.png", IsTitle = true, NomberInList = 1, Theme = t7, Title = "Мне нужна консультация или  защита юриста /адвоката" });
            list.Add(new TenderTheme() { ImageName = "7.png", IsTitle = false, NomberInList = 2, Theme = t7, Title = "Мне нужен юрист, адвокат по гражданским делам" });
            list.Add(new TenderTheme() { ImageName = "7.png", IsTitle = false, NomberInList = 3, Theme = t7, Title = "Мне нужен юрист, адвокат  по уголовным делам" });
            list.Add(new TenderTheme() { ImageName = "7.png", IsTitle = false, NomberInList = 4, Theme = t7, Title = "Мне нужен юрист, адвокат  по административным делам" });
            list.Add(new TenderTheme() { ImageName = "7.png", IsTitle = false, NomberInList = 5, Theme = t7, Title = "Прочие услуги частным лицам" });
            list.Add(new TenderTheme() { ImageName = "7.png", IsTitle = false, NomberInList = 6, Theme = t7, Title = "Независимый эксперт ,оценщик" });
            list.Add(new TenderTheme() { ImageName = "7.png", IsTitle = false, NomberInList = 7, Theme = t7, Title = "Дизайнер (все направления)" });
            list.Add(new TenderTheme() { ImageName = "7.png", IsTitle = false, NomberInList = 8, Theme = t7, Title = "Услуги подключения ТВ, интернет" });
            list.Add(new TenderTheme() { ImageName = "7.png", IsTitle = false, NomberInList = 9, Theme = t7, Title = "Фото, видео-сьемка" });
            list.Add(new TenderTheme() { ImageName = "7.png", IsTitle = false, NomberInList = 10, Theme = t7, Title = "Ищу няню , сиделку" });
            list.Add(new TenderTheme() { ImageName = "7.png", IsTitle = false, NomberInList = 11, Theme = t7, Title = "Услуги грузчиков, помощь при переезде" });

            var t8 = "Строительство, ремонт ,подключение";
            list.Add(new TenderTheme() { ImageName = "8.png", IsTitle = false, NomberInList = 1, Theme = t8, Title = "Отделка, ремонт -квартир, офисов, помещений" });
            list.Add(new TenderTheme() { ImageName = "8.png", IsTitle = false, NomberInList = 2, Theme = t8, Title = "Отделочные работы фасада, внешних элементов зданий" });
            list.Add(new TenderTheme() { ImageName = "8.png", IsTitle = false, NomberInList = 3, Theme = t8, Title = "Строительство домов, коттеджей, дач" });
            list.Add(new TenderTheme() { ImageName = "8.png", IsTitle = false, NomberInList = 4, Theme = t8, Title = "Строительство, ремонт бань" });
            list.Add(new TenderTheme() { ImageName = "8.png", IsTitle = false, NomberInList = 5, Theme = t8, Title = "Промышленный альпинизм" });
            list.Add(new TenderTheme() { ImageName = "8.png", IsTitle = false, NomberInList = 6, Theme = t8, Title = "Прочие объекты и тех.задания" });
            list.Add(new TenderTheme() { ImageName = "8.png", IsTitle = false, NomberInList = 7, Theme = t8, Title = "Строительство каминов, печей" });
            list.Add(new TenderTheme() { ImageName = "8.png", IsTitle = false, NomberInList = 8, Theme = t8, Title = "Мне нужен архитектор, инженер" });
            list.Add(new TenderTheme() { ImageName = "8.png", IsTitle = true, NomberInList = 9, Theme = t8, Title = "" });
            list.Add(new TenderTheme() { ImageName = "8.png", IsTitle = false, NomberInList = 10, Theme = t8, Title = "Установка ,ремонт окон" });
            list.Add(new TenderTheme() { ImageName = "8.png", IsTitle = false, NomberInList = 11, Theme = t8, Title = "Установка, ремонт дверей" });
            list.Add(new TenderTheme() { ImageName = "8.png", IsTitle = false, NomberInList = 12, Theme = t8, Title = "Работы связанные с потолками стенами, полами" });
            list.Add(new TenderTheme() { ImageName = "8.png", IsTitle = false, NomberInList = 13, Theme = t8, Title = "Сантехника -установка, планировка, ремонт, материалы" });
            list.Add(new TenderTheme() { ImageName = "8.png", IsTitle = false, NomberInList = 14, Theme = t8, Title = "Дерево-брус, бревно,  доска  и т.д." });
            list.Add(new TenderTheme() { ImageName = "8.png", IsTitle = false, NomberInList = 15, Theme = t8, Title = "Электро-техника, освещение" });
            list.Add(new TenderTheme() { ImageName = "8.png", IsTitle = false, NomberInList = 16, Theme = t8, Title = "Все для покраски" });
            list.Add(new TenderTheme() { ImageName = "8.png", IsTitle = false, NomberInList = 17, Theme = t8, Title = "Системы слежения и видеофиксации" });
            list.Add(new TenderTheme() { ImageName = "8.png", IsTitle = false, NomberInList = 18, Theme = t8, Title = "Системы вентиляции, кондиционеры" });

            var t12 = "Собираемся на отдых, в командировку";
            list.Add(new TenderTheme() { ImageName = "12.png", IsTitle = true, NomberInList = 1, Theme = t12, Title = "Хотим на отдых  за  границу" });
            list.Add(new TenderTheme() { ImageName = "12.png", IsTitle = false, NomberInList = 2, Theme = t12, Title = "Поиск, подбор тура у тур.фирм за границу" });
            list.Add(new TenderTheme() { ImageName = "12.png", IsTitle = false, NomberInList = 3, Theme = t12, Title = "Поиск, подбор речного, морского круиза" });
            list.Add(new TenderTheme() { ImageName = "12.png", IsTitle = true, NomberInList = 4, Theme = t12, Title = "Еду в командировку -ищу где остановиться" });
            list.Add(new TenderTheme() { ImageName = "12.png", IsTitle = false, NomberInList = 5, Theme = t12, Title = "Мне нужен номер в отеле" });
            list.Add(new TenderTheme() { ImageName = "12.png", IsTitle = false, NomberInList = 6, Theme = t12, Title = "Мне нужен номер в гостинице" });
            list.Add(new TenderTheme() { ImageName = "12.png", IsTitle = false, NomberInList = 7, Theme = t12, Title = "Мне нужно место в  хостеле" });
            list.Add(new TenderTheme() { ImageName = "12.png", IsTitle = false, NomberInList = 8, Theme = t12, Title = "Мне нужна квартира, комната в другом городе" });
            list.Add(new TenderTheme() { ImageName = "12.png", IsTitle = true, NomberInList = 9, Theme = t12, Title = "Едем отдыхать на наши курорты, Черное море" });
            list.Add(new TenderTheme() { ImageName = "12.png", IsTitle = false, NomberInList = 10, Theme = t12, Title = "Хочу снять комнату в частном доме" });
            list.Add(new TenderTheme() { ImageName = "12.png", IsTitle = false, NomberInList = 11, Theme = t12, Title = "Хочу снять номер в мини-гостинице, отеле" });

            foreach (var rec in list)
            {
                if (rec.IsValid())
                {
                    rec.Create();
                }
            }
        }

        public bool NeedMigrate()
        {
            return true;
        }
    }
}
