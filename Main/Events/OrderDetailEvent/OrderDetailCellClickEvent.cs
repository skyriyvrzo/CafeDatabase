using CSharp.Util.Logging;
using Main.Events.DrinkEvent;
using Main.Events.OrderEvent;
using Main.Utils;
using System;
using System.Windows.Forms;

namespace Main.Events.OrderDetailEvent
{
#pragma warning disable IDE1006
    internal class OrderDetailCellClickEvent
    {
        /*
         * show content of the clicked cell
         * if {@editButtonIsEnable Boolean} is false, it will not populate the textBox.
         * 
         * @param {@od OrderDetail} to set properties of component
         * @param {@ce DataGridViewCellEventArgs} to get the RowIndex of the clicked cell
         */
        internal static void onCellClick(OrderDetail od, DataGridViewCellEventArgs ce)
        {
            try
            {
                if (od.dataGridView1.Rows[ce.RowIndex].Cells["ORDER_ID"].Value.ToString() == "")
                {
                    MessageBox.Show("Please select a row with data.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (OrderDetailButtonClickEvent.editButtonIsEnable == false) { return; }

                    od.cb_order.SelectedValue = od.dataGridView1.Rows[ce.RowIndex].Cells["ORDER_ID"].Value.ToString();
                    od.cb_drink.SelectedValue = od.dataGridView1.Rows[ce.RowIndex].Cells["DRINK_ID"].Value.ToString();
                    od.cb_topping.SelectedValue = od.dataGridView1.Rows[ce.RowIndex].Cells["TOPPING_ID"].Value.ToString();
                    od.tb_quantity.Text = od.dataGridView1.Rows[ce.RowIndex].Cells["Quantity"].Value.ToString();
                }
            }
            catch (Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onCellClick), nameof(OrderDetailStartupEvent) + "/" + e1.GetType().Name, e1.Message);
            }
        }
    }
}
