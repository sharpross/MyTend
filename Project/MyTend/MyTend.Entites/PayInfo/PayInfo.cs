namespace MyTend.Entites
{
    using Castle.ActiveRecord;
    using Castle.Components.Validator;
    using System;

    [ActiveRecord("PayInfos")]
    public class PayInfo : BaseEntity<PayInfo>
    {
        [BelongsTo("UserId")]
        [ValidateNonEmpty]
        public UserSystem User { get; set; }

        [Property]
        [ValidateNonEmpty]
        public decimal Sum { get; set; }

        [Property]
        [ValidateNonEmpty]
        public DateTime PayDay { get; set; }

        [Property]
        [ValidateNonEmpty]
        public DateTime PayEnd { get; set; }
    }
}
