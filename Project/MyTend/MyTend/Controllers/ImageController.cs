namespace MyTend.Controllers
{
    using MyTend.Entites;
    using MyTend.Services.File;
    using MyTender.Core;
    using MyTender.Security;
    using System.IO;
    using System.Web.Mvc;

    public class ImageController : BaseController
    {
        [OutputCache(Duration = 10)]
        public ActionResult Get(int? id)
        {
            try
            {
                if (id.HasValue && id.Value != 0)
                {
                    var service = new FileService();

                    var obj = service.Get(id.Value);//File.Find(id.Value);

                    if (obj != null)
                    {
                        return File(obj.Data, obj.MimeType);
                    }
                }
            }
            catch
            {
            }

            var dir = Server.MapPath("/Content/images/image_not_found.svg");
            var path = Path.Combine(dir);

            return base.File(path, "image/png");
        }

        [HttpPost]
        public JsonResult Remove(int? id)
        {
            

            return Json(new { Success = false });
        }
    }
}