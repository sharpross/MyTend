using System;
using Castle.ActiveRecord;

namespace MyTend.Entites
{
    [ActiveRecord("SmsSendFact")]
    public class SmsSendFact : BaseEntity<SmsSendFact>
    {
        [BelongsTo("UserId")]
        public UserSystem User { get; set; }

        [Property]
        public DateTime SendDate { get; set; }
    }
}
