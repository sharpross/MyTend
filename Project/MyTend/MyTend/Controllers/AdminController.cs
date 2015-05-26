namespace MyTend.Controllers
{
    using MyTender.Core;
    using System.Web.Mvc;

    public class AdminController : BaseController
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
    }
}