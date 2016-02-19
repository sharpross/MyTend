namespace MyTender.Security
{
    using System.Web.Mvc;

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
