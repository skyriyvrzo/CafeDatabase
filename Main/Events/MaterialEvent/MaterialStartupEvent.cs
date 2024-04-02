using CSharp.Util.Logging;
using Main.Events.OrderEvent;
using Main.Events.ScreenChangeEvent;
using MySql.Data.MySqlClient;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace Main.Events.MaterialEvent
{
#pragma warning disable IDE1006
    internal sealed class MaterialStartupEvent
    {
        internal static void load(Material m)
        {
            try
            {
                onStartup(m);

                Thread thread = new Thread(() => registerDataGridView(m));
                thread.Start();

                Program.logger.Log(Level.INFO, nameof(MaterialStartupEvent) + " Loaded");
            }
            catch (System.Exception e)
            {
                Program.logger.Log(Level.ERROR, nameof(load), nameof(MaterialStartupEvent) + "/" + e.GetType().Name, e.Message);
            }
        }

        private static void onStartup(Material m)
        {
            m.tb_matid.Focus();
            m.dataGridView1.ReadOnly = true;

            ResetEvent.reset();
            Program.logger.Log(Level.INFO, nameof(onStartup) + " Loaded");
        }

        internal static void registerDataGridView(Material m)
        {
            Database database = new Database();

            try
            {
                if (database.ConnectDatabase())
                {
                    string query = "select * from `material`";

                    using (MySqlCommand command = new MySqlCommand(query, database.connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            m.dataGridView1.DataSource = dataTable;
                        }
                    }
                    database.DisconnectDatabase();
                    Program.logger.Log(Level.INFO, nameof(registerDataGridView) + " Successfully added item");
                }

                m.dataGridView1.ClearSelection();
                /*
                 * Resize the table to fit the data grid view
                 */
                m.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                Program.logger.Log(Level.INFO, nameof(registerDataGridView) + " Loaded");
            }
            catch (System.Exception e)
            {
                Program.logger.Log(Level.ERROR, nameof(registerDataGridView), nameof(MaterialStartupEvent) + "/" + e.GetType().Name, e.Message);
                database.DisconnectDatabase();
            }
        }
    }
}
