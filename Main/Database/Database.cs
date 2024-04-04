using CSharp.Util.Logging;
using MySql.Data.MySqlClient;
using System;

namespace Main
{
    public sealed class Database
    {
        private Logger logger = Logger.GetLogger("connection_log", true, true, true);

        static readonly string conString = "datasource=sql.cafeempty.net;" +
            "port=3307;" +
            "database=cafe_db;" +
            "username=lowidea;" +
            "password=LowIdea66;";
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