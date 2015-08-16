using MyTend.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Password = "testtest",
                Email = "test@test.ru",
                AboutShort = "admin user",
                Region = region,
                City = city
            };
            admin.Create();

            var user1 = new UserSystem()
            {
                FullName = "User1",
                Login = "user1@user.ru",
                Password = "user1user1",
                Email = "user1@test.ru",
                AboutShort = "user1",
                Region = region,
                City = city
            };
            user1.Create();

            var user2 = new UserSystem()
            {
                FullName = "User2",
                Login = "user2@user.ru",
                Password = "user2user2",
                Email = "user2@test.ru",
                AboutShort = "user2",
                Region = region,
                City = city
            };
            user2.Create();

            var user3 = new UserSystem()
            {
                FullName = "User3",
                Login = "user3@user.ru",
                Password = "user3user3",
                Email = "user3@test.ru",
                AboutShort = "user3",
                Region = region,
                City = city
            };
            user3.Create();
        }

        public bool NeedMigrate()
        {
            return true;
        }
    }
}
