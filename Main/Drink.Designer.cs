using Main.Utils;
using System.Windows.Forms;

namespace Main
{
    partial class Drink
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
            this.tb_drink_id = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.l_drinkid = new System.Windows.Forms.Label();
            this.l_drinkname = new System.Windows.Forms.Label();
            this.l_drinkstatus = new System.Windows.Forms.Label();
            this.l_drinkprice = new System.Windows.Forms.Label();
            this.bt_add_Drink = new System.Windows.Forms.Button();
            this.bt_Edit_Drink = new System.Windows.Forms.Button();
            this.bt_delete_drink = new System.Windows.Forms.Button();
            this.bt_save_Drink = new System.Windows.Forms.Button();
            this.cb_status = new System.Windows.Forms.ComboBox();
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
            this.dataGridView1.TabIndex = 1;
            /*
             * Resize the table to fit the data grid view
             */
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tb_drink_id
            // 
            this.tb_drink_id.Location = new System.Drawing.Point(68, 62);
            this.tb_drink_id.Name = "tb_drink_id";
            this.tb_drink_id.Size = new System.Drawing.Size(100, 20);
            this.tb_drink_id.TabIndex = 2;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(243, 62);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 20);
            this.tb_name.TabIndex = 4;
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(68, 96);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(100, 20);
            this.tb_price.TabIndex = 5;
            // 
            // l_drinkid
            // 
            this.l_drinkid.AutoSize = true;
            this.l_drinkid.Location = new System.Drawing.Point(17, 65);
            this.l_drinkid.Name = "l_drinkid";
            this.l_drinkid.Size = new System.Drawing.Size(46, 13);
            this.l_drinkid.TabIndex = 32;
            this.l_drinkid.Text = "Drink ID";
            // 
            // l_drinkname
            // 
            this.l_drinkname.AutoSize = true;
            this.l_drinkname.Location = new System.Drawing.Point(200, 65);
            this.l_drinkname.Name = "l_drinkname";
            this.l_drinkname.Size = new System.Drawing.Size(35, 13);
            this.l_drinkname.TabIndex = 31;
            this.l_drinkname.Text = "Name";
            // 
            // l_drinkstatus
            // 
            this.l_drinkstatus.AutoSize = true;
            this.l_drinkstatus.Location = new System.Drawing.Point(200, 103);
            this.l_drinkstatus.Name = "l_drinkstatus";
            this.l_drinkstatus.Size = new System.Drawing.Size(37, 13);
            this.l_drinkstatus.TabIndex = 30;
            this.l_drinkstatus.Text = "Status";
            // 
            // l_drinkprice
            // 
            this.l_drinkprice.AutoSize = true;
            this.l_drinkprice.Location = new System.Drawing.Point(17, 100);
            this.l_drinkprice.Name = "l_drinkprice";
            this.l_drinkprice.Size = new System.Drawing.Size(31, 13);
            this.l_drinkprice.TabIndex = 9;
            this.l_drinkprice.Text = "Price";
            // 
            // bt_add_Drink
            // 
            this.bt_add_Drink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_add_Drink.Location = new System.Drawing.Point(361, 68);
            this.bt_add_Drink.Name = "bt_add_Drink";
            this.bt_add_Drink.Size = new System.Drawing.Size(79, 47);
            this.bt_add_Drink.TabIndex = 10;
            this.bt_add_Drink.Text = "Add";
            this.bt_add_Drink.UseVisualStyleBackColor = true;
            this.bt_add_Drink.Click += new System.EventHandler(this.bt_add_Drink_Click);
            // 
            // bt_Edit_Drink
            // 
            this.bt_Edit_Drink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Edit_Drink.Location = new System.Drawing.Point(458, 68);
            this.bt_Edit_Drink.Name = "bt_Edit_Drink";
            this.bt_Edit_Drink.Size = new System.Drawing.Size(79, 47);
            this.bt_Edit_Drink.TabIndex = 11;
            this.bt_Edit_Drink.Text = "Edit";
            this.bt_Edit_Drink.UseVisualStyleBackColor = true;
            this.bt_Edit_Drink.Click += new System.EventHandler(this.bt_Edit_Drink_Click);
            // 
            // bt_delete_drink
            // 
            this.bt_delete_drink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_delete_drink.Location = new System.Drawing.Point(554, 68);
            this.bt_delete_drink.Name = "bt_delete_drink";
            this.bt_delete_drink.Size = new System.Drawing.Size(79, 47);
            this.bt_delete_drink.TabIndex = 12;
            this.bt_delete_drink.Text = "Delete";
            this.bt_delete_drink.UseVisualStyleBackColor = true;
            this.bt_delete_drink.Click += new System.EventHandler(this.bt_delete_drink_Click);
            // 
            // bt_save_Drink
            // 
            this.bt_save_Drink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_save_Drink.Location = new System.Drawing.Point(650, 68);
            this.bt_save_Drink.Name = "bt_save_Drink";
            this.bt_save_Drink.Size = new System.Drawing.Size(79, 47);
            this.bt_save_Drink.TabIndex = 13;
            this.bt_save_Drink.Text = "Save";
            this.bt_save_Drink.UseVisualStyleBackColor = true;
            this.bt_save_Drink.Click += new System.EventHandler(this.bt_save_Drink_Click);
            // 
            // cb_status
            // 
            this.cb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(243, 100);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(100, 21);
            this.cb_status.TabIndex = 6;
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
            this.panel1.TabIndex = 29;
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
            this.bt_od.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
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
            this.bt_drink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(204)))));
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
            // Drink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(997, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.bt_save_Drink);
            this.Controls.Add(this.bt_delete_drink);
            this.Controls.Add(this.bt_Edit_Drink);
            this.Controls.Add(this.bt_add_Drink);
            this.Controls.Add(this.l_drinkprice);
            this.Controls.Add(this.l_drinkstatus);
            this.Controls.Add(this.l_drinkname);
            this.Controls.Add(this.l_drinkid);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_drink_id);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Drink";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafe";
            this.Load += new System.EventHandler(this.Drink_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.TextBox tb_drink_id;
        internal System.Windows.Forms.TextBox tb_name;
        internal System.Windows.Forms.TextBox tb_price;
        internal System.Windows.Forms.Label l_drinkid;
        internal System.Windows.Forms.Label l_drinkname;
        internal System.Windows.Forms.Label l_drinkstatus;
        internal System.Windows.Forms.Label l_drinkprice;
        internal System.Windows.Forms.Button bt_add_Drink;
        internal System.Windows.Forms.Button bt_Edit_Drink;
        internal System.Windows.Forms.Button bt_delete_drink;
        internal System.Windows.Forms.Button bt_save_Drink;
        internal System.Windows.Forms.ComboBox cb_status;
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