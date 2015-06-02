namespace MyTend.Data
{
    using Castle.ActiveRecord;
    using Castle.ActiveRecord.Framework.Config;
    using System;
    using System.Collections.Generic;
    using System.Web.Hosting;

    public class DataBaseStarter
    {
        public DataBaseStarter()
        {
            this.entities = new List<Type>();
        }

        private List<Type> entities { get; set; }

        public void Add(Type type)
        {
            this.entities.Add(type);
        }

        public void Add(Type[] types)
        {
            this.entities.AddRange(types);
        }

        public void Initialize()
        {
            var cfgPath = string.Format(
                "{0}{1}",
                HostingEnvironment.ApplicationPhysicalPath,
                "dbconfig.config");

            ActiveRecordStarter.Initialize(new XmlConfigurationSource(cfgPath), this.entities.ToArray());
        }
    }
}
