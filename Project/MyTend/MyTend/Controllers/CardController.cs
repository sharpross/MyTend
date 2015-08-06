namespace MyTend.Controllers
{
    using MyTend.Models;
    using MyTender.Security;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class CardController : BaseController
    {
        // GET: Card
        public ActionResult Index()
        {
            var model = new ListContactModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult Add(string login)
        {
            var model = new FriendModel(login);

            if (model.IsValid())
            {
                model.Save();

                return JsonSuccess();
            }

            return JsonFailur(model.Errors);
        }

        [HttpPost]
        public ActionResult Remove(string login)
        {
            var model = new FriendModel(login);

            if (model.IsValid())
            {
                model.Revome();

                return JsonSuccess();
            }

            return JsonFailur(model.Errors);
        }

        [HttpGet]
        public ActionResult Write(string toUser)
        {
            var model = new WriteMessageModel(toUser);

            return View(model);
        }

        [HttpPost]
        public ActionResult Write(WriteMessageModel model)
        {
            if (model.IsValid())
            {
                model.Save();
            }

            return RedirectToAction("Write", new { @toUser = model.ToUserLogin });
        }
    }
}