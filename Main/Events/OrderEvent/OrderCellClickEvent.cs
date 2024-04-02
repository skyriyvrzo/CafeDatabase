using CSharp.Util.Logging;
using Main.Utils;
using System;
using System.Windows.Forms;

namespace Main.Events.OrderEvent
{
#pragma warning disable IDE1006
    internal sealed class OrderCellClickEvent
    {

        /*
         * show content of the clicked cell
         * if {@editButtonIsEnable Boolean} is false, it will not populate the textBox.
         * 
         * @param {@o OrdersDetail} to set properties of component
         * @param {@ce DataGridViewCellEventArgs} to get the RowIndex of the clicked cell
         */
        internal static void onCellClick(OrdersDetail o, DataGridViewCellEventArgs ce)
        {
            try
            {
                if (o.dataGridView1.Rows[ce.RowIndex].Cells["ORDER_ID"].Value.ToString() == "")
                {
                    MessageBox.Show("Please select a row with data.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if(OrderButtonClickEvent.editButtonIsEnable == false) { return; }

                    o.tb_orderid_od.Text = o.dataGridView1.Rows[ce.RowIndex].Cells["ORDER_ID"].Value.ToString();
                    o.cb_drink_id.SelectedValue = o.dataGridView1.Rows[ce.RowIndex].Cells["DRINK_ID"].Value.ToString();
                    o.cb_emp.SelectedValue = o.dataGridView1.Rows[ce.RowIndex].Cells["EMPLOYEE_ID"].Value.ToString();
                    o.cb_topping_id.SelectedValue = o.dataGridView1.Rows[ce.RowIndex].Cells["TOPPING_ID"].Value.ToString();
                    o.tb_quantity_od.Text = o.dataGridView1.Rows[ce.RowIndex].Cells["QUANTITY"].Value.ToString();
                    
                }
            }catch (Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onCellClick), nameof(OrderCellClickEvent), e1.Message);
            }
        }
    }
}
