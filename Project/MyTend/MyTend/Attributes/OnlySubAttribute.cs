using MyTend.Services.Common;
using MyTender.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MyTend.Attributes
{
    public class OnlySubAttribute : ActionFilterAttribute, IActionFilter
    {
        public AuthService Auth { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            this.Auth = new AuthService();

            var payService = new PayService(this.Auth.User);

            if (payService.HasPay())
            {
                base.OnActionExecuting(filterContext);
            }
            else
            {
                filterContext.Result = new RedirectResult("~/Account/OnlyForSub");
            }
        }
    }
}
