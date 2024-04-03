using CSharp.Util.Logging;
using System;
using System.Windows.Forms;

namespace Main
{
    public partial class OrderDetail : Form
    {
        public OrderDetail()
        {
            Program.logger.Log(Level.INFO, nameof(OrderDetail), nameof(OrderDetail), nameof(OrderDetail) + " Loading...");

            InitializeComponent();
        }

        private void OrderDetail_Load(object sender, EventArgs e)
        {
            Main.Events.OrderDetailEvent.OrderDetailStartupEvent.load(this);

            Program.logger.Log(Level.INFO, nameof(OrderDetail_Load), nameof(OrderDetail), nameof(OrderDetail) + " Loaded");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Main.Events.OrderDetailEvent.OrderDetailCellClickEvent.onCellClick(this, e);
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            Main.Events.OrderDetailEvent.OrderDetailButtonClickEvent.onClickAdd(this);
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            Main.Events.OrderDetailEvent.OrderDetailButtonClickEvent.onClickEdit(this);
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            Main.Events.OrderDetailEvent.OrderDetailButtonClickEvent.onClickDelete(this);
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            Main.Events.OrderDetailEvent.OrderDetailButtonClickEvent.onClickSave(this);
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
