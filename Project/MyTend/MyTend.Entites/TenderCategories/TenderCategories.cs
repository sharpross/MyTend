namespace MyTend.Entites
{
    using Castle.ActiveRecord;
    using Castle.Components.Validator;

    [ActiveRecord("UserMessages")]
    public class TenderCategories : ActiveRecordBase<TenderCategories>
    {
        [PrimaryKey(PrimaryKeyType.Native)]
        public int Id { get; set; }

        [Property]
        [ValidateNonEmpty]
        public string Name { get; set; }

        [Property]
        [ValidateNonEmpty]
        public string Category { get; set; }

        public TenderCategories()
        {
            this.Name = string.Empty;
            this.Category = string.Empty;
        }
    }
}
