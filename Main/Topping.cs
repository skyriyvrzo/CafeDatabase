using System;
using System.Windows.Forms;

namespace Main
{
#pragma warning disable IDE1006
    public partial class Topping : Form
    {
        public Topping()
        {
            InitializeComponent();
        }
        private void Topping_Load(object sender, EventArgs e)
        {
            Main.Events.ToppingEvent.ToppingStartupEvent.load(this);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            Main.Events.ToppingEvent.ToppingButtonClickEvent.onClickAdd(this);
        }

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            Main.Events.ToppingEvent.ToppingButtonClickEvent.onClickEdit(this);
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            Main.Events.ToppingEvent.ToppingButtonClickEvent.onClickDelete(this);
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            Main.Events.ToppingEvent.ToppingButtonClickEvent.onClickSave(this);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Main.Events.ToppingEvent.ToppingCellClickEvent.onCellClick(this, e);
        }

    }
}
