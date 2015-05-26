namespace MyTend.Controllers
{
    using MyTender.Core;
    using System.Web.Mvc;

    public class DocsController : BaseController
    {
        // GET: Docs
        public ActionResult Index()
        {
            return View();
        }
    }
}