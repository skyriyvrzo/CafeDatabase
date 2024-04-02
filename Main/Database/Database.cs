using CSharp.Util.Logging;
using MySql.Data.MySqlClient;
using System;

namespace Main
{
    public sealed class Database
    {
        private Logger logger = Logger.GetLogger("connection_log", true, true, true);

        static readonly string conString = "datasource=localhost;" +
            "port=3306;" +
            "database=cafe_db;" +
            "username=root;" +
            "password=;";
        public MySqlConnection connection = new MySqlConnection(conString);

        public bool ConnectDatabase()
        {
            try
            {
                connection.Open();
                logger.Log(Level.INFO, "Client", connection.DataSource, "Connected");
                return true;
            }
            catch (Exception ex)
            {
                logger.Log(Level.WARNING, "Client", connection.DataSource, ex.Message);
                return false;
            }
        }

        public bool DisconnectDatabase()
        {
            try
            {
                connection.Close();
                logger.Log(Level.INFO, "Client", connection.DataSource, "Disconnected");
                return true;
            }
            catch (Exception ex)
            {
                logger.Log(Level.WARNING, "Client", connection.DataSource, ex.Message);
                return false;
            }
        }
    }
}