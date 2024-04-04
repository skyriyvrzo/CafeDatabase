using System.Windows.Forms;

namespace Main.Events.DrinkEvent
{
#pragma warning disable IDE1006
    internal sealed class DrinkCellFormattingEvent
    {
        internal static void onCellFormat(Drink d, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex != d.dataGridView1.NewRowIndex)
            {
                if (d.dataGridView1.Rows[e.RowIndex].Cells["drink_price"].Value != null)
                {
                    double val1 = double.Parse(e.Value.ToString());
                    e.Value = val1.ToString("N2");
                }
            }
        }
    }
}
