using MyTend.Entites;
using MyTender.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTend.Models
{
    public class WriteMessageModel : UserMessage
    {
        public string ToUserLogin { get; set; }

        public List<UserMessage> Messages { get; set; }

        public int Unreaded { get; set; }

        private AuthService Auth { get; set; }

        public WriteMessageModel()
        {
            this.Auth = new AuthService();

            this.From = this.Auth.User;
            this.Messages = this.LoadMessages();
        }

        public WriteMessageModel(string login)
        {
            this.Auth = new AuthService();

            this.ToUserLogin = login;
            this.From = this.Auth.User;
            this.To = UserSystem
                .GetByProp("Login", login)
                .FirstOrDefault();
            this.Messages = this.LoadMessages();
        }

        public void GetUnreaded()
        {
            this.Unreaded = this.Messages
                .Where(x => x.IsRead == false)
                .Count();
        }

        public List<UserMessage> LoadMessages()
        {
            var msgs = UserMessage
                .FindAll()
                .Where(x => x.From.Id == this.Auth.User.Id || x.To.Id == this.Auth.User.Id)
                .OrderBy(x => x.Date)
                .ToList();

            return msgs;
        }

        public bool IsValid()
        {
            var msg = this.ToObj();

            if (msg.IsValid())
            {
                this.Errors = msg.Errors;

                return true;
            }

            return true;
        }

        public void Save()
        {
            var msg = this.ToObj();

            msg.Create();
        }

        public UserMessage ToObj()
        {
            var toUser = UserSystem.GetByProp("Login", this.ToUserLogin)
                .FirstOrDefault();

            var msg = new UserMessage() 
            { 
                Date = DateTime.Now,
                From = this.Auth.User,
                To = toUser,
                Message = this.Message
            };

            return msg;
        }
    }
}
