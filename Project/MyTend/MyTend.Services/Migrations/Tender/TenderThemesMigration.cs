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
              list.Add(new TenderTheme(){ImageName="1.png",IsTitle=true,NomberInList=1,Theme=t1,Title="--Поиск запчастей к автотранспорту--"});
              list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=2,Theme=t1,Title="Мне нужна деталь для кузова"});
              list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=3,Theme=t1,Title="Мне нужна деталь двигателя"});
              list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=4,Theme=t1,Title="Мне нужна деталь электрооборудования"});
              list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=5,Theme=t1,Title="Мне нужна деталь для ККП, АКПП"});
              list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=6,Theme=t1,Title="Мне нужна деталь для ходовой"});
              list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=7,Theme=t1,Title="Мне нужна деталь салона"});
              list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=8,Theme=t1,Title="Мне нужны шины, диски новые, б/у"});
              list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=9,Theme=t1,Title="Мне нужна деталь для тюнинга"});
              list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=10,Theme=t1,Title="Куплю авто на разбор"});
			  list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=11,Theme=t1,Title="Продам авто на разбор"});
              list.Add(new TenderTheme(){ImageName="1.png",IsTitle=true,NomberInList=12,Theme=t1,Title="--Ремонт, тюнинг авто--",});
              list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=13,Theme=t1,Title="Мне требуется специалист по ремонту кузова (ремонт после дтп, покраска итд)",});
              list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=14,Theme=t1,Title="Мне требуется специалист по ремонту двигателя",});
              list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=15,Theme=t1,Title="Мне требуется специалист по ремонту авто-электрики",});
              list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=16,Theme=t1,Title="Мне требуется специалист по ремонту КПП, АКПП",});
              list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=17,Theme=t1,Title="Мне требуется специалист по ремонту ходовой",});
              list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=18,Theme=t1,Title="Мне требуется специалист по ремонту салона, шумо-изоляция",});
              list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=19,Theme=t1,Title="Мне требуется специалист по тюнингу (кузов/ходовая/двс)",});
              list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=20,Theme=t1,Title="Мне нужно восстановить авто после дтп."});
              list.Add(new TenderTheme(){ImageName="1.png",IsTitle=true,NomberInList=21,Theme=t1,Title="--Услуги грузовых автоперевозок--",});
              list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=22,Theme=t1,Title="Мне нужно перевести груз до 3.5тонн",});
              list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=23,Theme=t1,Title="Мне нужно перевести груз от 3.5 тонн и выше",});
			  list.Add(new TenderTheme(){ImageName="1.png",IsTitle=true,NomberInList=24,Theme=t1,Title="--Услуги пассажирских автоперевозок--",});
              list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=25,Theme=t1,Title= "Мне нужно перевести до 15-20 человек",});
              list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=26,Theme=t1,Title="Мне нужно перевести от 20 человек и выше",});
			  list.Add(new TenderTheme(){ImageName="1.png",IsTitle=true,NomberInList=27,Theme=t1,Title="",});
              list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=28,Theme=t1,Title="Ищу водителя с личным автомобилем",});
              list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=29,Theme=t1,Title="Ищу инструктора по вождению автомобиля"});
			  list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=29,Theme=t1,Title="Мне нужно перегнать авто из пункта а в пункт б"});

            var t2 = "Недвижимость -сделки/аренда";
              list.Add(new TenderTheme(){ImageName="2.png",IsTitle=true,NomberInList=1,Theme=t2,Title="--Квартиры--",});
              list.Add(new TenderTheme(){ImageName="2.png",IsTitle=false,NomberInList=3,Theme=t2,Title="Я хочу снять квартиру,комнату на несколько месяцев",});
              list.Add(new TenderTheme(){ImageName="2.png",IsTitle=false,NomberInList=4,Theme=t2,Title="Я хочу снять квартиру на несколько часов, суток"});
			  list.Add(new TenderTheme(){ImageName="2.png",IsTitle=false,NomberInList=4,Theme=t2,Title="Я хочу подобрать варианты квартиры с целью покупки"});
              list.Add(new TenderTheme(){ImageName="2.png",IsTitle=true,NomberInList=5,Theme=t2,Title="--Коттеджи, дома, дачи, участки--",});
              list.Add(new TenderTheme(){ImageName="2.png",IsTitle=false,NomberInList=6,Theme=t2,Title="Я хочу арендовать коттедж, загородный дом, дачу посуточно",});
              list.Add(new TenderTheme(){ImageName="2.png",IsTitle=false,NomberInList=8,Theme=t2,Title="Хочу купить,земельный участок",});
              list.Add(new TenderTheme(){ImageName="2.png",IsTitle=true,NomberInList=9,Theme=t2,Title="--Коммерческая недвижимость, земля--",});
              list.Add(new TenderTheme(){ImageName="2.png",IsTitle=false,NomberInList=10,Theme=t2,Title="Мне нужно взять в аренду, купить, офисное помещение",});
              list.Add(new TenderTheme(){ImageName="2.png",IsTitle=false,NomberInList=11,Theme=t2,Title="Мне нужно взять в аренду коммерческую недвижимость",});
              list.Add(new TenderTheme(){ImageName="2.png",IsTitle=false,NomberInList=12,Theme=t2,Title="Мне нужно купить,коммерческую недвижимость",});
              list.Add(new TenderTheme(){ImageName="2.png",IsTitle=false,NomberInList=13,Theme=t2,Title="Мне нужно купить/в аренду земельный участок (под любые цели)",});
            
            var t3 = "Услуги юриста/адвоката";
           
              list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=2,Theme=t3,Title="-по гражданским делам",});
              list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=3,Theme=t3,Title="-по уголовным делам",});
              list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=4,Theme=t3,Title="-по административным делам",});
              list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=5,Theme=t3,Title="-по трудовым спорам",});
			  list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=6,Theme=t3,Title="-по антимонопольному законодательству",});
			  list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=7,Theme=t3,Title="-по налоговым спорам",});
			  list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=9,Theme=t3,Title="-по праву интелектуальной собственности ",});
              list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=10,Theme=t3,Title="по корпоративным спорам"});
              list.Add(new TenderTheme(){ImageName="3.png",IsTitle=true,NomberInList=11,Theme=t3,Title=" Мне требуется услуга патентного поверенного",});              
              list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=4,Theme=t3,Title="по административным делам",});
              list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=5,Theme=t3,Title="по вопросам авто-транспорта и ситуаций на дороге",});
			  list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=5,Theme=t3,Title="по правам интелектуальной собственности",});
			  list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=5,Theme=t3,Title="по самейному праву ",});
			  list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=5,Theme=t3,Title="по наследственным спорам",});
			  list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=5,Theme=t3,Title="по спорам с банками, коллекторскими агенствами итд",});
			  list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=5,Theme=t3,Title="по страховым спорам и выплатам",});
			  list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=5,Theme=t3,Title="по правам социального обеспечения",});
			  list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=5,Theme=t3,Title="по жилищному праву",});
			  list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=5,Theme=t3,Title="по муниципальному праву ",});
			  list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=5,Theme=t3,Title="по предпринимательскому праву",});
			  list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=5,Theme=t3,Title="по земельному праву",});
           

             var t4 = "Аренда, прокат";
             list.Add(new TenderTheme() { ImageName = "4.png", IsTitle = true, NomberInList = 1, Theme = t4, Title = "--Мне нужно арендовать--:", });
              list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=2,Theme=t4,Title="-автомобиль, автобус, мотоцикл, скутер в аренду",});
              list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=3,Theme=t4,Title="-спецтехнику ",});
              list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=4,Theme=t4,Title="–сппец.инструмент",});
			  list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=5,Theme=t4,Title="-электростанцию (бензо/дизель-генератор)",});
			  list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=5,Theme=t4,Title="-электростанцию (бензо/дизель/электро компрессор)",});
              list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=6,Theme=t4,Title="-лодку, катер, яхту, теплоход (пассажирский, прогулочный)",});
              list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=7,Theme=t4,Title="-легкомоторный самолет, вертолет",});
			  list.Add(new TenderTheme(){ImageName="1.png",IsTitle=true,NomberInList=8,Theme=t4,Title="Мне нужно азять в прокат:",});
              list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=9,Theme=t4,Title="-свадебное платье, смокинг и т.д.",});
              list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=10,Theme=t4,Title="-карнавальные, исторические костюмы и т.д.",});
              list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=11,Theme=t4,Title="-спортивный инвентарь",});
              list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=12,Theme=t4,Title="-туристическое оборудование, инвентарь",});
              list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=13,Theme=t4,Title="-звуковую, световую аппаратуру ",});
              list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=14,Theme=t4,Title="-фото/видеокамеру, студийное оборудование, арендовать студию"});

            var t5 = "Мне требуется репититор/инструктор/тренер";
			
              list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=1,Theme=t5,Title="Мне требуется инструктор по вождению автомобиля",});
			  list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=2,Theme=t5,Title="Мне требуется тренер (фитнес, бодибилдинг)",});
			  list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=3,Theme=t5,Title="Мне требуется тренер по боевым искуствам (все направления)",});
              list.Add(new TenderTheme(){ImageName="5.png",IsTitle=true,NomberInList=4,Theme=t5,Title="--Репетиторы -школа, вуз--",});
              list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=5,Theme=t5,Title="Мне требуется репетитор по математике, алгебре",});
              list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=6,Theme=t5,Title="Мне требуется репетитор по геометрии",});
              list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=7,Theme=t5,Title="Мне требуется репетитор по физике",});
              list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=8,Theme=t5,Title="Мне требуется репетитор по химии",});
              list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=9,Theme=t5,Title="Мне требуется репетитор по английскому языку",});
              list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=10,Theme=t5,Title="Мне требуется репетитор по французскому языку",});
              list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=11,Theme=t5,Title="Мне требуется репетитор по немецкомуязыку",});
              list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=12,Theme=t5,Title="Мне требуется репетитор по испанскому языку",});
              list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=13,Theme=t5,Title="Мне требуется репетитор по китайскому языку",});
              list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=14,Theme=t5,Title="Мне требуется репетитор по японскомуязыку",});
              list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=15,Theme=t5,Title="Мне требуется репетитор по другим языкам",});
              list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=16,Theme=t5,Title="Прочие консультации по разным дисциплинам"});
              list.Add(new TenderTheme(){ImageName="5.png",IsTitle=true,NomberInList=17,Theme=t5,Title="--Репетиторы по музыке--"});
              list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=18,Theme=t5,Title="Мне требуется репетитор по фортепиано"});
              list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=19,Theme=t5,Title="Мне требуется репетитор по вокалу"});
              list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=20,Theme=t5,Title="Мне требуется репетитор по гитаре(электрогитаре)"});
              list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=21,Theme=t5,Title="Мне требуется репетитор по скрипке, виолончели"});
              list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=22,Theme=t5,Title="Мне требуется репетитор по ударным инструментам"});
              list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=23,Theme=t5,Title="Мне требуется репетитор по аккордеону, баяну"});
              list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=24,Theme=t5,Title="Обучение игры на электрогитаре(бас) - школа рок музыки"});
              list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=25,Theme=t5,Title="Остальные инструменты"});

          

            var t6 = " Услуги для бизнеса";
              list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=13,Theme=t6,Title="Мне требуется бухгалтер, аудитор",});
              list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=14,Theme=t6,Title="Мне нужно открыть/закрыть ИП, ООО"});
              list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=16,Theme=t6,Title="Мне требуется эксперт, оценщик"});
              list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=17,Theme=t6,Title="Мне требуется переводчик (перевод литературы, сопровождение деловых встреч)",});
              list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=18,Theme=t6,Title="Мне требуется дизайнер(промышленный дизайн)",});
	          list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=19,Theme=t6,Title="Мне требуется дизайнер(Дизайн среды )",});
              list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=20,Theme=t6,Title="Мне требуется дизайнер(архитектура)",});
	          list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=21,Theme=t6,Title="Мне требуется дизайнер(web, графический)",});
              list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=22,Theme=t6,Title="Мненужно-интернет,it-техника,связь итд",});
              list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=23,Theme=t6,Title="Мне нужна организация встреч, презентаций, конференций и т.д.",});
              list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=24,Theme=t6,Title="Мне нужно изготовление спец.одежды"});
	          list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=25,Theme=t6,Title="Мне нужно изготовление спортивной формы/одежды"});
              list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=26,Theme=t6,Title="Мне требуется инженер, архитектор",});
              list.Add(new TenderTheme(){ImageName="6.png",IsTitle=true,NomberInList=27,Theme=t6,Title="--Фирменный стиль, реклама, PR для бизнеса--",});
              list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=28,Theme=t6,Title="Моей компании требуется сайт",});
              list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=29,Theme=t6,Title="Услуги полиграфии, печати, рекламная продукция",});
              list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=30,Theme=t6,Title="Мне нужно разработать фирменный стиль",});
              list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=31,Theme=t6,Title="Мне нужна реклама (тв, интернет, пресса, промоакции",});
              list.Add(new TenderTheme(){ImageName="6.png",IsTitle=true,NomberInList=32,Theme=t6,Title="--Охрана вас и вашего бизнеса--"});
              list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=33,Theme=t6,Title="Мне нужны услугио хранного предприятия, телохранитель",});
              list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=34,Theme=t6,Title="Мне нужны системы видеонаблюдения, охранные системы и т.д.",});
              list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=35,Theme=t6,Title="Мне нужно оборудование для бизнеса (все направления)",});
			  list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=36,Theme=t6,Title="Мне нужно взять в аренду, купить, офисное помещение",});

           

            var t7 = "Услуги частным лицам";

              
              list.Add(new TenderTheme(){ImageName="7.png",IsTitle=false,NomberInList=7,Theme=t7,Title="Независимый эксперт, оценщик",});
              list.Add(new TenderTheme(){ImageName="7.png",IsTitle=false,NomberInList=8,Theme=t7,Title="Дизайнер (все направления)",});
              list.Add(new TenderTheme(){ImageName="7.png",IsTitle=false,NomberInList=9,Theme=t7,Title="Услуги подключения ТВ, интернет",});
              list.Add(new TenderTheme(){ImageName="7.png",IsTitle=false,NomberInList=10,Theme=t7,Title="Фото, видео-сьемка",});
              list.Add(new TenderTheme(){ImageName="7.png",IsTitle=false,NomberInList=11,Theme=t7,Title="Ищу няню, сиделку",});
              list.Add(new TenderTheme(){ImageName="7.png",IsTitle=false,NomberInList=12,Theme=t7,Title="Услуги грузчиков,авто - помощь при переезде",});
              list.Add(new TenderTheme(){ImageName="7.png",IsTitle=false,NomberInList=13,Theme=t7,Title="Услуги очистки, уборки квартир, химчистки и т.д.",});
              list.Add(new TenderTheme(){ImageName="7.png",IsTitle=false,NomberInList=14,Theme=t7,Title="МУЖ НА ЧАС - то что не под силу дамам по хозяйству"});
              list.Add(new TenderTheme(){ImageName="7.png",IsTitle=false,NomberInList=15,Theme=t7,Title="Изготовление мебели на заказ",});

            var t8 = "Строительство/ремонт/подключение";

              list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=1,Theme=t8,Title="Мне требуется ремонт квартиры, офиса, итд",});
              list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=2,Theme=t8,Title="Отделочные работы фасада, внешних элементов зданий",});
              list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=3,Theme=t8,Title="Мне нужно построить дом, коттедж, прочие строения",});
              list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=4,Theme=t8,Title="Мне нужно построить баню, сауну, (ремонт)",});
              list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=5,Theme=t8,Title="Промышленный альпинизм",});
              list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=6,Theme=t8,Title="Прочие объекты и тех.Задания",});
              list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=7,Theme=t8,Title="Мне нужно построить камин, печь итд",});
              list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=8,Theme=t8,Title="Мне требуется архитектор, инженер",});
              list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=9,Theme=t8,Title="Установка, ремонт окон",});
              list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=10,Theme=t8,Title="Установка, ремонт дверей",});
              list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=11,Theme=t8,Title="Работы, связанные с потолками",});
			  list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=11,Theme=t8,Title="Работы, связанные с стенами",});
			  list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=11,Theme=t8,Title="Работы, связанные с полами",});
              list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=12,Theme=t8,Title="Сантехника - установка, планировка, ремонт, материалы ",});
              list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=13,Theme=t8,Title="Дерево - брус, бревно, доска итд (работы, поставка)",});
              list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=14,Theme=t8,Title="Электротехника, освещение (работы, поставка)",});
              list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=15,Theme=t8,Title="Лако-красочные материалы (поставка) ",});
              list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=16,Theme=t8,Title="Системы видеонаблюдения, охранные комплексы (работы, поставка)",});
              list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=17,Theme=t8,Title="Системы вентиляции, кондиционеры, теплотехника (установка, поставка)"});
              list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=18,Theme=t8,Title="Ворота, системы пропуска, шлакбаумы (установка, поставка)"});
              list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=19,Theme=t8,Title="Изготовление мебели на заказ (установка, поставка)",});

           var t9 = "Мне требуется мастер что либо сделать/починить";

             list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=15,Theme=t9,Title="Муж на час - то что не под силу дамам по хозяйству"});
			 list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=1,Theme=t9,Title="Мне требуется мастер - сантехник",});
             list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=2,Theme=t9,Title="Мне требуется мастер - электрик",});
             list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=3,Theme=t9,Title="Мне требуется мастер - по ремонту холодильников",});
             list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=4,Theme=t9,Title="Мне требуется мастер - по ремонту стиральных машин",});
             list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=5,Theme=t9,Title="Мне требуется мастер - по ремонту теле-радиоаппаратуры",});
             list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=6,Theme=t9,Title="Мне требуется мастер - по ремонту СВЧ печей",});
             list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=7,Theme=t9,Title="Мне требуется мастер - по ремонту и настройке компьютерной техники",});
             list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=8,Theme=t9,Title="Мне требуется мастер - по ремонту, сбору мебели",});
             list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=9,Theme=t9,Title="Мне требуется мастер - ювелирных изделий",});
             list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=10,Theme=t9,Title="Мне требуется мастер - электро/газо-сварщик",});
             list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=11,Theme=t9,Title="Мне требуется мастер - работа с металлом(станки, литье, ковка итд.)",});
             list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=12,Theme=t9,Title="Мне требуется мастер по дереву(весь спектр работ)",});
             list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=13,Theme=t9,Title="Мне требуется мастер по пошиву и ремонту одежды, меховых изделий, обуви",});
             list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=14,Theme=t9,Title="Прочие услуги",});
             

           
           var t10 = "У меня праздник/событие/корпоратив";
             list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=1,Theme=t10,Title="Мне требуется -ведущий, тамада",});
             list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=2,Theme=t10,Title="Мне требуется -d/j, звукооператор, аппаратура",});
             list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=3,Theme=t10,Title="Мне требуется -фотограф",});
             list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=4,Theme=t10,Title="Мне требуется -видеооператор",});
             list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=5,Theme=t10,Title="Мне нужна –кавер группа, живой звук, вокалист(ка)",});
             list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=6,Theme=t10,Title="Мне требуется -фокусник, иллюзионист",});
             list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=7,Theme=t10,Title="Мне требуется -актер-аниматор",});
             list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=8,Theme=t10,Title="Мне требуется -шоу-балет",});
			 list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=9,Theme=t10,Title="Мне нужно -Шоу мыльных пузырей",});
             list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=10,Theme=t10,Title="Мне требуется -артист светового, огненного шоу",});
             list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=11,Theme=t10,Title="Мне нужна - Выездная регистрация",});
             list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=12,Theme=t10,Title="Дед Мороз, Снегурочка",});
             list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=13,Theme=t10,Title="Украшение/подготовка/дизайн залов для торжеств",});
			 list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=13,Theme=t10,Title="Мне нужен повар/официант с выездом на банкет.",});
			 list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=13,Theme=t10,Title="Мне нужен баянист/аккордеонист",});
			 list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=13,Theme=t10,Title="Мне нужен народный хор/ансамбль",});
			 list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=13,Theme=t10,Title="Мне нужен цыганский ансамбль",});
			 list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=13,Theme=t10,Title="Мне нужен цыганский ансамбль",});
			 list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=13,Theme=t10,Title="Мне нужен инструментальный дуэт/ансамбль/оркестр.",});
             list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=14,Theme=t10,Title="Где мне бы отметить? - банкетные залы, кафе и т.д."});
			 list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=14,Theme=t10,Title="Автомобили/лимузины/конные экипажи на свадьбу"});

            
			
	  var t11 = "Красота и здоровье";

            list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=1,Theme=t11,Title="Мне требуется парикмахер",});
		    list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=2,Theme=t11,Title="Мне требуется визажист",});
            list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=3,Theme=t11,Title="Мне требуется мастер ногтевого сервиса",});
            list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=4,Theme=t11,Title="Мне требуется массажист"});
            list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=5,Theme=t11,Title="Мне требуется мастер по эпиляции",});
            list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=6,Theme=t11,Title="Мне требуется аращивание волос, ресниц, косички и т.д.",});
            list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=8,Theme=t11,Title="Мне требуется тату-мастер"});
			list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=8,Theme=t11,Title="Мне требуется татуаж губ/бровей"});
            list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=9,Theme=t11,Title="Продажа/презентация косметики"});


            
			
         var t12 = "Собираемся на отдых или в командировку";

           list.Add(new TenderTheme(){ImageName="12.png",IsTitle=true,NomberInList=1,Theme=t12,Title="--Хотим на отдых за границу--",});
           list.Add(new TenderTheme(){ImageName="12.png",IsTitle=false,NomberInList=2,Theme=t12,Title="Поиск, подбор тура у туристических фирм за границу",});
           list.Add(new TenderTheme(){ImageName="12.png",IsTitle=false,NomberInList=3,Theme=t12,Title="Поиск, подбор речного, морского круиза",});
           list.Add(new TenderTheme(){ImageName="12.png",IsTitle=true,NomberInList=4,Theme=t12,Title="--Еду в командировку, ищу где остановиться--",});
           list.Add(new TenderTheme(){ImageName="12.png",IsTitle=false,NomberInList=5,Theme=t12,Title="Мне требуется номер в отеле",});
           list.Add(new TenderTheme(){ImageName="12.png",IsTitle=false,NomberInList=6,Theme=t12,Title="Мне требуется номер в гостинице",});
           list.Add(new TenderTheme(){ImageName="12.png",IsTitle=false,NomberInList=7,Theme=t12,Title="Мне нужно место в хостеле"});
           list.Add(new TenderTheme(){ImageName="12.png",IsTitle=false,NomberInList=8,Theme=t12,Title="Мне нужна квартира, комната вдругом городе",});
           list.Add(new TenderTheme(){ImageName="12.png",IsTitle=true,NomberInList=9,Theme=t12,Title="--Едем отдыхать на наши курорты, Черное море--"});
           list.Add(new TenderTheme(){ImageName="12.png",IsTitle=false,NomberInList=10,Theme=t12,Title="Ищу комнату в частном доме",});
           list.Add(new TenderTheme(){ImageName="12.png",IsTitle=false,NomberInList=11,Theme=t12,Title="Ищу номер в мини-гостинице, отеле, пансионате, санатории"});

           

         var t13 = "Заказ банкетов/выездное питание/поставщики продуктов";

          list.Add(new TenderTheme(){ImageName="13.png",IsTitle=true,NomberInList=1,Theme=t13,Title="--Желаю закатить банкет/фуршет--"});
          list.Add(new TenderTheme(){ImageName="13.png",IsTitle=false,NomberInList=2,Theme=t13,Title="Мне требуется кафе организовать банкет/фуршет",});
          list.Add(new TenderTheme(){ImageName="13.png",IsTitle=false,NomberInList=3,Theme=t13,Title="Мне требуется ресторан организовать банкет/фуршет",});
          list.Add(new TenderTheme(){ImageName="13.png",IsTitle=false,NomberInList=4,Theme=t13,Title="Мне требуется загородный дом организовать банкет/фуршет",});
          list.Add(new TenderTheme(){ImageName="13.png",IsTitle=false,NomberInList=5,Theme=t13,Title="Мне требуется банкетный зал организовать банкет/фуршет",});
          list.Add(new TenderTheme(){ImageName="13.png",IsTitle=true,NomberInList=6,Theme=t13,Title="--Выездное питание, обслуживание--",});
          list.Add(new TenderTheme(){ImageName="13.png",IsTitle=false,NomberInList=7,Theme=t13,Title="Мне требуется повар",});
          list.Add(new TenderTheme(){ImageName="13.png",IsTitle=false,NomberInList=8,Theme=t13,Title="Мне нужны официанты",});
          list.Add(new TenderTheme(){ImageName="13.png",IsTitle=false,NomberInList=9,Theme=t13,Title="Мне нужна команда поваров, официантов с оборудованием или без",});
          list.Add(new TenderTheme(){ImageName="13.png",IsTitle=false,NomberInList=10,Theme=t13,Title="Мне нужно кормить сотрудников на работе (доставка обедов)",});
          list.Add(new TenderTheme(){ImageName="13.png",IsTitle=false,NomberInList=11,Theme=t13,Title="Нужно накормить – группу туристов, спортивную команду, школьную группу и т.д.",});
          list.Add(new TenderTheme(){ImageName="13.png",IsTitle=true,NomberInList=12,Theme=t13,Title="--Поиск поставщиков продуктов питания--",});
		  list.Add(new TenderTheme(){ImageName="13.png",IsTitle=false,NomberInList=13,Theme=t13,Title="Продукты питания (все виды)",});
		  list.Add(new TenderTheme(){ImageName="13.png",IsTitle=false,NomberInList=13,Theme=t13,Title="Напитки",});
          list.Add(new TenderTheme(){ImageName="13.png",IsTitle=false,NomberInList=13,Theme=t13,Title="Торты, выпечка на заказ",});
          list.Add(new TenderTheme(){ImageName="13.png",IsTitle=false,NomberInList=14,Theme=t13,Title="Полуфабрикаты (изготовление/поставка)"});

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
            return false;
        }
    }
}