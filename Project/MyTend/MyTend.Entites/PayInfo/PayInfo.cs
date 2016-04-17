namespace MyTend.Entites
{
    using Castle.ActiveRecord;
    using Castle.Components.Validator;
    using System;

    [ActiveRecord("PayInfos")]
    public class PayInfo : BaseEntity<PayInfo>
    {
        [BelongsTo("UserId")]
        public UserSystem User { get; set; }

        [Property]
        public decimal Sum { get; set; }

        [Property]
        public DateTime PayDay { get; set; }

        [Property]
        public DateTime PayEnd { get; set; }

        [Property]
        public int Account { get; set; }

        [Property]
        public bool IsPayed { get; set; }
    }
}
