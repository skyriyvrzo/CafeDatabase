using Main.Events.OrderEvent;
using Main.Utils;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Windows.Forms;
using System;
using CSharp.Util.Logging;

namespace Main.Events.DrinkEvent
{
#pragma warning disable IDE1006
    internal sealed class DrinkButtonClickEvent
    {
        internal static void onClickAdd(Drink d)
        {
            Database database = new Database();

            try
            {
                if (d.tb_drink_id.Text == "" || d.tb_name.Text == "" || d.tb_price.Text == "" || d.cb_status.SelectedItem == null)
                {
                    MessageBox.Show("Please fill in complete information.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!int.TryParse(d.tb_drink_id.Text, out int result) || !double.TryParse(d.tb_price.Text, out double result1))
                {
                    MessageBox.Show("Drink ID and price must be numbers only.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (database.ConnectDatabase())
                {
                    string query = $"insert into `drink` (DRINK_ID, DRINK_NAME, DRINK_PRICE, DRINK_STATUS) values " +
                        $"('{d.tb_drink_id.Text}', " +
                        $"'{d.tb_name.Text}', " +
                        $"'{d.tb_price.Text}', " +
                        $"'{(d.cb_status.SelectedItem as ComboBoxItem).Value}')";
                    int row = new MySqlCommand(query, database.connection).ExecuteNonQuery();

                    if (row > 0)
                    {
                        MessageBox.Show("Add successfully", Reference.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DrinkStartupEvent.registerDataGridView(d);
                    }

                    clearTextBox(d);
                    database.DisconnectDatabase();
                }
            }
            catch (MySqlException e1)
            {
                Program.logger.Log(Level.WARNING, nameof(onClickAdd), nameof(DrinkButtonClickEvent) + "/" + e1.GetType().Name, e1.Message);
                database.DisconnectDatabase();

                if (e1.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("ID: `" + d.tb_drink_id.Text + "` looks like a duplicate.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                throw new System.Exception(e1.Message);
            }
            catch (System.Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onClickAdd), nameof(DrinkButtonClickEvent) + "/" + e1.GetType().Name, e1.Message);
                database.DisconnectDatabase();
                MessageBox.Show(e1.Message, Reference.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         * change button color.
         * disable textBox(Drink ID)
         * 
         * @param {@d Drink} to set properties of component
         */
        internal static bool editButtonIsEnable = false;
        internal static void onClickEdit(Drink d)
        {
            if (editButtonIsEnable == false)
            {
                editButtonIsEnable = true;
                d.tb_drink_id.Enabled = false;
                d.bt_Edit_Drink.BackColor = Color.FromArgb(138, 226, 52);
            }
            else
            {
                editButtonIsEnable = false;
                d.tb_drink_id.Enabled = true;
                d.dataGridView1.ClearSelection();
                d.bt_Edit_Drink.BackColor = Color.White;
            }
        }

        internal static void onClickDelete(Drink d)
        {
            Database database = new Database();

            try
            {
                if (d.tb_drink_id.Text == "")
                {
                    MessageBox.Show("Please select the drink you want to delete.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (MessageBox.Show("Are you sure you want to delete?", Reference.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (database.ConnectDatabase())
                    {
                        string query = $"delete from `drink` where DRINK_ID = '{d.tb_drink_id.Text}'";
                        int row = new MySqlCommand(query, database.connection).ExecuteNonQuery();

                        if (row > 0)
                        {
                            MessageBox.Show("Delete successfully", Reference.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        clearTextBox(d);
                        DrinkStartupEvent.registerDataGridView(d);
                        database.DisconnectDatabase();
                    }
                }
            }
            catch (MySqlException e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onClickDelete), nameof(DrinkButtonClickEvent) + "/" + e1.GetType().Name, e1.Message);
                database.DisconnectDatabase();
                if (e1.Message.Contains("Cannot delete or update a parent row"))
                {
                    MessageBox.Show("Cannot delete or update a parent row", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                throw new Exception(e1.Message);
            }
            catch (System.Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onClickDelete), nameof(DrinkButtonClickEvent) + "/" + e1.GetType().Name, e1.Message);
                database.DisconnectDatabase();
            }
        }

        internal static void onClickSave(Drink d)
        {
            Database database = new Database();

            try
            {

                if (d.tb_drink_id.Text == "" || d.tb_name.Text == "" || d.tb_price.Text == "" || d.cb_status.SelectedItem == null)
                {
                    MessageBox.Show("Please fill in complete information.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!int.TryParse(d.tb_drink_id.Text, out int result) || !int.TryParse(d.tb_price.Text, out int result1))
                {
                    MessageBox.Show("Drink ID and price must be numbers only.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (database.ConnectDatabase())
                {
                    string query = "update `drink` set " +
                        $"DRINK_NAME = '{d.tb_name.Text}', " +
                        $"DRINK_PRICE = '{d.tb_price.Text}', " +
                        $"DRINK_STATUS = '{(d.cb_status.SelectedItem as ComboBoxItem).Value}'" +
                        $"where DRINK_ID = {d.tb_drink_id.Text}";
                    int row = new MySqlCommand(query, database.connection).ExecuteNonQuery();

                    if (row > 0)
                    {
                        MessageBox.Show("Your changes have been successfully saved!", Reference.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DrinkStartupEvent.registerDataGridView(d);
                    }

                    clearTextBox(d);
                    database.DisconnectDatabase();
                }

            }
            catch (Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onClickSave), nameof(OrderButtonClickEvent) + "/" + e1.GetType().Name, e1.Message);
                database.DisconnectDatabase();
            }
        }

        /*
         * clear values in textBox
         *
         * @param {@d Drink} to set properties of component
         */
        private static void clearTextBox(Drink d)
        {
            d.tb_drink_id.Clear();
            d.tb_name.Clear();
            d.tb_price.Clear();
            d.cb_status.SelectedItem = null;

            Program.logger.Log(Level.INFO, nameof(clearTextBox), nameof(DrinkButtonClickEvent), "Removed item(s) from components");
        }
    }
}
