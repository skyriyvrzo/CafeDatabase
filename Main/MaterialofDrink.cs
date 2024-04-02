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
    public partial class MaterialofDrink : Form
    {
        public MaterialofDrink()
        {
            InitializeComponent();
        }

        private void MaterialofDrink_Load(object sender, EventArgs e)
        {
            Main.Events.MaterialofDrinkEvent.MaterialofDrinkStartupEvent.load(this);
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
    }
}
