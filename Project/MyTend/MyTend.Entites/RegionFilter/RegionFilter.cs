namespace MyTend.Entites
{
    using Castle.ActiveRecord;
    using MyTend.Entites.Enums;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [ActiveRecord("Images")]
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
