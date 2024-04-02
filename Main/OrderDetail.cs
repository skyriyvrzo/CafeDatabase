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
    public partial class OrderDetail : Form
    {
        public OrderDetail()
        {
            InitializeComponent();
        }

        private void OrderDetail_Load(object sender, EventArgs e)
        {
            Main.Events.OrderDetailEvent.OrderDetailStartupEvent.load(this);
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
    }
}
