using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProizvoAvto
{
    internal class DB
    {
        private MySqlConnection connection = new MySqlConnection("server=MySQL-8.4; port=3306; username=root; password=; " +
           "database=proizvo_avto;");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed) { connection.Open(); }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open) { connection.Close(); }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
