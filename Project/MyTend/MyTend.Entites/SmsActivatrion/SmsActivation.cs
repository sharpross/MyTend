using Castle.ActiveRecord;

namespace MyTend.Entites
{
    [ActiveRecord("smsactiovation")]
    public class SmsActivation : BaseEntity<SmsActivation>
    {
        [BelongsTo("userid")]
        public UserSystem User { get; set; }

        [Property]
        public string Code { get; set; }
    }
}
