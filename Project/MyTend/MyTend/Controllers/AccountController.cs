namespace MyTend.Controllers
{
    using MyTend.Entites;
    using MyTend.Models;
    using MyTender.Core;
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
    }
}