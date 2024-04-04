using CSharp.Util.Logging;
using Main.Events.ScreenChangeEvent;
using Main.Utils;
using MySql.Data.MySqlClient;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace Main.Events.DrinkEvent
{
#pragma warning disable IDE1006
    internal sealed class DrinkStartupEvent
    {
        internal static void load(Drink d)
        {
            try
            {
                onStartup(d);
                registerItemsInComboBox(d);

                Thread thread = new Thread(() => registerDataGridView(d));
                thread.Start();

                Program.logger.Log(Level.INFO, nameof(load), nameof(DrinkStartupEvent), nameof(DrinkStartupEvent) + " Loaded");
            }
            catch (System.Exception e)
            {
                Program.logger.Log(Level.ERROR, nameof(load), nameof(DrinkStartupEvent) + "/" + e.GetType().Name, e.Message);
            }
        }

        private static void onStartup(Drink d)
        {
            d.tb_drink_id.Focus();
            d.dataGridView1.ReadOnly = true;

            ResetEvent.reset();
            Program.logger.Log(Level.INFO, nameof(onStartup), nameof(DrinkStartupEvent), nameof(onStartup) + " Loaded");
        }

        private static void registerItemsInComboBox(Drink d)
        {
            ComboBoxItem item1 = new ComboBoxItem();
            item1.Text = "ยังไม่พร้อมขาย";
            item1.Value = 0;

            ComboBoxItem item2 = new ComboBoxItem();
            item2.Text = "พร้อมขาย";
            item2.Value = 1;

            d.cb_status.Items.Add(item1);
            d.cb_status.Items.Add(item2);

            Program.logger.Log(Level.INFO, nameof(registerItemsInComboBox), nameof(DrinkStartupEvent), nameof(registerItemsInComboBox) + " Loaded");
        }

        internal static void registerDataGridView(Drink d)
        {
            Database database = new Database();

            try
            {
                if (database.ConnectDatabase())
                {
                    string query = "select * from drink";

                    using (MySqlCommand command = new MySqlCommand(query, database.connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            d.dataGridView1.Invoke((MethodInvoker)delegate
                            {
                                d.dataGridView1.DataSource = dataTable;
                            });
                        }
                    }
                    database.DisconnectDatabase();
                    Program.logger.Log(Level.INFO, nameof(registerDataGridView), nameof(DrinkStartupEvent), "Successfully added items");
                }

                d.dataGridView1.Invoke((MethodInvoker)delegate
                {
                    d.dataGridView1.ClearSelection();
                });

                Program.logger.Log(Level.INFO, nameof(registerDataGridView), nameof(DrinkStartupEvent), nameof(registerDataGridView) + " Loaded");
            }
            catch (System.Exception e)
            {
                Program.logger.Log(Level.ERROR, nameof(registerDataGridView), nameof(DrinkStartupEvent) + "/" + e.GetType().Name, e.Message);
                database.DisconnectDatabase();
            }
        }
    }
}