using MyTend.Entites.Block;
using MyTender.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MyTend.Attributes
{
    public class BanResourceAttribute : ActionFilterAttribute
    {
        public AuthService Auth { get; set; }
        
        public BanResourceAttribute()
        {
            this.Auth = new AuthService();
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (this.Auth.User != null)
            {
                if (!this.Auth.User.IsBlocked)
                {
                    base.OnActionExecuting(filterContext);
                }
                else
                {
                    filterContext.Result = new RedirectResult("~/Account/OnlyForSub");
                }
            }

            base.OnActionExecuting(filterContext);
        }
    }
}
