﻿namespace MyTend.Controllers
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

        /// <summary>
        /// Инструкция заполнеиния заявок
        /// </summary>
        /// <returns></returns>
        public ActionResult Instruction()
        {
            return View();
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
            return View();
        }

        /// <summary>
        /// Правила заполнения профиля
        /// </summary>
        /// <returns></returns>
        public ActionResult AboutProfile()
        {
            return View();
        }
    }
}