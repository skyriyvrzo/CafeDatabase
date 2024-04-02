using CSharp.Util.Logging;
using Main.Events.EmployeeEvent;
using Main.Events.ScreenChangeEvent;
using MySql.Data.MySqlClient;
using System.Data;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace Main.Events.OrderEvent
{
#pragma warning disable IDE1006
    internal sealed class OrderStartupEvent
    {
        internal static void load(OrdersDetail o)
        {
            try
            {
                onStartup(o);
                registerItemsInComboBox(o);
                registerDataGridView(o);
                Program.logger.Log(Level.INFO, nameof(OrderStartupEvent) + " Loaded");
            }
            catch (System.Exception e)
            {
                Program.logger.Log(Level.ERROR, nameof(load), nameof(OrderStartupEvent) + "/" + e.GetType().Name, e.Message);
            }
        }

        private static void onStartup(OrdersDetail o)
        {
            o.cb_drink_id.Focus();
            o.dataGridView1.ReadOnly = true;

            ResetEvent.reset();
            Program.logger.Log(Level.INFO, nameof(onStartup) + " Loaded");
        }

        private static void registerItemsInComboBox(OrdersDetail o)
        {
            Database database = new Database();

            try
            {
                if (database.ConnectDatabase())
                {
                    string query = "select EMPLOYEE_ID, FIRST_NAME, Concat(FIRST_NAME, Concat(' (', Concat(EMPLOYEE_ID, ')'))) as Name from `employees`";
                    using(MySqlCommand command = new MySqlCommand(query, database.connection))
                    {
                        using(MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            o.cb_emp.DataSource = dataTable;
                            o.cb_emp.DisplayMember = "Name";
                            o.cb_emp.ValueMember = "EMPLOYEE_ID";
                            o.cb_emp.SelectedItem = null;
                        }
                    }

                    query = "select DRINK_ID, DRINK_NAME, Concat(DRINK_NAME, Concat(' (', Concat(DRINK_ID, ')'))) as Name from `drink`";
                    using(MySqlCommand command = new MySqlCommand(query, database.connection))
                    {
                        using(MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            o.cb_drink_id.DataSource = dataTable;
                            o.cb_drink_id.DisplayMember = "Name";
                            o.cb_drink_id.ValueMember = "DRINK_ID";
                            o.cb_drink_id.SelectedItem = null;
                        }
                    }

                    query = "select TOPPING_ID, TOPPING_NAME, Concat(TOPPING_NAME, Concat(' (', Concat(TOPPING_ID, ')'))) as Name from `topping`";
                    using (MySqlCommand command = new MySqlCommand(query, database.connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            o.cb_topping_id.DataSource = dataTable;
                            o.cb_topping_id.DisplayMember = "Name";
                            o.cb_topping_id.ValueMember = "TOPPING_ID";
                            o.cb_topping_id.SelectedItem = null;
                        }
                    }
                    database.DisconnectDatabase();
                }
                Program.logger.Log(Level.INFO, nameof(registerItemsInComboBox) + " Loaded");
            }catch(System.Exception e)
            {
                Program.logger.Log(Level.ERROR, nameof(registerItemsInComboBox), nameof(OrderStartupEvent) + "/" + e.GetType().Name, e.Message);
                database.DisconnectDatabase();
            }

        }

        internal static void registerDataGridView(OrdersDetail o)
        {
            Database database = new Database();

            try
            {
                if (database.ConnectDatabase())
                {
                    string query = "SELECT o.ORDER_ID, od.DRINK_ID, od.TOPPING_ID, od.QUANTITY, o.ORDER_DATE, o.EMPLOYEE_ID from `order` o join `order_detail` od where o.ORDER_ID = od.ORDER_ID";

                    using (MySqlCommand command = new MySqlCommand(query, database.connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            o.dataGridView1.DataSource = dataTable;
                        }
                    }
                    database.DisconnectDatabase();
                    Program.logger.Log(Level.INFO, nameof(registerDataGridView) + " Successfully added item");
                }

                o.dataGridView1.ClearSelection();
                /*
                 * Resize the table to fit the data grid view
                 */
                o.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                Program.logger.Log(Level.INFO, nameof(registerDataGridView) + " Loaded");
            }
            catch (System.Exception e)
            {
                Program.logger.Log(Level.ERROR, nameof(registerDataGridView), nameof(OrderStartupEvent) + "/" + e.GetType().Name, e.Message);
                database.DisconnectDatabase();
            }
        }
    }
}
