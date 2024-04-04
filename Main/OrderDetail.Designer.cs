using System.Windows.Forms;

namespace Main
{
    partial class OrderDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_order = new System.Windows.Forms.ComboBox();
            this.cb_drink = new System.Windows.Forms.ComboBox();
            this.cb_topping = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Drink";
            // 
            // cb_order
            // 
            this.cb_order.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_order.FormattingEnabled = true;
            this.cb_order.Location = new System.Drawing.Point(56, 62);
            this.cb_order.Name = "cb_order";
            this.cb_order.Size = new System.Drawing.Size(181, 21);
            this.cb_order.TabIndex = 0;
            // 
            // cb_drink
            // 
            this.cb_drink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_drink.FormattingEnabled = true;
            this.cb_drink.Location = new System.Drawing.Point(56, 98);
            this.cb_drink.Name = "cb_drink";
            this.cb_drink.Size = new System.Drawing.Size(181, 21);
            this.cb_drink.TabIndex = 1;
            // 
            // cb_topping
            // 
            this.cb_topping.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_topping.FormattingEnabled = true;
            this.cb_topping.Location = new System.Drawing.Point(317, 62);
            this.cb_topping.Name = "cb_topping";
            this.cb_topping.Size = new System.Drawing.Size(181, 21);
            this.cb_topping.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Topping";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity";
            // 
            // tb_quantity
            // 
            this.tb_quantity.Location = new System.Drawing.Point(317, 98);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(181, 20);
            this.tb_quantity.TabIndex = 7;
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(528, 69);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(78, 38);
            this.bt_add.TabIndex = 8;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(612, 69);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(78, 38);
            this.bt_edit.TabIndex = 9;
            this.bt_edit.Text = "Edit";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(698, 69);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(78, 38);
            this.bt_delete.TabIndex = 10;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(782, 69);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(78, 38);
            this.bt_save.TabIndex = 11;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(973, 349);
            this.dataGridView1.TabIndex = 12;
            /*
             * Resize the table to fit the data grid view
             */
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.panel1.TabIndex = 33;
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
            this.bt_employee.TabIndex = 16;
            this.bt_employee.Text = "Employee";
            this.bt_employee.UseVisualStyleBackColor = false;
            this.bt_employee.Click += new System.EventHandler(this.bt_employee_Click);
            // 
            // bt_order
            // 
            this.bt_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.bt_order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_order.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.bt_order.FlatAppearance.BorderSize = 0;
            this.bt_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_order.Location = new System.Drawing.Point(18, 0);
            this.bt_order.Name = "bt_order";
            this.bt_order.Size = new System.Drawing.Size(97, 37);
            this.bt_order.TabIndex = 15;
            this.bt_order.Text = "Orders";
            this.bt_order.UseVisualStyleBackColor = false;
            this.bt_order.Click += new System.EventHandler(this.bt_order_Click);
            // 
            // bt_od
            // 
            this.bt_od.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(204)))));
            this.bt_od.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_od.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.bt_od.FlatAppearance.BorderSize = 0;
            this.bt_od.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_od.Location = new System.Drawing.Point(708, 0);
            this.bt_od.Name = "bt_od";
            this.bt_od.Size = new System.Drawing.Size(96, 37);
            this.bt_od.TabIndex = 27;
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
            this.bt_drink.TabIndex = 18;
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
            this.bt_mod.TabIndex = 26;
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
            this.bt_mat.TabIndex = 20;
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
            this.bt_topping.TabIndex = 25;
            this.bt_topping.Text = "Topping";
            this.bt_topping.UseVisualStyleBackColor = false;
            this.bt_topping.Click += new System.EventHandler(this.bt_topping_Click);
            // 
            // OrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(997, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.tb_quantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_topping);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_drink);
            this.Controls.Add(this.cb_order);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OrderDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafe";
            this.Load += new System.EventHandler(this.OrderDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox cb_order;
        internal System.Windows.Forms.ComboBox cb_drink;
        internal System.Windows.Forms.ComboBox cb_topping;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox tb_quantity;
        internal System.Windows.Forms.Button bt_add;
        internal System.Windows.Forms.Button bt_edit;
        internal System.Windows.Forms.Button bt_delete;
        internal System.Windows.Forms.Button bt_save;
        internal System.Windows.Forms.DataGridView dataGridView1;
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