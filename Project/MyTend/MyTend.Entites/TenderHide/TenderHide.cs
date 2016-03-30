namespace MyTend.Entites
{
    using Castle.ActiveRecord;

    [ActiveRecord("TenderHide")]
    public class TenderHide : BaseEntity<TenderHide>
    {
        [BelongsTo("UserId")]
        public UserSystem User { get; set; }

        [BelongsTo("ThemeId")]
        public Tender Tender { get; set; }
    }
}
