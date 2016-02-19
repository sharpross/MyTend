using MyTender.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyTend.Controllers
{
    public class ErrorController : BaseController
    {
        public ActionResult NotFound()
        {
            return View();
        }

        public ActionResult AccessDenied()
        {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}