namespace MyTend.Controllers
{
    using MyTend.Models;
    using MyTender.Core;
    using MyTender.Security;
    using System.Web.Mvc;

    public class MessageController : BaseController
    {
        // GET: Message
        public ActionResult Index()
        {
            var model = new UserMessageModel(this.Auth.User);
            model.Load();

            return View(model);
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