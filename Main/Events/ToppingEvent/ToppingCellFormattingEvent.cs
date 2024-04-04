using System.Windows.Forms;

namespace Main.Events.ToppingEvent
{
#pragma warning disable IDE1006
    internal sealed class ToppingCellFormattingEvent
    {
        internal static void onCellFormat(Topping t, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex != t.dataGridView1.NewRowIndex)
            {
                if (t.dataGridView1.Rows[e.RowIndex].Cells["topping_price"].Value != null)
                {
                    double val1 = double.Parse(e.Value.ToString());
                    e.Value = val1.ToString("N2");
                }
            }
        }
    }
}
