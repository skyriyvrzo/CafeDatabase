namespace Main
{
    partial class Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_empid = new System.Windows.Forms.TextBox();
            this.tb_fname = new System.Windows.Forms.TextBox();
            this.tb_lname = new System.Windows.Forms.TextBox();
            this.tb_salary = new System.Windows.Forms.TextBox();
            this.l_emp_id = new System.Windows.Forms.Label();
            this.l_fname = new System.Windows.Forms.Label();
            this.l_lname = new System.Windows.Forms.Label();
            this.l_sex = new System.Windows.Forms.Label();
            this.l_salary = new System.Windows.Forms.Label();
            this.bt_add_emp = new System.Windows.Forms.Button();
            this.bt_edit_emp = new System.Windows.Forms.Button();
            this.bt_delete_emp = new System.Windows.Forms.Button();
            this.tb_save_emp = new System.Windows.Forms.Button();
            this.bt_Menu_emp = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.cb_sex = new System.Windows.Forms.ComboBox();
            this.bt_drink_emp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(913, 356);
            this.dataGridView1.TabIndex = 0;
            // 
            // tb_empid
            // 
            this.tb_empid.Location = new System.Drawing.Point(119, 23);
            this.tb_empid.Name = "tb_empid";
            this.tb_empid.Size = new System.Drawing.Size(100, 20);
            this.tb_empid.TabIndex = 1;
            // 
            // tb_fname
            // 
            this.tb_fname.Location = new System.Drawing.Point(119, 56);
            this.tb_fname.Name = "tb_fname";
            this.tb_fname.Size = new System.Drawing.Size(100, 20);
            this.tb_fname.TabIndex = 2;
            // 
            // tb_lname
            // 
            this.tb_lname.Location = new System.Drawing.Point(119, 85);
            this.tb_lname.Name = "tb_lname";
            this.tb_lname.Size = new System.Drawing.Size(100, 20);
            this.tb_lname.TabIndex = 3;
            // 
            // tb_salary
            // 
            this.tb_salary.Location = new System.Drawing.Point(119, 115);
            this.tb_salary.Name = "tb_salary";
            this.tb_salary.Size = new System.Drawing.Size(100, 20);
            this.tb_salary.TabIndex = 4;
            // 
            // l_emp_id
            // 
            this.l_emp_id.AutoSize = true;
            this.l_emp_id.Location = new System.Drawing.Point(49, 26);
            this.l_emp_id.Name = "l_emp_id";
            this.l_emp_id.Size = new System.Drawing.Size(64, 13);
            this.l_emp_id.TabIndex = 6;
            this.l_emp_id.Text = "EmployeeID";
            // 
            // l_fname
            // 
            this.l_fname.AutoSize = true;
            this.l_fname.Location = new System.Drawing.Point(49, 56);
            this.l_fname.Name = "l_fname";
            this.l_fname.Size = new System.Drawing.Size(54, 13);
            this.l_fname.TabIndex = 7;
            this.l_fname.Text = "FirstName";
            // 
            // l_lname
            // 
            this.l_lname.AutoSize = true;
            this.l_lname.Location = new System.Drawing.Point(49, 85);
            this.l_lname.Name = "l_lname";
            this.l_lname.Size = new System.Drawing.Size(55, 13);
            this.l_lname.TabIndex = 8;
            this.l_lname.Text = "LastName";
            // 
            // l_sex
            // 
            this.l_sex.AutoSize = true;
            this.l_sex.Location = new System.Drawing.Point(57, 141);
            this.l_sex.Name = "l_sex";
            this.l_sex.Size = new System.Drawing.Size(25, 13);
            this.l_sex.TabIndex = 9;
            this.l_sex.Text = "Sex";
            // 
            // l_salary
            // 
            this.l_salary.AutoSize = true;
            this.l_salary.Location = new System.Drawing.Point(57, 115);
            this.l_salary.Name = "l_salary";
            this.l_salary.Size = new System.Drawing.Size(36, 13);
            this.l_salary.TabIndex = 10;
            this.l_salary.Text = "Salary";
            // 
            // bt_add_emp
            // 
            this.bt_add_emp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_add_emp.Location = new System.Drawing.Point(294, 16);
            this.bt_add_emp.Name = "bt_add_emp";
            this.bt_add_emp.Size = new System.Drawing.Size(75, 23);
            this.bt_add_emp.TabIndex = 11;
            this.bt_add_emp.Text = "Add";
            this.bt_add_emp.UseVisualStyleBackColor = true;
            // 
            // bt_edit_emp
            // 
            this.bt_edit_emp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_edit_emp.Location = new System.Drawing.Point(375, 16);
            this.bt_edit_emp.Name = "bt_edit_emp";
            this.bt_edit_emp.Size = new System.Drawing.Size(75, 23);
            this.bt_edit_emp.TabIndex = 12;
            this.bt_edit_emp.Text = "Edit";
            this.bt_edit_emp.UseVisualStyleBackColor = true;
            // 
            // bt_delete_emp
            // 
            this.bt_delete_emp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_delete_emp.Location = new System.Drawing.Point(456, 16);
            this.bt_delete_emp.Name = "bt_delete_emp";
            this.bt_delete_emp.Size = new System.Drawing.Size(75, 23);
            this.bt_delete_emp.TabIndex = 13;
            this.bt_delete_emp.Text = "Delete";
            this.bt_delete_emp.UseVisualStyleBackColor = true;
            // 
            // tb_save_emp
            // 
            this.tb_save_emp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_save_emp.Location = new System.Drawing.Point(537, 16);
            this.tb_save_emp.Name = "tb_save_emp";
            this.tb_save_emp.Size = new System.Drawing.Size(75, 23);
            this.tb_save_emp.TabIndex = 14;
            this.tb_save_emp.Text = "Save";
            this.tb_save_emp.UseVisualStyleBackColor = true;
            // 
            // bt_Menu_emp
            // 
            this.bt_Menu_emp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_Menu_emp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Menu_emp.Location = new System.Drawing.Point(294, 45);
            this.bt_Menu_emp.Name = "bt_Menu_emp";
            this.bt_Menu_emp.Size = new System.Drawing.Size(75, 60);
            this.bt_Menu_emp.TabIndex = 15;
            this.bt_Menu_emp.Text = "Menu";
            this.bt_Menu_emp.UseVisualStyleBackColor = false;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // cb_sex
            // 
            this.cb_sex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sex.FormattingEnabled = true;
            this.cb_sex.Location = new System.Drawing.Point(119, 141);
            this.cb_sex.Name = "cb_sex";
            this.cb_sex.Size = new System.Drawing.Size(100, 21);
            this.cb_sex.TabIndex = 16;
            this.cb_sex.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bt_drink_emp
            // 
            this.bt_drink_emp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_drink_emp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_drink_emp.Location = new System.Drawing.Point(375, 45);
            this.bt_drink_emp.Name = "bt_drink_emp";
            this.bt_drink_emp.Size = new System.Drawing.Size(75, 60);
            this.bt_drink_emp.TabIndex = 18;
            this.bt_drink_emp.Text = "Drink";
            this.bt_drink_emp.UseVisualStyleBackColor = false;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 570);
            this.Controls.Add(this.bt_drink_emp);
            this.Controls.Add(this.cb_sex);
            this.Controls.Add(this.bt_Menu_emp);
            this.Controls.Add(this.tb_save_emp);
            this.Controls.Add(this.bt_delete_emp);
            this.Controls.Add(this.bt_edit_emp);
            this.Controls.Add(this.bt_add_emp);
            this.Controls.Add(this.l_salary);
            this.Controls.Add(this.l_sex);
            this.Controls.Add(this.l_lname);
            this.Controls.Add(this.l_fname);
            this.Controls.Add(this.l_emp_id);
            this.Controls.Add(this.tb_salary);
            this.Controls.Add(this.tb_lname);
            this.Controls.Add(this.tb_fname);
            this.Controls.Add(this.tb_empid);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Employee";
            this.Text = "Cafe/Employee";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_empid;
        private System.Windows.Forms.TextBox tb_fname;
        private System.Windows.Forms.TextBox tb_lname;
        private System.Windows.Forms.TextBox tb_salary;
        private System.Windows.Forms.Label l_emp_id;
        private System.Windows.Forms.Label l_fname;
        private System.Windows.Forms.Label l_lname;
        private System.Windows.Forms.Label l_sex;
        private System.Windows.Forms.Label l_salary;
        private System.Windows.Forms.Button bt_add_emp;
        private System.Windows.Forms.Button bt_edit_emp;
        private System.Windows.Forms.Button bt_delete_emp;
        private System.Windows.Forms.Button tb_save_emp;
        private System.Windows.Forms.Button bt_Menu_emp;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.ComboBox cb_sex;
        private System.Windows.Forms.Button bt_drink_emp;
    }
}

