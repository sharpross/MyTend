namespace MyTend.Services.EmailService
{
    using FluentEmail;
    using MyTend.Entites;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Mail;
    using System.Text;
    using System.Threading.Tasks;

    public class EmailService
    {
        private EmailTemplates Templates { get; set; }

        public EmailService()
        {
            this.Templates = new EmailTemplates();
        }

        public SmtpClient GetClient()
        {
            var smtpClient = new SmtpClient("smtp.yandex.ru", 587);
            smtpClient.Credentials = new NetworkCredential("rt.sharpross", "dbdfkmlb4");
            smtpClient.EnableSsl = true;

            return smtpClient;
        }

        public void Registration(string userName, string password, string email)
        {
            try
            {
                Email.From("rt.sharpross@yandex.ru")
                .To(userName)
                .Subject("Спасибо за регистрацию")
                .UsingCultureTemplateFromFile("~\\Content\\email\\registrationm.html", new { Login = userName, Password = password })
                .UsingClient(this.GetClient())
                .Send();
            }
            catch (Exception e)
            {
                var logRec = new Log()
                {
                    Context = "registration",
                    Level = MyTend.Entites.Enums.LogLevel.Info,
                    Message = e.Message,
                    Stack = e.StackTrace,
                    UserName = null
                };

                logRec.Save();
            }
        }

        public void Winner(string tenderId, string login, string tenderTitle)
        {
            try
            {
                Email.From("rt.sharpross@yandex.ru")
                .To(login)
                .Subject("Вы победитель торга")
                .UsingCultureTemplateFromFile("~\\Content\\email\\winner.html", new { TenderId = tenderId, Title = tenderTitle })
                .UsingClient(this.GetClient())
                .Send();
            }
            catch (Exception e)
            {
                var logRec = new Log()
                {
                    Context = "registration",
                    Level = MyTend.Entites.Enums.LogLevel.Info,
                    Message = e.Message,
                    Stack = e.StackTrace,
                    UserName = null
                };

                logRec.Save();
            }
        }

        public void CreateTender(string tenderId, string title)
        {
            try
            {
                Email.From("rt.sharpross@yandex.ru")
                .To("Mytend2016@gmail.com")
                .Subject("Создан торг")
                .UsingCultureTemplateFromFile("~\\Content\\email\\create.html", new { TenderId = tenderId, Title = title })
                .UsingClient(this.GetClient())
                .Send();
            }
            catch (Exception e)
            {
                var logRec = new Log()
                {
                    Context = "registration",
                    Level = MyTend.Entites.Enums.LogLevel.Info,
                    Message = e.Message,
                    Stack = e.StackTrace,
                    UserName = null
                };

                logRec.Save();
            }
        }
    }
}
