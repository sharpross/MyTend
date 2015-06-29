namespace MyTend.Controllers
{
    using MyTend.Entites;
    using MyTend.Models;
    using MyTender.Core;
    using MyTender.Security;
    using System;
    using System.Web.Mvc;

    public class AccountController : BaseController
    {
        /// <summary>
        /// Профиль
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Profile()
        {
            var model = new ProfileModel(this.Auth.User);

            return View(model);
        }

        [HttpPost]
        public JsonResult UpdateProfile(ProfileModel model)
        {
            if (model != null)
            {
                model.UpdateProfile();
            }

            return JsonSuccess();
        }

        [HttpGet]
        public ActionResult Registration()
        {
            var model = new RegistrationModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult Registration(RegistrationModel model)
        {
            if (model.TryRegistry())
            {
                RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(string login, string password, bool? remembeMe)
        {
            if (!string.IsNullOrEmpty(login) &&
                !string.IsNullOrEmpty(password))
            {
                try
                {
                    this.Auth.Login(login, password);

                    return JsonSuccess();
                }
                catch (Exception e)
                {
                    return JsonFailur(Constants._UNKNOW_USER);
                }
            }

            return JsonFailur(Constants._UNKNOW_USER);
        }

        [HttpPost]
        public JsonResult Logout()
        {
            try
            {
                this.Auth.Logout();

                return Json(new
                {
                    Success = true,
                    Data = "null"
                });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}