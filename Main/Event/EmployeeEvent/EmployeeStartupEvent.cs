using CSharp.Util.Logging;
using MySql.Data.MySqlClient;
using System.Data;

namespace Main.Event.EmployeeEvent
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
                registerDataGridView(e);

                Program.logger.Log(Level.INFO, nameof(EmployeeStartupEvent) + " Loaded");
            }catch(System.Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(load), nameof(EmployeeStartupEvent) + "/" + e1.GetType().Name, e1.Message);
            }
        }

        /*
         * disable edit mode dataGridView
         * 
         * @param {@e Employee} to set properties of component
         */
        private static void onStartup(Employee e)
        {
            e.tb_empid.Focus();
            e.dataGridView1.Enabled = false;
            e.dataGridView1.ReadOnly = true;
        }

        /*
         * add items into comboBox
         * 
         * @param {@e Employee} to set properties of component
         */
        private static void registerItemsInComboBox(Employee e)
        {
            e.cb_sex.Items.Add("Male");
            e.cb_sex.Items.Add("Female");
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

                    MySqlCommand command = new MySqlCommand(query, database.connection);

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = command;

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    e.dataGridView1.DataSource = dataTable;

                    database.DisconnectDatabase();
                }


            }catch(System.Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(registerDataGridView), nameof(EmployeeStartupEvent) + "/" + e1.GetType().Name, e1.Message);
                database.DisconnectDatabase();
            }
        }
    }
}
