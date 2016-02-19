using MyTend.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace MyTend.Services.Migrations.User
{
    public class UserMigration : IMigration
    {

        public string Code
        {
            get { return "Миграция создания тестовых пользователей пользователей"; }
        }

        public void Migrate()
        {
            var city = City
                .FindAll()
                .FirstOrDefault(x => x.Id == 1);

            var region = city.Region;

            var admin = new UserSystem() 
            {
                FullName = "Admin",
                Login = "admin@admin.ru",
                Password = this.GetMD5String("testtest"),
                Email = "admin@test.ru",
                AboutShort = "admin user",
                Region = region,
                City = city
            };
            admin.Create();

            var user1 = new UserSystem()
            {
                FullName = "Модератор №1",
                Login = "moder1@user.ru",
                Password = this.GetMD5String("testtest"),
                Email = "moder1@test.ru",
                AboutShort = "user1",
                Region = region,
                City = city
            };
            user1.Create();

            var user2 = new UserSystem()
            {
                FullName = "Модератор №2",
                Login = "moder2@user.ru",
                Password = this.GetMD5String("testtest"),
                Email = "user2@test.ru",
                AboutShort = "user2",
                Region = region,
                City = city
            };
            user2.Create();

            var user3 = new UserSystem()
            {
                FullName = "Модератор №3",
                Login = "moder3@user.ru",
                Password = this.GetMD5String("testtest"),
                Email = "user3@test.ru",
                AboutShort = "user3",
                Region = region,
                City = city
            };
            user3.Create();

            var payInfo = new PayInfo()
            {
                PayDay = DateTime.Now,
                PayEnd = DateTime.Now.AddYears(100),
                Sum = 100,
                User = user1
            };
            payInfo.Save();

            var payInfo2 = new PayInfo()
            {
                PayDay = DateTime.Now,
                PayEnd = DateTime.Now.AddYears(100),
                Sum = 100,
                User = user1
            };
            payInfo2.Save();

            var payInfo3 = new PayInfo()
            {
                PayDay = DateTime.Now,
                PayEnd = DateTime.Now.AddYears(100),
                Sum = 100,
                User = admin
            };
            payInfo3.Save();
        }

        public bool NeedMigrate()
        {
            return true;
        }

        public string GetMD5String(string password)
        {
            var md5string = string.Empty;

            md5string = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "MD5");

            return md5string;
        }
    }
}
