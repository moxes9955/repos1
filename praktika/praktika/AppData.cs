using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika
{
    internal class AppData
    {
        public static Entities.AttachedProductEntities Context
        { get; } = new Entities.AttachedProductEntities();
    }
}
