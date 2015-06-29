namespace MyTend.Controllers
{
    using MyTender.Core;
    using MyTender.Security;
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