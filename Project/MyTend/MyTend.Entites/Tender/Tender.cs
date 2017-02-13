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

        /// <summary>
        /// Тема тендера
        /// </summary>
        [ValidateNonEmpty("Укажите тему тендера")]
        [BelongsTo("ThemeId")]
        public TenderTheme Theme { get; set; }

        /// <summary>
        /// Открытый или закрытый тендер (не используется)
        /// </summary>
        [Property]
        public bool IsOpen { get; set; }

        /// <summary>
        /// Разрешить писать мне (не используется!!!)
        /// </summary>
        [Property]
        public bool AllowWriteMe { get; set; }

        /// <summary>
        /// Приблизительная стоимость
        /// </summary>
        [Property]
        public decimal Cost { get; set; }

        /// <summary>
        /// Приблизительная стоимость
        /// </summary>
        [Property]
        public decimal CountGuests { get; set; }

        /// <summary>
        /// Заголовок тендера
        /// </summary>
        [ValidateNonEmpty("Укажите заголовок тендера")]
        [Property]
        public string Title { get; set; }

        /// <summary>
        /// Сообщение тендера
        /// </summary>
        [ValidateNonEmpty("Укажите сообщение тендера")]
        [Property(Length=12000)]
        public string Message { get; set; }

        /// <summary>
        /// Дата окончания тендера
        /// </summary>
        [ValidateNonEmpty("Укажите дату окончания тендера")]
        [Property]
        public DateTime DateEnd { get; set; }
        
        /// <summary>
        /// Дата окончания тендера
        /// </summary>
        [Property]
        public string EventDay { get; set; }

        /// <summary>
        /// Дата окончания тендера
        /// </summary>
        [Property]
        public string EventTime { get; set; }

        /// <summary>
        /// Тендер активен/закрыт
        /// </summary>
        [Property]
        public bool IsActive { get; set; }

        public void SetWinner(UserSystem user)
        {
            if (this.Winner != null)
            {
                throw new Exception("Победитель уже выбран");
            }

            this.Winner = user;
            this.IsActive = false;
            this.Update();
        }

        public void Cancel()
        {
            this.IsActive = false;
            this.Update();
        }

        public Tender()
        {
            this.IsActive = true;
        }
    }
}
