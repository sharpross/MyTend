namespace MyTend.Services
{
    using MyTend.Entites;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class UserMessagesService
    {
        private UserSystem User { get; set; }

        public UserMessagesService(UserSystem user)
        {
            this.User = user;
        }

        public List<UserSystem> GetListUsersFromMessages()
        {
            var users = new List<UserSystem>();

            var allMessages = UserMessage
                .FindAll()
                .Where(x => x.From.Id == this.User.Id || x.To.Id == this.User.Id)
                .ToList();

            var usersA = allMessages
                .Where(x => x.From.Id != this.User.Id)
                .GroupBy(x => x.From)
                .OrderBy(x => x.Key.FullName)
                .Select(x => x.Key);

            users.AddRange(usersA);

            return users;
        }

        public int GetUnreaded(UserSystem user)
        {
            var messages = UserMessage
                .FindAll()
                .Where(x => x.From.Id == user.Id)
                .Where(x => x.IsRead == false)
                .ToList();

            return messages.Count;
        }

        public int CountUnread()
        {
            var count = 0;

            var contacts = this.GetListUsersFromMessages();

            foreach (var contact in contacts)
            {
                count += this.GetUnreaded(contact);
            }

            return count;
        }
    }
}
