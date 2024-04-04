using CSharp.Util.Logging;
using Main.Events.DrinkEvent;
using Main.Events.OrderDetailEvent;
using Main.Events.ScreenChangeEvent;
using MySql.Data.MySqlClient;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace Main.Events.OrderEvent
{
#pragma warning disable IDE1006
    internal sealed class OrderStartupEvent
    {
        internal static void load(Order o)
        {
            try
            {
                onStartup(o);
                Thread thread1 = new Thread(() => registerItemsInComboBox(o));
                Thread thread2 = new Thread(() => registerDataGridView(o));
                thread1.Start();
                thread2.Start();

                Program.logger.Log(Level.INFO, nameof(load), nameof(OrderStartupEvent), nameof(OrderStartupEvent) + " Loaded");
            }
            catch (System.Exception e)
            {
                Program.logger.Log(Level.ERROR, nameof(load), nameof(OrderStartupEvent) + "/" + e.GetType().Name, e.Message);
            }
        }

        private static void onStartup(Order o)
        {
            o.tb_orderid_od.Focus();
            o.dataGridView1.ReadOnly = true;

            ResetEvent.reset();
            Program.logger.Log(Level.INFO, nameof(onStartup), nameof(OrderStartupEvent), nameof(onStartup) + " Loaded");
        }

        private static void registerItemsInComboBox(Order o)
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
                    database.DisconnectDatabase();
                }
                Program.logger.Log(Level.INFO, nameof(registerItemsInComboBox), nameof(OrderStartupEvent), nameof(registerItemsInComboBox) + " Loaded");
            }
            catch(System.Exception e)
            {
                Program.logger.Log(Level.ERROR, nameof(registerItemsInComboBox), nameof(OrderStartupEvent) + "/" + e.GetType().Name, e.Message);
                database.DisconnectDatabase();
            }

        }

        internal static void registerDataGridView(Order o)
        {
            Database database = new Database();

            try
            {
                if (database.ConnectDatabase())
                {
                    string query = "select * from `order`";

                    using (MySqlCommand command = new MySqlCommand(query, database.connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            o.dataGridView1.Invoke((MethodInvoker)delegate
                            {
                                o.dataGridView1.DataSource = dataTable;
                            });
                        }
                    }
                    database.DisconnectDatabase();
                    Program.logger.Log(Level.INFO, nameof(registerDataGridView), nameof(OrderStartupEvent), "Successfully added items");
                }

                o.dataGridView1.Invoke((MethodInvoker)delegate
                {
                    o.dataGridView1.ClearSelection();
                });

                Program.logger.Log(Level.INFO, nameof(registerDataGridView), nameof(OrderStartupEvent), nameof(registerDataGridView) + " Loaded");
            }
            catch (System.Exception e)
            {
                Program.logger.Log(Level.ERROR, nameof(registerDataGridView), nameof(OrderStartupEvent) + "/" + e.GetType().Name, e.Message);
                database.DisconnectDatabase();
            }
        }
    }
}
