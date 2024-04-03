using CSharp.Util.Logging;
using System;
using System.Windows.Forms;

namespace Main
{
    public partial class MaterialofDrink : Form
    {
        public MaterialofDrink()
        {
            Program.logger.Log(Level.INFO, nameof(MaterialofDrink), nameof(MaterialofDrink), nameof(MaterialofDrink) + " Loading...");

            InitializeComponent();
        }

        private void MaterialofDrink_Load(object sender, EventArgs e)
        {
            Main.Events.MaterialofDrinkEvent.MaterialofDrinkStartupEvent.load(this);

            Program.logger.Log(Level.INFO, nameof(MaterialofDrink_Load), nameof(MaterialofDrink), nameof(MaterialofDrink) + " Loaded");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            Main.Events.MaterialofDrinkEvent.MaterialofDrinkButtonClickEvent.onClickAdd(this);
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            Main.Events.MaterialofDrinkEvent.MaterialofDrinkButtonClickEvent.onClickEdit(this);
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            Main.Events.MaterialofDrinkEvent.MaterialofDrinkButtonClickEvent.onClickDelete(this);
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            Main.Events.MaterialofDrinkEvent.MaterialofDrinkButtonClickEvent.onClickSave(this);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Main.Events.MaterialofDrinkEvent.MaterialofDrinkCellClickEvent.onCellClick(this, e);
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
