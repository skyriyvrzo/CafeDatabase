using CSharp.Util.Logging;
using Main.Events.OrderEvent;
using Main.Events.ScreenChangeEvent;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Events.MaterialofDrinkEvent
{
#pragma warning disable IDE1006
    internal sealed class MaterialofDrinkStartupEvent
    {
        internal static void load(MaterialofDrink mod)
        {
            try
            {
                onStartup(mod);
                registerItemsInComboBox(mod);
                registerDataGridView(mod);
                Program.logger.Log(Level.INFO, nameof(MaterialofDrinkStartupEvent) + " Loaded");
            }
            catch (System.Exception e)
            {
                Program.logger.Log(Level.ERROR, nameof(load), nameof(MaterialofDrinkStartupEvent) + "/" + e.GetType().Name, e.Message);
            }
        }

        private static void onStartup(MaterialofDrink mod)
        {
            mod.cb_drink.Focus();
            mod.dataGridView1.ReadOnly = true;

            ResetEvent.reset();
            Program.logger.Log(Level.INFO, nameof(onStartup) + " Loaded");
        }

        private static void registerItemsInComboBox(MaterialofDrink mod)
        {
            Database database = new Database();

            try
            {
                if (database.ConnectDatabase())
                {
                    string query = "select DRINK_ID, DRINK_NAME, Concat(DRINK_NAME, Concat(' (', Concat(DRINK_ID, ')'))) as Name from `drink`";
                    using (MySqlCommand command = new MySqlCommand(query, database.connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            mod.cb_drink.DataSource = dataTable;
                            mod.cb_drink.DisplayMember = "Name";
                            mod.cb_drink.ValueMember = "DRINK_ID";
                            mod.cb_drink.SelectedItem = null;
                        }
                    }

                    query = "select MATERIAL_ID, MATERIAL_NAME, Concat(MATERIAL_NAME, Concat(' (', Concat(MATERIAL_ID, ')'))) as Name from `material`";
                    using (MySqlCommand command = new MySqlCommand(query, database.connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            mod.cb_material.DataSource = dataTable;
                            mod.cb_material.DisplayMember = "Name";
                            mod.cb_material.ValueMember = "MATERIAL_ID";
                            mod.cb_material.SelectedItem = null;
                        }
                    }
                    database.DisconnectDatabase();
                }
                Program.logger.Log(Level.INFO, nameof(registerItemsInComboBox) + " Loaded");
            }
            catch (System.Exception e)
            {
                Program.logger.Log(Level.ERROR, nameof(registerItemsInComboBox), nameof(MaterialofDrinkStartupEvent) + "/" + e.GetType().Name, e.Message);
                database.DisconnectDatabase();
            }

        }

        internal static void registerDataGridView(MaterialofDrink mod)
        {
            Database database = new Database();

            try
            {
                if (database.ConnectDatabase())
                {
                    string query = "SELECT * from `material_of_drink`";

                    using (MySqlCommand command = new MySqlCommand(query, database.connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            mod.dataGridView1.DataSource = dataTable;
                        }
                    }
                    database.DisconnectDatabase();
                    Program.logger.Log(Level.INFO, nameof(registerDataGridView) + " Successfully added item");
                }

                mod.dataGridView1.ClearSelection();
                /*
                 * Resize the table to fit the data grid view
                 */
                mod.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                Program.logger.Log(Level.INFO, nameof(registerDataGridView) + " Loaded");
            }
            catch (System.Exception e)
            {
                Program.logger.Log(Level.ERROR, nameof(registerDataGridView), nameof(MaterialofDrinkStartupEvent) + "/" + e.GetType().Name, e.Message);
                database.DisconnectDatabase();
            }
        }
    }
}
