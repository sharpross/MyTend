using System.IO;
using System.Web.Hosting;
using FileIO = System.IO.File;

namespace MyTend.Services
{
    public static class StorableFileService
    {
        private const string StoreName = "file_store";

        public static void Save(Stream stream, string fileName, int id)
        {
            var path = string.Format(@"{0}\{1}\{2}", GetDir(), StoreName, id);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            path += @"\" + fileName;

            using (var file = System.IO.File.Create(path))
            {
                stream.Seek(0, SeekOrigin.Begin);
                stream.CopyTo(file);
            }
        }

        public static byte[] Get(int id, string name)
        {
            var path = string.Format(@"{0}\{1}\{2}\{3}", GetDir(), StoreName, id, name);

            var data = FileIO.ReadAllBytes(path);

            return data;
        }

        public static void Delete(int id)
        {
            var path = string.Format(@"{0}\{1}\{2}", GetDir(), StoreName, id);

            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
            }
        }

        public static string GetDir()
        {
            var source = HostingEnvironment.ApplicationPhysicalPath;
            
            return source;
        }
    }
}
