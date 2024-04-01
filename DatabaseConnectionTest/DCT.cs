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
            string query = $"insert into orders (Order_Id, Order_Date, Emp_Id) values ('465456', '{DateTime.Now.ToString("yyyy-MM-dd h:mm:ss.fffff")}', '55555')";

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
            string query = "insert into drinks (Drink_Id, Drink_Name, Drink_Price, Drink_Status) values ('25164', 'iuenfekwjfew', '50', '1')";

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
            string query = "insert into materials (Material_Id, Material_Name) values ('784', 'we8fbjdsf')";

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
            string query = "insert into toppings (Topping_Id, Topping_Name, Topping_Price) values ('710', '9qwjoknmlkg', '2000')";

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
            string query = "insert into orders_detail (Order_Id, Drink_Id, Topping_Id, Quantity) values ('465456', '25164', '710', '5')";

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
            string query = "insert into material_of_drink (Drink_Id, Material_Id) values ('25164', '784')";

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
