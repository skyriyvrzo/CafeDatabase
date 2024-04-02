using CSharp.Util.Logging;
using System;
using System.Windows.Forms;

namespace Main.Event.EmployeeEvent
{
#pragma warning disable IDE1006
    internal class EmployeeCellClickEvent
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
                    MessageBox.Show("Please select a row with data.", "Cafe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if(EmployeeButtonClickEvent.editButtonIsEnable == false) { return; }

                    e.tb_empid.Text = e.dataGridView1.Rows[ce.RowIndex].Cells["EMPLOYEE_ID"].Value.ToString();
                    e.tb_fname.Text = e.dataGridView1.Rows[ce.RowIndex].Cells["FIRST_NAME"].Value.ToString();
                    e.tb_lname.Text = e.dataGridView1.Rows[ce.RowIndex].Cells["LAST_NAME"].Value.ToString();
                    e.tb_salary.Text = e.dataGridView1.Rows[ce.RowIndex].Cells["SALARY"].Value.ToString();
                    e.cb_sex.SelectedItem = e.dataGridView1.Rows[ce.RowIndex].Cells["SEX"].Value.ToString() == "M" ? "Male" : "Female";
                }
            }catch (Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onCellClick), nameof(EmployeeCellClickEvent), e1.Message);
            }
        }
    }
}
