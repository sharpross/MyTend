namespace MyTend.Controllers
{
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
            return View();
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
        public ActionResult Create()
        {
            return View();
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