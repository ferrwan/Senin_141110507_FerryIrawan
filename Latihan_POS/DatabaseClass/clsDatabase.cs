using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Latihan_POS.DatabaseClass
{
    class clsDatabase
    {
        private static string stringConnection = "SERVER=10.0.2.2; DATABASE=latihan_pos; UID=ferr; password=ferr";
        public static MySqlConnection conn = new MySqlConnection(stringConnection);

        public static void openConnection()
        {
            try
            {
                conn.Open();
            }
            catch (MySqlException err)
            {
                throw new Exception(err.Message);
            }
        }
        public static void closeConnection()
        {
            if(conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }
    }
}
