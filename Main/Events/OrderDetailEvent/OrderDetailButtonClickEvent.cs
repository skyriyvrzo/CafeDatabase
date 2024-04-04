using Main.Utils;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Windows.Forms;
using System;
using CSharp.Util.Logging;

namespace Main.Events.OrderDetailEvent
{
#pragma warning disable IDE1006
    internal sealed class OrderDetailButtonClickEvent
    {
        internal static void onClickAdd(OrderDetail od)
        {
            Database database = new Database();

            try
            {
                if (od.cb_order.SelectedItem == null || od.cb_drink.SelectedItem == null || od.tb_quantity.Text == "")
                {
                    MessageBox.Show("Please fill in complete information.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!int.TryParse(od.tb_quantity.Text, out int result))
                {
                    MessageBox.Show("Quantity must be numbers only.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (database.ConnectDatabase())
                {
                    string query;

                    if (od.cb_topping.SelectedItem == null)
                    {
                        query = $"insert into `order_detail` (ORDER_ID, DRINK_ID, QUANTITY) values ('{od.cb_order.SelectedValue}', '{od.cb_drink.SelectedValue}', '{od.tb_quantity.Text}')";
                    }
                    else
                    {
                        query = $"insert into `order_detail` (ORDER_ID, DRINK_ID, TOPPING_ID, QUANTITY) values ('{od.cb_order.SelectedValue}', '{od.cb_drink.SelectedValue}', '{od.cb_topping.SelectedValue}', '{od.tb_quantity.Text}')";

                    }
                    int row = new MySqlCommand(query, database.connection).ExecuteNonQuery();

                    if (row > 0)
                    {
                        MessageBox.Show("Add successfully", Reference.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OrderDetailStartupEvent.registerDataGridView(od);
                    }

                    clearTextBox(od);
                    database.DisconnectDatabase();
                }
            }
            catch (MySqlException e1)
            {
                Program.logger.Log(Level.WARNING, nameof(onClickAdd), nameof(OrderDetailButtonClickEvent) + "/" + e1.GetType().Name, e1.Message);
                database.DisconnectDatabase();

                if (e1.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Order: `" + od.cb_order.SelectedValue + ", Drink: " + od.cb_drink.SelectedValue + "` looks like a duplicate.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                throw new System.Exception(e1.Message);
            }
            catch (System.Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onClickAdd), nameof(OrderDetailButtonClickEvent) + "/" + e1.GetType().Name, e1.Message);
                database.DisconnectDatabase();
                MessageBox.Show(e1.Message, Reference.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         * change button color.
         * disable textBox(Order ID)
         * 
         * @param {@od OrderDetail} to set properties of component
         */
        internal static bool editButtonIsEnable = false;
        internal static void onClickEdit(OrderDetail od)
        {
            if (editButtonIsEnable == false)
            {
                editButtonIsEnable = true;
                od.cb_order.Enabled = false;
                od.cb_drink.Enabled = false;
                od.bt_edit.BackColor = Color.FromArgb(138, 226, 52);
            }
            else
            {
                editButtonIsEnable = false;
                od.cb_order.Enabled = true;
                od.cb_drink.Enabled = true;
                od.dataGridView1.ClearSelection();
                od.bt_edit.BackColor = Color.White;
            }
        }

        internal static void onClickDelete(OrderDetail od)
        {
            Database database = new Database();

            try
            {
                if (od.cb_order.SelectedText == null)
                {
                    MessageBox.Show("Please select the item you want to delete.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (MessageBox.Show("Are you sure you want to delete?", Reference.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (database.ConnectDatabase())
                    {
                        string query = $"delete from `order_detail` where (ORDER_ID, DRINK_ID) = ({od.cb_order.SelectedValue}, {od.cb_drink.SelectedValue})";
                        int row = new MySqlCommand(query, database.connection).ExecuteNonQuery();

                        if (row > 0)
                        {
                            MessageBox.Show("Delete successfully", Reference.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        clearTextBox(od);
                        OrderDetailStartupEvent.registerDataGridView(od);
                        database.DisconnectDatabase();
                    }
                }
            }
            catch (MySqlException e1)
            {
                database.DisconnectDatabase();
                Program.logger.Log(Level.WARNING, nameof(onClickDelete), nameof(OrderDetailButtonClickEvent) + "/" + e1.GetType().Name, e1.Message);
                if (e1.Message.Contains("Cannot delete or update a parent row"))
                {
                    MessageBox.Show("Cannot delete or update a parent row", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                throw new Exception(e1.Message);
            }
            catch (System.Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onClickDelete), nameof(OrderDetailButtonClickEvent) + "/" + e1.GetType().Name, e1.Message);
                database.DisconnectDatabase();
            }
        }

        internal static void onClickSave(OrderDetail od)
        {
            Database database = new Database();

            try
            {

                if (od.cb_order.SelectedItem == null || od.cb_drink.SelectedItem == null || od.cb_topping.SelectedItem == null || od.tb_quantity.Text == "")
                {
                    MessageBox.Show("Please fill in complete information.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!int.TryParse(od.tb_quantity.Text, out int result))
                {
                    MessageBox.Show("Quantity must be numbers only.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (database.ConnectDatabase())
                {
                    string query = "update `order_detail` set " +
                        $"TOPPING_ID = '{od.cb_topping.SelectedValue}'," +
                        $"QUANTITY = '{od.tb_quantity.Text}' " +
                        $"where (ORDER_ID, DRINK_ID) = ({od.cb_order.SelectedValue}, {od.cb_drink.SelectedValue})";
                    int row = new MySqlCommand(query, database.connection).ExecuteNonQuery();

                    if (row > 0)
                    {
                        MessageBox.Show("Your changes have been successfully saved!", Reference.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OrderDetailStartupEvent.registerDataGridView(od);
                    }

                    clearTextBox(od);
                    database.DisconnectDatabase();
                }

            }
            catch (Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onClickSave), nameof(OrderDetailButtonClickEvent) + "/" + e1.GetType().Name, e1.Message);
                database.DisconnectDatabase();
            }
        }

        /*
         * clear values in textBox
         *
         * @param {@od OrderDetail} to set properties of component
         */
        private static void clearTextBox(OrderDetail od)
        {
            od.cb_order.SelectedItem = null;
            od.cb_drink.SelectedItem = null;
            od.cb_topping.SelectedItem = null;
            od.tb_quantity.Clear();

            Program.logger.Log(Level.INFO, nameof(clearTextBox), nameof(OrderDetailButtonClickEvent), "Removed item(s) from components");
        }
    }
}
