namespace MyTend.Controllers
{
    using MyTender.Core;
    using System.Web.Mvc;

    public class MessageController : BaseController
    {
        // GET: Message
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Write()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Write(int i)
        {
            return View();
        }
    }
}