using CSharp.Util.Logging;
using Main.Events.DrinkEvent;
using Main.Events.OrderEvent;
using Main.Events.ScreenChangeEvent;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace Main.Events.OrderDetailEvent
{
#pragma warning disable IDE1006
    internal sealed class OrderDetailStartupEvent
    {
        internal static void load(OrderDetail od)
        {
            try
            {
                onStartup(od);
                Thread thread1 = new Thread(() => registerItemsInComboBox(od));
                Thread thread2 = new Thread(() => registerDataGridView(od));
                thread1.Start();
                thread2.Start();

                Program.logger.Log(Level.INFO, nameof(load), nameof(OrderDetailStartupEvent), nameof(OrderDetailStartupEvent) + " Loaded");
            }
            catch (Exception e)
            {
                Program.logger.Log(Level.ERROR, nameof(load), nameof(OrderDetailStartupEvent) + "/" + e.GetType().Name, e.Message);
            }
        }

        private static void onStartup(OrderDetail od)
        {
            od.cb_order.Focus();
            od.dataGridView1.ReadOnly = true;

            ResetEvent.reset();
            Program.logger.Log(Level.INFO, nameof(onStartup), nameof(OrderDetailStartupEvent), nameof(onStartup) + " Loaded");
        }

        private static void registerItemsInComboBox(OrderDetail od)
        {
            Database database = new Database();

            try
            {
                if (database.ConnectDatabase())
                {
                    string query = "select ORDER_ID from `order`";
                    using (MySqlCommand command = new MySqlCommand(query, database.connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            od.cb_order.DataSource = dataTable;
                            od.cb_order.DisplayMember = "ORDER_ID";
                            od.cb_order.ValueMember = "ORDER_ID";
                            od.cb_order.SelectedItem = null;
                        }
                    }

                    query = "select DRINK_ID, DRINK_NAME, Concat(DRINK_NAME, Concat(' (', Concat(DRINK_ID, ')'))) as Name from `drink`";
                    using (MySqlCommand command = new MySqlCommand(query, database.connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            od.cb_drink.DataSource = dataTable;
                            od.cb_drink.DisplayMember = "Name";
                            od.cb_drink.ValueMember = "DRINK_ID";
                            od.cb_drink.SelectedItem = null;
                        }
                    }

                    query = "select TOPPING_ID, TOPPING_NAME, Concat(TOPPING_NAME, Concat(' (', Concat(TOPPING_ID, ')'))) as Name from `topping`";
                    using (MySqlCommand command = new MySqlCommand(query, database.connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            od.cb_topping.DataSource = dataTable;
                            od.cb_topping.DisplayMember = "Name";
                            od.cb_topping.ValueMember = "TOPPING_ID";
                            od.cb_topping.SelectedItem = null;
                        }
                    }
                    database.DisconnectDatabase();
                }
                Program.logger.Log(Level.INFO, nameof(registerItemsInComboBox), nameof(OrderDetailStartupEvent), nameof(registerItemsInComboBox) + " Loaded");
            }
            catch (System.Exception e)
            {
                Program.logger.Log(Level.ERROR, nameof(registerItemsInComboBox), nameof(OrderDetailEvent) + "/" + e.GetType().Name, e.Message);
                database.DisconnectDatabase();
            }
        }

        internal static void registerDataGridView(OrderDetail od)
        {
            Database database = new Database();

            try
            {
                if (database.ConnectDatabase())
                {
                    string query = "select * from `order_detail`";

                    using (MySqlCommand command = new MySqlCommand(query, database.connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            od.dataGridView1.DataSource = dataTable;
                        }
                    }
                    database.DisconnectDatabase();
                    Program.logger.Log(Level.INFO, nameof(registerDataGridView), nameof(OrderDetailStartupEvent), "Successfully added items");
                }

                od.dataGridView1.ClearSelection();
                /*
                 * Resize the table to fit the data grid view
                 */
                od.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                Program.logger.Log(Level.INFO, nameof(registerDataGridView), nameof(OrderDetailStartupEvent), nameof(registerDataGridView) + " Loaded");
            }
            catch (System.Exception e)
            {
                Program.logger.Log(Level.ERROR, nameof(registerDataGridView), nameof(OrderDetailStartupEvent) + "/" + e.GetType().Name, e.Message);
                database.DisconnectDatabase();
            }
        }
    }
}
