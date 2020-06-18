using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class DbCommand
    {
        private DbConnection _dbConnection;
        private string _sqlInstruction;
        public DbCommand(DbConnection dbConnection, string sqlInstruction)
        {
            if(dbConnection == null || String.IsNullOrEmpty(sqlInstruction))
            {
                throw (new ArgumentNullException());
            }
            _dbConnection = dbConnection;
            _sqlInstruction = sqlInstruction;
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine(_sqlInstruction);
            _dbConnection.CloseConnection();
        }


    }
}
