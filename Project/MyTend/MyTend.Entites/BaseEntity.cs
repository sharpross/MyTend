using Castle.ActiveRecord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTend.Entites
{
    public class BaseEntity<T> : ActiveRecordBase<T> where  T : class 
    {
        [PrimaryKey(PrimaryKeyType.Native)]
        public int Id { get; set; }
    }
}
