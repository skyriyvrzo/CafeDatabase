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
