namespace MyTend.Data
{
    using Castle.ActiveRecord;
    using Castle.ActiveRecord.Framework.Config;
    using MyTender.Core;
    using System;
    using System.Collections.Generic;
    using System.Reflection;
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

            Assembly asm = Assembly.Load("MyTend.Entites");

            ActiveRecordStarter.Initialize(asm, new XmlConfigurationSource(cfgPath));

            if (Constants._CREATE_SCHEME)
            {
                ActiveRecordStarter.CreateSchema();
            }
        }
    }
}
