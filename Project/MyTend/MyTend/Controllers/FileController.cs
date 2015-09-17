namespace MyTend.Controllers
{
    using MyTend.Services.File;
    using System;
    using System.IO;
    using System.Web.Mvc;

    public class FileController : Controller
    {
        [OutputCache(Duration = 10)]
        public ActionResult Get(int? id)
        {
            try
            {
                if (id.HasValue)
                {
                    var service = new FileService();

                    var obj = service.Get(id.Value);

                    if (obj != null)
                    {
                        return File(obj.Data, obj.MimeType);
                    }
                    else
                    {
                        throw new Exception(string.Format("Файл с id={0} не найден", id.Value));
                    }
                }
            }
            catch
            {
                throw new Exception(string.Format("Файл с id={0} не найден", id.Value));
            }

            var dir = Server.MapPath("/Content/images/image_not_found.png");
            var path = Path.Combine(dir);

            return base.File(path, "image/png");
        }
    }
}