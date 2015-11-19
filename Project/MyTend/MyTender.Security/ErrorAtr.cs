using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MyTender.Security
{
    public class ErrorAtr : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            filterContext.Result = new ViewResult
            {
                ViewName = "~/Views/Error/Error.cshtml"
            };

            base.OnException(filterContext);
        }
    }
}
