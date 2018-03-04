namespace MyTender.Security
{
    using System;
    using System.Web.Mvc;

    public class ErrorAtr : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            filterContext.HttpContext.Response.Clear();
            filterContext.HttpContext.Response.TrySkipIisCustomErrors = true;
                
            filterContext.ExceptionHandled = true;
            
            if (filterContext.Exception is FluentSecurity.PolicyViolationException)
            {
                filterContext.Result = new RedirectResult("~/Account/Registration");
            }

            if (!filterContext.ExceptionHandled && filterContext.Exception is HttpNotFoundResult)
            {
                filterContext.Result = new RedirectResult("~/Error/NotFound");
            }
            
            if (!filterContext.ExceptionHandled)
            {
                filterContext.Result = new ViewResult
                {
                    ViewName = "~/Views/Error/Error.cshtml"
                };   
            }
            

            base.OnException(filterContext);
        }
    }
}
