using System;
using System.IO;
using System.Net;
using System.Text;
using MyTend.Entites;

namespace MyTend.Services.Common
{
    public class SmsMegafonSender
    {
        public void Send(string code, string phone, UserSystem user)
        {
            this.SendSms(code, phone, user);
        }
        
        private void SendSms(string code, string phone, UserSystem user)
        {
            CanSend(user);

            ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);
            
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes("VLG_ipromnv" + ":" + "BHYeoPuD");
            var loginPassword = System.Convert.ToBase64String(plainTextBytes);

            var request = WebRequest.Create("https://a2p-api.megalabs.ru/sms/v1/sms");
            request.Method = "POST";
            request.Headers.Add("Authorization", "Basic " + loginPassword);
            request.ContentType = "application/json;charset=utf-8";
            
            try
            {
                var message = "Code activacii: " + code;

                var a = new SmsMessage()
                {
                    from = "My-Tend.Com",
                    to = long.Parse(this.ParsePhone(phone)),
                    message = message
                };

                var b = Newtonsoft.Json.JsonConvert.SerializeObject(a);

                byte[] byteArray = Encoding.UTF8.GetBytes(b);

                request.ContentLength = byteArray.Length;

                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();

                WebResponse response = request.GetResponse();

                var responseReader = new StreamReader(response.GetResponseStream());
                var responseData = responseReader.ReadToEnd();

                var logRec = new Log()
                {
                    Context = "Sms Sender",
                    Level = MyTend.Entites.Enums.LogLevel.Error,
                    Message = responseData,
                    UserName = string.Empty
                };

                logRec.Save();
            }
            catch(Exception ex)
            {
                var logRec = new Log()
                {
                    Context = "Sms Sender",
                    Level = MyTend.Entites.Enums.LogLevel.Error,
                    Message = ex.Message,
                    Stack = ex.StackTrace,
                    UserName = string.Empty
                };

                logRec.Save();
            }
        }

        public static bool AcceptAllCertifications(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certification, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
        
        private void CanSend(UserSystem user)
        {
            var facts = SmsSendFact.FindAllByProperty("User", user);

            if (facts.Length > 3)
            {
                var message = string.Format("Превышен лимит отправки смс в сутки ({0} в сутки).", 3);

                throw new Exception(message);
            }

            var fact = new SmsSendFact()
            {
                User = user,
                SendDate = DateTime.Now
            };

            fact.Save();
        }
    
        private string ParsePhone(string phone)
        {
            var result = phone.Replace(" ", "").Replace("+7", "7").Replace("(", "").Replace(")", "");

            if (!result.StartsWith("7"))
            {
                result = "7" + result.Substring(1, result.Length);
            }

            return result;
        }

        public class SmsMessage
        {
            public string from { get; set; }

            public long to { get; set; }

            public string message { get; set; }
        }
    }
}
