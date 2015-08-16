namespace MyTend.Entites.FileStorageInfo
{
    using Castle.ActiveRecord;
    using MyTend.Entites.Enums;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [ActiveRecord("FileStorageInfos")]
    public class FileStorageInfo : BaseEntity<FileStorageInfo>
    {
        [Property]
        public StoreType Type { get; set; }

        [BelongsTo("FileId")]
        public FileSystem File { get; set; }

        [BelongsTo("UserId")]
        public UserSystem User { get; set; }

        [BelongsTo("TenderId")]
        public Tender Tender { get; set; }
    }
}
