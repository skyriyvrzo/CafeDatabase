using CSharp.Util.Logging;
using Main.Events.EmployeeEvent;
using Main.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Data.Odbc;
using System.Drawing;
using System.Windows.Forms;

namespace Main.Events.OrderEvent
{
#pragma warning disable IDE1006
    internal sealed class OrderButtonClickEvent
    {
        internal static void onClickAdd(OrdersDetail o)
        {
            Database database = new Database();

            try
            {
                if (o.tb_orderid_od.Text == "" || o.cb_drink_id.SelectedItem == null || o.cb_emp.SelectedItem == null || o.cb_topping_id.SelectedItem == null || o.tb_quantity_od.Text == "")
                {
                    MessageBox.Show("Please fill in complete information.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!int.TryParse(o.tb_orderid_od.Text, out int result) || !int.TryParse(o.tb_quantity_od.Text, out int result1))
                {
                    MessageBox.Show("Order ID and quantity must be numbers only.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (database.ConnectDatabase())
                {
                    string query = $"insert into `order` (ORDER_ID, ORDER_DATE, EMPLOYEE_ID) values ('{o.tb_orderid_od.Text}', '{DateTime.Now.ToString("yyyy-MM-dd h:mm:ss.fffff")}', '{o.cb_emp.SelectedValue}')";
                    int row1 = new MySqlCommand(query, database.connection).ExecuteNonQuery();

                    query = $"insert into `order_detail` (ORDER_ID, DRINK_ID, TOPPING_ID, QUANTITY) values ('{o.tb_orderid_od.Text}', '{o.cb_drink_id.SelectedValue}', '{o.cb_topping_id.SelectedValue}', '{o.tb_quantity_od.Text}')";
                    int row2 = new MySqlCommand(query, database.connection).ExecuteNonQuery();

                    if (row1 > 0 && row2 > 0)
                    {
                        MessageBox.Show("Add successfully", Reference.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OrderStartupEvent.registerDataGridView(o);
                    }

                    clearTextBox(o);
                    database.DisconnectDatabase();
                }
            }
            catch (MySqlException e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onClickAdd), nameof(OrderButtonClickEvent) + "/" + e1.GetType().Name, e1.Message);
                database.DisconnectDatabase();

                if (e1.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("ID: `" + o.tb_orderid_od.Text + "` looks like a duplicate.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                throw new System.Exception(e1.Message);
            }
            catch (System.Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onClickAdd), nameof(OrderButtonClickEvent) + "/" + e1.GetType().Name, e1.Message);
                database.DisconnectDatabase();
                MessageBox.Show(e1.Message, Reference.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         * change button color.
         * lock textBox(Order ID)
         * 
         * @param {@o OrdersDetail} to set properties of component
         */
        internal static bool editButtonIsEnable = false;
        internal static void onClickEdit(OrdersDetail o)
        {
            if (editButtonIsEnable == false)
            {
                editButtonIsEnable = true;
                o.tb_orderid_od.Enabled = false;
                o.bt_edit_.BackColor = Color.FromArgb(138, 226, 52);
            }
            else
            {
                editButtonIsEnable = false;
                o.tb_orderid_od.Enabled = true;
                o.dataGridView1.ClearSelection();
                o.bt_edit_.BackColor = Color.White;
            }
        }

        internal static void onClickDelete(OrdersDetail o)
        {
            Database database = new Database();

            try
            {
                if (o.tb_orderid_od.Text == "")
                {
                    MessageBox.Show("Please select the order you want to delete.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (MessageBox.Show("Are you sure you want to delete?", Reference.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (database.ConnectDatabase())
                    {
                        string query = $"delete from `order_detail` where ORDER_ID = '{o.tb_orderid_od.Text}' and DRINK_ID = '{o.cb_drink_id.SelectedValue}'";
                        int row1 = new MySqlCommand(query, database.connection).ExecuteNonQuery();

                        query = $"delete from `order` where ORDER_ID = '{o.tb_orderid_od.Text}'";
                        int row2 = new MySqlCommand(query, database.connection).ExecuteNonQuery();

                        if(row1 > 0 && row2 > 0)
                        {
                            MessageBox.Show("Delete successfully", Reference.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        clearTextBox(o);
                        OrderStartupEvent.registerDataGridView(o);
                        database.DisconnectDatabase();
                    }
                }
            }
            catch (MySqlException e1)
            {
                database.DisconnectDatabase();
                Program.logger.Log(Level.ERROR, nameof(onClickDelete), nameof(OrderButtonClickEvent) + "/" + e1.GetType().Name, e1.Message);
                if (e1.Message.Contains("Cannot delete or update a parent row"))
                {
                    MessageBox.Show("Cannot delete or update a parent row", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                throw new Exception(e1.Message);
            }
            catch (System.Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onClickDelete), nameof(OrderButtonClickEvent) + "/" + e1.GetType().Name, e1.Message);
                database.DisconnectDatabase();
            }
        }

        internal static void onClickSave(OrdersDetail o)
        {
            Database database = new Database();

            try
            {

                if (o.tb_orderid_od.Text == "" || o.cb_drink_id.SelectedItem == null || o.cb_emp.SelectedItem == null || o.cb_topping_id.SelectedItem == null || o.tb_quantity_od.Text == "")
                {
                    MessageBox.Show("Please fill in complete information.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!int.TryParse(o.tb_orderid_od.Text, out int result) || !int.TryParse(o.tb_quantity_od.Text, out int result1))
                {
                    MessageBox.Show("Order ID and quantity must be numbers only.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (database.ConnectDatabase())
                {
                    string query = "update `order` set " +
                        $"EMPLOYEE_ID = '{o.cb_emp.SelectedValue}' " +
                        $"where ORDER_ID = {o.tb_orderid_od.Text}";
                    int row1 = new MySqlCommand(query, database.connection).ExecuteNonQuery();

                    query = "update `order_detail` set " +
                        $"DRINK_ID = '{o.cb_drink_id.SelectedValue}', " +
                        $"TOPPING_ID = '{o.cb_topping_id.SelectedValue}', " +
                        $"QUANTITY = '{o.tb_quantity_od.Text}' " +
                        $"where ORDER_ID = {o.tb_orderid_od.Text}";

                    int row2 = new MySqlCommand(query, database.connection).ExecuteNonQuery();

                    if (row1 > 0 && row2 > 0)
                    {
                        MessageBox.Show("Your changes have been successfully saved!", Reference.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OrderStartupEvent.registerDataGridView(o);
                    }

                    clearTextBox(o);
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
         * @param {@o OrderDetail} to set properties of component
         */
        private static void clearTextBox(OrdersDetail o)
        {
            o.tb_orderid_od.Clear();
            o.cb_drink_id.SelectedItem = null;
            o.cb_emp.SelectedItem = null;
            o.cb_topping_id.SelectedItem = null;
            o.tb_quantity_od.Clear();
        }
    }
}
