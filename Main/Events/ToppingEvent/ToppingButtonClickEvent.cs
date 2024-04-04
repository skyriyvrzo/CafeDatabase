using CSharp.Util.Logging;
using Main.Events.DrinkEvent;
using Main.Events.EmployeeEvent;
using Main.Utils;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms.Ecc;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Main.Events.ToppingEvent
{
#pragma warning disable IDE1006
    internal sealed class ToppingButtonClickEvent
    {
        /*
         * insert new data into database(table=topping)
         * 
         * if textBox is empty, will displays the message box warning and returns it.
         * and material id are not numbers, a message box warning will be displayed and returned.
         * 
         * @param {@t Topping} to set properties of component
         */

        internal static void onClickAdd(Topping t)
        {
            Database database = new Database();

            try
            {

                if (database.ConnectDatabase())
                {
                    if (t.tb_tp_id.Text == "" || t.tb_tp_name.Text == "" || t.tb_tp_price.Text == "")
                    {
                        MessageBox.Show("Please fill in complete information.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (!int.TryParse(t.tb_tp_id.Text, out int result) || !double.TryParse(t.tb_tp_price.Text, out double result1))
                    {
                        MessageBox.Show("Topping ID and price must be numbers only.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string query = "insert into `topping` (TOPPING_ID, TOPPING_NAME, TOPPING_PRICE) " +
                        "values(" +
                        $"'{t.tb_tp_id.Text}', " +
                        $"'{t.tb_tp_name.Text}', " +
                        $"'{t.tb_tp_price.Text}')";

                    int row = new MySqlCommand(query, database.connection).ExecuteNonQuery();

                    if (row > 0)
                    {
                        MessageBox.Show("Add successfully", Reference.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ToppingStartupEvent.registerDataGridView(t);
                    }

                    clearTextBox(t);
                    database.DisconnectDatabase();
                }

            }
            catch (MySqlException e1)
            {
                Program.logger.Log(Level.WARNING, nameof(onClickAdd), nameof(ToppingButtonClickEvent) + "/" + e1.GetType().Name, e1.Message);
                database.DisconnectDatabase();

                if (e1.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("ID: `" + t.tb_tp_id.Text + "` looks like a duplicate.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Program.logger.Log(Level.ERROR, nameof(onClickAdd), nameof(ToppingButtonClickEvent) + "/" + e1.GetType().Name, e1.Message);
            }
            catch (System.Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onClickAdd), nameof(ToppingButtonClickEvent) + "/" + e1.GetType().Name, e1.Message);
                database.DisconnectDatabase();
                MessageBox.Show(e1.Message, Reference.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         * change button color.
         * disable textBox(Topping ID)
         * 
         * @param {@t Topping} to set properties of component
         */
        internal static bool editButtonIsEnable = false;
        internal static void onClickEdit(Topping t)
        {
            if (editButtonIsEnable == false)
            {
                editButtonIsEnable = true;
                //e.dataGridView1.Enabled = true;
                t.tb_tp_id.Enabled = false;
                t.bt_Edit.BackColor = Color.FromArgb(138, 226, 52);
            }
            else
            {
                editButtonIsEnable = false;
                //e.dataGridView1.Enabled = false;
                t.tb_tp_id.Enabled = true;
                t.dataGridView1.ClearSelection();
                t.bt_Edit.BackColor = Color.White;
            }
        }

        /*
         * Delete data from table.
         *
         * Show MessageBox confirm when pressing delete button
         * 
         * @param {@t Topping} to set properties of component
         */
        internal static void onClickDelete(Topping t)
        {
            Database database = new Database();

            try
            {
                if (t.tb_tp_id.Text == "")
                {
                    MessageBox.Show("Please select the topping you want to delete.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (MessageBox.Show("Are you sure you want to delete?", Reference.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (database.ConnectDatabase())
                    {
                        string query = $"delete from `topping` where TOPPING_ID = '{t.tb_tp_id.Text}'";
                        int row = new MySqlCommand(query, database.connection).ExecuteNonQuery();

                        if(row > 0)
                        {
                            MessageBox.Show("Delete successfully", Reference.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        clearTextBox(t);
                        ToppingStartupEvent.registerDataGridView(t);
                        database.DisconnectDatabase();
                    }
                }
            }
            catch (MySqlException e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onClickDelete), nameof(ToppingButtonClickEvent) + "/" + e1.GetType().Name, e1.Message);
                if (e1.Message.Contains("Cannot delete or update a parent row"))
                {
                    MessageBox.Show("Cannot delete or update a parent row", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Program.logger.Log(Level.ERROR, nameof(onClickDelete), nameof(ToppingButtonClickEvent) + "/" + e1.GetType().Name, e1.Message);
            }
            catch (System.Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onClickDelete), nameof(ToppingButtonClickEvent) + "/" + e1.GetType().Name, e1.Message);
                database.DisconnectDatabase();
            }
        }

        /*
         * Save data into database after editing
         * 
         * @param {@t Topping} to set properties of component
         */
        internal static void onClickSave(Topping t)
        {
            Database database = new Database();

            try
            {

                if (t.tb_tp_id.Text == "" || t.tb_tp_name.Text == "" || t.tb_tp_price.Text == "")
                {
                    MessageBox.Show("Please fill in complete information.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!int.TryParse(t.tb_tp_id.Text, out int result) || !double.TryParse(t.tb_tp_price.Text, out double result1))
                {
                    MessageBox.Show("Topping ID and price must be numbers only.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (database.ConnectDatabase())
                {
                    string query = "update `topping` set " +
                        $"TOPPING_NAME = '{t.tb_tp_name.Text}', " +
                        $"TOPPING_PRICE = '{t.tb_tp_price.Text}' " +
                        $"where TOPPING_ID = {t.tb_tp_id.Text}";

                    int row = new MySqlCommand(query, database.connection).ExecuteNonQuery();

                    if (row > 0)
                    {
                        MessageBox.Show("Your changes have been successfully saved!", Reference.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ToppingStartupEvent.registerDataGridView(t);
                    }

                    clearTextBox(t);
                    database.DisconnectDatabase();
                }

            }
            catch (Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onClickSave), nameof(ToppingButtonClickEvent) + "/" + e1.GetType().Name, e1.Message);
                database.DisconnectDatabase();
            }
        }

        /*
         * clear values in textBox
         *
         * @param {@e Employee} to set properties of component
         */
        private static void clearTextBox(Topping t)
        {
            t.tb_tp_id.Clear();
            t.tb_tp_name.Clear();
            t.tb_tp_price.Clear();

            Program.logger.Log(Level.INFO, nameof(clearTextBox), nameof(ToppingButtonClickEvent), "Removed item(s) from components");
        }
    }
}
