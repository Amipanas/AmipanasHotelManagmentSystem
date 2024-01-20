using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Amipanas_Hotel
{
    class DbConnection
    {
        private MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;database=hotel_data");

        // rerturn the connection
        public MySqlConnection GetConnection()
        {
            return connection;
        }
        // open the connection
        public void OpenCon()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        // close the connection
        public void CloseCon()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
