using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class DB2
    {
        MySqlConnection connection1 = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=teacher");
        public void openConnection1()
        {
            if (connection1.State == System.Data.ConnectionState.Closed)
            {
                connection1.Open();
            }
        }
        public void closeConnection1()
        {
            if (connection1.State == System.Data.ConnectionState.Open)
            {
                connection1.Close();
            }

        }
        public MySqlConnection getConnection1()
        {
            return connection1;
        }
    }
}