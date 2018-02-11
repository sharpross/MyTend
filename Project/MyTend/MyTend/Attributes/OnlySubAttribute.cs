using System;
using System.Web.Mvc;
using MyTender.Security;

namespace MyTend.Attributes
{
    public class OnlySubAttribute : ActionFilterAttribute, IActionFilter
    {
        public AuthService Auth { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            this.Auth = new AuthService();

            if (this.Auth.User != null)
            {
                if (this.Auth.User.SubToDate < DateTime.Now)
                {
                    filterContext.Result = new RedirectResult("~/Account/OnlyForSub");
                }
                else
                {
                    base.OnActionExecuting(filterContext);
                }
            }
            else
            {
                filterContext.Result = new RedirectResult("~/Account/OnlyForSub");
            }
        }
    }
}
