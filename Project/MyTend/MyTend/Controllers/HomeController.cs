namespace MyTend.Controllers
{
    using MyTend.Models;
    using MyTender.Core;
    using MyTender.Security;
    using System.Web.Mvc;

    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var model = new ListThemeTenderModel();

            return View(model);
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Support()
        {
            var model = new SupportMessageModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult Support(SupportMessageModel model)
        {
            return RedirectToAction("Thanks");
        }

        public ActionResult Thanks()
        {
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }
    }
}