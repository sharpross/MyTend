namespace MyTend.Entites
{
    using Castle.ActiveRecord;
    using MyTend.Entites.Enums;

    [ActiveRecord("RegionFilters")]
    public class RegionFilter : BaseEntity<RegionFilter>
    {
        [BelongsTo("UserId")]
        public UserSystem User { get; set; }

        [Property]
        public SubRegionType Type { get; set; }

        [BelongsTo("CityId")]
        public City City { get; set; }

        [BelongsTo("RegionId")]
        public Region Region { get; set; }
    }
}
