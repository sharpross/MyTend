using MyTend.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTend.Models
{
    public class CardModel : UserSystem
    {
        public CardModel(string login)
        {
            this.Load(login);
        }

        private void Load(string login)
        {
            var user = UserSystem.FindAll()
                .FirstOrDefault(x => x.Login == login);

            if (user == null)
            {
                throw new Exception("Пользователь не найден");
            }

            this.AboutFull = user.AboutFull;
            this.AboutShort = user.AboutShort;
            this.City = user.City;
            this.CreatedDateTime = user.CreatedDateTime;
            this.Email = user.Email;
            this.Facebook = user.Facebook;
            this.FullName = user.FullName;
            this.Id = user.Id;
            this.Instagram = user.Instagram;
            this.Login = user.Login;
            this.Phone = user.Phone;
            this.Phone2 = user.Phone2;
            this.Portfolio = user.Portfolio;
            this.Region = user.Region;
            this.Site = user.Site;
            this.Skype = user.Skype;
            this.VKontakte = user.VKontakte;
        }
    }
}
