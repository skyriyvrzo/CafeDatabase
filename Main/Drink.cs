using CSharp.Util.Logging;
using System;
using System.Windows.Forms;

namespace Main
{
#pragma warning disable IDE1006
    public partial class Drink : Form
    {
        public Drink()
        {
            Program.logger.Log(Level.INFO, nameof(Drink), nameof(Drink), nameof(Drink) + " Loading...");

            InitializeComponent();
        }
        private void Drink_Load(object sender, EventArgs e)
        {
            Main.Events.DrinkEvent.DrinkStartupEvent.load(this);

            Program.logger.Log(Level.INFO, nameof(Drink_Load), nameof(Drink), nameof(Drink) + " Loaded");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
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

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Main.Events.DrinkEvent.DrinkCellFormattingEvent.onCellFormat(this, e);
        }
    }
}
