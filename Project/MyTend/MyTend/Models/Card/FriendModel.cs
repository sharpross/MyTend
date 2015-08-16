using MyTend.Entites;
using MyTend.Entites.Contacts;
using MyTender.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTend.Models
{
    public class FriendModel
    {
        public List<string> Errors { get; set; }

        private AuthService Auth { get; set; }

        private string Login { get; set; }

        public FriendModel(string login)
        {
            this.Auth = new AuthService();
            this.Login = login;
        }

        public void Save()
        {
            var cotact = this.ToObj();

            cotact.Create();
        }

        public void Revome()
        {
            var contact = Contact
                .FindAll()
                .Where(x => x.User.Id == this.Auth.User.Id)
                .Where(x => x.Friend.Login == this.Login)
                .FirstOrDefault();

            if (contact != null)
            {
                contact.Delete();
            }
        }

        public bool IsValid()
        {
            var contact = this.ToObj();

            if (!contact.IsValid())
            {
                this.Errors = contact.Errors;

                return false;
            }

            if (!this.AdditionalValidation(contact))
            {
                return false;
            }

            return true;
        }

        private bool AdditionalValidation(Contact contact) 
        {
            var exist = Contact
                .FindAll()
                .Where(x => x.User.Id == contact.User.Id)
                .Where(x => x.Friend.Id == contact.Friend.Id)
                .ToList();

            if (exist.Count > 0)
            {
                this.Errors.Add(string.Format("Пользователь {0} уже у вас в контактах.", contact.Friend.Login));

                return false;
            }

            var self = Contact
                .FindAll()
                .Where(x => x.Friend.Id == contact.User.Id)
                .ToList();

            if (self.Count > 0)
            {
                this.Errors.Add("Недопустимая операция.");

                return false;
            }

            return true;
        }

        public Contact ToObj()
        {
            var user = this.Auth.User;
            var friend = UserSystem.GetByProp("Login", this.Login)
                .FirstOrDefault();

            return new Contact()
            {
                User = user,
                Friend = friend,
                CreatedDateTime = DateTime.Now
            };
        }
    }
}
