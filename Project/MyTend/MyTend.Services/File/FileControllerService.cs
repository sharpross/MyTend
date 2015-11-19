using MyTend.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MyTend.Services.File
{
    public class FileControllerService
    {
        public List<FileSystem> UpdateFiles(HttpPostedFileBase[] files, UserSystem user)
        {
            List<FileSystem> result = null;

            if (files != null)
            {
                var service = new FileService();

                var data = new List<FileInfo>();

                foreach (var file in files)
                {
                    if (file == null)
                    {
                        continue;
                    }

                    var fileInfo = new FileInfo()
                    {
                        Data = file.InputStream,
                        Name = file.FileName,
                        MimeType = file.ContentType,
                        IsAvatar = false
                    };

                    data.Add(fileInfo);
                }

                //this.DeleteOldAvatar(user);

                var resultData = service.Save(user, data);

                if (resultData.Count > 0)
                {
                    result = resultData
                        .Select(x => x.File)
                        .ToList();
                }
            }

            return result;
        }

        public FileSystem UpdateAvatar(HttpPostedFileBase[] files, UserSystem user)
        {
            FileSystem result = null;

            if (files != null)
            {
                var service = new FileService();

                var data = new List<FileInfo>();

                foreach (var file in files)
                {
                    if (file == null)
                    {
                        continue;
                    }

                    var fileInfo = new FileInfo()
                    {
                        Data = file.InputStream,
                        Name = file.FileName,
                        MimeType = file.ContentType,
                        IsAvatar = true
                    };

                    data.Add(fileInfo);
                }

                this.DeleteOldAvatar(user);

                var resultData = service.Save(user, data);

                if(resultData.Count > 0)
                {
                    result = resultData
                        .FirstOrDefault()
                        .File;
                }
            }

            return result;
        }

        private void DeleteOldAvatar(UserSystem user)
        {
            if (user.Avatar == null)
            {
                return;
            }

            var service = new FileService();

            var id = user.Avatar.Id;

            user.Avatar = null;
            user.Update();

            service.Delete(id);
        }

        public void DeletePortFile(int id, UserSystem user)
        {
            var service = new FileService();

            service.Delete(id);
        }

        public void SaveFileTender(HttpPostedFileBase[] files, Tender tender)
        {
            if (files == null && tender == null)
            {
                return;
            }

            var fileInfos = new List<FileInfo>();

            foreach (var file in files)
            {
                if (file != null)
                {
                    fileInfos.Add(new FileInfo()
                    {
                        Name = file.FileName,
                        MimeType = file.ContentType,
                        Data = file.InputStream
                    });
                }
            }

            var service = new FileService();

            var result = service.Save(tender, fileInfos);
        }

        public List<FileSystem> Get(Tender tender)
        {
            var service = new FileService();

            return service.Get(tender);
        }

        public List<FileSystem> Get(UserSystem user, bool notAvatar = false)
        {
            var file = FileSystem.FindAll();
                

            var service = new FileService();

            return service.Get(user, notAvatar)
                .Where(x => x != null)
                .ToList();
        }
    }
}
