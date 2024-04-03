using CSharp.Util.Logging;
using System.Windows.Forms;

namespace Main
{
#pragma warning disable IDE1006
    public partial class Employee : Form
    {
        public Employee()
        {
            Program.logger.Log(Level.INFO, nameof(Employee), nameof(Employee), nameof(Employee) + " Loading...");
            InitializeComponent();
        }

        private void Employee_Load(object sender, System.EventArgs e)
        {
            Main.Events.EmployeeEvent.EmployeeStartupEvent.load(this);

            Program.logger.Log(Level.INFO, nameof(Employee_Load), nameof(Employee), nameof(Employee) + " Loaded");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }

        private void bt_add_emp_Click(object sender, System.EventArgs e)
        {
            Main.Events.EmployeeEvent.EmployeeButtonClickEvent.onClickAdd(this);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Main.Events.EmployeeEvent.OrderCellClickEvent.onCellClick(this, e);
        }

        private void bt_edit_emp_Click(object sender, System.EventArgs e)
        {
            Main.Events.EmployeeEvent.EmployeeButtonClickEvent.onClickEdit(this);
        }

        private void bt_delete_emp_Click(object sender, System.EventArgs e)
        {
            Main.Events.EmployeeEvent.EmployeeButtonClickEvent.onClickDelete(this);
        }

        private void tb_save_emp_Click(object sender, System.EventArgs e)
        {
            Main.Events.EmployeeEvent.EmployeeButtonClickEvent.onClickSave(this);
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
