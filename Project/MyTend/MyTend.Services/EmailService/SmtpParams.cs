namespace MyTend.Services.EmailService
{
    public class SmtpParams
    {
        public string Host { get; set; }

        public int Port { get; set; }

        public bool UseSsl { get; set; }
    }
}
