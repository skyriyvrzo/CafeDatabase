using CSharp.Util.Logging;
using Main.Events.EmployeeEvent;
using Main.Utils;
using System;
using System.Windows.Forms;

namespace Main.Events.DrinkEvent
{
#pragma warning disable IDE1006
    internal sealed class DrinkCellClickEvent
    {
        /*
         * show content of the clicked cell
         * if {@editButtonIsEnable Boolean} is false, it will not populate the textBox.
         * 
         * @param {@d Drink} to set properties of component
         * @param {@ce DataGridViewCellEventArgs} to get the RowIndex of the clicked cell
         */
        internal static void onCellClick(Drink d, DataGridViewCellEventArgs ce)
        {
            try
            {
                if (d.dataGridView1.Rows[ce.RowIndex].Cells["DRINK_ID"].Value.ToString() == "")
                {
                    MessageBox.Show("Please select a row with data.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (DrinkButtonClickEvent.editButtonIsEnable == false) { return; }

                    d.tb_drink_id.Text = d.dataGridView1.Rows[ce.RowIndex].Cells["DRINK_ID"].Value.ToString();
                    d.tb_name.Text = d.dataGridView1.Rows[ce.RowIndex].Cells["DRINK_NAME"].Value.ToString();
                    d.tb_price.Text = d.dataGridView1.Rows[ce.RowIndex].Cells["DRINK_PRICE"].Value.ToString();
                    //Console.WriteLine(d.dataGridView1.Rows[ce.RowIndex].Cells["DRINK_STATUS"].Value.ToString());
                    d.cb_status.SelectedIndex = d.dataGridView1.Rows[ce.RowIndex].Cells["DRINK_STATUS"].Value.ToString() == "False" ? 0 : 1;
                }
            }
            catch (System.Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onCellClick), nameof(DrinkCellClickEvent) + "/" + e1.GetType().Name, e1.Message);
            }
        }
    }
}
