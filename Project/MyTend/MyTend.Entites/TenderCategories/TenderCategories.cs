namespace MyTend.Entites
{
    using Castle.ActiveRecord;
    using Castle.Components.Validator;

    [ActiveRecord("UserMessages")]
    public class TenderCategories : BaseEntity<TenderCategories>
    {
        [Property]
        [ValidateNonEmpty]
        public string Name { get; set; }

        [Property]
        [ValidateNonEmpty]
        public string Category { get; set; }
    }
}
