namespace MyTend.Controllers
{
    using MyTender.Core;
    using System.Web.Mvc;

    public class ImageController : BaseController
    {
        // GET: Image
        public ActionResult Index()
        {
            return View();
        }
    }
}