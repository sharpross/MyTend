namespace MyTend.Services.File
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using MyTend.Entites;
    using MyTend.Entites.Enums;
    using MyTend.Entites.FileStorageInfo;
    using MyTender.Core;
    using NHibernate.Criterion;

    /// <summary>
    /// Сервис по работе с файлами. 
    /// Любые манипуляции с файлами производить через него!!!
    /// </summary>
    public class FileService
    {
        public FileSystem Get(int fileId)
        {
            var file = FileSystem.GetById(fileId);

            file.Data = StorableFileService.Get(file.Id, file.Name);

            return file;
        }

        /// <summary>
        /// Получить файлы привязанные к тендеру
        /// </summary>
        /// <param name="tender"></param>
        /// <returns></returns>
        public List<FileSystem> Get(Tender tender)
        {
            var files = new List<FileSystem>();

            try
            {
                files = FileStorageInfo
                    .FindAll(Expression.Eq("Tender", tender))
                    //.Where(x => x.Tender != null && x.Tender.Id == tender.Id)
                    .Select(x => x.File)
                    .ToList();

                foreach (var file in files)
                {
                    file.Data = StorableFileService.Get(file.Id, file.Name);
                }
            }
            catch
            { 
            }

            return files;
        }

        /// <summary>
        /// Привязать файлы к тендеру
        /// </summary>
        /// <param name="tender"></param>
        /// <param name="streams"></param>
        public List<FileStorageInfo> Save(Tender tender, List<FileInfo> files)
        {
            var result = new List<FileStorageInfo>();

            var i = 0;// this.GetCurrentCountFiles(StoreType.Tender, null, tender);

            foreach (var file in files)
            {
                if (i > Constants._MAX_FILES_TENDER)
                {
                    continue;
                }

                if (file.Data.Length >= Constants._MAX_FILE_SIZE)
                {
                    continue;
                }

                var data = this.GetData(file.Data);

                var fileSystem = new FileSystem()
                {
                    Data = data,
                    Name = file.Name,
                    MimeType = file.MimeType
                };

                fileSystem.Create();

                var fileInfo = new FileStorageInfo()
                {
                    File = fileSystem,
                    Tender = tender
                };
                
                fileInfo.Create();

                StorableFileService.Save(file.Data, file.Name, fileInfo.Id);

                result.Add(fileInfo);

                i++;
            }

            return result;
        }

        /// <summary>
        /// Получить файлы привязанные к профилю пользователя
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public List<FileSystem> Get(UserSystem user, bool notAvatar = true)
        {
            var files = new List<FileSystem>();

            if (notAvatar)
            {
                files = FileStorageInfo
                    .FindAll(Expression.Eq("User", user))
                    //.Where(x => x.User != null && x.User.Id == user.Id)
                    .Where(x => x.IsAvatar == false)
                    .Select(x => x.File)
                    .ToList();

                foreach (var file in files)
                {
                    file.Data = StorableFileService.Get(file.Id, file.Name);
                }
            }
            else
            {
                if (user.Avatar != null)
                {
                    files = FileStorageInfo
                        .FindAll(Expression.Eq("User", user))
                        //.Where(x => x.User != null && x.User.Id == user.Id)
                        .Where(x => x.IsAvatar == true)
                        .Select(x => x.File)
                        .ToList();

                    foreach (var file in files)
                    {
                        file.Data = StorableFileService.Get(file.Id, file.Name);
                    }
                }
            }

            return files;
        }

        /// <summary>
        /// Привязать файлы к профилю пользователя
        /// </summary>
        /// <param name="user"></param>
        /// <param name="streams"></param>
        public List<FileStorageInfo> Save(UserSystem user, List<FileInfo> files)
        {
            var result = new List<FileStorageInfo>();

            var i = this.GetCurrentCountFiles(StoreType.User, user, null);

            foreach (var file in files)
            {
                if (i > Constants._MAX_FILES_USER)
                {
                    continue;
                }

                if (file.Data.Length > Constants._MAX_FILE_SIZE)
                {
                    continue;
                }

                var data = this.GetData(file.Data);

                var fileSystem = new FileSystem()
                {
                    Data = data,
                    Name = file.Name,
                    MimeType = file.MimeType
                };

                while (fileSystem.Id == 0)
                {
                    fileSystem.Save();
                }

                StorableFileService.Save(file.Data, file.Name, fileSystem.Id);

                var fileInfo = new FileStorageInfo()
                {
                    File = fileSystem,
                    User = user,
                    IsAvatar = file.IsAvatar
                };

                try
                {
                    if (fileInfo.IsValid())
                    {
                        while (fileInfo.Id == 0)
                        {
                            fileInfo.SaveAndFlush();
                        }

                        StorableFileService.Save(file.Data, file.Name, fileSystem.Id);

                        result.Add(fileInfo);

                        i++;
                    }
                    else
                    {
                        var aa = 1;
                    }
                }
                catch
                {
                    
                }
            }

            return result;
        }

        /// <summary>
        /// Удалить файл
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            var fileStorageInfo = FileStorageInfo
                .FindAll()
                .FirstOrDefault(x => x.File.Id == id);

            if (fileStorageInfo != null)
            {
                fileStorageInfo.Delete();
            }
        }

        public int GetCurrentCountFiles(StoreType storeType, UserSystem user, Tender tender)
        {
            var result = 0;

            var data = new List<FileStorageInfo>();

            switch (storeType)
            {
                case StoreType.User:
                    data = FileStorageInfo.FindAll(Expression.Eq("User", user))
                        //.Where(x => x.User != null && x.User.Id == user.Id)
                        .ToList();
                    break;
                case StoreType.Tender:
                    data = FileStorageInfo.FindAll(Expression.Eq("Tender", tender))
                        //.Where(x => x.Tender.Id == tender.Id)
                        .ToList();
                    break;
            }

            result = data.Count;

            return result;
        }

        private byte[] GetData(Stream stream)
        {
            byte[] result = null;

            using (var streamReader = new MemoryStream())
            {
                stream.CopyTo(streamReader);
                result = streamReader.ToArray();
            }

            return result;
        }
    }
}
