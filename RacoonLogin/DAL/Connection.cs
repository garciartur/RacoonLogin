using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacoonLogin.DAL
{
    public class Connection
    {
        public SqlConnection connection = new SqlConnection();

        public Connection()
        {
            //@"" usado antes de string de caminho - Connection String
            connection.ConnectionString = @"Data Source=DESKTOP-UEEVM2L;Initial Catalog=RacoonLogin;Integrated Security=True";
        }

        public SqlConnection Connect()
        {
            if (connection.State == System.Data.ConnectionState.Closed) 
                connection.Open();

            return connection;
        }

        public SqlConnection Disconnect()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();

            return connection;
        }
    }
}
