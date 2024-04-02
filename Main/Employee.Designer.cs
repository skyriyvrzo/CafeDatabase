﻿namespace Main
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
            this.bt_order_emp = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.cb_sex = new System.Windows.Forms.ComboBox();
            this.bt_drink_emp = new System.Windows.Forms.Button();
            this.bt_mat = new System.Windows.Forms.Button();
            this.bt_topping_emp = new System.Windows.Forms.Button();
            this.bt_mod = new System.Windows.Forms.Button();
            this.bt_od = new System.Windows.Forms.Button();
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
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.l_emp_id.Location = new System.Drawing.Point(46, 26);
            this.l_emp_id.Name = "l_emp_id";
            this.l_emp_id.Size = new System.Drawing.Size(67, 13);
            this.l_emp_id.TabIndex = 6;
            this.l_emp_id.Text = "Employee ID";
            // 
            // l_fname
            // 
            this.l_fname.AutoSize = true;
            this.l_fname.Location = new System.Drawing.Point(46, 59);
            this.l_fname.Name = "l_fname";
            this.l_fname.Size = new System.Drawing.Size(57, 13);
            this.l_fname.TabIndex = 7;
            this.l_fname.Text = "First Name";
            // 
            // l_lname
            // 
            this.l_lname.AutoSize = true;
            this.l_lname.Location = new System.Drawing.Point(46, 88);
            this.l_lname.Name = "l_lname";
            this.l_lname.Size = new System.Drawing.Size(58, 13);
            this.l_lname.TabIndex = 8;
            this.l_lname.Text = "Last Name";
            // 
            // l_sex
            // 
            this.l_sex.AutoSize = true;
            this.l_sex.Location = new System.Drawing.Point(46, 149);
            this.l_sex.Name = "l_sex";
            this.l_sex.Size = new System.Drawing.Size(25, 13);
            this.l_sex.TabIndex = 9;
            this.l_sex.Text = "Sex";
            // 
            // l_salary
            // 
            this.l_salary.AutoSize = true;
            this.l_salary.Location = new System.Drawing.Point(46, 118);
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
            this.bt_add_emp.Click += new System.EventHandler(this.bt_add_emp_Click);
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
            this.bt_edit_emp.Click += new System.EventHandler(this.bt_edit_emp_Click);
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
            this.bt_delete_emp.Click += new System.EventHandler(this.bt_delete_emp_Click);
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
            this.tb_save_emp.Click += new System.EventHandler(this.tb_save_emp_Click);
            // 
            // bt_order_emp
            // 
            this.bt_order_emp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_order_emp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_order_emp.Location = new System.Drawing.Point(294, 45);
            this.bt_order_emp.Name = "bt_order_emp";
            this.bt_order_emp.Size = new System.Drawing.Size(75, 60);
            this.bt_order_emp.TabIndex = 15;
            this.bt_order_emp.Text = "Orders";
            this.bt_order_emp.UseVisualStyleBackColor = false;
            this.bt_order_emp.Click += new System.EventHandler(this.bt_order_emp_Click);
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
            this.cb_sex.TabIndex = 5;
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
            this.bt_drink_emp.Click += new System.EventHandler(this.bt_drink_emp_Click);
            // 
            // bt_mat
            // 
            this.bt_mat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_mat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_mat.Location = new System.Drawing.Point(456, 45);
            this.bt_mat.Name = "bt_mat";
            this.bt_mat.Size = new System.Drawing.Size(75, 60);
            this.bt_mat.TabIndex = 20;
            this.bt_mat.Text = "Material";
            this.bt_mat.UseVisualStyleBackColor = false;
            this.bt_mat.Click += new System.EventHandler(this.bt_mat_Click);
            // 
            // bt_topping_emp
            // 
            this.bt_topping_emp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_topping_emp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_topping_emp.Location = new System.Drawing.Point(537, 45);
            this.bt_topping_emp.Name = "bt_topping_emp";
            this.bt_topping_emp.Size = new System.Drawing.Size(75, 60);
            this.bt_topping_emp.TabIndex = 25;
            this.bt_topping_emp.Text = "Topping";
            this.bt_topping_emp.UseVisualStyleBackColor = false;
            this.bt_topping_emp.Click += new System.EventHandler(this.bt_topping_emp_Click);
            // 
            // bt_mod
            // 
            this.bt_mod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_mod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_mod.Location = new System.Drawing.Point(769, 102);
            this.bt_mod.Name = "bt_mod";
            this.bt_mod.Size = new System.Drawing.Size(75, 60);
            this.bt_mod.TabIndex = 26;
            this.bt_mod.Text = "Mod";
            this.bt_mod.UseVisualStyleBackColor = false;
            this.bt_mod.Click += new System.EventHandler(this.bt_mod_Click);
            // 
            // bt_od
            // 
            this.bt_od.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_od.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_od.Location = new System.Drawing.Point(878, 102);
            this.bt_od.Name = "bt_od";
            this.bt_od.Size = new System.Drawing.Size(75, 60);
            this.bt_od.TabIndex = 27;
            this.bt_od.Text = "OD";
            this.bt_od.UseVisualStyleBackColor = false;
            this.bt_od.Click += new System.EventHandler(this.bt_od_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(997, 570);
            this.Controls.Add(this.bt_od);
            this.Controls.Add(this.bt_mod);
            this.Controls.Add(this.bt_topping_emp);
            this.Controls.Add(this.bt_mat);
            this.Controls.Add(this.bt_drink_emp);
            this.Controls.Add(this.cb_sex);
            this.Controls.Add(this.bt_order_emp);
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
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafe/Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.TextBox tb_empid;
        internal System.Windows.Forms.TextBox tb_fname;
        internal System.Windows.Forms.TextBox tb_lname;
        internal System.Windows.Forms.TextBox tb_salary;
        internal System.Windows.Forms.Label l_emp_id;
        internal System.Windows.Forms.Label l_fname;
        internal System.Windows.Forms.Label l_lname;
        internal System.Windows.Forms.Label l_sex;
        internal System.Windows.Forms.Label l_salary;
        internal System.Windows.Forms.Button bt_add_emp;
        internal System.Windows.Forms.Button bt_edit_emp;
        internal System.Windows.Forms.Button bt_delete_emp;
        internal System.Windows.Forms.Button tb_save_emp;
        internal System.Windows.Forms.Button bt_order_emp;
        internal MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        internal System.Windows.Forms.ComboBox cb_sex;
        internal System.Windows.Forms.Button bt_drink_emp;
        internal System.Windows.Forms.Button bt_mat;
        internal System.Windows.Forms.Button bt_topping_emp;
        internal System.Windows.Forms.Button bt_mod;
        internal System.Windows.Forms.Button bt_od;
    }
}

