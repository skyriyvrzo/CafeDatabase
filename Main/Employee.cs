using CSharp.Util.Logging;
using System.Windows.Forms;

namespace Main
{
#pragma warning disable IDE1006
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();

            Program.logger.Log(Level.INFO, nameof(Employee) + " Loaded");
        }

        private void Employee_Load(object sender, System.EventArgs e)
        {
            Event.EmployeeEvent.EmployeeStartupEvent.load(this);

            Program.logger.Log(Level.INFO, nameof(Employee_Load) + " Loaded");
        }

        private void bt_add_emp_Click(object sender, System.EventArgs e)
        {
            Event.EmployeeEvent.EmployeeButtonClickEvent.onClickAdd(this);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Event.EmployeeEvent.EmployeeCellClickEvent.onCellClick(this, e);
        }

        private void bt_edit_emp_Click(object sender, System.EventArgs e)
        {
            Event.EmployeeEvent.EmployeeButtonClickEvent.onClickEdit(this);
        }

        private void bt_delete_emp_Click(object sender, System.EventArgs e)
        {
            Event.EmployeeEvent.EmployeeButtonClickEvent.onClickDelete(this);
        }
    }
}
