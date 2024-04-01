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
         * @param {@e Employee} for set properties of component
         */
        internal static void load(Employee e)
        {
            onStartup(e);
            registerItemsInComboBox(e);
            registerDataGridView(e);

            Program.logger.Log(Level.INFO, nameof(EmployeeStartupEvent) + " Loaded");
        }

        /*
         * disable edit mode for textbox and combobox
         * 
         * @param {@e Employee} for set properties of component
         */
        private static void onStartup(Employee e)
        {
            e.tb_empid.Enabled = false;
            e.tb_fname.Enabled = false;
            e.tb_lname.Enabled = false;
            e.tb_salary.Enabled = false;
            e.cb_sex.Enabled = false;
        }

        /*
         * add items into combobox
         * 
         * @param {@e Employee} for set properties of component
         */
        private static void registerItemsInComboBox(Employee e)
        {
            e.cb_sex.Items.Add("Male");
            e.cb_sex.Items.Add("Female");
        }

        /*
         * fill data from database(table=employee) into dataGridview
         * 
         * @param {@e Employee} for set properties of component
         */
        private static void registerDataGridView(Employee e)
        {
            try
            {
                Database database = new Database();

                if (database.ConnectDatabase())
                {
                    string query = "select * from `employees`";

                    MySqlCommand command = new MySqlCommand(query, database.connection);

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = command;

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    e.dataGridView1.DataSource = dataTable;
                }


            }catch(System.Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(registerDataGridView), nameof(EmployeeStartupEvent), e1.Message);
            }
        }
    }
}
