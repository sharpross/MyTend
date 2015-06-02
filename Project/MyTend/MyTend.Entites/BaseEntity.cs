using Castle.ActiveRecord;
using Castle.Components.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTend.Entites
{
    public class BaseEntity<T> : ActiveRecordBase<T> where  T : class 
    {
        public List<string> ListErrors { get; set; }

        [PrimaryKey(PrimaryKeyType.Native)]
        public int Id { get; set; }

        public static T Get(int id)
        {
            try
            {
                return Find(id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static T[] GetAll()
        {
            return FindAll();
        }

        public static void Delete(int id)
        {
            var obj = Find(id);

            if(obj != null)
            {
                Delete(id);
            }
        }

        public bool IsValid()
        {
            IValidatorRunner runner = new ValidatorRunner(new CachedValidationRegistry());

            if (runner.IsValid(this))
            {
                return true;
            }

            return false;
        }

        public override void Save()
        {
            if (this.IsValid())
            {
                base.Save();
            }
            else 
            {
                throw new Exception("Error");
            }
        }
    }
}
