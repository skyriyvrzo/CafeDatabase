using CSharp.Util.Logging;
using Main.Events.MaterialEvent;
using Main.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Main.Events.MaterialofDrinkEvent
{
#pragma warning disable IDE1006
    internal class MaterialofDrinkButtonClickEvent
    {
        /*
         * insert new data into database(table=materialofdrink)
         * 
         * if textBox is empty, will displays the message box warning and returns it.
         * and material id are not numbers, a message box warning will be displayed and returned.
         * 
         * @param {@mod Material} to set properties of component
         */

        internal static void onClickAdd(MaterialofDrink mod)
        {
            Database database = new Database();

            try
            {

                if (database.ConnectDatabase())
                {
                    if (mod.cb_drink.SelectedValue == null || mod.cb_material.SelectedValue == null)
                    {
                        MessageBox.Show("Please fill in complete information.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    //Console.WriteLine(mod.cb_drink.SelectedValue);
                    //Console.WriteLine(mod.cb_material.SelectedValue);

                    string query = $"INSERT INTO `material_of_drink` (`DRINK_ID`, `MATERIAL_ID`) VALUES ('{mod.cb_drink.SelectedValue}', '{mod.cb_material.SelectedValue}')";

                    int row = new MySqlCommand(query, database.connection).ExecuteNonQuery();

                    if (row > 0)
                    {
                        MessageBox.Show("Add successfully", Reference.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MaterialofDrinkStartupEvent.registerDataGridView(mod);
                    }

                    clearTextBox(mod);
                    database.DisconnectDatabase();
                }

            }
            catch (MySqlException e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onClickAdd), nameof(MaterialofDrinkStartupEvent) + "/" + e1.GetType().Name, e1.Message);
                database.DisconnectDatabase();

                if (e1.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("ID: `" + mod.cb_drink.SelectedValue + "/" + mod.cb_material.SelectedValue + "` looks like a duplicate.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                throw new System.Exception(e1.Message);
            }
            catch (System.Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onClickAdd), nameof(MaterialofDrinkStartupEvent) + "/" + e1.GetType().Name, e1.Message);
                database.DisconnectDatabase();
                MessageBox.Show(e1.Message, Reference.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         * change button color.
         * lock comboBox(Drink ID)
         * 
         * @param {@mod MaterialofDrink} to set properties of component
         */
        internal static bool editButtonIsEnable = false;
        internal static void onClickEdit(MaterialofDrink mod)
        {
            if (editButtonIsEnable == false)
            {
                editButtonIsEnable = true;
                mod.cb_drink.Enabled = false;
                mod.bt_edit.BackColor = Color.FromArgb(138, 226, 52);
            }
            else
            {
                editButtonIsEnable = false;
                mod.cb_drink.Enabled = true;
                mod.dataGridView1.ClearSelection();
                mod.bt_edit.BackColor = Color.White;
            }
        }

        /*
         * Delete data from table.
         *
         * Show MessageBox confirm when pressing delete button
         * 
         * @param {@mod MaterialofDrink} to set properties of component
         */
        internal static void onClickDelete(MaterialofDrink mod)
        {
            Database database = new Database();

            try
            {
                if (mod.cb_drink.SelectedValue == null || mod.cb_material.SelectedValue == null)
                {
                    MessageBox.Show("Please select the value you want to delete.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (MessageBox.Show("Are you sure you want to delete?", Reference.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (database.ConnectDatabase())
                    {
                        string query = $"delete from `material_of_drink` where (DRINK_ID, MATERIAL_ID)= '({mod.cb_drink.SelectedValue}, {mod.cb_material.SelectedValue})'";
                        int row = new MySqlCommand(query, database.connection).ExecuteNonQuery();

                        if (row > 0)
                        {
                            MessageBox.Show("Delete successfully", Reference.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        clearTextBox(mod);
                        MaterialofDrinkStartupEvent.registerDataGridView(mod);
                        database.DisconnectDatabase();
                    }
                }
            }
            catch (MySqlException e1)
            {
                if (e1.Message.Contains("Cannot delete or update a parent row"))
                {
                    MessageBox.Show("Cannot delete or update a parent row", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                throw new Exception(e1.Message);
            }
            catch (System.Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onClickDelete), nameof(MaterialofDrinkStartupEvent) + "/" + e1.GetType().Name, e1.Message);
                database.DisconnectDatabase();
            }
        }

        /*
         * Save data into database after editing
         * 
         * @param {@mod MaterialofDrink} to set properties of component
         */

        internal static string materialOldValue;
        internal static void onClickSave(MaterialofDrink mod)
        {
            Database database = new Database();

            try
            {

                if (mod.cb_drink.SelectedValue == null || mod.cb_material.SelectedValue == null)
                {
                    MessageBox.Show("Please fill in complete information.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (database.ConnectDatabase())
                {

                    string query = $"update `material_of_drink` set MATERIAL_ID = {mod.cb_material.SelectedValue} where (DRINK_ID, MATERIAL_ID) = ({mod.cb_drink.SelectedValue}, {materialOldValue})";

                    int row = new MySqlCommand(query, database.connection).ExecuteNonQuery();

                    if (row > 0)
                    {
                        MessageBox.Show("Your changes have been successfully saved!", Reference.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MaterialofDrinkStartupEvent.registerDataGridView(mod);
                    }
                    /*else
                    {
                        Console.WriteLine(row);
                        Console.WriteLine("DRINK ID: " + mod.cb_drink.SelectedValue);
                        Console.WriteLine("OLD: " + materialOldValue);
                        Console.WriteLine("NEW: " + mod.cb_material.SelectedValue);
                    }*/

                    clearTextBox(mod);
                    database.DisconnectDatabase();
                }

            }
            catch (Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onClickSave), nameof(MaterialofDrinkStartupEvent) + "/" + e1.GetType().Name, e1.Message);
                database.DisconnectDatabase();
            }
        }

        /*
         * clear values in textBox
         *
         * @param {@mod MaterialofDrink} to set properties of component
         */
        private static void clearTextBox(MaterialofDrink mod)
        {
            mod.cb_drink.SelectedItem = null;
            mod.cb_material.SelectedItem = null;
        }
    }
}
