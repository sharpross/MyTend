﻿namespace MyTend.Entites
{
    using Castle.ActiveRecord;
    using Castle.Components.Validator;
    using System;

    [ActiveRecord("PayInfos")]
    public class PayInfo : ActiveRecordBase<PayInfo>
    {
        [PrimaryKey(PrimaryKeyType.Native)]
        public int Id { get; set; }

        [BelongsTo("UserId")]
        public UserSystem User { get; set; }

        [Property]
        public decimal Sum { get; set; }

        [Property]
        public DateTime PayDay { get; set; }

        [Property]
        public DateTime PayEnd { get; set; }
    }
}