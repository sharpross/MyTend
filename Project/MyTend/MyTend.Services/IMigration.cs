using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTend.Services
{
    public interface IMigration
    {
        string Code { get; }

        void Migrate();

        bool NeedMigrate();
    }
}
