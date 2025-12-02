using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingIn.Classes
{
    public class WorkingDB
    {
        public static readonly string config = "server=127.0.0.1;uid=root;pwd=;database=regin";
        public static MySqlConnection OpenConnection()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(config);
                connection.Open();

                return connection;
            }
            catch (Exception exp) 
            {
                Debug.WriteLine(exp.Message);
                return null;
            }
        }

        public static MySqlDataReader Query(string SQL,out MySqlConnection connection)
        {
            connection = OpenConnection();

            MySqlCommand command = new MySqlCommand(SQL, connection);
            return command.ExecuteReader();
        }

        public static void CloseConnection(MySqlConnection connection)
        {
            connection.Close();
            MySqlConnection.ClearPool(connection);
        }
        public static bool OpenConnection(MySqlConnection connection)
        {
            return connection != null && connection.State  == System.Data.ConnectionState.Open;
        }
    }
}
