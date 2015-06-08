namespace MyTend.Entites
{
    using Castle.ActiveRecord;
    using Castle.Components.Validator;
    using System;

    [ActiveRecord("Tenders")]
    public class Tender : ActiveRecordBase<Tender>
    {
        [PrimaryKey(PrimaryKeyType.Native)]
        public int Id { get; set; }

        [BelongsTo("UserId")]
        [ValidateNonEmpty]
        public UserSystem User { get; set; }

        [ValidateNonEmpty]
        [BelongsTo("TenderCategoriesId")]
        public TenderCategories Categories { get; set; }

        [ValidateNonEmpty]
        [BelongsTo("RegionId")]
        public Region Region { get; set; }

        [ValidateNonEmpty]
        [BelongsTo("CityId")]
        public City City { get; set; }

        [Property]
        public bool IsOpen { get; set; }

        [Property]
        public bool AllowWriteMe { get; set; }

        [Property]
        public decimal Cost { get; set; }

        [Property]
        [ValidateNonEmpty]
        public string Title { get; set; }

        [Property]
        [ValidateNonEmpty]
        public string Message { get; set; }

        [Property]
        [ValidateNonEmpty]
        public DateTime DateEnd { get; set; }
    }
}
