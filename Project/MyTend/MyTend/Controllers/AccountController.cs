namespace MyTend.Controllers
{
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
            return RedirectToAction("Profile");
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Profile()
        {
            var model = new ProfileModel(this.Auth.User);

            return View(model);
        }

        public ActionResult Card(string user)
        {
            var model = new CardModel(user);

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

        [HttpPost]
        public JsonResult UpdateAbout(ProfileModel model)
        {
            if (model != null)
            {
                model.UpdateProfile();
            }

            return JsonSuccess();
        }

        [HttpPost]
        public JsonResult UpdateSubRegions(SubRegionModel model)
        {
            model.Save(this.Auth.User);

            return JsonSuccess();
        }

        [HttpPost]
        public JsonResult UpdateAbout(string portfolio)
        {
            var model = new ProfileModel(this.Auth.User);

            model.UpdatePortfolio(portfolio);

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
                this.Auth.Login(model.Login, model.Password);

                RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Profile");
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(string login, string password)
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