namespace MyTend.Controllers
{
    using MyTend.Models;
    using MyTender.Core;
    using MyTender.Security;
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
        public ActionResult List()
        {
            return View();
        }

        /// <summary>
        /// Создать тенедер
        /// </summary>
        /// <returns></returns>
        [HttpGet]
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
        public ActionResult Create(int id)
        {
            var model = new CreateTenderModel(id);

            return View(model);
        }

        /// <summary>
        /// Активные тендеры
        /// </summary>
        /// <returns></returns>
        public ActionResult Active()
        {
            return View();
        }

        /// <summary>
        /// Мои тендеры
        /// </summary>
        /// <returns></returns>
        public ActionResult My()
        {
            return View();
        }

        /// <summary>
        /// Подробно
        /// </summary>
        /// <param name="id">Id тендера</param>
        /// <returns></returns>
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}