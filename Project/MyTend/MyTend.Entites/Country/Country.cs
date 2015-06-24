namespace MyTend.Entites
{
    using Castle.ActiveRecord;
    using Castle.Components.Validator;

    [ActiveRecord("Countrys")]
    public class Country : BaseEntity<Country>
    {
        //[PrimaryKey]
        //public int Id { get; set; }

        [Property]
        public string Name { get; set; }

        public Country()
        {
            this.Name = string.Empty;
        }
    }
}
