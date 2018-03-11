namespace MyTend.Controllers
{
    using MyTender.Core;
    using MyTender.Security;
    using System.Web.Mvc;

    public class DocsController : BaseController
    {
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        /// <summary>
        /// Чяво
        /// </summary>
        /// <returns></returns>
        public ActionResult FAQ()
        {
            return RedirectToAction("Index", "Home");
        }

        /// <summary>
        /// Инструкция заполнеиния заявок
        /// </summary>
        /// <returns></returns>
        public ActionResult Instruction()
        {
            return RedirectToAction("Index", "Home");
        }

        /// <summary>
        /// Публичуе данные
        /// </summary>
        /// <returns></returns>
        public ActionResult PublicData()
        {
            return RedirectToAction("Index", "Home");
        }

        /// <summary>
        /// Правила пользования сайтом
        /// </summary>
        /// <returns></returns>
        public ActionResult Rules()
        {
            return View();
        }

        /// <summary>
        /// Договор-оферта
        /// </summary>
        /// <returns></returns>
        public ActionResult Termins()
        {
            return RedirectToAction("Index", "Home");
        }

        /// <summary>
        /// Правила заполнения профиля
        /// </summary>
        /// <returns></returns>
        public ActionResult AboutProfile()
        {
            return RedirectToAction("Index", "Home");
        }

        /// <summary>
        /// О меню
        /// </summary>
        /// <returns></returns>
        public ActionResult AboutMenu()
        {
            return RedirectToAction("Index", "Home");
        }

        /// <summary>
        /// Договор оферты
        /// </summary>
        /// <returns></returns>
        /*public ActionResult Aferta()
        {
            return View();
        }*/

        /// <summary>
        /// Договор оферты
        /// </summary>
        /// <returns></returns>
        public ActionResult Oferta()
        {
            return View();
        }

        public ActionResult AboutWork()
        {
            return RedirectToAction("Index", "Home");
        }

        public ActionResult AboutWork2()
        {
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Torgs()
        {
            return View();
        }
    }
}