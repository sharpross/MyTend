namespace MyTend.Entites
{
    using Castle.ActiveRecord;
    using Castle.Components.Validator;

    [ActiveRecord("Regions")]
    public class Region : BaseEntity<Region>
    {
        [Property]
        [ValidateNonEmpty]
        public string Name { get; set; }

        [BelongsTo("CountryId")]
        public Country Country { get; set; }

        [BelongsTo("CountryId")]
        [ValidateNonEmpty]
        public int NomberSort { get; set; }
    }
}
