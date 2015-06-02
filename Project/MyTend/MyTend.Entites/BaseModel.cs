using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTend.Entites
{
    public class BaseModel<T> where T : BaseEntity<T>
    {
        public void Save()
        {
            try
            {
                this.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
