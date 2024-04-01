﻿using CSharp.Util.Logging;
using Main.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Main.Event.EmployeeEvent
{
#pragma warning disable IDE1006
    internal class EmployeeButtonClickEvent
    {
        /*
         * insert new data into database(table=employees)
         * 
         * if textBox and comboBox is empty or null, will displays the message box warning and returns it.
         * and employee id and salary are not numbers, a message box warning will be displayed and returned.
         * 
         * @param {@e Employee} to set properties of component
         */

        internal static void onClickAdd(Employee e)
        {
            Database database = new Database();
            
            try
            {

                if (database.ConnectDatabase())
                {
                    if(e.tb_empid.Text == "" || e.tb_fname.Text == "" || e.tb_lname.Text == "" || e.tb_salary.Text == "" || e.cb_sex.SelectedItem == null)
                    {
                        MessageBox.Show("Please fill in complete information.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if(!int.TryParse(e.tb_empid.Text, out int result) || !int.TryParse(e.tb_salary.Text, out int result1))
                    {
                        MessageBox.Show("Employee ID and salary must be numbers only.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    char sex = e.cb_sex.SelectedItem.ToString() == "Male" ? 'M' : 'F';
                    string query = "insert into `employees` (EMPLOYEE_ID, FIRST_NAME, LAST_NAME, SALARY, SEX) " +
                        "values(" +
                        $"'{e.tb_empid.Text}' ," +
                        $"'{e.tb_fname.Text}' ," +
                        $"'{e.tb_lname.Text}' ," +
                        $"'{e.tb_salary.Text}' ," +
                        $"'{sex}')";

                    MySqlCommand command = new MySqlCommand(query, database.connection);

                    int row = command.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Add successfully", Reference.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EmployeeStartupEvent.registerDataGridView(e);
                    }

                    database.DisconnectDatabase();
                }

            }
            catch (MySqlException e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onClickAdd), nameof(EmployeeButtonClickEvent) + "/" + e1.GetType().Name, e1.Message);
                database.DisconnectDatabase();

                if (e1.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("ID: `" + e.tb_empid.Text + "` looks like a duplicate.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                throw new System.Exception(e1.Message);
            }
            catch (System.Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onClickAdd), nameof(EmployeeButtonClickEvent) + "/" + e1.GetType().Name, e1.Message);
                database.DisconnectDatabase();
                MessageBox.Show(e1.Message, Reference.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         * can click inside a cell
         * 
         * @param {@e Employee} to set properties of component
         */
        private static bool editButtonIsEnable = false;
        internal static void onClickEdit(Employee e)
        {
            if (editButtonIsEnable == false)
            {
                editButtonIsEnable = true;
                e.dataGridView1.Enabled = true;
                e.bt_edit_emp.BackColor = Color.FromArgb(138, 226, 52);
            }
            else
            {
                editButtonIsEnable = false;
                e.dataGridView1.Enabled = false;
                e.bt_edit_emp.BackColor = Color.White;
            }
        }

        /*
         * Delete data from table.
         *
         * Show MessageBox confirm when pressing delete button
         */
        internal static void onClickDelete(Employee e)
        {
            Database database = new Database();

            try
            {
                if(e.tb_empid.Text == "")
                {
                    MessageBox.Show("Please select the employee you want to delete.", Reference.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }else if(MessageBox.Show("Are you sure you want to delete?", Reference.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (database.ConnectDatabase())
                    {
                        string query = $"delete from `employees` where EMPLOYEE_ID = '{e.tb_empid.Text}'";
                        MySqlCommand command = new MySqlCommand(query, database.connection);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Delete successfully", Reference.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EmployeeStartupEvent.registerDataGridView(e);
                        database.DisconnectDatabase();
                    }
                }
            }catch(System.Exception e1)
            {
                Program.logger.Log(Level.ERROR, nameof(onClickDelete), nameof(EmployeeButtonClickEvent) + "/" + e1.GetType().Name, e1.Message);
                database.DisconnectDatabase();
            }
        }

        /*
         * Save data into database after editing
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
