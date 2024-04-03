using CSharp.Util.Logging;
using Main.Utils;
using System;
using System.Windows.Forms;

namespace Main.Events.EmployeeEvent
{
#pragma warning disable IDE1006
    internal sealed class OrderCellClickEvent
    {

        /*
         * show content of the clicked cell
         * if {@editButtonIsEnable Boolean} is false, it will not populate the textBox.
         * 
         * @param {@e Employee} to set properties of component
         * @param {@ce DataGridViewCellEventArgs} to get the RowIndex of the clicked cell
         */
        internal static void onCellClick(Employee e, DataGridViewCellEventArgs ce)
        {
            try
            {
                if (e.dataGridView1.Rows[ce.RowIndex].Cells["EMPLOYEE_ID"].Value.ToString() == "")
                {
                    MessageBox.Show("Please select a row with data.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if(EmployeeButtonClickEvent.editButtonIsEnable == false) { return; }

                    e.tb_empid.Text = e.dataGridView1.Rows[ce.RowIndex].Cells["EMPLOYEE_ID"].Value.ToString();
                    e.tb_fname.Text = e.dataGridView1.Rows[ce.RowIndex].Cells["FIRST_NAME"].Value.ToString();
                    e.tb_lname.Text = e.dataGridView1.Rows[ce.RowIndex].Cells["LAST_NAME"].Value.ToString();
                    e.tb_salary.Text = e.dataGridView1.Rows[ce.RowIndex].Cells["SALARY"].Value.ToString();
                    Console.WriteLine(e.dataGridView1.Rows[ce.RowIndex].Cells["SEX"].Value.ToString());
                    e.cb_sex.SelectedIndex = e.dataGridView1.Rows[ce.RowIndex].Cells["SEX"].Value.ToString() == "M" ? 0 : 1;
                }
            }catch (Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onCellClick), nameof(OrderCellClickEvent) + "/" + e1.GetType().Name, e1.Message);
            }
        }
    }
}
