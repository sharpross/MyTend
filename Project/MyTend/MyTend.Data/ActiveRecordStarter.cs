using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework;
using Castle.ActiveRecord.Framework.Config;

namespace MyTend.Data
{
    public class ActiveRecordStarter
    {
        private List<Type> entities { get; set; }

        public void Add(Type type)
        {
            if (!this.entities.Contains(type))
            {
                this.entities.Add(type);
            }
        }

        public void Initialize()
        {
            IConfigurationSource config = null;

            IDictionary<string, string> properties = new Dictionary<string, string>();

            properties.Add("connection.driver_class", "NHibernate.Driver.SqlClientDriver");
            properties.Add("dialect", "NHibernate.Dialect.MsSql2000Dialect");
            properties.Add("connection.provider", "NHibernate.Connection.DriverConnectionProvider");
            properties.Add("connection.connection_string", "Data Source=.;Initial Catalog=test;Integrated Security=SSPI");

            InPlaceConfigurationSource source = new InPlaceConfigurationSource();

            source.Add(typeof(ActiveRecordBase), properties);

            foreach (var t in this.entities)
            {
                
            }
        }
    }
}
