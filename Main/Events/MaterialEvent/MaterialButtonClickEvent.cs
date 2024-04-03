using CSharp.Util.Logging;
using Main.Events.DrinkEvent;
using Main.Events.EmployeeEvent;
using Main.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Main.Events.MaterialEvent
{
#pragma warning disable IDE1006
    internal sealed class MaterialButtonClickEvent
    {
        /*
         * insert new data into database(table=material)
         * 
         * if textBox is empty, will displays the message box warning and returns it.
         * and material id are not numbers, a message box warning will be displayed and returned.
         * 
         * @param {@m Material} to set properties of component
         */

        internal static void onClickAdd(Material m)
        {
            Database database = new Database();

            try
            {

                if (database.ConnectDatabase())
                {
                    if (m.tb_matid.Text == "" || m.tb_matname.Text == "")
                    {
                        MessageBox.Show("Please fill in complete information.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (!int.TryParse(m.tb_matid.Text, out int result))
                    {
                        MessageBox.Show("Material ID must be numbers only.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string query = "insert into `material` (MATERIAL_ID, MATERIAL_NAME) " +
                        "values(" +
                        $"'{m.tb_matid.Text}' ," +
                        $"'{m.tb_matname.Text}')";

                    int row = new MySqlCommand(query, database.connection).ExecuteNonQuery();

                    if (row > 0)
                    {
                        MessageBox.Show("Add successfully", Reference.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MaterialStartupEvent.registerDataGridView(m);
                    }

                    clearTextBox(m);
                    database.DisconnectDatabase();
                }

            }
            catch (MySqlException e1)
            {
                Program.logger.Log(Level.WARNING, nameof(onClickAdd), nameof(MaterialButtonClickEvent) + "/" + e1.GetType().Name, e1.Message);
                database.DisconnectDatabase();

                if (e1.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("ID: `" + m.tb_matid.Text + "` looks like a duplicate.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                throw new System.Exception(e1.Message);
            }
            catch (System.Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onClickAdd), nameof(MaterialButtonClickEvent) + "/" + e1.GetType().Name, e1.Message);
                database.DisconnectDatabase();
                MessageBox.Show(e1.Message, Reference.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         * change button color.
         * lock textBox(Employee ID)
         * 
         * @param {@e Employee} to set properties of component
         */
        internal static bool editButtonIsEnable = false;
        internal static void onClickEdit(Material m)
        {
            if (editButtonIsEnable == false)
            {
                editButtonIsEnable = true;
                //e.dataGridView1.Enabled = true;
                m.tb_matid.Enabled = false;
                m.bt_Edit_Material.BackColor = Color.FromArgb(138, 226, 52);
            }
            else
            {
                editButtonIsEnable = false;
                //e.dataGridView1.Enabled = false;
                m.tb_matid.Enabled = true;
                m.dataGridView1.ClearSelection();
                m.bt_Edit_Material.BackColor = Color.White;
            }
        }

        /*
         * Delete data from table.
         *
         * Show MessageBox confirm when pressing delete button
         * 
         * @param {@e Employee} to set properties of component
         */
        internal static void onClickDelete(Material m)
        {
            Database database = new Database();

            try
            {
                if (m.tb_matid.Text == "")
                {
                    MessageBox.Show("Please select the material you want to delete.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (MessageBox.Show("Are you sure you want to delete?", Reference.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (database.ConnectDatabase())
                    {
                        string query = $"delete from `material` where MATERIAL_ID = '{m.tb_matid.Text}'";
                        int row = new MySqlCommand(query, database.connection).ExecuteNonQuery();

                        if(row > 0)
                        {
                            MessageBox.Show("Delete successfully", Reference.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        clearTextBox(m);
                        MaterialStartupEvent.registerDataGridView(m);
                        database.DisconnectDatabase();
                    }
                }
            }
            catch (MySqlException e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onClickDelete), nameof(MaterialButtonClickEvent) + "/" + e1.GetType().Name, e1.Message);

                if (e1.Message.Contains("Cannot delete or update a parent row"))
                {
                    MessageBox.Show("Cannot delete or update a parent row", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                throw new Exception(e1.Message);
            }
            catch (System.Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onClickDelete), nameof(MaterialButtonClickEvent) + "/" + e1.GetType().Name, e1.Message);
                database.DisconnectDatabase();
            }
        }

        /*
         * Save data into database after editing
         * 
         * @param {@e Employee} to set properties of component
         */
        internal static void onClickSave(Material m)
        {
            Database database = new Database();

            try
            {

                if (m.tb_matid.Text == "" || m.tb_matname.Text == "")
                {
                    MessageBox.Show("Please fill in complete information.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!int.TryParse(m.tb_matid.Text, out int result))
                {
                    MessageBox.Show("Material ID must be numbers only.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (database.ConnectDatabase())
                {

                    string query = "update `material` set " +
                        $"MATERIAL_NAME = '{m.tb_matname.Text}' " +
                        $"where MATERIAL_ID = {m.tb_matid.Text}";

                    int row = new MySqlCommand(query, database.connection).ExecuteNonQuery();

                    if (row > 0)
                    {
                        MessageBox.Show("Your changes have been successfully saved!", Reference.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MaterialStartupEvent.registerDataGridView(m);
                    }

                    clearTextBox(m);
                    database.DisconnectDatabase();
                }

            }
            catch (Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onClickSave), nameof(MaterialButtonClickEvent) + "/" + e1.GetType().Name, e1.Message);
                database.DisconnectDatabase();
            }
        }

        /*
         * clear values in textBox
         *
         * @param {@e Employee} to set properties of component
         */
        private static void clearTextBox(Material m)
        {
            m.tb_matid.Clear();
            m.tb_matname.Clear();

            Program.logger.Log(Level.INFO, nameof(clearTextBox), nameof(MaterialButtonClickEvent), "Removed item(s) from components");
        }
    }
}
