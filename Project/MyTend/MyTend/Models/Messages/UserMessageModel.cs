using MyTend.Entites;
using MyTend.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTend.Models
{
    public class UserMessageModel
    {
        private UserMessagesService Service { get; set; }

        private UserSystem User { get; set; }

        public List<UserMessagesListModel> Contacts { get; set; }

        public UserMessageModel(UserSystem user)
        {
            this.User = user;
            this.Service = new UserMessagesService(user);

            this.Contacts = new List<UserMessagesListModel>();
        }

        public void Load()
        {
            var contacts = this.Service.GetListUsersFromMessages();

            foreach (var contact in contacts)
            {
                var newUser = new UserMessagesListModel()
                {
                    User = contact,
                    Unreaded = this.Service.GetUnreaded(contact)
                };

                this.Contacts.Add(newUser);
            }
        }
    }
}
