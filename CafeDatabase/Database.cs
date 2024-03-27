using MySql.Data.MySqlClient;
using System;

namespace CafeDatabase
{
    public sealed class Database
    {
        static readonly string conString = "datasource=sql.cafeempty.net;" +
            "port=3307;" +
            "database=performance_schema;" +
            "username=root;" +
            "password=;";
        public MySqlConnection connection = new MySqlConnection(conString);

        public bool Connect_DB()
        {
            try
            {
                connection.Open();
                Console.WriteLine("connected");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Disconnect_DB()
        {
            try
            {
                connection.Close();
                Console.WriteLine("disconnected");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}