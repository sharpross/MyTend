using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MyTender.Core
{
    public class BaseController : Controller
    {
        public JsonResult JsonSuccess()
        {
            var result = new
            {
                Success = true
            };

            return Json(result, JsonRequestBehavior.AllowGet); ;
        }

        public JsonResult JsonSuccess(object data)
        {
            var result = new
            {
                Data = data,
                Success = true
            };

            return Json(result, JsonRequestBehavior.AllowGet); ;
        }

        public JsonResult JsonFailur(object data)
        {
            var result = new
            {
                Data = data,
                Success = false
            };

            return Json(result, JsonRequestBehavior.AllowGet); ;
        }
    }
}
