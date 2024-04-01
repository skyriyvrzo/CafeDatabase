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
            this.tb_orderid_od = new System.Windows.Forms.TextBox();
            this.tb_quantity_od = new System.Windows.Forms.TextBox();
            this.tb_drinkid_od = new System.Windows.Forms.TextBox();
            this.tb_topoing_od = new System.Windows.Forms.TextBox();
            this.l_topping = new System.Windows.Forms.Label();
            this.l_drinkid_od = new System.Windows.Forms.Label();
            this.l_quantity = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bt_add_od = new System.Windows.Forms.Button();
            this.bt_edit_ = new System.Windows.Forms.Button();
            this.bt_delete_od = new System.Windows.Forms.Button();
            this.bt_save_od = new System.Windows.Forms.Button();
            this.l_empid_od = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bt_drink_od = new System.Windows.Forms.Button();
            this.bt_mat = new System.Windows.Forms.Button();
            this.bt_emp = new System.Windows.Forms.Button();
            this.bt_topping_od = new System.Windows.Forms.Button();
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
            // 
            // l_orderid_od
            // 
            this.l_orderid_od.AutoSize = true;
            this.l_orderid_od.Location = new System.Drawing.Point(49, 34);
            this.l_orderid_od.Name = "l_orderid_od";
            this.l_orderid_od.Size = new System.Drawing.Size(44, 13);
            this.l_orderid_od.TabIndex = 1;
            this.l_orderid_od.Text = "OrderID";
            // 
            // tb_orderid_od
            // 
            this.tb_orderid_od.Location = new System.Drawing.Point(112, 34);
            this.tb_orderid_od.Name = "tb_orderid_od";
            this.tb_orderid_od.Size = new System.Drawing.Size(100, 20);
            this.tb_orderid_od.TabIndex = 2;
            // 
            // tb_quantity_od
            // 
            this.tb_quantity_od.Location = new System.Drawing.Point(362, 80);
            this.tb_quantity_od.Name = "tb_quantity_od";
            this.tb_quantity_od.Size = new System.Drawing.Size(100, 20);
            this.tb_quantity_od.TabIndex = 3;
            // 
            // tb_drinkid_od
            // 
            this.tb_drinkid_od.Location = new System.Drawing.Point(112, 80);
            this.tb_drinkid_od.Name = "tb_drinkid_od";
            this.tb_drinkid_od.Size = new System.Drawing.Size(100, 20);
            this.tb_drinkid_od.TabIndex = 4;
            // 
            // tb_topoing_od
            // 
            this.tb_topoing_od.Location = new System.Drawing.Point(362, 34);
            this.tb_topoing_od.Name = "tb_topoing_od";
            this.tb_topoing_od.Size = new System.Drawing.Size(100, 20);
            this.tb_topoing_od.TabIndex = 5;
            // 
            // l_topping
            // 
            this.l_topping.AutoSize = true;
            this.l_topping.Location = new System.Drawing.Point(267, 34);
            this.l_topping.Name = "l_topping";
            this.l_topping.Size = new System.Drawing.Size(47, 13);
            this.l_topping.TabIndex = 6;
            this.l_topping.Text = "TopPing";
            // 
            // l_drinkid_od
            // 
            this.l_drinkid_od.AutoSize = true;
            this.l_drinkid_od.Location = new System.Drawing.Point(49, 80);
            this.l_drinkid_od.Name = "l_drinkid_od";
            this.l_drinkid_od.Size = new System.Drawing.Size(43, 13);
            this.l_drinkid_od.TabIndex = 7;
            this.l_drinkid_od.Text = "DrinkID";
            // 
            // l_quantity
            // 
            this.l_quantity.AutoSize = true;
            this.l_quantity.Location = new System.Drawing.Point(267, 80);
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
            // 
            // l_empid_od
            // 
            this.l_empid_od.AutoSize = true;
            this.l_empid_od.Location = new System.Drawing.Point(49, 121);
            this.l_empid_od.Name = "l_empid_od";
            this.l_empid_od.Size = new System.Drawing.Size(64, 13);
            this.l_empid_od.TabIndex = 17;
            this.l_empid_od.Text = "EmployeeID";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 118);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 18;
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
            // OrdersDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 570);
            this.Controls.Add(this.bt_topping_od);
            this.Controls.Add(this.bt_emp);
            this.Controls.Add(this.bt_mat);
            this.Controls.Add(this.bt_drink_od);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.l_empid_od);
            this.Controls.Add(this.bt_save_od);
            this.Controls.Add(this.bt_delete_od);
            this.Controls.Add(this.bt_edit_);
            this.Controls.Add(this.bt_add_od);
            this.Controls.Add(this.l_quantity);
            this.Controls.Add(this.l_drinkid_od);
            this.Controls.Add(this.l_topping);
            this.Controls.Add(this.tb_topoing_od);
            this.Controls.Add(this.tb_drinkid_od);
            this.Controls.Add(this.tb_quantity_od);
            this.Controls.Add(this.tb_orderid_od);
            this.Controls.Add(this.l_orderid_od);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrdersDetail";
            this.Text = "Cafe/OrdersDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label l_orderid_od;
        private System.Windows.Forms.TextBox tb_orderid_od;
        private System.Windows.Forms.TextBox tb_quantity_od;
        private System.Windows.Forms.TextBox tb_drinkid_od;
        private System.Windows.Forms.TextBox tb_topoing_od;
        private System.Windows.Forms.Label l_topping;
        private System.Windows.Forms.Label l_drinkid_od;
        private System.Windows.Forms.Label l_quantity;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button bt_add_od;
        private System.Windows.Forms.Button bt_edit_;
        private System.Windows.Forms.Button bt_delete_od;
        private System.Windows.Forms.Button bt_save_od;
        private System.Windows.Forms.Label l_empid_od;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bt_drink_od;
        private System.Windows.Forms.Button bt_mat;
        private System.Windows.Forms.Button bt_emp;
        private System.Windows.Forms.Button bt_topping_od;
    }
}