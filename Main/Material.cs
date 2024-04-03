using CSharp.Util.Logging;
using System;
using System.Windows.Forms;

namespace Main
{
#pragma warning disable IDE1006
    public partial class Material : Form
    {
        public Material()
        {
            Program.logger.Log(Level.INFO, nameof(Material), nameof(Material), nameof(Material) + " Loading...");

            InitializeComponent();
        }
        private void Material_Load(object sender, EventArgs e)
        {
            Main.Events.MaterialEvent.MaterialStartupEvent.load(this);

            Program.logger.Log(Level.INFO, nameof(Material_Load), nameof(Material), nameof(Material) + " Loaded");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
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

        private void bt_order_Click(object sender, System.EventArgs e)
        {
            Main.Events.ScreenChangeEvent.ScreenButtonClickEvent.onClickOrder(this);
        }

        private void bt_employee_Click(object sender, System.EventArgs e)
        {
            Main.Events.ScreenChangeEvent.ScreenButtonClickEvent.onClickEmployee(this);
        }
        private void bt_drink_Click(object sender, System.EventArgs e)
        {
            Main.Events.ScreenChangeEvent.ScreenButtonClickEvent.onClickDrink(this);
        }

        private void bt_mat_Click(object sender, System.EventArgs e)
        {
            Main.Events.ScreenChangeEvent.ScreenButtonClickEvent.onClickMaterial(this);
        }

        private void bt_topping_Click(object sender, System.EventArgs e)
        {
            Main.Events.ScreenChangeEvent.ScreenButtonClickEvent.onClickTopping(this);
        }

        private void bt_mod_Click(object sender, System.EventArgs e)
        {
            Main.Events.ScreenChangeEvent.ScreenButtonClickEvent.onClickMaterialofDrink(this);
        }

        private void bt_od_Click(object sender, System.EventArgs e)
        {
            Main.Events.ScreenChangeEvent.ScreenButtonClickEvent.onClickOrderDetail(this);
        }
    }
}
