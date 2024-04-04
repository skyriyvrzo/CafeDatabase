using System.Windows.Forms;

namespace Main
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.l_orderid_od = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bt_add_od = new System.Windows.Forms.Button();
            this.bt_edit_ = new System.Windows.Forms.Button();
            this.bt_delete_od = new System.Windows.Forms.Button();
            this.bt_save_od = new System.Windows.Forms.Button();
            this.l_empid_od = new System.Windows.Forms.Label();
            this.cb_emp = new System.Windows.Forms.ComboBox();
            this.tb_orderid_od = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_employee = new System.Windows.Forms.Button();
            this.bt_order = new System.Windows.Forms.Button();
            this.bt_od = new System.Windows.Forms.Button();
            this.bt_drink = new System.Windows.Forms.Button();
            this.bt_mod = new System.Windows.Forms.Button();
            this.bt_mat = new System.Windows.Forms.Button();
            this.bt_topping = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(973, 349);
            this.dataGridView1.TabIndex = 0;
            /*
             * Resize the table to fit the data grid view
             */
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // l_orderid_od
            // 
            this.l_orderid_od.AutoSize = true;
            this.l_orderid_od.Location = new System.Drawing.Point(23, 64);
            this.l_orderid_od.Name = "l_orderid_od";
            this.l_orderid_od.Size = new System.Drawing.Size(47, 13);
            this.l_orderid_od.TabIndex = 1;
            this.l_orderid_od.Text = "Order ID";
            // 
            // bt_add_od
            // 
            this.bt_add_od.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_add_od.Location = new System.Drawing.Point(254, 67);
            this.bt_add_od.Name = "bt_add_od";
            this.bt_add_od.Size = new System.Drawing.Size(79, 47);
            this.bt_add_od.TabIndex = 11;
            this.bt_add_od.Text = "Add";
            this.bt_add_od.UseVisualStyleBackColor = true;
            this.bt_add_od.Click += new System.EventHandler(this.bt_add_od_Click);
            // 
            // bt_edit_
            // 
            this.bt_edit_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_edit_.Location = new System.Drawing.Point(353, 67);
            this.bt_edit_.Name = "bt_edit_";
            this.bt_edit_.Size = new System.Drawing.Size(79, 47);
            this.bt_edit_.TabIndex = 12;
            this.bt_edit_.Text = "Edit";
            this.bt_edit_.UseVisualStyleBackColor = true;
            this.bt_edit_.Click += new System.EventHandler(this.bt_edit__Click);
            // 
            // bt_delete_od
            // 
            this.bt_delete_od.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_delete_od.Location = new System.Drawing.Point(453, 67);
            this.bt_delete_od.Name = "bt_delete_od";
            this.bt_delete_od.Size = new System.Drawing.Size(79, 47);
            this.bt_delete_od.TabIndex = 13;
            this.bt_delete_od.Text = "Delete";
            this.bt_delete_od.UseVisualStyleBackColor = true;
            this.bt_delete_od.Click += new System.EventHandler(this.bt_delete_od_Click);
            // 
            // bt_save_od
            // 
            this.bt_save_od.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_save_od.Location = new System.Drawing.Point(548, 67);
            this.bt_save_od.Name = "bt_save_od";
            this.bt_save_od.Size = new System.Drawing.Size(79, 47);
            this.bt_save_od.TabIndex = 14;
            this.bt_save_od.Text = "Save";
            this.bt_save_od.UseVisualStyleBackColor = true;
            this.bt_save_od.Click += new System.EventHandler(this.bt_save_od_Click);
            // 
            // l_empid_od
            // 
            this.l_empid_od.AutoSize = true;
            this.l_empid_od.Location = new System.Drawing.Point(21, 101);
            this.l_empid_od.Name = "l_empid_od";
            this.l_empid_od.Size = new System.Drawing.Size(53, 13);
            this.l_empid_od.TabIndex = 17;
            this.l_empid_od.Text = "Employee";
            // 
            // cb_emp
            // 
            this.cb_emp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_emp.FormattingEnabled = true;
            this.cb_emp.Location = new System.Drawing.Point(84, 98);
            this.cb_emp.Name = "cb_emp";
            this.cb_emp.Size = new System.Drawing.Size(150, 21);
            this.cb_emp.TabIndex = 8;
            // 
            // tb_orderid_od
            // 
            this.tb_orderid_od.Location = new System.Drawing.Point(84, 61);
            this.tb_orderid_od.Name = "tb_orderid_od";
            this.tb_orderid_od.Size = new System.Drawing.Size(150, 20);
            this.tb_orderid_od.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.bt_employee);
            this.panel1.Controls.Add(this.bt_order);
            this.panel1.Controls.Add(this.bt_od);
            this.panel1.Controls.Add(this.bt_drink);
            this.panel1.Controls.Add(this.bt_mod);
            this.panel1.Controls.Add(this.bt_mat);
            this.panel1.Controls.Add(this.bt_topping);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 37);
            this.panel1.TabIndex = 32;
            // 
            // bt_employee
            // 
            this.bt_employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.bt_employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_employee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.bt_employee.FlatAppearance.BorderSize = 0;
            this.bt_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_employee.Location = new System.Drawing.Point(133, 0);
            this.bt_employee.Name = "bt_employee";
            this.bt_employee.Size = new System.Drawing.Size(97, 37);
            this.bt_employee.TabIndex = 1;
            this.bt_employee.Text = "Employee";
            this.bt_employee.UseVisualStyleBackColor = false;
            this.bt_employee.Click += new System.EventHandler(this.bt_employee_Click);
            // 
            // bt_order
            // 
            this.bt_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(204)))));
            this.bt_order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_order.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.bt_order.FlatAppearance.BorderSize = 0;
            this.bt_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_order.Location = new System.Drawing.Point(18, 0);
            this.bt_order.Name = "bt_order";
            this.bt_order.Size = new System.Drawing.Size(97, 37);
            this.bt_order.TabIndex = 0;
            this.bt_order.Text = "Orders";
            this.bt_order.UseVisualStyleBackColor = false;
            this.bt_order.Click += new System.EventHandler(this.bt_order_Click);
            // 
            // bt_od
            // 
            this.bt_od.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.bt_od.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_od.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.bt_od.FlatAppearance.BorderSize = 0;
            this.bt_od.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_od.Location = new System.Drawing.Point(708, 0);
            this.bt_od.Name = "bt_od";
            this.bt_od.Size = new System.Drawing.Size(96, 37);
            this.bt_od.TabIndex = 6;
            this.bt_od.Text = "Order detail";
            this.bt_od.UseVisualStyleBackColor = false;
            this.bt_od.Click += new System.EventHandler(this.bt_od_Click);
            // 
            // bt_drink
            // 
            this.bt_drink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.bt_drink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_drink.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.bt_drink.FlatAppearance.BorderSize = 0;
            this.bt_drink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_drink.Location = new System.Drawing.Point(247, 0);
            this.bt_drink.Name = "bt_drink";
            this.bt_drink.Size = new System.Drawing.Size(96, 37);
            this.bt_drink.TabIndex = 2;
            this.bt_drink.Text = "Drink";
            this.bt_drink.UseVisualStyleBackColor = false;
            this.bt_drink.Click += new System.EventHandler(this.bt_drink_Click);
            // 
            // bt_mod
            // 
            this.bt_mod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.bt_mod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_mod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.bt_mod.FlatAppearance.BorderSize = 0;
            this.bt_mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_mod.Location = new System.Drawing.Point(591, 0);
            this.bt_mod.Name = "bt_mod";
            this.bt_mod.Size = new System.Drawing.Size(96, 37);
            this.bt_mod.TabIndex = 5;
            this.bt_mod.Text = "Material of Drink";
            this.bt_mod.UseVisualStyleBackColor = false;
            this.bt_mod.Click += new System.EventHandler(this.bt_mod_Click);
            // 
            // bt_mat
            // 
            this.bt_mat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.bt_mat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_mat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.bt_mat.FlatAppearance.BorderSize = 0;
            this.bt_mat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_mat.Location = new System.Drawing.Point(361, 0);
            this.bt_mat.Name = "bt_mat";
            this.bt_mat.Size = new System.Drawing.Size(96, 37);
            this.bt_mat.TabIndex = 3;
            this.bt_mat.Text = "Material";
            this.bt_mat.UseVisualStyleBackColor = false;
            this.bt_mat.Click += new System.EventHandler(this.bt_mat_Click);
            // 
            // bt_topping
            // 
            this.bt_topping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.bt_topping.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_topping.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.bt_topping.FlatAppearance.BorderSize = 0;
            this.bt_topping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_topping.Location = new System.Drawing.Point(477, 0);
            this.bt_topping.Name = "bt_topping";
            this.bt_topping.Size = new System.Drawing.Size(96, 37);
            this.bt_topping.TabIndex = 4;
            this.bt_topping.Text = "Topping";
            this.bt_topping.UseVisualStyleBackColor = false;
            this.bt_topping.Click += new System.EventHandler(this.bt_topping_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(997, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb_emp);
            this.Controls.Add(this.l_empid_od);
            this.Controls.Add(this.bt_save_od);
            this.Controls.Add(this.bt_delete_od);
            this.Controls.Add(this.bt_edit_);
            this.Controls.Add(this.bt_add_od);
            this.Controls.Add(this.tb_orderid_od);
            this.Controls.Add(this.l_orderid_od);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafe";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Label l_orderid_od;
        internal System.ComponentModel.BackgroundWorker backgroundWorker1;
        internal System.Windows.Forms.Button bt_add_od;
        internal System.Windows.Forms.Button bt_edit_;
        internal System.Windows.Forms.Button bt_delete_od;
        internal System.Windows.Forms.Button bt_save_od;
        internal System.Windows.Forms.Label l_empid_od;
        internal System.Windows.Forms.ComboBox cb_emp;
        internal System.Windows.Forms.TextBox tb_orderid_od;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button bt_employee;
        internal System.Windows.Forms.Button bt_order;
        internal System.Windows.Forms.Button bt_od;
        internal System.Windows.Forms.Button bt_drink;
        internal System.Windows.Forms.Button bt_mod;
        internal System.Windows.Forms.Button bt_mat;
        internal System.Windows.Forms.Button bt_topping;
    }
}