namespace MyTend.Controllers
{
    using Castle.ActiveRecord;
    using MyTend.Services.Migrations;
    using MyTend.Services.Migrations.Regions;
    using MyTender.Core;
    using System.Web.Mvc;

    public class MigrationsController : BaseController
    {
        public JsonResult AddUpdateTenderThemes()
        {
            var migration = new TenderThemesMigration();

            migration.Migrate();

            return JsonSuccess();
        }

        public JsonResult CreateSchema()
        {
            ActiveRecordStarter.CreateSchema();

            return JsonSuccess();
        }

        public JsonResult CreateRegions()
        {
            var migration = new RegionMigration();

            migration.Migrate();

            return JsonSuccess();
        }
    }
}