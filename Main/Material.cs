using System;
using System.Windows.Forms;

namespace Main
{
#pragma warning disable IDE1006
    public partial class Material : Form
    {
        public Material()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }

        private void Material_Load(object sender, EventArgs e)
        {
            Main.Events.MaterialEvent.MaterialStartupEvent.load(this);
        }

        private void bt_add_Material_Click(object sender, EventArgs e)
        {
            Main.Events.MaterialEvent.MaterialButtonClickEvent.onClickAdd(this);
        }

        private void bt_Edit_Material_Click(object sender, EventArgs e)
        {
            Main.Events.MaterialEvent.MaterialButtonClickEvent.onClickEdit(this);
        }

        private void bt_delete_Material_Click(object sender, EventArgs e)
        {
            Main.Events.MaterialEvent.MaterialButtonClickEvent.onClickDelete(this);
        }

        private void bt_save_Material_Click(object sender, EventArgs e)
        {
            Main.Events.MaterialEvent.MaterialButtonClickEvent.onClickSave(this);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Main.Events.MaterialEvent.MaterialCellClickEvent.onCellClick(this, e);
        }
    }
}
