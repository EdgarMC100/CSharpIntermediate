using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //var migration = new Migration(new ConsoleLogger());
            var migration = new Migration(new FileLogger("C:\\Projects\\log.txt"));
            migration.Migrate();
        }
    }
}
