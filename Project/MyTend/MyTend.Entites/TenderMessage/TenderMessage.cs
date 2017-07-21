namespace MyTend.Entites
{
    using Castle.ActiveRecord;
    using Castle.Components.Validator;
    using System;

    [ActiveRecord("TenderMessage")]
    public class TenderMessage : BaseEntity<TenderMessage>
    {
        [BelongsTo("TenderId")]
        [ValidateNonEmpty]
        public Tender Tender { get; set; }

        [Property]
        [ValidateNonEmpty]
        public DateTime Date { get; set; }

        [BelongsTo("UserId")]
        [ValidateNonEmpty]
        public UserSystem User { get; set; }

        [Property(Length=2000)]
        [ValidateNonEmpty]
        public string Message { get; set; }
        
        [Property]
        public int CanSumm { get; set; }
    }
}
