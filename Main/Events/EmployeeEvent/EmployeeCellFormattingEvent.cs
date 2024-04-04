using System.Windows.Forms;

namespace Main.Events.EmployeeEvent
{
#pragma warning disable IDE1006
    internal sealed class EmployeeCellFormattingEvent
    {
        internal static void onCellFormat(Employee em, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex != em.dataGridView1.NewRowIndex)
            {
                if (em.dataGridView1.Rows[e.RowIndex].Cells["salary"].Value != null)
                {
                    double val1 = double.Parse(e.Value.ToString());
                    e.Value = val1.ToString("N2");
                }
            }
        }
    }
}
