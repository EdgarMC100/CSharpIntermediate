using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{

    public class OracleConnection : DbConnection
    {
        public override void OpenConnection()
        {
            Console.WriteLine("Openning Connection");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Closing Connection");
        }
    }
    public class SqlConnection : DbConnection
    {
        public override void OpenConnection()
        {
            Console.WriteLine("Openning Connection");
        }
        public  override void CloseConnection()
        {
            Console.WriteLine("Closing Connection");
        }
    }
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection()
        {
            ConnectionString = String.Empty;
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    

    }
}
