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
            TryConnect tryConnect = new TryConnect();

            TryInsertEmployee tryInEmp = new TryInsertEmployee();
            TryInsertOrders tryInOrder = new TryInsertOrders();
            TryInsertDrinks tryInDrink = new TryInsertDrinks();
            TryInsertMaterials tryInMaterial = new TryInsertMaterials();
            TryInsertToppings tryInTopping = new TryInsertToppings();
            TryInsertOrdersDetail tryInOrdersDetail = new TryInsertOrdersDetail();
            TryInsertMaterialOfDrink tryInMaterialOfDrink = new TryInsertMaterialOfDrink();

            tryInEmp.Start();
            tryInOrder.Start();
            tryInDrink.Start();
            tryInMaterial.Start();
            tryInTopping.Start();
            tryInOrdersDetail.Start();
            tryInMaterialOfDrink.Start();

            Console.ReadKey();
        }
    }

    [Obsolete]
    class TryConnect : Thread
    {
        public override void Run()
        {
            Database database = new Database();
            database.ConnectDatabase();
            database.DisconnectDatabase();
        }
    }

    class TryInsertEmployee : Thread
    {
        private readonly Logger logger = Logger.GetLogger("", true, true, false);

        public override void Run()
        {
            Database database = new Database();
            string query = "insert into employees (EMPLOYEE_ID, FIRST_NAME, LAST_NAME, SEX, SALARY) values ('55555', 'TH', 'LK', 'M', '99999')";
            
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
                    logger.Log(Level.ERROR, "Server", nameof(TryInsertEmployee), e.Message);
                }
                database.DisconnectDatabase();
            }
        }
    }

    class TryInsertOrders : Thread
    {
        private readonly Logger logger = Logger.GetLogger("", true, true, false);

        public override void Run()
        {
            Database database = new Database();
            string query = $"insert into `order` (ORDER_ID, ORDER_DATE, EMPLOYEE_ID) values ('465456', '{DateTime.Now.ToString("yyyy-MM-dd h:mm:ss.fffff")}', '55555')";

            if (database.ConnectDatabase())
            {
                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, database.connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (System.Exception e)
                {
                    logger.Log(Level.ERROR, "Server", nameof(TryInsertOrders), e.Message);
                }
                database.DisconnectDatabase();
            }
        }
    }

    class TryInsertDrinks : Thread
    {
        private readonly Logger logger = Logger.GetLogger("", true, true, false);

        public override void Run()
        {
            Database database = new Database();
            string query = "insert into drink (DRINK_ID, DRINK_NAME, DRINK_PRICE, DRINK_STATUS) values ('25164', 'iuenfekwjfew', '50', '1')";

            if (database.ConnectDatabase())
            {
                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, database.connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (System.Exception e)
                {
                    logger.Log(Level.ERROR, "Server", nameof(TryInsertDrinks), e.Message);
                }
                database.DisconnectDatabase();
            }
        }
    }

    class TryInsertMaterials : Thread
    {
        private readonly Logger logger = Logger.GetLogger("", true, true, false);

        public override void Run()
        {
            Database database = new Database();
            string query = "insert into material (MATERIAL_ID, MATERIAL_NAME) values ('784', 'we8fbjdsf')";

            if (database.ConnectDatabase())
            {
                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, database.connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (System.Exception e)
                {
                    logger.Log(Level.ERROR, "Server", nameof(TryInsertMaterials), e.Message);
                }
                database.DisconnectDatabase();
            }
        }
    }

    class TryInsertToppings : Thread
    {
        private readonly Logger logger = Logger.GetLogger("", true, true, false);

        public override void Run()
        {
            Database database = new Database();
            string query = "insert into topping (TOPPING_ID, TOPPING_NAME, TOPPING_PRICE) values ('710', '9qwjoknmlkg', '2000')";

            if (database.ConnectDatabase())
            {
                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, database.connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (System.Exception e)
                {
                    logger.Log(Level.ERROR, "Server", nameof(TryInsertToppings), e.Message);
                }
                database.DisconnectDatabase();
            }
        }
    }

    class TryInsertOrdersDetail : Thread
    {
        private readonly Logger logger = Logger.GetLogger("", true, true, false);

        public override void Run()
        {
            Database database = new Database();
            string query = "insert into order_detail (ORDER_ID, DRINK_ID, TOPPING_ID, QUANTITY) values ('465456', '25164', '710', '5')";

            if (database.ConnectDatabase())
            {
                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, database.connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (System.Exception e)
                {
                    logger.Log(Level.ERROR, "Server", nameof(TryInsertOrdersDetail), e.Message);
                }
                database.DisconnectDatabase();
            }
        }
    }

    class TryInsertMaterialOfDrink : Thread
    {
        private readonly Logger logger = Logger.GetLogger("", true, true, false);

        public override void Run()
        {
            Database database = new Database();
            string query = "insert into material_of_drink (DRINK_ID, MATERIAL_ID) values ('25164', '784')";

            if (database.ConnectDatabase())
            {
                try
                {
                    using (MySqlCommand command = new MySqlCommand(query, database.connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (System.Exception e)
                {
                    logger.Log(Level.ERROR, "Server", nameof(TryInsertMaterialOfDrink), e.Message);
                }
                database.DisconnectDatabase();
            }
        }
    }
}
