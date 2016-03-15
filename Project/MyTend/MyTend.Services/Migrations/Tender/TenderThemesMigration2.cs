 namespace MyTend.Services.Migrations
{
    using Castle.ActiveRecord;
    using MyTend.Data;
    using MyTend.Entites;
    using System.Collections.Generic;

    public class TenderThemesMigration2 : IMigration
    {
        public string Code
        {
            get { return "Создание тем тендера."; }
        }

        public void Migrate()
        {
            var list = new List<TenderTheme>();
 
            var t1 = "Организация события";
			list.Add(new TenderTheme(){ImageName="1.svg",IsTitle=false,NomberInList=1,Theme=t1,Title="Мне требуется организация события «под ключ»",}); 
			list.Add(new TenderTheme(){ImageName="1.svg",IsTitle=false,NomberInList=2,Theme=t1,Title="Мне требуется составление сценария мероприятия",});
			list.Add(new TenderTheme(){ImageName="1.svg",IsTitle=false,NomberInList=3,Theme=t1,Title="Мне требуется организатор/свадебный распорядитель",});
			list.Add(new TenderTheme(){ImageName="1.svg",IsTitle=false,NomberInList=4,Theme=t1,Title="Мне требуется выездная регистрация",});
			
            var t2 = "Ведущий/тамада, на мероприятие";
			list.Add(new TenderTheme(){ImageName="2.svg",IsTitle=false,NomberInList=1,Theme=t2,Title="Мне требуется ведущий, тамада",}); 
			list.Add(new TenderTheme(){ImageName="2.svg",IsTitle=false,NomberInList=2,Theme=t2,Title="Мне требуется дуэт ведущих",}); 
			list.Add(new TenderTheme(){ImageName="2.svg",IsTitle=false,NomberInList=3,Theme=t2,Title="Мне требуется поющий ведущий",}); 
			list.Add(new TenderTheme(){ImageName="2.svg",IsTitle=false,NomberInList=4,Theme=t2,Title="Мне требуется ведущий, тамада с ведением на национальном языке",});
			list.Add(new TenderTheme(){ImageName="2.svg",IsTitle=false,NomberInList=5,Theme=t2,Title="Мне требуется ведущий детских праздников",}); 

            var t3 = "Дискотека, озвучивание события";
			list.Add(new TenderTheme(){ImageName="3.svg",IsTitle=false,NomberInList=1,Theme=t3,Title="Мне требуется DJ",}); 
			list.Add(new TenderTheme(){ImageName="3.svg",IsTitle=false,NomberInList=2,Theme=t3,Title="Мне требуется звукорежиссер",});
			list.Add(new TenderTheme(){ImageName="3.svg",IsTitle=false,NomberInList=3,Theme=t3,Title="Мне требуется аренда звуковой аппаратуры",});
 
 
            var t4 = "Фото, видео съемка  события";
 			list.Add(new TenderTheme(){ImageName="4.svg",IsTitle=false,NomberInList=1,Theme=t4,Title="Мне требуется фотограф",}); 
			list.Add(new TenderTheme(){ImageName="4.svg",IsTitle=false,NomberInList=2,Theme=t4,Title="Мне требуется видеограф",});
			list.Add(new TenderTheme(){ImageName="4.svg",IsTitle=false,NomberInList=3,Theme=t4,Title="Мне требуется ретушь/монтаж фото/видео материала",});
 
            var t5 = "Музыканты, вокалисты, танцоры, артисты, щоу";
     		list.Add(new TenderTheme(){ImageName="5.svg",IsTitle=true,NomberInList=1,Theme=t5,Title="Музыканты, вокалисты:",});
            list.Add(new TenderTheme(){ImageName="5.svg",IsTitle=false,NomberInList=2,Theme=t5,Title="Мне требуется кавер-группа",});
			list.Add(new TenderTheme(){ImageName="5.svg",IsTitle=false,NomberInList=3,Theme=t5,Title="Мне требуется певец/певица",});
			list.Add(new TenderTheme(){ImageName="5.svg",IsTitle=false,NomberInList=4,Theme=t5,Title="Мне требуется баянист/аккордеонист/гармонист",});
			list.Add(new TenderTheme(){ImageName="5.svg",IsTitle=false,NomberInList=5,Theme=t5,Title="Мне требуется скрипач/ альтист/ дуэт/ трио/ квартет"});
			list.Add(new TenderTheme(){ImageName="5.svg",IsTitle=false,NomberInList=6,Theme=t5,Title="Мне требуется саксафонист/флейтист (live/минус)"});
			list.Add(new TenderTheme(){ImageName="5.svg",IsTitle=false,NomberInList=7,Theme=t5,Title="Мне требуется гитарист (live/ минус)"});
			list.Add(new TenderTheme(){ImageName="5.svg",IsTitle=false,NomberInList=8,Theme=t5,Title="Мне требуется пианист(live/дуэтом/минус)"});
			list.Add(new TenderTheme(){ImageName="5.svg",IsTitle=false,NomberInList=9,Theme=t5,Title="Мне требуется народный хор/ансамбль",});
			list.Add(new TenderTheme(){ImageName="5.svg",IsTitle=false,NomberInList=10,Theme=t5,Title="Мне требуется цыганский ансамбль",});
			list.Add(new TenderTheme(){ImageName="5.svg",IsTitle=false,NomberInList=11,Theme=t5,Title="Мне требуется ансамбль/оркестр",});
			list.Add(new TenderTheme(){ImageName="5.svg",IsTitle=true,NomberInList=12,Theme=t5,Title="Артисты, шоу:",});
            list.Add(new TenderTheme(){ImageName="5.svg",IsTitle=false,NomberInList=13,Theme=t5,Title="Мне требуется фокусник, иллюзионист",});
			list.Add(new TenderTheme(){ImageName="5.svg",IsTitle=false,NomberInList=14,Theme=t5,Title="Мне требуется шоу пародий",});
            list.Add(new TenderTheme(){ImageName="5.svg",IsTitle=false,NomberInList=15,Theme=t5,Title="Мне требуется актер-аниматор",});
            list.Add(new TenderTheme(){ImageName="5.svg",IsTitle=false,NomberInList=16,Theme=t5,Title="Мне требуется артист светового/лазерного/fire-шоу",});
			list.Add(new TenderTheme(){ImageName="5.svg",IsTitle=false,NomberInList=17,Theme=t5,Title="Мне требуется шоу мыльных пузырей",}); 
			list.Add(new TenderTheme(){ImageName="5.svg",IsTitle=false,NomberInList=18,Theme=t5,Title="Мне требуется интерактивое шоу",});
			list.Add(new TenderTheme(){ImageName="5.svg",IsTitle=false,NomberInList=19,Theme=t5,Title="Мне требуется бармен шоу",});
			list.Add(new TenderTheme(){ImageName="5.svg",IsTitle=false,NomberInList=20,Theme=t5,Title="Мне требуется Дед Мороз, Снегурочка на дом/в офис/на корпоратив",});
			list.Add(new TenderTheme(){ImageName="5.svg",IsTitle=true,NomberInList=21,Theme=t5,Title="Танцоры:",});
		    list.Add(new TenderTheme(){ImageName="5.svg",IsTitle=false,NomberInList=22,Theme=t5,Title="Мне требуется шоу-балет",});
		    list.Add(new TenderTheme(){ImageName="5.svg",IsTitle=false,NomberInList=23,Theme=t5,Title="Мне требуется классический балет",});
            list.Add(new TenderTheme(){ImageName="5.svg",IsTitle=false,NomberInList=24,Theme=t5,Title="Мне требуется артист(ка) стриптиза",});
			list.Add(new TenderTheme(){ImageName="5.svg",IsTitle=false,NomberInList=25,Theme=t5,Title="Мне требуется танец живота",});
 
            var t6 = "Банкетный  зал, кейтеринг, торт на заказ";
			list.Add(new TenderTheme(){ImageName="6.svg",IsTitle=false,NomberInList=1,Theme=t6,Title="Мне требуется кафе/ресторан/банкетный зал  до 25 человек"});
			list.Add(new TenderTheme(){ImageName="6.svg",IsTitle=false,NomberInList=2,Theme=t6,Title="Мне требуется кафе/ресторан/банкетный зал от 25 до 50 человек"});
			list.Add(new TenderTheme(){ImageName="6.svg",IsTitle=false,NomberInList=3,Theme=t6,Title="Мне требуется кафе/ресторан/банкетный зал от 40 человек и больше"});
			list.Add(new TenderTheme(){ImageName="6.svg",IsTitle=true,NomberInList=4,Theme=t6,Title="Кейтеринг/Выездное питание/обслуживание:",});
            list.Add(new TenderTheme(){ImageName="6.svg",IsTitle=false,NomberInList=5,Theme=t6,Title="Мне нужен повар с выездом к заказчику",});
            list.Add(new TenderTheme(){ImageName="6.svg",IsTitle=false,NomberInList=6,Theme=t6,Title="Мне нужен официант с выездом к заказчику",});
            list.Add(new TenderTheme(){ImageName="6.svg",IsTitle=false,NomberInList=7,Theme=t6,Title="Мне нужна команда поваров и официантов со своим оборудованием",});
			list.Add(new TenderTheme(){ImageName="6.svg",IsTitle=true,NomberInList=8,Theme=t6,Title=":",});
			list.Add(new TenderTheme(){ImageName="6.svg",IsTitle=false,NomberInList=9,Theme=t6,Title="Мне нужен торт на заказ",});
 
            var t7 = "Образ на праздник";
			list.Add(new TenderTheme(){ImageName="7.svg",IsTitle=false,NomberInList=1,Theme=t7,Title="Мне требуется пошив платья для невесты",});
			list.Add(new TenderTheme(){ImageName="7.svg",IsTitle=false,NomberInList=2,Theme=t7,Title="Мне требуется визажист/парикмахер/маникюр и педикюр",});
			list.Add(new TenderTheme(){ImageName="7.svg",IsTitle=false,NomberInList=3,Theme=t7,Title="Мне требуется карнавальный костюм",});
			list.Add(new TenderTheme(){ImageName="7.svg",IsTitle=false,NomberInList=4,Theme=t7,Title="Мне требуется смокинг/вечернее платье",});			 
			list.Add(new TenderTheme(){ImageName="7.svg",IsTitle=false,NomberInList=5,Theme=t7,Title="Мне нужны атрибуты для костюмированной вечеринки",});
 
            var t8 = "Оформление, дизайн места проведения";
 			list.Add(new TenderTheme(){ImageName="8.svg",IsTitle=false,NomberInList=1,Theme=t8,Title="Мне требуется флорист/оформление живыми цветами/букет невесты",});
			list.Add(new TenderTheme(){ImageName="8.svg",IsTitle=false,NomberInList=2,Theme=t8,Title="Мне требуется стилистическое оформление места проведения торжества",});						 
			list.Add(new TenderTheme(){ImageName="8.svg",IsTitle=false,NomberInList=3,Theme=t8,Title="Мне требуется оформление шарами",});
			list.Add(new TenderTheme(){ImageName="8.svg",IsTitle=false,NomberInList=4,Theme=t8,Title="Мне нужны пригласительные, полиграфические атрибуты мероприятия",});						 
 
            var t9 = "Лимузин, карета, автобус для гостей";
 			list.Add(new TenderTheme(){ImageName="9.svg",IsTitle=false,NomberInList=1,Theme=t9,Title="Мне требуется автомобиль премиум класса",}); 
			list.Add(new TenderTheme(){ImageName="9.svg",IsTitle=false,NomberInList=2,Theme=t9,Title="Мне требуется лимузин",});
			list.Add(new TenderTheme(){ImageName="9.svg",IsTitle=false,NomberInList=3,Theme=t9,Title="Мне требуется карета/конный экипаж ",}); 
			list.Add(new TenderTheme(){ImageName="9.svg",IsTitle=false,NomberInList=4,Theme=t9,Title="Мне требуется микроавтобус",});
			list.Add(new TenderTheme(){ImageName="9.svg",IsTitle=false,NomberInList=5,Theme=t9,Title="Мне требуется автобус",}); 
		
            var t10 = "Мне требуется  аренда коттеджа";
 			list.Add(new TenderTheme(){ImageName="10.svg",IsTitle=false,NomberInList=1,Theme=t10,Title="Мне требуется коттедж",}); 
			list.Add(new TenderTheme(){ImageName="10.svg",IsTitle=false,NomberInList=2,Theme=t10,Title="Мне требуется с баней/бассейном",});

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
 
 