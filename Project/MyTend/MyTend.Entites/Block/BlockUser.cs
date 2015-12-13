namespace MyTend.Entites.Block
{
    using Castle.ActiveRecord;
    using System;

    [ActiveRecord("BlocksUser")]
    public class BlockUser : BaseEntity<BlockUser>
    {
        [BelongsTo("UserId", Cascade = CascadeEnum.All)]
        public UserSystem User { get; set; }

        [Property]
        public DateTime DateTo { get; set; }

        [Property]
        public string Log { get; set; }

        public BlockUser()
        {
            
        }
    }
}
