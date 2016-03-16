namespace MyTend.Services.EmailService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EmailTemplates
    {
        public string Registration
        {
            get 
            {
                var template = new StringBuilder();

                template.Append("<!doctype html>");
                template.Append("<html>");
                template.AppendLine("<meta charset=\"utf-8\">");

                template.AppendLine("<title>Благодарим за регистрацию</title>");

                template.AppendLine("</head>");

                template.AppendLine("<img src=\"http://MY-TEND.COM/Content/images/logo.svg\" alt=\"My-tend.com\" width=\"40%\" height=\"106\" style=\"display:block; width:15%\"/>");
                template.AppendLine("<p style=\"margin-top:5px; font-size:12px; font-family: Arial; color:#4a2054\"><strong>Сайт,где исполнитель соревнуется за праздник заказчика</strong></p>");
                template.AppendLine("<div><strong>Здравствуйте @Model.Login!</strong></div>");
                template.AppendLine("<div>Мы рады сообщить, что Вы успешно зарегистрированы на сайте <strong> My-tend.com</strong></div>");
                template.AppendLine("<div>Ваш логин: <b>@Model.Login</b></div>");
                template.AppendLine("<div>Ваш пароль: <b>>@Model.Password</b></div>");
                template.AppendLine("<div>Вы имеете возможность, <a href=\"http://my-tend.com/Tender/Index\" target=\"_blank\">создавать заявки на нужные для Вас услуги</a>, в качестве покупателя. </div>");
                template.AppendLine("<div><strong>Если Вы желаете продавать услуги предложенные на сайте и получить доступ к заявкам </strong>:");
                template.AppendLine("<ol>");
                template.AppendLine("<li><strong>Заплните все вкладки визитки</strong>, рассказав о себе или своей услуге,  а так же загрузите до 20 фотографий в портфолио. </li>");
                template.AppendLine("<li><strong>Сделайте подписку</strong> на заявки от заказчиков, указав сферу оказываемых услуг. </li>");
                template.AppendLine("<li><strong>Укажите города</strong> в которых Вы  готовы оказывать усугу. </li>");
                template.AppendLine("<li><strong><strong>Оплатите 1000 рублей</strong> за право доступа к заявкам от покупателей. </li>");
                template.AppendLine("</ol>");
                template.AppendLine("</div>");

                template.AppendLine("<br>");
                template.AppendLine("<p style=\"margin-top:20px; font-size:12px; font-family: Arial; color:#202020\">С уважением к Вам,  команда сайта <strong>My-tend.com</strong></p>");
                template.AppendLine("</html>");

                return template.ToString();
            }
        }

        public string Winner
        {
            get
            {
                var template = new StringBuilder();

                template.Append("<!doctype html>");
                template.Append("<html>");
                template.AppendLine("<meta charset=\"utf-8\">");

                template.AppendLine("<title>Вы победили в торге</title>");

                template.AppendLine("</head>");

                template.AppendLine("<img src=\"http://MY-TEND.COM/Content/images/logo.svg\" alt=\"My-tend.com\" width=\"40%\" height=\"106\" style=\"display:block; width:15%\"/>");
                template.AppendLine("<p style=\"margin-top:5px; font-size:12px; font-family: Arial; color:#4a2054\"><strong>Сайт,где исполнитель соревнуется за праздник заказчика</strong></p>");
                template.AppendLine("<div><strong>Здравствуйте @Model.Login!</strong></div>");

                template.AppendLine("<div><div><strong>Поздравляем!!! </strong>)</div>");
                template.AppendLine("<div><strong>Поздравляем!!! Вы стали победителем торга на заявку:</strong> @Model.Link </div>");
                template.AppendLine("<div><strong>Свяжитесь с заказчиком по телефону из его визитки или дождитесь его звонка. </div>");

                template.AppendLine("<br>");
                template.AppendLine("<p style=\"margin-top:20px; font-size:12px; font-family: Arial; color:#202020\">С уважением к Вам,  команда сайта <strong>My-tend.com</strong></p>");
                template.AppendLine("</html>");

                return template.ToString();
            }
        }
    }
}
