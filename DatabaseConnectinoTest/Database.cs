using MySql.Data.MySqlClient;
using System;

namespace DatabaseConnectinoTest
{
    public sealed class Database
    {
        static readonly string conString = "datasource=sql.cafeempty.net;" +
            "port=3307;" +
            "database=cafe_db;" +
            "username=root;" +
            "password=;";
        public MySqlConnection connection = new MySqlConnection(conString);

        public bool ConnectDatabase()
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

        public bool DisconnectDatabase()
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