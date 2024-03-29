using CSharp.Lang;
using CSharp.Util.Logging;
using MySql.Data.MySqlClient;
using System;
using static CSharp.Lang.Annotation;

namespace DatabaseConnectinoTest
{
    internal class DCT
    {
        public static Logger logger = Logger.GetLogger("", true, true, false);

        static void Main(string[] args)
        {
            TryInsert tryInsert = new TryInsert();
            tryInsert.Start();
            Console.ReadKey();
        }
    }

    [Deprecated]
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
        private Logger logger = Logger.GetLogger("", true, true, false);

        public override void Run()
        {
            Database database = new Database();
            string query = "insert into employees (Emp_Id, Emp_FirstName, Emp_LastName, Emp_Sex, Emp_Salary) values ('55555', 'TH', 'LK', 'M', '99999')";
            
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
                    logger.Log(Level.ERROR, "Server", nameof(TryInsert), e.Message);
                }
                database.DisconnectDatabase();
            }
        }
    }
}
