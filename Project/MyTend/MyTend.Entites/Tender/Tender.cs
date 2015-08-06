namespace MyTend.Entites
{
    using Castle.ActiveRecord;
    using Castle.Components.Validator;
    using System;

    [ActiveRecord("Tenders")]
    public class Tender : BaseEntity<Tender>
    {
        [BelongsTo("UserId")]
        [ValidateNonEmpty("Не известный пользователь")]
        public UserSystem User { get; set; }

        [BelongsTo("WinerId")]
        public UserSystem Winner { get; set; }

        [ValidateNonEmpty("Укажите регоион")]
        [BelongsTo("RegionId")]
        public Region Region { get; set; }

        [ValidateNonEmpty("Укажите город")]
        [BelongsTo("CityId")]
        public City City { get; set; }

        [ValidateNonEmpty("Укажите тему тендера")]
        [BelongsTo("ThemeId")]
        public TenderTheme Theme { get; set; }

        [Property]
        public bool IsOpen { get; set; }

        [Property]
        public bool AllowWriteMe { get; set; }

        [Property]
        public decimal Cost { get; set; }

        [ValidateNonEmpty("Укажите заголовок тендера")]
        [Property]
        public string Title { get; set; }

        [ValidateNonEmpty("Укажите сообщение тендера")]
        [Property]
        public string Message { get; set; }

        [ValidateNonEmpty("Укажите дату окончания тендера")]
        [Property]
        public DateTime DateEnd { get; set; }

        [Property]
        public bool IsActive { get; set; }

        public void SetWinner(UserSystem user)
        {
            this.Winner = user;
        }

        public Tender()
        {
            this.IsActive = true;
        }
    }
}
