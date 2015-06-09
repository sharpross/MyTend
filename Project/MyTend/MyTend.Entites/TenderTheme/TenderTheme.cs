﻿namespace MyTend.Entites
{
    using Castle.ActiveRecord;
    using Castle.Components.Validator;

    [ActiveRecord("TenderTheme")]
    public class TenderTheme : ActiveRecordBase<TenderTheme>
    {
        [PrimaryKey(PrimaryKeyType.Native)]
        public int Id { get; set; }

        [Property]
        [ValidateNonEmpty]
        public string Title { get; set; }

        [Property]
        [ValidateNonEmpty]
        public string Theme { get; set; }

        [Property]
        [ValidateNonEmpty]
        public string ImageName { get; set; }

        [Property]
        public bool IsTitle { get; set; }

        [Property]
        public int NomberInList { get; set; }

        public TenderTheme()
            : base()
        {
            this.Title = string.Empty;
            this.Theme = string.Empty;
            this.IsTitle = false;
            this.ImageName = string.Empty;
            this.NomberInList = 0;
        }

        public static bool IsValid(object obj)
        {
            IValidatorRunner runner = new ValidatorRunner(new CachedValidationRegistry());

            if (runner.IsValid(obj))
            {
                return true;
            }

            return false;
        }
    }
}
