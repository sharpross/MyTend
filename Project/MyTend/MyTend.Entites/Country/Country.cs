namespace MyTend.Entites
{
    using Castle.ActiveRecord;
    using Castle.Components.Validator;

    [ActiveRecord("Countrys")]
    public class Country : BaseEntity<Country>
    {
        [Property]
        [ValidateNonEmpty]
        public string Name { get; set; }
    }
}
