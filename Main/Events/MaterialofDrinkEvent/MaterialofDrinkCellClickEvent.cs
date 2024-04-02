using CSharp.Util.Logging;
using Main.Events.OrderEvent;
using Main.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Events.MaterialofDrinkEvent
{
#pragma warning disable IDE1006
    internal sealed class MaterialofDrinkCellClickEvent
    {
        /*
         * show content of the clicked cell
         * if {@editButtonIsEnable Boolean} is false, it will not populate the textBox.
         * 
         * @param {@mod MaterialofDrink} to set properties of component
         * @param {@ce DataGridViewCellEventArgs} to get the RowIndex of the clicked cell
         */
        internal static void onCellClick(MaterialofDrink mod, DataGridViewCellEventArgs ce)
        {
            try
            {
                if (mod.dataGridView1.Rows[ce.RowIndex].Cells["DRINK_ID"].Value.ToString() == "")
                {
                    MessageBox.Show("Please select a row with data.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MaterialofDrinkButtonClickEvent.editButtonIsEnable == false) { return; }

                    mod.cb_drink.SelectedValue = mod.dataGridView1.Rows[ce.RowIndex].Cells["DRINK_ID"].Value.ToString();
                    mod.cb_material.SelectedValue = mod.dataGridView1.Rows[ce.RowIndex].Cells["MATERIAL_ID"].Value.ToString();

                    MaterialofDrinkButtonClickEvent.materialOldValue = mod.dataGridView1.Rows[ce.RowIndex].Cells["MATERIAL_ID"].Value.ToString();
                }
            }
            catch (Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onCellClick), nameof(OrderCellClickEvent), e1.Message);
            }
        }
    }
}
