namespace MyTender.Security
{
    using MyTend.Services.Common;
    using System.Web.Mvc;

    public class BaseController : Controller
    {
        public AuthService Auth { get; set; }

        /// <summary>
        /// Пользователь имеет платную подписку
        /// </summary>
        public bool IsSubmited 
        {
            get
            {
                var service = new SubmiteService();

                return service.IsSubmite(null);
            }
        }

        public BaseController()
        {
            this.Auth = new AuthService();
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            this.Auth.HttpContext = filterContext.HttpContext;

            this.ViewBag.IsAuth = false;

            if (this.Auth.User != null)
            {
                this.ViewBag.IsAuth = true;
                this.ViewBag.UserLogin = this.Auth.User.Login;
                this.ViewBag.UserEmail = this.Auth.User.Email;
                this.ViewBag.UserName = this.Auth.User.Name;
                this.ViewBag.IsSubRegions = false;
                this.ViewBag.IsSubTenders = false;
            }

            base.OnActionExecuting(filterContext);
        }

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
