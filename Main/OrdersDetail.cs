using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
#pragma warning disable IDE1006
    public partial class OrdersDetail : Form
    {
        public OrdersDetail()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_emp_Click(object sender, EventArgs e)
        {
            Main.Events.ScreenChangeEvent.ScreenButtonClickEvent.onClickEmployee(this);
        }

        private void OrdersDetail_Load(object sender, EventArgs e)
        {
            Main.Events.OrderEvent.OrderStartupEvent.load(this);
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
    }
}
