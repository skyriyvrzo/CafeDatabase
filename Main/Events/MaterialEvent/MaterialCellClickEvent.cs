using CSharp.Util.Logging;
using Main.Events.EmployeeEvent;
using Main.Events.ToppingEvent;
using Main.Utils;
using System;
using System.Windows.Forms;

namespace Main.Events.MaterialEvent
{
#pragma warning disable IDE1006
    internal sealed class MaterialCellClickEvent
    {
        /*
         * show content of the clicked cell
         * if {@editButtonIsEnable Boolean} is false, it will not populate the textBox.
         * 
         * @param {@m Material} to set properties of component
         * @param {@ce DataGridViewCellEventArgs} to get the RowIndex of the clicked cell
         */
        internal static void onCellClick(Material m, DataGridViewCellEventArgs ce)
        {
            try
            {
                if (m.dataGridView1.Rows[ce.RowIndex].Cells["MATERIAL_ID"].Value.ToString() == "")
                {
                    MessageBox.Show("Please select a row with data.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MaterialButtonClickEvent.editButtonIsEnable == false) { return; }

                    m.tb_matid.Text = m.dataGridView1.Rows[ce.RowIndex].Cells["MATERIAL_ID"].Value.ToString();
                    m.tb_matname.Text = m.dataGridView1.Rows[ce.RowIndex].Cells["MATERIAL_NAME"].Value.ToString();
                }
            }
            catch (Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onCellClick), nameof(MaterialCellClickEvent), e1.Message);
            }
        }
    }
}