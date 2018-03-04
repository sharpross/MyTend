using FluentSecurity;
using MyTend.Controllers;
using MyTend.Entites;
using MyTender.Core;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MyTender.Security;

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
                configuration.For<FileController>().AllowAny();
                configuration.For<HomeController>().AllowAny();
                configuration.For<DocsController>().AllowAny();
                configuration.For<RegionController>().AllowAny();
                configuration.For<MigrationsController>().AllowAny();

                //TODO: подправить под DenyAuthenticatedAccess
                configuration.For<AccountController>(ac => ac.Registration()).Ignore();
                //configuration.For<AccountController>(ac => ac.Registration()).DenyAuthenticatedAccess();
                configuration.For<AccountController>(ac => ac.Login(string.Empty, string.Empty)).Ignore();
                configuration.For<AccountController>(ac => ac.Card(string.Empty)).Ignore();
                configuration.For<AccountController>(ac => ac.Welcom()).Ignore();
                configuration.For<PayController>(ac => ac.Paid(string.Empty, string.Empty, string.Empty, string.Empty, 0, 0, string.Empty, string.Empty, string.Empty, false)).Ignore();
                configuration.For<ErrorController>().Ignore();


                configuration.For<TenderController>(ac => ac.Index()).Ignore();
                configuration.For<TenderController>(ac => ac.Create(0)).Ignore();
                configuration.For<TenderController>(ac => ac.Map()).Ignore();
            });

            filters.Add(new HandleSecurityAttribute(), 0);
            filters.Add(new ErrorAtr());
        }

        private static bool IsAuth(HttpContext context)
        {
            HttpCookie authCookie = context.Request.Cookies.Get(Constants._COOKIE_NAME);
            if (authCookie != null && !string.IsNullOrEmpty(authCookie.Value))
            {
                try
                {
                    var ticket = FormsAuthentication.Decrypt(authCookie.Value);
                    var exist = false;

                    exist = UserSystem.GetByProp("Login", ticket.Name) != null;

                    return exist;
                }
                catch
                {
                    return false;
                }
            }

            return false;
        }
    }
}
