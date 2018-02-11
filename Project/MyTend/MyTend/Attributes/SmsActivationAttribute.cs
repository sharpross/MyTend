using System.Web.Mvc;
using MyTender.Security;

namespace MyTend.Attributes
{
    public class SmsActivationAttribute : ActionFilterAttribute, IActionFilter
    {
        public AuthService Auth { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            this.Auth = new AuthService();

            if (this.Auth.User == null)
            {
                return;
            }

            if (this.Auth.User.Activated)
            {
                return;
            }

            filterContext.Result = new RedirectResult("~/Account/Activate");

            base.OnActionExecuting(filterContext);
        }
    }
}