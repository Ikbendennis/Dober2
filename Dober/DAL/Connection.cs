using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Dober
{
    public class Connection
    {
        string connectionstring = "Server=studmysql01.fhict.local;Uid=dbi344709;Database=dbi344709;Pwd=";
        MySqlConnection conn = null;
        public MySqlConnection Conn { get => conn; }

        public Connection()
        {
            StartConnection();
        }
        public void StartConnection()
        {
            try
            {
                conn = new MySqlConnection(connectionstring);

                conn.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
        }
        public void CloseConnection()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
