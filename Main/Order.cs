using CSharp.Util.Logging;
using System;
using System.Windows.Forms;

namespace Main
{
#pragma warning disable IDE1006
    public partial class Order : Form
    {
        public Order()
        {
            Program.logger.Log(Level.INFO, nameof(Order), nameof(Order), nameof(Order) + " Loading...");

            InitializeComponent();
        }
        private void Order_Load(object sender, EventArgs e)
        {
            Main.Events.OrderEvent.OrderStartupEvent.load(this);

            Program.logger.Log(Level.INFO, nameof(Order_Load), nameof(Order), nameof(Order) + " Loaded");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }

        private void bt_emp_Click(object sender, EventArgs e)
        {
            Main.Events.ScreenChangeEvent.ScreenButtonClickEvent.onClickEmployee(this);
        }


        private void bt_add_od_Click(object sender, EventArgs e)
        {
            Main.Events.OrderEvent.OrderButtonClickEvent.onClickAdd(this);
        }

        private void bt_edit__Click(object sender, EventArgs e)
        {
            Main.Events.OrderEvent.OrderButtonClickEvent.onClickEdit(this);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Main.Events.OrderEvent.OrderCellClickEvent.onCellClick(this, e);
        }

        private void bt_delete_od_Click(object sender, EventArgs e)
        {
            Main.Events.OrderEvent.OrderButtonClickEvent.onClickDelete(this);
        }

        private void bt_save_od_Click(object sender, EventArgs e)
        {
            Main.Events.OrderEvent.OrderButtonClickEvent.onClickSave(this);
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
