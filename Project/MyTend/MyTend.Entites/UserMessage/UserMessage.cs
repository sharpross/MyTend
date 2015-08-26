namespace MyTend.Entites
{
    using Castle.ActiveRecord;
    using Castle.Components.Validator;
    using System;

    [ActiveRecord("UserMessages")]
    public class UserMessage : BaseEntity<UserMessage>
    {
        [Property(Length = 1000)]
        [ValidateNonEmpty]
        public string Message { get; set; }

        [Property]
        public DateTime Date { get; set; }

        [Property]
        public bool IsRead { get; set; }

        [BelongsTo("FromId")]
        public UserSystem From { get; set; }

        [BelongsTo("ToId")]
        public UserSystem To { get; set; }

        public UserMessage()
        {
            this.IsRead = false;
        }
    }
}
