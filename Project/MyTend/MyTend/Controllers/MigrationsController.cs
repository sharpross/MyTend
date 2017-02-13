namespace MyTend.Controllers
{
    using Castle.ActiveRecord;
    using MyTend.Services.Migrations;
    using MyTend.Services.Migrations.Regions;
    using MyTend.Services.Migrations.User;
    using MyTender.Core;
    using MyTender.Security;
    using System;
    using System.Web.Mvc;

    public class MigrationsController : BaseController
    {
        public JsonResult Zero(string id)
        {
            var shtamp = string.Format("017{0}_{1}", DateTime.Now.ToString("ddMMyyyyhh"), "kadastr");

            //if (!string.IsNullOrEmpty(id) && id == shtamp) 
            {
                ActiveRecordStarter.CreateSchema();

                var migration = new RegionMigration();
                migration.Migrate();

                var migration2 = new TenderThemesMigration2();
                migration2.Migrate();

                var migration3 = new UserMigration();
                migration3.Migrate();

                return JsonSuccess();
            }

            var no = new { Result = " no auth" };

            return JsonFailur(no);
        }
    }
}