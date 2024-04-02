using CSharp.Util.Logging;
using Main.Events.ScreenChangeEvent;
using MySql.Data.MySqlClient;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace Main.Events.ToppingEvent
{
#pragma warning disable IDE1006
    internal sealed class ToppingStartupEvent
    {
        internal static void load(Topping t)
        {
            try
            {
                onStartup(t);
                Thread thread = new Thread(() => registerDataGridView(t));
                thread.Start();

                Program.logger.Log(Level.INFO, nameof(ToppingStartupEvent) + " Loaded");
            }
            catch (System.Exception e)
            {
                Program.logger.Log(Level.ERROR, nameof(load), nameof(ToppingStartupEvent) + "/" + e.GetType().Name, e.Message);
            }
        }

        private static void onStartup(Topping t)
        {
            t.tb_tp_id.Focus();
            t.dataGridView1.ReadOnly = true;

            ResetEvent.reset();
            Program.logger.Log(Level.INFO, nameof(onStartup) + " Loaded");
        }

        internal static void registerDataGridView(Topping t)
        {
            Database database = new Database();

            try
            {
                if (database.ConnectDatabase())
                {
                    string query = "select * from `topping`";

                    using (MySqlCommand command = new MySqlCommand(query, database.connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            t.dataGridView1.DataSource = dataTable;
                        }
                    }
                    database.DisconnectDatabase();
                    Program.logger.Log(Level.INFO, nameof(registerDataGridView) + " Successfully added item");
                }

                t.dataGridView1.ClearSelection();
                /*
                 * Resize the table to fit the data grid view
                 */
                t.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                Program.logger.Log(Level.INFO, nameof(registerDataGridView) + " Loaded");
            }
            catch (System.Exception e)
            {
                Program.logger.Log(Level.ERROR, nameof(registerDataGridView), nameof(ToppingStartupEvent) + "/" + e.GetType().Name, e.Message);
                database.DisconnectDatabase();
            }
        }
    }
}
