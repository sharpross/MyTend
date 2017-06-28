namespace MyTend.Entites.Contacts
{
    using Castle.ActiveRecord;
    using Castle.Components.Validator;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [ActiveRecord("Contacts")]
    public class Contact : BaseEntity<Contact>
    {
        [BelongsTo("UserId")]
        [ValidateNonEmpty("Неизвестный пользователь")]
        public UserSystem User { get; set; }

        [BelongsTo("FriendId")]
        [ValidateNonEmpty("Неизвестный пользователь")]
        public UserSystem Friend { get; set; }
    }
}
