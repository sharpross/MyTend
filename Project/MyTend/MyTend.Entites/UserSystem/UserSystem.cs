namespace MyTend.Entites
{
    using Castle.ActiveRecord;
    using Castle.Components.Validator;

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

        [Property]
        public string Skype { get; set; }

        [Property]
        public string VKontakte { get; set; }

        [Property]
        public string Facebook { get; set; }

        [Property]
        public string Site { get; set; }

        [Property]
        public string Instagram { get; set; }

        [Property]
        public string Phone { get; set; }

        [Property]
        public string Phone2 { get; set; }

        [ValidateNonEmpty("Укажите регион")]
        [BelongsTo("regionid")]
        public Region Region { get; set; }

        [ValidateNonEmpty("Укажите город")]
        [BelongsTo("cityid")]
        public City City { get; set; }

        [Property]
        public string AboutFull { get; set; }

        [Property]
        public string AboutShort { get; set; }

        [Property]
        public string Portfolio { get; set; }
    }
}
