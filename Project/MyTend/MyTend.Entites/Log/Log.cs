namespace MyTend.Entites
{
    using Castle.ActiveRecord;
    using MyTend.Entites.Enums;

    [ActiveRecord("Logs")]
    public class Log : BaseEntity<Log>
    {
        [Property(Length = 2000)]
        public string Message { get; set; }

        [Property(Length = 4000)]
        public string Stack { get; set; }

        [Property]
        public LogLevel Level { get; set; }

        [Property(Length = 1000)]
        public string Context { get; set; }

        [Property]
        public string UserName { get; set; }

        [Property]
        public string Agent { get; set; }

        [Property]
        public string Addr { get; set; }

        [Property]
        public string Query { get; set; }
    }
}
