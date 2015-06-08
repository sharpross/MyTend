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
            /*var list = new List<TenderTheme>();

            var t1 = "Авто, Автоперевозки";
            var t2 = "Недвижимость-сделки, Аренда";

            list.Add(new TenderTheme() { ImageName = "1.png", IsTitle = true, NomberInList = 1, Theme = t1, Title = "Ищу з/ч к авто" });
            list.Add(new TenderTheme() { ImageName = "1.png", IsTitle = false, NomberInList = 2, Theme = t1, Title = "Ищу з/ч от кузова" });
            list.Add(new TenderTheme() { ImageName = "1.png", IsTitle = false, NomberInList = 3, Theme = t1, Title = "Ищу з/ч от двигателя" });
            list.Add(new TenderTheme() { ImageName = "1.png", IsTitle = false, NomberInList = 4, Theme = t1, Title = "Ищу з/ч от электронного оборудования" });

            list.Add(new TenderTheme() { ImageName = "2.png", IsTitle = true, NomberInList = 5, Theme = t2, Title = "Квартиры" });
            list.Add(new TenderTheme() { ImageName = "2.png", IsTitle = false, NomberInList = 6, Theme = t2, Title = "Купить/продать квартиру" });
            list.Add(new TenderTheme() { ImageName = "2.png", IsTitle = false, NomberInList = 7, Theme = t2, Title = "Снять квартиру на несколько месяцев" });
            list.Add(new TenderTheme() { ImageName = "2.png", IsTitle = false, NomberInList = 8, Theme = t2, Title = "Снять квартиру на несколько часов/суток" });

            new TenderTheme().Create();

            foreach (var rec in list)
            {
                if (TenderTheme.IsValid(rec))
                {
                    rec.Create();
                }
            }*/
        }

        public bool NeedMigrate()
        {
            return true;
        }
    }
}
