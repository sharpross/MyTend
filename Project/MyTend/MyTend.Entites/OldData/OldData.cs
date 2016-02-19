namespace MyTend.Entites.OldData
{
    using Castle.ActiveRecord;

    public class OldData : BaseEntity<OldData>
    {
        [Property]
        public string Data { get; set; }
    }
}
