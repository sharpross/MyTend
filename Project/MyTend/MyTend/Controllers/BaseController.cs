namespace MyTend.Controllers
{
    using FluentSecurity;
    using MyTend.Entites;
    using MyTend.Services;
    using MyTend.Services.Common;
    using MyTender.Security;
    using System;
    using System.Web.Mvc;

    [ErrorAtr]
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

        private void LogError(ExceptionContext filterContext)
        {
            var user = string.Empty;

            if (this.Auth != null && this.Auth.User != null)
            {
                user = this.Auth.User.Login;
            }

            var logRec = new Log()
            {
                Context = filterContext.Controller.ControllerContext.HttpContext.Request.Path,
                Level = MyTend.Entites.Enums.LogLevel.Error,
                Message = filterContext.Exception.Message,
                Stack = filterContext.Exception.StackTrace,
                UserName = user,
                Addr = this.Request.ServerVariables["REMOTE_ADDR"],
                Agent = this.Request.ServerVariables["HTTP_USER_AGENT"],
                Query = this.Request.ServerVariables["QUERY_STRING"]
            };

            logRec.Save();
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            try
            {
                this.LogError(filterContext);
            }
            catch
            {
                
            }
            finally
            {
                if (filterContext.Exception is PolicyViolationException)
                {
                    filterContext.Result = new RedirectResult("~/Account/Registration");
                }
                if (filterContext.Exception is HttpNotFoundResult)
                {
                    filterContext.Result = new RedirectResult("~/Error/NotFound");
                }
                else
                {
                    filterContext.Result = new RedirectResult("~/Error/Error");
                }
            }

            base.OnException(filterContext);
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            this.ViewBag.IsAuth = false;
            this.ViewBag.NoIndexing = false;

            if (this.Auth.User != null)
            {
                var regionFilter = new RegionFilterService(this.Auth.User);
                var themesFilter = new TenderFilterService(this.Auth.User);
                var payService = new PayService(this.Auth.User);
                var tenderService = new TenderService(this.Auth.User);
                var messageService = new UserMessagesService(this.Auth.User);

                this.ViewBag.ActiveTendersCount = tenderService.GetCountTenders();
                this.ViewBag.UnreadedMessages = messageService.CountUnread();

                this.ViewBag.IsAuth = true;
                this.ViewBag.UserLogin = this.Auth.User.Login;
                this.ViewBag.UserEmail = this.Auth.User.Email;
                this.ViewBag.UserName = this.Auth.User.FullName;
                this.ViewBag.IsSubRegions = regionFilter.HasSubs();
                this.ViewBag.IsSubTenders = themesFilter.HasSubs();
                this.ViewBag.HasPay = payService.HasPay();
                this.ViewBag.PayEnd = payService.PayEnd();

                var active = new MyTend.Models.TenderService().GetActive().Count;
                var winner = new MyTend.Models.TenderService().GetWinner().Count;

                ViewBag.ActiveCount = active;
                ViewBag.WinnerCount = winner;
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

            this.Response.StatusCode = 500;

            return Json(result, JsonRequestBehavior.AllowGet); ;
        }
    }
}
