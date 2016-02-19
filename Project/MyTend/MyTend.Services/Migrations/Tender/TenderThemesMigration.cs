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
 
 var t1 = "Авто: запчасти, ремонт, тюнинг, аренда, перегон";
			
            list.Add(new TenderTheme(){ImageName="1.png",IsTitle=true,NomberInList=1,Theme=t1,Title="Поиск запчастей:",});
			list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=2,Theme=t1,Title="Мне нужна деталь для кузова",});
            list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=3,Theme=t1,Title="Мне нужна деталь двигателя",});
            list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=4,Theme=t1,Title="Мне нужна деталь электрооборудования",});
            list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=5,Theme=t1,Title="Мне нужна деталь для ККП, АКПП",});
            list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=6,Theme=t1,Title="Мне нужна деталь для ходовой",});
            list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=7,Theme=t1,Title="Мне нужна деталь салона",});
            list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=8,Theme=t1,Title="Мне нужны шины/диски новые, б/у",});
            list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=9,Theme=t1,Title="Мне нужна деталь для тюнинга",});
            list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=10,Theme=t1,Title="Куплю авто на разбор",});
			list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=11,Theme=t1,Title="Продам авто на разбор",});
			list.Add(new TenderTheme(){ImageName="1.png",IsTitle=true,NomberInList=12,Theme=t1,Title="Ремонт, поиск специалиста:",});
			list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=13,Theme=t1,Title="Мне нужен ремонт кузова (покраска, вмятины, после дтп)",});
            list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=14,Theme=t1,Title="Мне нужен ремонт бензинового двигателя",});
			list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=15,Theme=t1,Title="Мне нужен ремонт дизельного двигателя",});
			list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=16,Theme=t1,Title="Мне нужен ремонт топливной аппаратуры",});
            list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=17,Theme=t1,Title="Мне нужен ремонт автоэлектрики",});
            list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=18,Theme=t1,Title="Мне нужен ремонт КПП, АКПП",});
            list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=19,Theme=t1,Title="Мне нужен ремонт ходовой",});
            list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=20,Theme=t1,Title="Мне нужен ремонт салона/шумоизоляция",});
			list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=21,Theme=t1,Title="Мне нужен пошив автокресел, перетяжка руля, потолок"});
            list.Add(new TenderTheme(){ImageName="1.png",IsTitle=true,NomberInList=22,Theme=t1,Title="Тюнинг:",});
			list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=23,Theme=t1,Title="Мне нужен тюнинг кузова",});
			list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=24,Theme=t1,Title="Мне нужен тюнинг двс/кпп/ходовой",});
			list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=25,Theme=t1,Title="Мне нужен OFF-ROAD тюнинг"});
            list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=26,Theme=t1,Title="Мне нужно восстановить авто после дтп"});
			list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=27,Theme=t1,Title="Мне нужно поставить дополнительное оборудование"});
			list.Add(new TenderTheme(){ImageName="1.png",IsTitle=true,NomberInList=28,Theme=t1,Title="Аренда:",});
            list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=29,Theme=t1,Title="Мне нужен автомобиль посуточно",});
            list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=30,Theme=t1,Title="Мне нужен автомобиль с водителем",});
			list.Add(new TenderTheme(){ImageName="1.png",IsTitle=true,NomberInList=31,Theme=t1,Title="Перегон авто:",});
			list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=32,Theme=t1,Title="Мне нужно перегнать авто из пункта \"а\" в пункт \"б\" по доверенности"});
			list.Add(new TenderTheme(){ImageName="1.png",IsTitle=false,NomberInList=33,Theme=t1,Title="Торги на свободные категории услуг по данной теме",});
			list.Add(new TenderTheme(){ImageName="1.png",IsTitle=true,NomberInList=34,Theme=t1,Title="Список будет дополняться по просьбам зарегистрированных пользователей"});
			  
var t2 = "Автоперевозки, водители, помощь при переезде";  
			 
			list.Add(new TenderTheme(){ImageName="2.png",IsTitle=true,NomberInList=1,Theme=t2,Title="Грузовые автоперевозки:",});
            list.Add(new TenderTheme(){ImageName="2.png",IsTitle=false,NomberInList=2,Theme=t2,Title="Мне нужно перевести груз до 3.5 тонн",});
			list.Add(new TenderTheme(){ImageName="2.png",IsTitle=false,NomberInList=3,Theme=t2,Title="Мне нужно перевести груз от 3.5 до 7 тонн",});
            list.Add(new TenderTheme(){ImageName="2.png",IsTitle=false,NomberInList=4,Theme=t2,Title="Мне нужно перевести груз от 7 до 12 тонн и выше",});
			list.Add(new TenderTheme(){ImageName="2.png",IsTitle=false,NomberInList=5,Theme=t2,Title="Мне нужно перевести груз от 12 тонн и выше",});
			list.Add(new TenderTheme(){ImageName="2.png",IsTitle=true,NomberInList=6,Theme=t2,Title="Пассажирские автоперевозки:",});
            list.Add(new TenderTheme(){ImageName="2.png",IsTitle=false,NomberInList=7,Theme=t2,Title="Мне нужно перевести до 20 человек",});
            list.Add(new TenderTheme(){ImageName="2.png",IsTitle=false,NomberInList=8,Theme=t2,Title="Мне нужно перевести от 20 человек и выше",});
			list.Add(new TenderTheme(){ImageName="2.png",IsTitle=true,NomberInList=9,Theme=t2,Title="Водители с л/а, инструктора:",});
            list.Add(new TenderTheme(){ImageName="2.png",IsTitle=false,NomberInList=10,Theme=t2,Title="Ищу водителя с личным автомобилем",});
            list.Add(new TenderTheme(){ImageName="2.png",IsTitle=false,NomberInList=11,Theme=t2,Title="Ищу инструктора по вождению автомобиля"});
			list.Add(new TenderTheme(){ImageName="2.png",IsTitle=true,NomberInList=12,Theme=t2,Title="Помощь при переезде:",});
			list.Add(new TenderTheme(){ImageName="2.png",IsTitle=false,NomberInList=13,Theme=t2,Title="Ищу автомобиль для переезда",});
			list.Add(new TenderTheme(){ImageName="2.png",IsTitle=false,NomberInList=14,Theme=t2,Title="Ищу автомобиль и грузчиков для переезда",});
			list.Add(new TenderTheme(){ImageName="2.png",IsTitle=false,NomberInList=15,Theme=t2,Title="Торги на свободные категории услуг по данной теме",});
			list.Add(new TenderTheme(){ImageName="2.png",IsTitle=true,NomberInList=16,Theme=t2,Title="Список будет дополняться по просьбам зарегистрированных пользователей ",});

var t3 = "Недвижимость: подбор вариантов, аренда";
 			list.Add(new TenderTheme(){ImageName="3.png",IsTitle=true,NomberInList=1,Theme=t3,Title="Риэлторские услуги:",});
	        list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=2,Theme=t3,Title="Мне нужен риэлтор (подбор/сопровождение)",});			  
 			list.Add(new TenderTheme(){ImageName="3.png",IsTitle=true,NomberInList=3,Theme=t3,Title="Жилая недвижимость:",});
     	    list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=4,Theme=t3,Title="Я хочу снять квартиру/комнату на несколько месяцев",});
            list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=5,Theme=t3,Title="Я хочу снять квартиру на несколько часов, суток"});
			list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=6,Theme=t3,Title="Я хочу подобрать варианты квартиры с целью покупки"});
            list.Add(new TenderTheme(){ImageName="3.png",IsTitle=true,NomberInList=7,Theme=t3,Title="Коттеджи/дома/дачи:",});
			list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=8,Theme=t3,Title="Я хочу подобрать дом/коттедж/дачу с целью покупки",});
            list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=9,Theme=t3,Title="Я хочу арендовать коттедж/дом/дачу посуточно",});
            list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=10,Theme=t3,Title="Я хочу купить земельный участок",});
            list.Add(new TenderTheme(){ImageName="3.png",IsTitle=true,NomberInList=11,Theme=t3,Title="Коммерческая недвижимость/земля:",});
            list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=12,Theme=t3,Title="Мне нужно взять в аренду/купить офисное помещение",});
            list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=13,Theme=t3,Title="Мне нужно взять в аренду коммерческую недвижимость",});
            list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=14,Theme=t3,Title="Мне нужно купить коммерческую недвижимость",});
            list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=15,Theme=t3,Title="Мне нужно взять в аренду/купить земельный участок (под любые цели)",});
			list.Add(new TenderTheme(){ImageName="3.png",IsTitle=false,NomberInList=16,Theme=t3,Title="Торги на свободные категории услуг по данной теме",});
			list.Add(new TenderTheme(){ImageName="3.png",IsTitle=true,NomberInList=17,Theme=t3,Title="Список будет дополняться по просьбам зарегистрированных пользователей",}); 

var t4 = "Поиск юриста/адвоката";
           
		    list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=1,Theme=t4,Title="Мне требуется комплексное юридическое сопровождение",});
            list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=2,Theme=t4,Title="Мне требуется юрист/адвокат по гражданским делам",});
            list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=3,Theme=t4,Title="Мне требуется юрист/адвокат по уголовным делам",});
            list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=4,Theme=t4,Title="Мне требуется юрист/адвокат по административным делам",});
            list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=5,Theme=t4,Title="Мне требуется юрист/адвокат по трудовым спорам",});
			list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=6,Theme=t4,Title="Мне требуется юрист/адвокат по антимонопольному законодательству",});
			list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=7,Theme=t4,Title="Мне требуется юрист/адвокат по налоговым спорам",});
			list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=8,Theme=t4,Title="Мне требуется юрист/адвокат по правам интелектуальной собственности ",});
            list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=9,Theme=t4,Title="Мне требуется юрист/адвокат по корпоративным спорам"});
            list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=10,Theme=t4,Title="Мне требуется юрист/адвокат по земельному праву",});
			list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=11,Theme=t4,Title="Мне требуется юрист/адвокат по административным делам",});
            list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=12,Theme=t4,Title="Мне требуется юрист/адвокат по вопросам автотранспорта и ситуаций на дороге",});
			list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=13,Theme=t4,Title="Мне требуется юрист/адвокат по правам интеллектуальной собственности",});
			list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=14,Theme=t4,Title="Мне требуется юрист/адвокат по семейному праву ",});
			list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=15,Theme=t4,Title="Мне требуется юрист/адвокат по наследственным спорам",});
			list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=16,Theme=t4,Title="Мне требуется юрист/адвокат по спорам с банками/коллекторскими агенствами, долговым обязательствам",});
			list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=17,Theme=t4,Title="Мне требуется юрист/адвокат по страховым спорам и выплатам",});
			list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=18,Theme=t4,Title="Мне требуется юрист/адвокат по правам социального обеспечения",});
			list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=19,Theme=t4,Title="Мне требуется юрист/адвокат по жилищному праву",});
			list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=20,Theme=t4,Title="Мне требуется юрист/адвокат по муниципальному праву ",});
			list.Add(new TenderTheme(){ImageName="4.png",IsTitle=false,NomberInList=21,Theme=t4,Title="Мне требуется юрист/адвокат по предпринимательскому праву",});
			list.Add(new TenderTheme(){ImageName="4.png",IsTitle=true,NomberInList=22,Theme=t4,Title="Список будет дополняться по просьбам зарегистрированных пользователей",}); 
			 
var t5 = "Услуги для бизнеса";
	
	        list.Add(new TenderTheme(){ImageName="5.png",IsTitle=true,NomberInList=1,Theme=t5,Title="Бухгалтерские/аудиторские услуги:",});
	        list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=2,Theme=t5,Title="Мне требуется ведение бухгалтерского учета (ведение юр.лиц)",});
			list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=3,Theme=t5,Title="Мне требуются аудиторские услуги",});
	        list.Add(new TenderTheme(){ImageName="5.png",IsTitle=true,NomberInList=4,Theme=t5,Title="Открытие/ликвидация фирм:",});
            list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=5,Theme=t5,Title="Мне требуется открыть ИП, ООО",});
			list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=6,Theme=t5,Title="Мне требуется закрыть ИП, ООО",});	
	        list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=7,Theme=t5,Title="Мне требуется открыть ИП, ООО",});
			list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=8,Theme=t5,Title="Мне требуется закрыть ИП, ООО",});
	        list.Add(new TenderTheme(){ImageName="5.png",IsTitle=true,NomberInList=9,Theme=t5,Title="Оборудование, технологии, it:",});
			list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=10,Theme=t5,Title="Мне нужно купить оборудование для бизнеса (все направления)",});
			list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=11,Theme=t5,Title="Мне нужно арендовать оборудование для бизнеса (все направления)",});
			list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=12,Theme=t5,Title="Мне нужны интернет/it-техника/системы конференции и т.д.",});
			list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=13,Theme=t5,Title="Моей компании требуется сайт",});
			list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=14,Theme=t5,Title="Хочу купить франшизу",});
			list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=15,Theme=t5,Title="Мне нужен программист/системный администратор/1C",});
			list.Add(new TenderTheme(){ImageName="5.png",IsTitle=true,NomberInList=16,Theme=t5,Title="Организация мероприятий/event-услуги:",});
			list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=17,Theme=t5,Title="Мне нужна организация встреч/презентаций/конференций",});
			list.Add(new TenderTheme(){ImageName="5.png",IsTitle=true,NomberInList=18,Theme=t5,Title="Пошив и изготовление одежды:",});
			list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=19,Theme=t5,Title="Мне требуется изготовление спец.одежды"});
	        list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=20,Theme=t5,Title="Мне требуется изготовление спортивной формы/одежды"});
			list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=21,Theme=t5,Title="Мне требуется закупка/пошив постельного белья (оптом)",});
			list.Add(new TenderTheme(){ImageName="5.png",IsTitle=true,NomberInList=22,Theme=t5,Title="PR/реклама/маркетинг/продвижение:",});
			list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=23,Theme=t5,Title="Мне требуются услуги полиграфии/печати/рекламная продукция",});
			list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=24,Theme=t5,Title="Мне нужно разработать фирменный стиль/бренд-бук",});
            list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=25,Theme=t5,Title="Мне нужна реклама (тв, интернет, пресса, промо-акции",});
			list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=26,Theme=t5,Title="Мне требуется антикризисный менеджмент",});
			list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=27,Theme=t5,Title="Мне нужны маркетинговые/социологические исследования",});
			list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=28,Theme=t5,Title="Мне нужна PR/рекламная-кампания",});
			list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=29,Theme=t5,Title="Мне нужен копирайтер",});
			list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=30,Theme=t5,Title="Мне нужен имиджмейкер",});
			list.Add(new TenderTheme(){ImageName="5.png",IsTitle=true,NomberInList=31,Theme=t5,Title="Охрана Вас и вашего бизнеса:",});
            list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=32,Theme=t5,Title="Мне нужны услуги охранного предприятия/телохранитель",});
            list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=33,Theme=t5,Title="Мне нужны системы видеонаблюдения/охранные, противопожарные системы",});
			list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=34,Theme=t5,Title="Мне нужен специалист по информационной безопасности",});
            list.Add(new TenderTheme(){ImageName="5.png",IsTitle=true,NomberInList=35,Theme=t5,Title="Разное:",});
			list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=36,Theme=t5,Title="Клининговые услуги",});
			list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=37,Theme=t5,Title="Аутсортинговые услуги",});		
	        list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=38,Theme=t5,Title="Мне требуется эксперт/оценщик",});
	        list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=39,Theme=t5,Title="Мне требуется переводчик (перевод литературы, сопровождение деловых встреч)",});
			list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=40,Theme=t5,Title="Мне нужна упаковка для моей продукции",});
            list.Add(new TenderTheme(){ImageName="5.png",IsTitle=false,NomberInList=41,Theme=t5,Title="Торги на свободные категории услуг по данной теме",});
			list.Add(new TenderTheme(){ImageName="5.png",IsTitle=true,NomberInList=42,Theme=t5,Title="Список будет дополняться по просьбам зарегистрированных пользователей",});
			  
var t6 = "Все для праздника, корпоратива, свадьбы";  
			
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=true,NomberInList=1,Theme=t6,Title="Организация события:"});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=2,Theme=t6,Title="Мне требуется организация события «под ключ»",}); 
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=3,Theme=t6,Title="Мне требуется составление сценария мероприятия",});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=4,Theme=t6,Title="Мне требуется организатор/свадебный распорядитель",});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=5,Theme=t6,Title="Мне требуется выездная регистрация",});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=true,NomberInList=6,Theme=t6,Title="Дизайн/оформление мероприятия:",});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=7,Theme=t6,Title="Мне требуется флорист/оформление живыми цветами/букет невесты",});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=8,Theme=t6,Title="Мне требуется стилистическое оформление места проведения торжества",});						 
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=9,Theme=t6,Title="Мне требуется оформление шарами",});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=10,Theme=t6,Title="Мне нужны пригласительные, полиграфические атрибуты мероприятия",});						 
		    list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=11,Theme=t6,Title="Мне нужны декоратичные элементы мероприятия",});	
            list.Add(new TenderTheme(){ImageName="6.png",IsTitle=true,NomberInList=12,Theme=t6,Title="Место проведения торжества/мероприятия:",});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=13,Theme=t6,Title="Мне требуется кафе/ресторан/банкетный зал до 40 человек"});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=14,Theme=t6,Title="Мне требуется кафе/ресторан/банкетный зал от 40 человек и больше"});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=15,Theme=t6,Title="Мне требуется коттедж/загородный дом"});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=16,Theme=t6,Title="Мне требуется теплоход"});
            list.Add(new TenderTheme(){ImageName="6.png",IsTitle=true,NomberInList=17,Theme=t6,Title="Образ на праздник:",});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=18,Theme=t6,Title="Мне требуется пошив платья для невесты",});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=19,Theme=t6,Title="Мне требуется визажист/парикмахер/маникюр и педикюр",});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=20,Theme=t6,Title="Мне требуется карнавальный костюм",});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=21,Theme=t6,Title="Мне требуется смокинг/вечернее платье",});			 
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=22,Theme=t6,Title="Мне нужны атрибуты для костюмированной вечеринки",});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=true,NomberInList=23,Theme=t6,Title="Транспорт:",}); 		
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=24,Theme=t6,Title="Мне требуется автомобиль/лимузин"});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=25,Theme=t6,Title="Мне требуется конный экипаж"});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=26,Theme=t6,Title="Мне требуется автобус/микроавтобус"});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=true,NomberInList=27,Theme=t6,Title="Кейтеринг/Выездное питание/обслуживание:",});
            list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=28,Theme=t6,Title="Мне нужен повар с выездом к заказчику",});
            list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=29,Theme=t6,Title="Мне нужен официант с выездом к заказчику",});
            list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=30,Theme=t6,Title="Мне нужна команда поваров и официантов со своим оборудованием",});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=true,NomberInList=31,Theme=t6,Title="Развлекательная часть:"});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=32,Theme=t6,Title="Мне требуется ведущий, тамада",});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=33,Theme=t6,Title="Мне требуется фотограф",});
            list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=34,Theme=t6,Title="Мне требуется видеооператор",});
		    list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=35,Theme=t6,Title="Мне требуется dj/звукооператор/звуковая аппаратура",});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=true,NomberInList=36,Theme=t6,Title="Музыканты:",});
            list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=37,Theme=t6,Title="Мне требуется кавер-группа",});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=38,Theme=t6,Title="Мне требуется живой вокал (под минус)",});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=39,Theme=t6,Title="Мне требуется баянист/аккордеонист/гармонист",});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=40,Theme=t6,Title="Мне требуется скрипач/альтист/дуэт/трио/квартет/live/минус"});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=41,Theme=t6,Title="Мне требуется саксафонист/флейтист (live/минус)"});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=42,Theme=t6,Title="Мне требуется гитарист (live/ минус)"});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=43,Theme=t6,Title="Мне требуется пианист(live/дуэтом/минус)"});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=44,Theme=t6,Title="Мне требуется народный хор/ансамбль",});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=45,Theme=t6,Title="Мне требуется цыганский ансамбль",});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=46,Theme=t6,Title="Мне требуется ансамбль/оркестр",});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=true,NomberInList=47,Theme=t6,Title="Артисты, шоу:",});
            list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=48,Theme=t6,Title="Мне требуется фокусник, иллюзионист",});
            list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=49,Theme=t6,Title="Мне требуется актер-аниматор",});
            list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=50,Theme=t6,Title="Мне требуется шоу-балет",});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=51,Theme=t6,Title="Мне требуется классический балет",});
            list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=52,Theme=t6,Title="Мне требуется артист светового/лазерного/fire-шоу",});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=53,Theme=t6,Title="Мне требуется шоу мыльных пузырей",}); 
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=54,Theme=t6,Title="Мне требуется интерактивое шоу",});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=55,Theme=t6,Title="Мне требуется бармен шоу",});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=56,Theme=t6,Title="Мне требуется артист(ка) стриптиза",});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=57,Theme=t6,Title="Мне требуется Дед Мороз, Снегурочка на дом/в офис/на корпоратив",});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=false,NomberInList=58,Theme=t6,Title="Торги на свободные категории услуг по данной теме",});
			list.Add(new TenderTheme(){ImageName="6.png",IsTitle=true,NomberInList=59,Theme=t6,Title="Список будет дополняться по просьбам зарегистрированных пользователей",});
			 
var t7 = "Услуги дизайнеров, архитекторов, скульпторов, художников";
            
			list.Add(new TenderTheme(){ImageName="7.png",IsTitle=true,NomberInList=1,Theme=t7,Title="Дизайнеры:",});
   		    list.Add(new TenderTheme(){ImageName="7.png",IsTitle=false,NomberInList=2,Theme=t7,Title="Мне требуется дизайнер-одежды (одежда, форма, спец.одежда)",});
	        list.Add(new TenderTheme(){ImageName="7.png",IsTitle=false,NomberInList=3,Theme=t7,Title="Мне требуется дизайнер-декоратор",});
            list.Add(new TenderTheme(){ImageName="7png",IsTitle=false,NomberInList=4,Theme=t7,Title="Мне требуется дизайнер-визуализатор",});
	        list.Add(new TenderTheme(){ImageName="7.png",IsTitle=false,NomberInList=5,Theme=t7,Title="Мне требуется дизайнер-имиджмейкер",});
			list.Add(new TenderTheme(){ImageName="7.png",IsTitle=false,NomberInList=6,Theme=t7,Title="Мне требуется дизайнер-цветокорректор",});
			list.Add(new TenderTheme(){ImageName="7.png",IsTitle=false,NomberInList=7,Theme=t7,Title="Мне требуется фитодизайнер (дизайнер – флорист)",});
			list.Add(new TenderTheme(){ImageName="7.png",IsTitle=false,NomberInList=8,Theme=t7,Title="Мне требуется дизайнер-макетчик",});
			list.Add(new TenderTheme(){ImageName="7.png",IsTitle=false,NomberInList=9,Theme=t7,Title="Мне требуется графический (полиграфический) дизайнер",});
			list.Add(new TenderTheme(){ImageName="7.png",IsTitle=false,NomberInList=10,Theme=t7,Title="Мне требуется дизайнер интерьеров",});
			list.Add(new TenderTheme(){ImageName="7.png",IsTitle=false,NomberInList=11,Theme=t7,Title="Мне требуется web-дизайнер",});
			list.Add(new TenderTheme(){ImageName="7.png",IsTitle=false,NomberInList=12,Theme=t7,Title="Мне требуется дизайнер по ландшафту",});
            list.Add(new TenderTheme() { ImageName = "7.png", IsTitle = false, NomberInList = 13, Theme = t7, Title = "Мне требуется дизайнер по фэншуй", });
		    list.Add(new TenderTheme(){ImageName="7.png",IsTitle=true,NomberInList=14,Theme=t7,Title="Художники:",});
			list.Add(new TenderTheme(){ImageName="7.png",IsTitle=false,NomberInList=15,Theme=t7,Title="Мне требуется художник (портрет, натюрморт и.т.д ",});
			list.Add(new TenderTheme(){ImageName="7.png",IsTitle=false,NomberInList=16,Theme=t7,Title="Мне требуется художник-иллюстратор, мультипликатор",});
			list.Add(new TenderTheme(){ImageName="7.png",IsTitle=false,NomberInList=17,Theme=t7,Title="Мне требуется художник-оформитель, роспись стен и.т.д",});
			list.Add(new TenderTheme(){ImageName="7.png",IsTitle=false,NomberInList=18,Theme=t7,Title="Мне требуется иллюстратор, мультипликатор",});
			list.Add(new TenderTheme(){ImageName="7.png",IsTitle=true,NomberInList=19,Theme=t7,Title="",});
			list.Add(new TenderTheme(){ImageName="7.png",IsTitle=false,NomberInList=20,Theme=t7,Title="Мне требуется архитектор",});
			list.Add(new TenderTheme(){ImageName="7.png",IsTitle=false,NomberInList=21,Theme=t7,Title="Мне требуется скульптор",});

var t8 = "Собираюсь в турне/в командировку/на Черное море/экскурсии для тур. групп";

            list.Add(new TenderTheme(){ImageName="8.png",IsTitle=true,NomberInList=1,Theme=t8,Title="Поиск/подбор туров:",});
            list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=2,Theme=t8,Title="Мне нужно подобрать тур за границу (город исполнения = город, где вы покупаете путевку)",});
            list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=3,Theme=t8,Title="Мне нужно найти и подобрать речной, морского круиза",});
            list.Add(new TenderTheme(){ImageName="8.png",IsTitle=true,NomberInList=4,Theme=t8,Title="Еду в командировку, ищу где остановиться:",});
            list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=5,Theme=t8,Title="Мне требуется номер в отеле",});
            list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=6,Theme=t8,Title="Мне требуется номер в гостинице",});
            list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=7,Theme=t8,Title="Мне нужно место в хостеле",});
		    list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=8,Theme=t8,Title="Мне нужна квартира посуточно",});
            list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=9,Theme=t8,Title="Мне нужна квартира, комната в другом городе",});
            list.Add(new TenderTheme(){ImageName="8.png",IsTitle=true,NomberInList=10,Theme=t8,Title="Еду отдыхать на Черноморское побережье:"});
            list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=11,Theme=t8,Title="Мне требуется комната в частном доме",});
            list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=12,Theme=t8,Title="Мне требуется номер в мини-гостинице, отеле",});
		    list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=13,Theme=t8,Title="Мне требуется квартира посуточно",});
		    list.Add(new TenderTheme(){ImageName="8.png",IsTitle=true,NomberInList=14,Theme=t8,Title="",});
		    list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=15,Theme=t8,Title="Мне требуется прием/размещение/экскурсия для тур.группы.",});
		    list.Add(new TenderTheme(){ImageName="8.png",IsTitle=false,NomberInList=16,Theme=t8,Title="Торги на свободные категории услуг по данной теме",});
		    list.Add(new TenderTheme(){ImageName="8.png",IsTitle=true,NomberInList=17,Theme=t8,Title="Список будет дополняться по просьбам зарегистрированных пользователей",}); 
			 
			 
var t9 = "Выездное, заказное питание/поставщики продуктов питания";

 
            list.Add(new TenderTheme(){ImageName="9.png",IsTitle=true,NomberInList=1,Theme=t9,Title="Кейтеринг/Выездное питание/обслуживание:",});
            list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=2,Theme=t9,Title="Мне нужен повар с выездом к заказчику",});
            list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=3,Theme=t9,Title="Мне нужен официант с выездом к заказчику",});
            list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=4,Theme=t9,Title="Мне нужна команда поваров и официантов со своим оборудованием",});
		    list.Add(new TenderTheme(){ImageName="9.png",IsTitle=true,NomberInList=5,Theme=t9,Title="Заказное питание:",});
            list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=6,Theme=t9,Title="Питание сотрудников на работе (доставка обедов)",});
            list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=7,Theme=t9,Title="Питание приезжих туристических групп, спортивных команд, делегаций",});
            list.Add(new TenderTheme(){ImageName="9.png",IsTitle=true,NomberInList=8,Theme=t9,Title="Поиск поставщиков продуктов питания:",});
		    list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=9,Theme=t9,Title="Продукты питания «Бакалея»",});
		    list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=10,Theme=t9,Title="продукты питания «Гастрономия»",});
		    list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=11,Theme=t9,Title="Мясо/птица/яйцо",});
		    list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=12,Theme=t9,Title="Рыба",});
		    list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=13,Theme=t9,Title="Фрукты/овощи/грибы",});
		    list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=14,Theme=t9,Title="Молочные продукты",});
		    list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=15,Theme=t9,Title="Кондитерские изделия",});
		    list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=16,Theme=t9,Title="Замороженные полуфабрикаты ",});
		    list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=17,Theme=t9,Title="Безолкагольные напитки/соки/воды",});
		    list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=18,Theme=t9,Title="Чай/кофе",});
            list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=19,Theme=t9,Title="Кондитерские изделия, выпечка на заказ",});
			list.Add(new TenderTheme(){ImageName="9.png",IsTitle=false,NomberInList=20,Theme=t9,Title="Торги на свободные категории услуг по данной теме",});
		    list.Add(new TenderTheme(){ImageName="9.png",IsTitle=true,NomberInList=21,Theme=t9,Title="Список будет дополняться по просьбам зарегистрированных пользователей",}); 
			 
var t10 = "Строительство/монтаж/ремонт/стройматериалы/проектирование";
		   
            list.Add(new TenderTheme(){ImageName="10.png",IsTitle=true,NomberInList=1,Theme=t10,Title="Заказы на ремонт:",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=2,Theme=t10,Title="Мне нужно сделать ремонт в квартире",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=3,Theme=t10,Title="Мне нужно сделать ремонт в коммерческом помещении",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=4,Theme=t10,Title="Мне нужно сделать мелкий ремонт квартиры/офиса",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=5,Theme=t10,Title="Мне нужно сделать ремонт в ванной, кухне и т.д.",});			  			 
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=6,Theme=t10,Title="Мне нужно установить пластиковые окна",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=7,Theme=t10,Title="Мне нужно установить двери в комнатах",});
		    list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=8,Theme=t10,Title="Мне нужно установить входную дверь",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=9,Theme=t10,Title="Мне нужно остеклить балкон",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=10,Theme=t10,Title="Мне нужен монтаж потолков",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=11,Theme=t10,Title="Мне нужно сделать пол (выравнивание/стяжка)",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=12,Theme=t10,Title="Мне нужно сделать штукатурно-малярные работы",});			  			 
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=13,Theme=t10,Title="Мне нужно положить плитку",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=14,Theme=t10,Title="Мне нужен монтаж гипсокартона",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=15,Theme=t10,Title="Мне нужно уложить/отремонтировать паркет",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=16,Theme=t10,Title="Мне нужно уложить ламинат/ковролин/линолеум",});			  			 
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=true,NomberInList=17,Theme=t10,Title="Строительно-монтажные заказы:",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=18,Theme=t10,Title="Мне нужно построить дом/коттедж",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=19,Theme=t10,Title="Мне нужно построить быстровозводимый дом",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=20,Theme=t10,Title="Мне нужно построить сруб",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=21,Theme=t10,Title="Мне нужно построить баню/сауну",});			  			 
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=22,Theme=t10,Title="Мне нужно построить забор",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=23,Theme=t10,Title="Мне нужно пробурить скважину",});
		    list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=24,Theme=t10,Title="Мне нужна бригада каменщиков",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=25,Theme=t10,Title="Мне нужны кровельные работы",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=26,Theme=t10,Title="Мне нужно установить фундамент",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=27,Theme=t10,Title="Мне нужны ворота/рольставни/роллеты",});			  			 
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=28,Theme=t10,Title="Мне нужно изготовить лестницу",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=29,Theme=t10,Title="мне нужно построить печь/камин",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=30,Theme=t10,Title="Мне нужно построить бассейн",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=31,Theme=t10,Title="Мне нужно демонтировать дом",});	
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=32,Theme=t10,Title="Мне нужно изготовление/монтаж металлоконструкций",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=33,Theme=t10,Title="Прочие обьекты и технические задания",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=true,NomberInList=34,Theme=t10,Title="Инженерно-монтажные заказы:",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=36,Theme=t10,Title="Мне нужно установить сантехнику/трубы",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=37,Theme=t10,Title="Мне нужно установить отопление/водоснабжение",});			  			 
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=38,Theme=t10,Title="Мне нужен монтаж теплого пола",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=39,Theme=t10,Title="Мне нужны электро-монтажные работы",});
		    list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=40,Theme=t10,Title="Мне нужно установить кондиционер",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=41,Theme=t10,Title="Мне нужен монтаж вентиляции",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=42,Theme=t10,Title="Мне нужны услуги промышленного альпинизма",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=43,Theme=t10,Title="Прочие обьекты и задания",});	
            list.Add(new TenderTheme(){ImageName="10.png",IsTitle=true,NomberInList=44,Theme=t10,Title="Установка систем безопасности:",});			  
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=45,Theme=t10,Title="Мне нужна установка видеонаблюдения и охраны",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=46,Theme=t10,Title="Мне нужна установка сигнализации",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=47,Theme=t10,Title="Мне нужна установка пожарной сигнализации",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=48,Theme=t10,Title="",});	
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=47,Theme=t10,Title="Мне нужен аварийный  бензо/дизель-генератор (стационарно)",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=48,Theme=t10,Title="Прочие системы",});		
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=true,NomberInList=49,Theme=t10,Title="Поставка строительных материалов (мелкий опт):"});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=50,Theme=t10,Title="Мне нужны пеноблоки/кирпичи",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=51,Theme=t10,Title="Мне нужны строительные смеси",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=52,Theme=t10,Title="Мне нужна электрика (комплектующие)",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=53,Theme=t10,Title="Мне нужен металлопрокат",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=54,Theme=t10,Title="Мне нужны пиломатериалы",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=55,Theme=t10,Title="Мне нужны лаки/краски/грунтовки и т.д.",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=56,Theme=t10,Title="Мне нужны двери/окна",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=57,Theme=t10,Title="Мне нужен гипсокартон",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=58,Theme=t10,Title="Мне нужна кровля",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=59,Theme=t10,Title="Мне нужны напольные покрытия",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=60,Theme=t10,Title="Мне нужны сыпучие материалы",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=61,Theme=t10,Title="Мне нужны стройматериалы б/у",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=true,NomberInList=62,Theme=t10,Title="Заказы  на проектирование:"});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=63,Theme=t10,Title="Мне нужны услуги архитектора",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=64,Theme=t10,Title="Мне нужны услуги инженера",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=65,Theme=t10,Title="Мне нужны стройматериалы б/у",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=false,NomberInList=66,Theme=t10,Title="Торги на свободные категории услуг по данной теме",});
			list.Add(new TenderTheme(){ImageName="10.png",IsTitle=true,NomberInList=67,Theme=t10,Title="Список будет дополняться по просьбам зарегистрированных пользователей",}); 
			  
         
		 
var t11 = "Услуги для дома и офиса";
            
			list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=1,Theme=t11,Title="Услуга «МУЖ НА ЧАС», то, что не под силу дамам по хозяйству"});
            list.Add(new TenderTheme(){ImageName="11.png",IsTitle=true,NomberInList=2,Theme=t11,Title="Ремонт/установка бытовой техники:",});
            list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=3,Theme=t11,Title="Мне требуется мастер по ремонту холодильников",});
            list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=4,Theme=t11,Title="Мне требуется мастер по ремонту стиральных машин",});
            list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=5,Theme=t11,Title="Мне требуется мастер по ремонту теле-радио аппаратуры",});
            list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=6,Theme=t11,Title="Мне требуется мастер по ремонту СВЧ-печей",});
            list.Add(new TenderTheme(){ImageName="11.png",IsTitle=true,NomberInList=7,Theme=t11,Title="Жилищно-коммунальные услуги/ремонт:",});
	     	list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=8,Theme=t11,Title="Мне требуется мастер-сантехник",});
			list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=9,Theme=t11,Title="Мне требуется установка водяных счетчиков",});;
            list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=10,Theme=t11,Title="Мне требуется мастер-электрик",});
			list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=11,Theme=t11,Title="Мне требуется электро/газо-сварщик",});
	        list.Add(new TenderTheme(){ImageName="11.png",IsTitle=true,NomberInList=12,Theme=t11,Title="Компьютерная помощь, интернет, ТВ, гаджеты:",});
			list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=13,Theme=t11,Title="Мне нужны услуги подключения ТВ, интернет",});
		    list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=14,Theme=t11,Title="Мне требуется мастер по ремонту компьютерной техники ",});
			list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=15,Theme=t11,Title="Мне требуется мастер по ремонту планшетов/смартфонов",});
	        list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=16,Theme=t11,Title="Мне нужно заправить картридж в принтер",});
		    list.Add(new TenderTheme(){ImageName="11.png",IsTitle=true,NomberInList=17,Theme=t11,Title="Сборка/установка/ремонт мебели:",});
		    list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=18,Theme=t11,Title="Мне требуется мастер по ремонту/сбору мебели",});
			list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=19,Theme=t11,Title="Мне требуется реставрация ванны",});		   
		    list.Add(new TenderTheme(){ImageName="11.png",IsTitle=true,NomberInList=20,Theme=t11,Title="Разное:",});
			list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=21,Theme=t11,Title="Мне нужны грузчики",});
			list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=22,Theme=t11,Title="Мне требуется мастер по работе с металлом (станки)",});
			list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=23,Theme=t11,Title="Мне требуется мастер по работе с металлом (литье, худ.ковка)",});
            list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=24,Theme=t11,Title="Мне требуется мастер по дереву (изделия из дерева)",});
			list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=25,Theme=t11,Title="Мне нужно изготовить мебель на заказ",});
			list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=26,Theme=t11,Title="Мне требуется мастер по пошиву и ремонту одежды/меховых изделий",});
			list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=27,Theme=t11,Title="Мне требуется мастер по изготовлению/ремонту/настройке музыкальных инструментов",});
			list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=28,Theme=t11,Title="Мне требуется озеленение ланшафта",});
			list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=29,Theme=t11,Title="Мне требуется спил деревьев",});
			list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=30,Theme=t11,Title="Мне нужно избавиться от грызунов/насекомых",});
			list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=31,Theme=t11,Title="Мне нужны разнорабочие для работы в огороде/на даче",});
			list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=32,Theme=t11,Title="Мне нужен независимый эксперт/оценщик",});
            list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=33,Theme=t11,Title="Мне нужен дизайнер (все направления)",});
			list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=34,Theme=t11,Title="Мне нужны услуги Фото/видео-съемки",});
			list.Add(new TenderTheme(){ImageName="11.png",IsTitle=true,NomberInList=35,Theme=t11,Title="Социальная помощь:",});         
            list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=36,Theme=t11,Title="Мне нужны услуги няни, сопровождающей ребенка",});
			list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=37,Theme=t11,Title="Мне нужны услуги няни-педагога",});
            list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=38,Theme=t11,Title="Мне нужны услуги няни ребенку",});
			list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=39,Theme=t11,Title="Мне нужны услуги ухода за пожилыми/больными",});
            list.Add(new TenderTheme(){ImageName="11.png",IsTitle=true,NomberInList=40,Theme=t11,Title="Помощь по хозяйству:",}); 
            list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=41,Theme=t11,Title="Мне нужны услуги уборки (квартиры/офисы/коттеджи)",});
            list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=42,Theme=t11,Title="Мне нужны услуги повара на дому",});
            list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=43,Theme=t11,Title="Мне нужны услуги домработницы",});
			list.Add(new TenderTheme(){ImageName="11.png",IsTitle=false,NomberInList=44,Theme=t11,Title="Торги на свободные категории услуг по данной теме",});
			list.Add(new TenderTheme(){ImageName="11.png",IsTitle=true,NomberInList=45,Theme=t11,Title="Список будет дополняться по просьбам зарегистрированных пользователей",});
 
 		 
 var t12 = "Аренда, прокат";
			list.Add(new TenderTheme(){ImageName="12.png",IsTitle=true,NomberInList=1,Theme=t12,Title="Мне нужно арендовать:",});
            list.Add(new TenderTheme(){ImageName="12.png",IsTitle=false,NomberInList=2,Theme=t12,Title="Мне нужно арендовать автомобиль/автобус",});
			list.Add(new TenderTheme(){ImageName="12.png",IsTitle=false,NomberInList=3,Theme=t12,Title="Мне нужно арендовать мотоцикл/скутер",});
            list.Add(new TenderTheme(){ImageName="12.png",IsTitle=false,NomberInList=4,Theme=t12,Title="Мне нужно арендовать спецтехнику",});
			list.Add(new TenderTheme(){ImageName="12.png",IsTitle=false,NomberInList=5,Theme=t12,Title="Мне нужно арендовать лодку/гидроцикл/катер",});
			list.Add(new TenderTheme(){ImageName="12.png",IsTitle=false,NomberInList=6,Theme=t12,Title="Мне нужно арендовать яхту/теплоход",});
            list.Add(new TenderTheme(){ImageName="12.png",IsTitle=false,NomberInList=7,Theme=t12,Title="Мне нужно арендовать легкомоторный самолет",});
			list.Add(new TenderTheme(){ImageName="12.png",IsTitle=false,NomberInList=8,Theme=t12,Title="Мне нужно арендовать электростанцию (бензо/дизель-генератор)",});
			list.Add(new TenderTheme(){ImageName="12.png",IsTitle=false,NomberInList=9,Theme=t12,Title="Мне нужно арендовать установку для бурения скважин",});
			list.Add(new TenderTheme(){ImageName="12.png",IsTitle=false,NomberInList=10,Theme=t12,Title="Мне нужно арендовать компрессор",});
            list.Add(new TenderTheme(){ImageName="12.png",IsTitle=false,NomberInList=11,Theme=t12,Title="Мне нужно арендовать специнструмент",});
			list.Add(new TenderTheme(){ImageName="12.png",IsTitle=false,NomberInList=12,Theme=t12,Title="Мне нужно арендовать спецтехнику",});
			list.Add(new TenderTheme(){ImageName="12.png",IsTitle=false,NomberInList=13,Theme=t12,Title="Мне нужно арендовать строительные леса",});
			list.Add(new TenderTheme(){ImageName="12.png",IsTitle=false,NomberInList=14,Theme=t12,Title="Мне нужно арендовать оборудование для  бизнеса",});
			list.Add(new TenderTheme(){ImageName="12.png",IsTitle=false,NomberInList=15,Theme=t12,Title="Мне нужен бизнес в аренду",});
			list.Add(new TenderTheme(){ImageName="12.png",IsTitle=false,NomberInList=16,Theme=t12,Title="Мне нужно арендовать сцену для мероприятий",});
			list.Add(new TenderTheme(){ImageName="12.png",IsTitle=true,NomberInList=17,Theme=t12,Title="Мне нужно взять в прокат:",});
            list.Add(new TenderTheme(){ImageName="12.png",IsTitle=false,NomberInList=18,Theme=t12,Title="Мне нужно взять в прокат садебное/вечернее платье, смокинг и т.д.",});
            list.Add(new TenderTheme(){ImageName="12.png",IsTitle=false,NomberInList=19,Theme=t12,Title="Мне нужно взять в прокат карнавальные, исторические костюмы и т.д.",});
            list.Add(new TenderTheme(){ImageName="12.png",IsTitle=false,NomberInList=20,Theme=t12,Title="Мне нужно взять в прокат спортивный инвентарь",});
            list.Add(new TenderTheme(){ImageName="12.png",IsTitle=false,NomberInList=21,Theme=t12,Title="Мне нужно взять в прокат туристическое оборудование, инвентарь",});
            list.Add(new TenderTheme(){ImageName="12.png",IsTitle=false,NomberInList=22,Theme=t12,Title="Мне нужно взять в прокат звуковую, световую аппаратуру",});
            list.Add(new TenderTheme(){ImageName="12.png",IsTitle=false,NomberInList=23,Theme=t12,Title="Мне нужно взять в прокат фото/видеокамеру, студийное оборудование, арендовать студию"});
			list.Add(new TenderTheme(){ImageName="12.png",IsTitle=false,NomberInList=24,Theme=t12,Title="Торги на свободные категории услуг по данной теме",});
			list.Add(new TenderTheme(){ImageName="12.png",IsTitle=true,NomberInList=25,Theme=t12,Title="Список будет дополняться по просьбам зарегистрированных пользователей",});		

var t13 = "Мне требуется репититор/инструктор/тренер";

list.Add(new TenderTheme() { ImageName = "13.png", IsTitle = false, NomberInList = 1, Theme = t13, Title = "Мне требуется инструктор по вождению автомобиля", });
list.Add(new TenderTheme() { ImageName = "13.png", IsTitle = false, NomberInList = 2, Theme = t13, Title = "Мне требуется тренер (фитнес, бодибилдинг)", });
list.Add(new TenderTheme() { ImageName = "13.png", IsTitle = false, NomberInList = 3, Theme = t13, Title = "Мне требуется тренер по боевым искуствам (все направления)", });
list.Add(new TenderTheme() { ImageName = "13.png", IsTitle = true, NomberInList = 4, Theme = t13, Title = "Репетиторы (школа, вуз):", });
list.Add(new TenderTheme() { ImageName = "13.png", IsTitle = false, NomberInList = 5, Theme = t13, Title = "Мне требуется репетитор по математике, алгебре", });
list.Add(new TenderTheme() { ImageName = "13.png", IsTitle = false, NomberInList = 6, Theme = t13, Title = "Мне требуется репетитор по геометрии", });
list.Add(new TenderTheme() { ImageName = "13.png", IsTitle = false, NomberInList = 7, Theme = t13, Title = "Мне требуется репетитор по физике", });
list.Add(new TenderTheme() { ImageName = "13.png", IsTitle = false, NomberInList = 8, Theme = t13, Title = "Мне требуется репетитор по химии", });
list.Add(new TenderTheme() { ImageName = "13.png", IsTitle = false, NomberInList = 9, Theme = t13, Title = "Мне требуется репетитор по английскому языку", });
list.Add(new TenderTheme() { ImageName = "13.png", IsTitle = false, NomberInList = 10, Theme = t13, Title = "Мне требуется репетитор по французскому языку", });
list.Add(new TenderTheme() { ImageName = "13.png", IsTitle = false, NomberInList = 11, Theme = t13, Title = "Мне требуется репетитор по немецкому языку", });
list.Add(new TenderTheme() { ImageName = "13.png", IsTitle = false, NomberInList = 12, Theme = t13, Title = "Мне требуется репетитор по испанскому языку", });
list.Add(new TenderTheme() { ImageName = "13.png", IsTitle = false, NomberInList = 13, Theme = t13, Title = "Мне требуется репетитор по китайскому языку", });
list.Add(new TenderTheme() { ImageName = "13.png", IsTitle = false, NomberInList = 14, Theme = t13, Title = "Мне требуется репетитор по японскому языку", });
list.Add(new TenderTheme() { ImageName = "13.png", IsTitle = false, NomberInList = 15, Theme = t13, Title = "Мне требуется репетитор по другим языкам", });
list.Add(new TenderTheme() { ImageName = "13.png", IsTitle = false, NomberInList = 16, Theme = t13, Title = "Прочие консультации по разным дисциплинам" });
list.Add(new TenderTheme() { ImageName = "13.png", IsTitle = true, NomberInList = 17, Theme = t13, Title = "Репетиторы по музыке:" });
list.Add(new TenderTheme() { ImageName = "13.png", IsTitle = false, NomberInList = 18, Theme = t13, Title = "Мне требуется репетитор по фортепиано" });
list.Add(new TenderTheme() { ImageName = "13.png", IsTitle = false, NomberInList = 19, Theme = t13, Title = "Мне требуется репетитор по вокалу" });
list.Add(new TenderTheme() { ImageName = "13.png", IsTitle = false, NomberInList = 20, Theme = t13, Title = "Мне требуется репетитор по гитаре (электрогитаре)" });
list.Add(new TenderTheme() { ImageName = "13.png", IsTitle = false, NomberInList = 21, Theme = t13, Title = "Мне требуется репетитор по скрипке, виолончели" });
list.Add(new TenderTheme() { ImageName = "13.png", IsTitle = false, NomberInList = 22, Theme = t13, Title = "Мне требуется репетитор по ударным инструментам" });
list.Add(new TenderTheme() { ImageName = "13.png", IsTitle = false, NomberInList = 23, Theme = t13, Title = "Мне требуется репетитор по аккордеону, баяну" });
list.Add(new TenderTheme() { ImageName = "13.png", IsTitle = false, NomberInList = 24, Theme = t13, Title = "Обучение игры на электрогитаре (бас) - школа рок-музыки" });
list.Add(new TenderTheme() { ImageName = "13.png", IsTitle = false, NomberInList = 25, Theme = t13, Title = "Остальные инструменты" });
list.Add(new TenderTheme() { ImageName = "13.png", IsTitle = false, NomberInList = 26, Theme = t13, Title = "Торги на свободные категории услуг по данной теме", });
list.Add(new TenderTheme() { ImageName = "13.png", IsTitle = true, NomberInList = 27, Theme = t13, Title = "Список будет дополняться по просьбам зарегистрированных пользователей", });		
		  
		  
var t14 = "Красота и уход (требуется рекомендация специалистов)";
		
		    list.Add(new TenderTheme(){ImageName="14.png",IsTitle=true,NomberInList=1,Theme=t14,Title="Парикмахерские услуги:"});
			list.Add(new TenderTheme(){ImageName="14.png",IsTitle=false,NomberInList=2,Theme=t14,Title="Мне нужна стрижка/укладка/окраска волос",});
			list.Add(new TenderTheme(){ImageName="14.png",IsTitle=false,NomberInList=3,Theme=t14,Title="Мне требуется наращивание волос, косички, дреды, афрокосы",});
		    list.Add(new TenderTheme(){ImageName="14.png",IsTitle=true,NomberInList=4,Theme=t14,Title="Маникюр-педикюр:"});
			list.Add(new TenderTheme(){ImageName="14.png",IsTitle=false,NomberInList=5,Theme=t14,Title="Хочу выбрать мастера ногтевого сервиса (уход/наращивание)",});
		    list.Add(new TenderTheme(){ImageName="14.png",IsTitle=false,NomberInList=6,Theme=t14,Title="Хочу сделать педикюр/уход за ногами",});
			list.Add(new TenderTheme(){ImageName="14.png",IsTitle=true,NomberInList=7,Theme=t14,Title="Массаж:"});
			list.Add(new TenderTheme(){ImageName="14.png",IsTitle=false,NomberInList=8,Theme=t14,Title="Мне нужен оздоровительный массаж"});
			list.Add(new TenderTheme(){ImageName="14.png",IsTitle=false,NomberInList=9,Theme=t14,Title="Мне нужен SPA-массаж",});
		    list.Add(new TenderTheme(){ImageName="14.png",IsTitle=true,NomberInList=10,Theme=t14,Title="Уход за телом:"});
			list.Add(new TenderTheme(){ImageName="14.png",IsTitle=false,NomberInList=11,Theme=t14,Title="Хочу выбрать мастера по эпиляции",});
			list.Add(new TenderTheme(){ImageName="14.png",IsTitle=false,NomberInList=12,Theme=t14,Title="Мне требуется тату-мастер"});
		    list.Add(new TenderTheme(){ImageName="14.png",IsTitle=true,NomberInList=13,Theme=t14,Title="Уход за лицом/косметология:"});
			list.Add(new TenderTheme(){ImageName="14.png",IsTitle=false,NomberInList=14,Theme=t14,Title="Хочу выбрать визажиста",});
			list.Add(new TenderTheme(){ImageName="14.png",IsTitle=false,NomberInList=15,Theme=t14,Title="Мне нужен косметолог",});
			list.Add(new TenderTheme(){ImageName="14.png",IsTitle=false,NomberInList=16,Theme=t14,Title="Мне требуется наращивание ресниц",});				
			list.Add(new TenderTheme(){ImageName="14.png",IsTitle=false,NomberInList=17,Theme=t14,Title="Мне требуется татуаж губ/бровей"});
		    list.Add(new TenderTheme(){ImageName="14.png",IsTitle=true,NomberInList=18,Theme=t14,Title="Стиль/Образ:"});
			list.Add(new TenderTheme(){ImageName="14.png",IsTitle=false,NomberInList=19,Theme=t14,Title="Хочу создать новый стиль/образ",});
            list.Add(new TenderTheme(){ImageName="14.png",IsTitle=false,NomberInList=20,Theme=t14,Title="Мне нужен стилист/помощник по подбору одежды",});
			list.Add(new TenderTheme(){ImageName="14.png",IsTitle=false,NomberInList=21,Theme=t14,Title="Мне нужна помощь по подбору цветотипа",});
			list.Add(new TenderTheme(){ImageName="14.png",IsTitle=false,NomberInList=22,Theme=t14,Title="Торги на свободные категории услуг по данной теме",});
			list.Add(new TenderTheme(){ImageName="14.png",IsTitle=true,NomberInList=23,Theme=t14,Title="Список будет дополняться по просьбам зарегистрированных пользователей",});


     
		  

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












