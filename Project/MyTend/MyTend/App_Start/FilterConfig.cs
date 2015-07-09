using FluentSecurity;
using MyTend.Controllers;
using MyTend.Entites;
using MyTender.Core;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MyTend
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            SecurityConfigurator.Configure(configuration =>
            {
                configuration.GetAuthenticationStatusFrom(() => IsAuth(HttpContext.Current));
                configuration.ForAllControllers().DenyAnonymousAccess();

                configuration.For<ImageController>().AllowAny();
                configuration.For<HomeController>().AllowAny();
                configuration.For<DocsController>().AllowAny();
                configuration.For<RegionController>().AllowAny();
                configuration.For<MigrationsController>().AllowAny();

                configuration.For<AccountController>(ac => ac.Registration()).DenyAuthenticatedAccess();

                configuration.For<AccountController>(ac => ac.About()).Ignore();
                configuration.For<AccountController>(ac => ac.Login(string.Empty, string.Empty)).Ignore();
            });

            filters.Add(new HandleErrorAttribute());
            filters.Add(new HandleSecurityAttribute(), 0);
        }

        private static bool IsAuth(HttpContext context)
        {
            HttpCookie authCookie = context.Request.Cookies.Get(Constants._COOKIE_NAME);
            if (authCookie != null && !string.IsNullOrEmpty(authCookie.Value))
            {
                var ticket = FormsAuthentication.Decrypt(authCookie.Value);
                var exist = false;

                exist = UserSystem.GetByProp("Login", ticket.Name) != null;

                return exist;
            }

            return false;
        }
    }
}
