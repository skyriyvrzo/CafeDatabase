using CSharp.Lang;
using CSharp.Util.Logging;
using MySql.Data.MySqlClient;
using System;

namespace DatabaseConnectinoTest
{
    internal class DCT
    {
        public static Logger logger = Logger.GetLogger("", true, true, false);

        static void Main(string[] args)
        {
            TryInsert tryInsert = new TryInsert();
            tryInsert.Start();
        }
    }

    class TryConnect : Thread
    {
        public override void Run()
        {
            Database database = new Database();
            database.ConnectDatabase();
            database.DisconnectDatabase();
        }
    }

    class TryInsert : Thread
    {
        public override void Run()
        {
            Database database = new Database();
            string query = "insert into employees (EMPLOYEE_ID, FIRST_NAME, LAST_NAME, SEX, SALARY) values (NULL, 'TH', 'LK', 'M', '12757')";
            
            if(database.ConnectDatabase())
            {
                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, database.connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }catch(System.Exception e)
                {
                    Console.WriteLine(e);
                }
                database.DisconnectDatabase();
            }
        }
    }
}
