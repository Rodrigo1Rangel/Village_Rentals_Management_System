using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace VillageRentalsMS.Utilities
{
    internal class DatabaseSingleton
    {

        private static OracleConnection _conn = null;

        public static OracleConnection Connection
        {
            get
            {
                if (_conn == null)
                {
                    string connString = "User Id=villagerentals;Password=password;Data Source=localhost:1521/XE;";

                    _conn = new OracleConnection(connString);

                    _conn.Open();
                }

                return _conn;
            }
        }
    }
}
