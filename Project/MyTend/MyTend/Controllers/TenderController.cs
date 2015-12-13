namespace MyTend.Controllers
{
    using MyTend.Attributes;
    using MyTend.Models;
    using MyTender.Core;
    using MyTender.Security;
    using System;
    using System.Web.Mvc;

    public class TenderController : BaseController
    {
        /// <summary>
        /// Выбор создания тендера
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var model = new ListThemeTenderModel();

            return View(model);
        }

        /// <summary>
        /// Список тендеров
        /// </summary>
        /// <returns></returns>
        [OnlySub]
        [BanResource]
        public ActionResult List()
        {
            var model = new ListTendersModel();

            return View(model);
        }

        /// <summary>
        /// Создать тенедер
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [BanResource]
        public ActionResult Create(int id)
        {
            var model = new CreateTenderModel(id);

            return View(model);
        }

        /// <summary>
        /// Создать тенедер
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ValidateInput(false)]
        [BanResource]
        public ActionResult Create(CreateTenderModel model)
        {
            if (this.Auth.User == null)
            {
                return RedirectToAction("About", "Account");
            }

            if (model.IsValid())
            {
                model.Save();

                return RedirectToAction("My");
            }

            return View(model);
        }

        /// <summary>
        /// Активные тендеры
        /// </summary>
        /// <returns></returns>
        [OnlySub]
        [BanResource]
        public ActionResult Active()
        {
            var model = new ActiveTenderListModel();

            return View(model);
        }

        /// <summary>
        /// Закрыте тендеры
        /// </summary>
        /// <returns></returns>
        public ActionResult Closed()
        {
            var model = new ActiveTenderListModel();

            return View(model);
        }

        /// <summary>
        /// Мои тендеры
        /// </summary>
        /// <returns></returns>
        public ActionResult My()
        {
            var model = new MyTendersModel();

            return View(model);
        }

        /// <summary>
        /// Подробно
        /// </summary>
        /// <param name="id">Id тендера</param>
        /// <returns></returns>
        public ActionResult Details(int id)
        {
            var model = new TenderDetailsModel(id);

            return View(model);
        }

        public ActionResult SelectWinner(int userId, int tenderId)
        {
            try
            {
                var model = new CloseTenderModel(userId, tenderId);
                model.Close();
            }
            catch(Exception ex)
            {
                return JsonFailur(ex.Message);
            }

            return RedirectToAction("Details", new { @id = tenderId});
        }

        public ActionResult CancelTender(int id)
        {
            var model = new CloseTenderModel(this.Auth.User.Id, id);
            model.Cancel();

            return RedirectToAction("My");
        }

        [HttpPost]
        [BanResource]
        public ActionResult AddComment(TenderMessageModel model)
        {
            if (model.IsValid())
            {
                model.Save();

                return JsonSuccess();
            }

            return JsonFailur(model);
        }
    }
}