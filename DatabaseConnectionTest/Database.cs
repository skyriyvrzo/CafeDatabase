using CSharp.Util.Logging;
using MySql.Data.MySqlClient;
using System;

namespace DatabaseConnectinoTest
{
    public sealed class Database
    {
        private Logger logger = Logger.GetLogger("connection_log", true, true , true);

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
                logger.Log(Level.INFO, "Client", nameof(Database), "Connected");
                return true;
            }
            catch (Exception ex)
            {
                logger.Log(Level.ERROR, "Client", nameof(Database), ex.Message);
                return false;
            }
        }

        public bool DisconnectDatabase()
        {
            try
            {
                connection.Close();
                logger.Log(Level.INFO, "Client", nameof(Database), "Disconnected");
                return true;
            }
            catch (Exception ex)
            {
                logger.Log(Level.ERROR, "Client", nameof(Database), ex.Message);
                return false;
            }
        }
    }
}