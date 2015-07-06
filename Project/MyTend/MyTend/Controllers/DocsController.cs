namespace MyTend.Controllers
{
    using MyTender.Core;
    using MyTender.Security;
    using System.Web.Mvc;

    public class DocsController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}