namespace MyTend.Entites
{
    using Castle.ActiveRecord;
    using Castle.Components.Validator;
    using MyTend.Entites.Block;
    using System;
    using System.Linq;

    [ActiveRecord("users")]
    public class UserSystem : BaseEntity<UserSystem>
    {
        [Property]
        [ValidateNonEmpty("Укажите своё имя")]
        public string FullName { get; set; }

        [Property]
        [ValidateIsUnique("Такой логин уже существует")]
        [ValidateEmail("Укажите карректный почтовый адрес")]
        [ValidateNonEmpty("Логин не может быть пустым")]
        public string Login { get; set; }

        [Property]
        [ValidateNonEmpty("Пароль не может быть пустым")]
        public string Password { get; set; }

        [Property]
        [ValidateIsUnique("Такой почтовый адрес уже существует")]
        [ValidateEmail("Укажите карректный почтовый адрес.")]
        [ValidateNonEmpty("Почтовый адрес не может быть пустым")]
        public string Email { get; set; }

        [Property(Length = 255)]
        public string Skype { get; set; }

        [Property(Length = 255)]
        public string VKontakte { get; set; }

        [Property(Length = 255)]
        public string Facebook { get; set; }

        [Property(Length = 255)]
        public string Youtube { get; set; }

        [Property(Length = 255)]
        public string Site { get; set; }

        [Property(Length = 255)]
        public string Instagram { get; set; }

        [Property(Length = 255)]
        [ValidateIsUnique("Такой номер телефона уже используется")]
        [ValidateNonEmpty("Укажите номер телефона")]
        public string Phone { get; set; }
        
        [ValidateNonEmpty("Укажите регион")]
        [BelongsTo]
        public Region Region { get; set; }

        [ValidateNonEmpty("Укажите город")]
        [BelongsTo]
        public City City { get; set; }

        [Property(Length = 5000)]
        public string AboutFull { get; set; }

        [Property(Length = 255)]
        public string AboutShort { get; set; }

        [Property(Length = 5000)]
        public string Portfolio { get; set; }

        [BelongsTo]
        public FileSystem Avatar { get; set; }

        [Property()]
        public DateTime SubToDate { get; set; }

        [Property()]
        public bool Activated { get; set; }

        public bool IsBlocked
        {
            get
            {
                var blocks = BlockUser.FindAll()
                    .Any(x => x.DateTo > DateTime.Now);

                return blocks;
            }
        }

        public UserSystem()
        {
            this.SubToDate = DateTime.Now.AddDays(-30);
        }
    }
}
