namespace Main.Event.EmployeeEvent
{
#pragma warning disable IDE1006
    internal class EmployeeButtonClickEvent
    {
        /*
         * clear all value in textbox
         * enable edit mode for textbox and combobox
         * 
         * @param {@e Employee} for set properties of component
         */

        internal static void onClickAdd(Employee e)
        {
            e.tb_empid.Clear();
            e.tb_fname.Clear();
            e.tb_lname.Clear();
            e.tb_salary.Clear();
            e.cb_sex.SelectedItem = null;

            e.tb_empid.Enabled = true;
            e.tb_fname.Enabled = true;
            e.tb_lname.Enabled = true;
            e.tb_salary.Enabled = true;
            e.cb_sex.Enabled = true;
        }

        /*
         * Enable textbox to editable
         * 
         */
        internal static void onClickEdit()
        {

        }

        /*
         * Delete data from table.
         *
         * Show MessageBox confirm when pressing delete button
         */
        internal static void onClickDelete()
        {

        }

        /*
         * Save data into database
         */
        internal static void onClickSave()
        {

        }

        /*
         * Move to Mene(Menu.cs) display
         * 
         * @param
         */
        internal static void onClickMenu() { 
        
        }
    }
}
