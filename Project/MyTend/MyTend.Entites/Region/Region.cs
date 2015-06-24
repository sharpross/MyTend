namespace MyTend.Entites
{
    using Castle.ActiveRecord;
    using Castle.Components.Validator;

    [ActiveRecord("Regions")]
    public class Region : BaseEntity<Region>
    {
        //[PrimaryKey]
        //public int Id { get; set; }

        [Property]
        public string Name { get; set; }

        [BelongsTo("CountryId")]
        public Country Country { get; set; }

        [Property]
        public int NomberSort { get; set; }

        public Region()
        {
            this.Name = string.Empty;
            this.Country = null;
            this.NomberSort = 0;
        }
    }
}
