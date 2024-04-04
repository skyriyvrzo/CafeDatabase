using CSharp.Util.Logging;
using Main.Events.DrinkEvent;
using Main.Events.OrderEvent;
using Main.Events.ScreenChangeEvent;
using Main.Utils;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Main.Events.EmployeeEvent
{
#pragma warning disable IDE1006
    internal sealed class EmployeeStartupEvent
    {

        /*
         * run when program startup
         * used to call all methods in this class.
         * 
         * @param {@e Employee} to set properties of component
         */
        internal static void load(Employee e)
        {
            try
            {
                onStartup(e);
                registerItemsInComboBox(e);

                Thread thread = new Thread(() => registerDataGridView(e));
                thread.Start();

                Program.logger.Log(Level.INFO, nameof(load), nameof(EmployeeStartupEvent), nameof(EmployeeStartupEvent) + " Loaded");
            }
            catch (System.Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(load), nameof(EmployeeStartupEvent) + "/" + e1.GetType().Name, e1.Message);
            }
        }

        /*
         * set dataGridView to read-only
         * 
         * @param {@e Employee} to set properties of component
         */
        private static void onStartup(Employee e)
        {
            e.tb_empid.Focus();
            //e.dataGridView1.Enabled = false;
            e.dataGridView1.ReadOnly = true;

            ResetEvent.reset();

            Program.logger.Log(Level.INFO, nameof(onStartup), nameof(EmployeeStartupEvent), nameof(onStartup) + " Loaded");
        }

        /*
         * add items into comboBox
         * 
         * @param {@e Employee} to set properties of component
         */
        private static void registerItemsInComboBox(Employee e)
        {
            ComboBoxItem m = new ComboBoxItem();
            m.Text = "Male";
            m.Value = "M";

            ComboBoxItem f = new ComboBoxItem();
            f.Text = "Female";
            f.Value = "F";

            e.cb_sex.Items.Add(m);
            e.cb_sex.Items.Add(f);

            Program.logger.Log(Level.INFO, nameof(registerItemsInComboBox), nameof(EmployeeStartupEvent), nameof(registerItemsInComboBox) + " Loaded");
        }

        /*
         * fill data from database(table=employees) into dataGridView
         * 
         * @param {@e Employee} to set properties of component
         */
        internal static void registerDataGridView(Employee e)
        {
            Database database = new Database();
            
            try
            {

                if (database.ConnectDatabase())
                {
                    string query = "select * from `employees`";

                    using (MySqlCommand command = new MySqlCommand(query, database.connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            e.dataGridView1.Invoke((MethodInvoker)delegate
                            {
                                e.dataGridView1.DataSource = dataTable;
                            });
                        }
                    }
                    database.DisconnectDatabase();
                    Program.logger.Log(Level.INFO, nameof(registerDataGridView), nameof(EmployeeStartupEvent), "Successfully added item");
                }

                e.dataGridView1.Invoke((MethodInvoker)delegate
                {
                    e.dataGridView1.ClearSelection();
                });

                Program.logger.Log(Level.INFO, nameof(registerDataGridView), nameof(EmployeeStartupEvent), nameof(registerDataGridView) + " Loaded");
            }
            catch(System.Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(registerDataGridView), nameof(EmployeeStartupEvent) + "/" + e1.GetType().Name, e1.Message);
                database.DisconnectDatabase();
            }
        }
    }
}
