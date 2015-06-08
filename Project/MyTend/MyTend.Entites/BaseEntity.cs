namespace MyTend.Entites
{
    using Castle.ActiveRecord;
    using Castle.Components.Validator;
    using System;
    using System.Collections.Generic;

    public class BaseEntity<T> : ActiveRecordBase<T> where  T : class 
    {
        public List<string> ListErrors { get; set; }

        [PrimaryKey(PrimaryKeyType.Native)]
        public int Id { get; set; }

        public BaseEntity()
        {
            this.ListErrors = new List<string>();
            this.Id = 0;
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
