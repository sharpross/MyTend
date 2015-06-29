namespace MyTend.Controllers
{
    using MyTender.Core;
    using MyTender.Security;
    using System.Web.Mvc;

    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}