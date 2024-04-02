using System;
using System.Windows.Forms;

namespace Main
{
#pragma warning disable IDE1006
    public partial class Drink : Form
    {
        public Drink()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }

        private void Drink_Load(object sender, EventArgs e)
        {
            Main.Events.DrinkEvent.DrinkStartupEvent.load(this);
        }

        private void bt_add_Drink_Click(object sender, EventArgs e)
        {
            Main.Events.DrinkEvent.DrinkButtonClickEvent.onClickAdd(this);
        }

        private void bt_Edit_Drink_Click(object sender, EventArgs e)
        {
            Main.Events.DrinkEvent.DrinkButtonClickEvent.onClickEdit(this);
        }

        private void bt_delete_drink_Click(object sender, EventArgs e)
        {
            Main.Events.DrinkEvent.DrinkButtonClickEvent.onClickDelete(this);
        }

        private void bt_save_Drink_Click(object sender, EventArgs e)
        {
            Main.Events.DrinkEvent.DrinkButtonClickEvent.onClickSave(this);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Main.Events.DrinkEvent.DrinkCellClickEvent.onCellClick(this, e);
        }
    }
}
