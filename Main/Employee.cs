using CSharp.Util.Logging;
using System.Windows.Forms;

namespace Main
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();

            Program.logger.Log(Level.INFO, typeof(Employee) + " Loaded");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }
    }
}
