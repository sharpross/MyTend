namespace MyTend.Entites.FileStorageInfo
{
    using Castle.ActiveRecord;
    using Castle.Components.Validator;
    using MyTend.Entites.Enums;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [ActiveRecord("FileStorageInfos")]
    public class FileStorageInfo : ActiveRecordBase<FileStorageInfo>
    {
        [PrimaryKey(PrimaryKeyType.Foreign)]
        public int Id { get; set; }

        [Property]
        public StoreType Type { get; set; }

        [OneToOne(Cascade = CascadeEnum.All)]
        public FileSystem File { get; set; }

        [BelongsTo("UserId")]
        public UserSystem User { get; set; }

        [BelongsTo("TenderId")]
        public Tender Tender { get; set; }

        [Property]
        public bool IsAvatar { get; set; }

        [ValidateNonEmpty("Укажите дату создания")]
        [Property]
        public DateTime CreatedDateTime { get; set; }

        public List<string> Errors { get; set; }

        public bool IsValid()
        {
            IValidatorRunner runner = new ValidatorRunner(new CachedValidationRegistry());

            if (runner.IsValid(this))
            {
                return true;
            }

            this.Errors.Clear();
            this.Errors.AddRange(runner.GetErrorSummary(this).ErrorMessages);

            return false;
        }

    }
}
