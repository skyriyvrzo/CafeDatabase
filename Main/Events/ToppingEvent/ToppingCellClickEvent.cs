using CSharp.Util.Logging;
using Main.Utils;
using System;
using System.Windows.Forms;

namespace Main.Events.ToppingEvent
{
#pragma warning disable IDE1006
    internal sealed class ToppingCellClickEvent
    {
        /*
         * show content of the clicked cell
         * if {@editButtonIsEnable Boolean} is false, it will not populate the textBox.
         * 
         * @param {@t Topping} to set properties of component
         * @param {@ce DataGridViewCellEventArgs} to get the RowIndex of the clicked cell
         */
        internal static void onCellClick(Topping t, DataGridViewCellEventArgs ce)
        {
            try
            {
                if (t.dataGridView1.Rows[ce.RowIndex].Cells["TOPPING_ID"].Value.ToString() == "")
                {
                    MessageBox.Show("Please select a row with data.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (ToppingButtonClickEvent.editButtonIsEnable == false) { return; }

                    t.tb_tp_id.Text = t.dataGridView1.Rows[ce.RowIndex].Cells["TOPPING_ID"].Value.ToString();
                    t.tb_tp_name.Text = t.dataGridView1.Rows[ce.RowIndex].Cells["TOPPING_NAME"].Value.ToString();
                    t.tb_tp_price.Text = t.dataGridView1.Rows[ce.RowIndex].Cells["TOPPING_PRICE"].Value.ToString();
                }
            }
            catch (Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onCellClick), nameof(ToppingCellClickEvent), e1.Message);
            }
        }
    }
}