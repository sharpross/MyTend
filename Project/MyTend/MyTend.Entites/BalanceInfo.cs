namespace MyTend.Entites
{
    using Castle.ActiveRecord;

    [ActiveRecord("BlocksUser")]
    public class BalanceInfo : BaseEntity<BalanceInfo>
    {
        [BelongsTo("UserId", Cascade = CascadeEnum.All)]
        public UserSystem User { get; set; }

        [Property]
        public decimal Balance { get; set; }
    }
}
