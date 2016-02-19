namespace MyTend.Services.EmailService
{
    using System.IO;

    /// <summary>
    /// Прикрепляемый файл к письму
    /// </summary>
    public class AttachFile
    {
        /// <summary>
        /// Имя файла
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Поток файла 
        /// </summary>
        public Stream Data { get; set; }
    }
}
