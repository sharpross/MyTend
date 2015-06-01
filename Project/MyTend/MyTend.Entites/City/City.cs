namespace MyTend.Entites
{
    using Castle.ActiveRecord;
    using Castle.Components.Validator;

    [ActiveRecord("Citys")]
    public class City : BaseEntity<City>
    {
        [Property]
        [ValidateNonEmpty]
        public string Name { get; set; }

        [BelongsTo("regionid")]
        [ValidateNonEmpty]
        public Region Region { get; set; }
    }
}
