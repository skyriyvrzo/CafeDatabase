namespace Main
{
    partial class OrdersDetail
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
            this.l_orderid_od = new System.Windows.Forms.Label();
            this.tb_quantity_od = new System.Windows.Forms.TextBox();
            this.l_topping = new System.Windows.Forms.Label();
            this.l_drinkid_od = new System.Windows.Forms.Label();
            this.l_quantity = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bt_add_od = new System.Windows.Forms.Button();
            this.bt_edit_ = new System.Windows.Forms.Button();
            this.bt_delete_od = new System.Windows.Forms.Button();
            this.bt_save_od = new System.Windows.Forms.Button();
            this.l_empid_od = new System.Windows.Forms.Label();
            this.cb_emp = new System.Windows.Forms.ComboBox();
            this.bt_drink_od = new System.Windows.Forms.Button();
            this.bt_mat = new System.Windows.Forms.Button();
            this.bt_emp = new System.Windows.Forms.Button();
            this.bt_topping_od = new System.Windows.Forms.Button();
            this.tb_orderid_od = new System.Windows.Forms.TextBox();
            this.cb_drink_id = new System.Windows.Forms.ComboBox();
            this.cb_topping_id = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(913, 356);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // l_orderid_od
            // 
            this.l_orderid_od.AutoSize = true;
            this.l_orderid_od.Location = new System.Drawing.Point(25, 37);
            this.l_orderid_od.Name = "l_orderid_od";
            this.l_orderid_od.Size = new System.Drawing.Size(47, 13);
            this.l_orderid_od.TabIndex = 1;
            this.l_orderid_od.Text = "Order ID";
            // 
            // tb_quantity_od
            // 
            this.tb_quantity_od.Location = new System.Drawing.Point(316, 77);
            this.tb_quantity_od.Name = "tb_quantity_od";
            this.tb_quantity_od.Size = new System.Drawing.Size(162, 20);
            this.tb_quantity_od.TabIndex = 3;
            // 
            // l_topping
            // 
            this.l_topping.AutoSize = true;
            this.l_topping.Location = new System.Drawing.Point(264, 38);
            this.l_topping.Name = "l_topping";
            this.l_topping.Size = new System.Drawing.Size(46, 13);
            this.l_topping.TabIndex = 6;
            this.l_topping.Text = "Topping";
            // 
            // l_drinkid_od
            // 
            this.l_drinkid_od.AutoSize = true;
            this.l_drinkid_od.Location = new System.Drawing.Point(26, 83);
            this.l_drinkid_od.Name = "l_drinkid_od";
            this.l_drinkid_od.Size = new System.Drawing.Size(46, 13);
            this.l_drinkid_od.TabIndex = 7;
            this.l_drinkid_od.Text = "Drink ID";
            // 
            // l_quantity
            // 
            this.l_quantity.AutoSize = true;
            this.l_quantity.Location = new System.Drawing.Point(264, 81);
            this.l_quantity.Name = "l_quantity";
            this.l_quantity.Size = new System.Drawing.Size(46, 13);
            this.l_quantity.TabIndex = 8;
            this.l_quantity.Text = "Quantity";
            // 
            // bt_add_od
            // 
            this.bt_add_od.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_add_od.Location = new System.Drawing.Point(524, 34);
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
            this.bt_edit_.Location = new System.Drawing.Point(629, 34);
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
            this.bt_delete_od.Location = new System.Drawing.Point(739, 34);
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
            this.bt_save_od.Location = new System.Drawing.Point(524, 99);
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
            this.l_empid_od.Location = new System.Drawing.Point(19, 121);
            this.l_empid_od.Name = "l_empid_od";
            this.l_empid_od.Size = new System.Drawing.Size(53, 13);
            this.l_empid_od.TabIndex = 17;
            this.l_empid_od.Text = "Employee";
            // 
            // cb_emp
            // 
            this.cb_emp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_emp.FormattingEnabled = true;
            this.cb_emp.Location = new System.Drawing.Point(82, 118);
            this.cb_emp.Name = "cb_emp";
            this.cb_emp.Size = new System.Drawing.Size(150, 21);
            this.cb_emp.TabIndex = 18;
            // 
            // bt_drink_od
            // 
            this.bt_drink_od.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_drink_od.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_drink_od.Location = new System.Drawing.Point(714, 97);
            this.bt_drink_od.Name = "bt_drink_od";
            this.bt_drink_od.Size = new System.Drawing.Size(75, 60);
            this.bt_drink_od.TabIndex = 20;
            this.bt_drink_od.Text = "Drink";
            this.bt_drink_od.UseVisualStyleBackColor = false;
            // 
            // bt_mat
            // 
            this.bt_mat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_mat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_mat.Location = new System.Drawing.Point(795, 97);
            this.bt_mat.Name = "bt_mat";
            this.bt_mat.Size = new System.Drawing.Size(75, 60);
            this.bt_mat.TabIndex = 21;
            this.bt_mat.Text = "Material";
            this.bt_mat.UseVisualStyleBackColor = false;
            // 
            // bt_emp
            // 
            this.bt_emp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_emp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_emp.Location = new System.Drawing.Point(633, 97);
            this.bt_emp.Name = "bt_emp";
            this.bt_emp.Size = new System.Drawing.Size(75, 60);
            this.bt_emp.TabIndex = 22;
            this.bt_emp.Text = "Employee";
            this.bt_emp.UseVisualStyleBackColor = false;
            this.bt_emp.Click += new System.EventHandler(this.bt_emp_Click);
            // 
            // bt_topping_od
            // 
            this.bt_topping_od.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_topping_od.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_topping_od.Location = new System.Drawing.Point(876, 97);
            this.bt_topping_od.Name = "bt_topping_od";
            this.bt_topping_od.Size = new System.Drawing.Size(75, 60);
            this.bt_topping_od.TabIndex = 25;
            this.bt_topping_od.Text = "Topping";
            this.bt_topping_od.UseVisualStyleBackColor = false;
            // 
            // tb_orderid_od
            // 
            this.tb_orderid_od.Location = new System.Drawing.Point(82, 34);
            this.tb_orderid_od.Name = "tb_orderid_od";
            this.tb_orderid_od.Size = new System.Drawing.Size(150, 20);
            this.tb_orderid_od.TabIndex = 2;
            // 
            // cb_drink_id
            // 
            this.cb_drink_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_drink_id.FormattingEnabled = true;
            this.cb_drink_id.Location = new System.Drawing.Point(82, 80);
            this.cb_drink_id.Name = "cb_drink_id";
            this.cb_drink_id.Size = new System.Drawing.Size(150, 21);
            this.cb_drink_id.TabIndex = 26;
            // 
            // cb_topping_id
            // 
            this.cb_topping_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_topping_id.FormattingEnabled = true;
            this.cb_topping_id.Location = new System.Drawing.Point(316, 34);
            this.cb_topping_id.Name = "cb_topping_id";
            this.cb_topping_id.Size = new System.Drawing.Size(162, 21);
            this.cb_topping_id.TabIndex = 27;
            // 
            // OrdersDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 570);
            this.Controls.Add(this.cb_topping_id);
            this.Controls.Add(this.cb_drink_id);
            this.Controls.Add(this.bt_topping_od);
            this.Controls.Add(this.bt_emp);
            this.Controls.Add(this.bt_mat);
            this.Controls.Add(this.bt_drink_od);
            this.Controls.Add(this.cb_emp);
            this.Controls.Add(this.l_empid_od);
            this.Controls.Add(this.bt_save_od);
            this.Controls.Add(this.bt_delete_od);
            this.Controls.Add(this.bt_edit_);
            this.Controls.Add(this.bt_add_od);
            this.Controls.Add(this.l_quantity);
            this.Controls.Add(this.l_drinkid_od);
            this.Controls.Add(this.l_topping);
            this.Controls.Add(this.tb_quantity_od);
            this.Controls.Add(this.tb_orderid_od);
            this.Controls.Add(this.l_orderid_od);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OrdersDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafe/OrdersDetail";
            this.Load += new System.EventHandler(this.OrdersDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Label l_orderid_od;
        internal System.Windows.Forms.TextBox tb_quantity_od;
        internal System.Windows.Forms.Label l_topping;
        internal System.Windows.Forms.Label l_drinkid_od;
        internal System.Windows.Forms.Label l_quantity;
        internal System.ComponentModel.BackgroundWorker backgroundWorker1;
        internal System.Windows.Forms.Button bt_add_od;
        internal System.Windows.Forms.Button bt_edit_;
        internal System.Windows.Forms.Button bt_delete_od;
        internal System.Windows.Forms.Button bt_save_od;
        internal System.Windows.Forms.Label l_empid_od;
        internal System.Windows.Forms.ComboBox cb_emp;
        internal System.Windows.Forms.Button bt_drink_od;
        internal System.Windows.Forms.Button bt_mat;
        internal System.Windows.Forms.Button bt_emp;
        internal System.Windows.Forms.Button bt_topping_od;
        internal System.Windows.Forms.TextBox tb_orderid_od;
        internal System.Windows.Forms.ComboBox cb_drink_id;
        internal System.Windows.Forms.ComboBox cb_topping_id;
    }
}