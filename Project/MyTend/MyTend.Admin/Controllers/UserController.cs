using MyTend.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyTend.Admin.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            var users = new List<UserSystem>();

            users.Add(new UserSystem() 
            {
                FullName = "Василий Викторович",
                Email = "vasya@yandex.ru",
                Login = "vasya@yandex.ru",
                AboutShort = "Торгую танками"
            });

            users.Add(new UserSystem()
            {
                FullName = "Дмитрий фёдорович",
                Email = "dima@yandex.ru",
                Login = "dima@yandex.ru",
                AboutShort = "Скупаю танки"
            });

            users.Add(new UserSystem()
            {
                FullName = "Николая Александрович",
                Email = "vasya@yandex.ru",
                Login = "vasya@yandex.ru",
                AboutShort = "Торгую танками"
            });

            users.Add(new UserSystem()
            {
                FullName = "Василий Викторович",
                Email = "vasya@yandex.ru",
                Login = "vasya@yandex.ru",
                AboutShort = "Торгую танками"
            });

            return View(users);
        }
    }
}