namespace MyTend.Entites
{
    using Castle.ActiveRecord;
    using Castle.Components.Validator;
    using System;

    [ActiveRecord("UserMessages")]
    public class TenderMessage : ActiveRecordBase<TenderMessage>
    {
        [PrimaryKey(PrimaryKeyType.Native)]
        public int Id { get; set; }

        [BelongsTo("TenderId")]
        [ValidateNonEmpty]
        public Tender Tender { get; set; }

        [Property]
        [ValidateNonEmpty]
        public DateTime Date { get; set; }

        [BelongsTo("UserId")]
        [ValidateNonEmpty]
        public UserSystem User { get; set; }

        [Property]
        [ValidateNonEmpty]
        public string Message { get; set; }
    }
}
