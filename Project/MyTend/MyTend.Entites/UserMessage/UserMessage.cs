namespace MyTend.Entites
{
    using Castle.ActiveRecord;
    using Castle.Components.Validator;
    using System;

    [ActiveRecord("UserMessages")]
    public class UserMessage : ActiveRecordBase<UserMessage>
    {
        [PrimaryKey(PrimaryKeyType.Native)]
        public int Id { get; set; }

        [Property]
        [ValidateNonEmpty]
        public string Message { get; set; }

        [Property]
        public DateTime Date { get; set; }

        [BelongsTo("FromId")]
        public UserSystem From { get; set; }

        [BelongsTo("ToId")]
        public UserSystem To { get; set; }
    }
}
