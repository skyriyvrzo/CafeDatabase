using CSharp.Util.Logging;
using System.Windows.Forms;

namespace Main
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            Program.logger.Log(Level.INFO, typeof(Main) + " Loaded");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
