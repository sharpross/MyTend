namespace MyTend.Entites
{
    using Castle.ActiveRecord;
    using Castle.Components.Validator;
    using System;
    using System.Collections.Generic;

    public class BaseEntity<T> : ActiveRecordBase<T> where  T : class 
    {
        [ValidateNonEmpty("Укажите дату создания")]
        [Property]
        public DateTime CreatedDateTime { get; set; }

        public List<string> Errors { get; set; }

        [PrimaryKey(PrimaryKeyType.Native)]
        public int Id { get; set; }

        public BaseEntity()
        {
            this.Errors = new List<string>();
            this.Id = 0;
            this.CreatedDateTime = DateTime.Now;
        }

        public bool IsValid()
        {
            IValidatorRunner runner = new ValidatorRunner(new CachedValidationRegistry());

            if (runner.IsValid(this))
            {
                return true;
            }

            this.Errors.Clear();
            this.Errors.AddRange(runner.GetErrorSummary(this).ErrorMessages);

            if (this.Errors.Contains("Login is currently in use. Please pick up a new Login."))
            {
                this.Errors.Remove("Login is currently in use. Please pick up a new Login.");
                this.Errors.Add("Такой логин уже используется. Пожалуйста выберите другой логин.");
            }
            if (this.Errors.Contains("Email is currently in use. Please pick up a new Email."))
            {
                this.Errors.Remove("Email is currently in use. Please pick up a new Email.");
            }
            if (this.Errors.Contains("Phone is currently in use. Please pick up a new Phone."))
            {
                this.Errors.Remove("Phone is currently in use. Please pick up a new Phone.");
                this.Errors.Add("Данный номер телефона занят. Укажите другой номер.");
            }
            
            return false;
        }

        public static T GetById(int id)
        {
            try
            {
                var obj = FindByPrimaryKey(id);

                return (T)obj;
            }
            catch
            {
                return null;
            }
        }

        public static T[] GetByProp(string proppertyName, object value)
        {
            try
            {
                var obj = FindAllByProperty(proppertyName, value);

                return (T[])obj;
            }
            catch
            {
                return null;
            }
        }
    }
}
