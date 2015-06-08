namespace MyTend.Entites
{
    using Castle.ActiveRecord;
    using Castle.Components.Validator;

    [ActiveRecord("Images")]
    public class Image : ActiveRecordBase<Image>
    {
        [PrimaryKey(PrimaryKeyType.Native)]
        public int Id { get; set; }

        [Property]
        [ValidateNonEmpty]
        public string Name { get; set; }

        [Property]
        public byte[] Data { get; set; }

        [Property]
        [ValidateNonEmpty]
        public string MimeType { get; set; }
    }
}
