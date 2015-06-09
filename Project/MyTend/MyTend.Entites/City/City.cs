﻿namespace MyTend.Entites
{
    using Castle.ActiveRecord;
    using Castle.Components.Validator;

    [ActiveRecord("Citys")]
    public class City : ActiveRecordBase<City>
    {
        [PrimaryKey]
        public int Id { get; set; }

        [Property]
        public string Name { get; set; }

        [BelongsTo("RegionId")]
        public Region Region { get; set; }

        public City()
        {
            this.Name = string.Empty;
            this.Region = null;
        }
    }
}