﻿using CSharp.Util.Logging;
using Main.Events.ScreenChangeEvent;
using Main.Utils;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
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
                registerDataGridView(d);
                Program.logger.Log(Level.INFO, nameof(DrinkStartupEvent) + " Loaded");
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
            Program.logger.Log(Level.INFO, nameof(onStartup) + " Loaded");
        }

        private static void registerItemsInComboBox(Drink d)
        {
            ComboBoxItem item1 = new ComboBoxItem();
            item1.Text = "โสด";
            item1.Value = 0;

            ComboBoxItem item2 = new ComboBoxItem();
            item2.Text = "มีแฟนแล้ว";
            item2.Value = 1;

            d.cb_status.Items.Add(item1);
            d.cb_status.Items.Add(item2);

            Program.logger.Log(Level.INFO, nameof(registerItemsInComboBox) + " Loaded");
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
                            d.dataGridView1.DataSource = dataTable;
                        }
                    }
                    database.DisconnectDatabase();
                    Program.logger.Log(Level.INFO, nameof(registerDataGridView) + " Successfully added item");
                }

                d.dataGridView1.ClearSelection();
                /*
                 * Resize the table to fit the data grid view
                 */
                d.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                Program.logger.Log(Level.INFO, nameof(registerDataGridView) + " Loaded");
            }
            catch (System.Exception e)
            {
                Program.logger.Log(Level.ERROR, nameof(registerDataGridView), nameof(DrinkStartupEvent) + "/" + e.GetType().Name, e.Message);
                database.DisconnectDatabase();
            }
        }
    }
}