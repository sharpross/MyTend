namespace MyTend.Services.EmailService
{
    using System.Collections.Generic;

    /// <summary>
    /// Данные для отправки письма
    /// </summary>
    public class SendEmailData
    {
        /// <summary>
        /// Адрес от кого отправляем (Пример: email@email.ru)
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// Имя от кого отправляем (Пример: NickName)
        /// </summary>
        public string FromName { get; set; }

        /// <summary>
        /// Адрес кому отправляем (Пример: email@email.ru)
        /// </summary>
        public string To { get; set; }

        /// <summary>
        ///  Имя кому отправляем (Пример: NickName)
        /// </summary>
        public string ToName { get; set; }

        /// <summary>
        /// Тема сообщения
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Текст сообщения
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Пароль для отправки
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Прикреплячемые файлы
        /// </summary>
        public IList<AttachFile> Attachment { get; set; }

        public SendEmailData()
        {
            this.Attachment = new List<AttachFile>();
        }
    }
}
