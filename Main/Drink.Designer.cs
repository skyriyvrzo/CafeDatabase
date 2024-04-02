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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.l_drinkid = new System.Windows.Forms.Label();
            this.l_drinkname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l_drinkstatus = new System.Windows.Forms.Label();
            this.l_drinkprice = new System.Windows.Forms.Label();
            this.bt_add_Drink = new System.Windows.Forms.Button();
            this.bt_Edit_Drink = new System.Windows.Forms.Button();
            this.bt_delete_drink = new System.Windows.Forms.Button();
            this.bt_save_Drink = new System.Windows.Forms.Button();
            this.bt_orders_drink = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bt_mat = new System.Windows.Forms.Button();
            this.bt_emp = new System.Windows.Forms.Button();
            this.l_matid = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.bt_topping_drink = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(913, 341);
            this.dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(286, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(111, 54);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            // 
            // l_drinkid
            // 
            this.l_drinkid.AutoSize = true;
            this.l_drinkid.Location = new System.Drawing.Point(60, 15);
            this.l_drinkid.Name = "l_drinkid";
            this.l_drinkid.Size = new System.Drawing.Size(46, 13);
            this.l_drinkid.TabIndex = 6;
            this.l_drinkid.Text = "Drink ID";
            // 
            // l_drinkname
            // 
            this.l_drinkname.AutoSize = true;
            this.l_drinkname.Location = new System.Drawing.Point(243, 15);
            this.l_drinkname.Name = "l_drinkname";
            this.l_drinkname.Size = new System.Drawing.Size(35, 13);
            this.l_drinkname.TabIndex = 7;
            this.l_drinkname.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // l_drinkstatus
            // 
            this.l_drinkstatus.AutoSize = true;
            this.l_drinkstatus.Location = new System.Drawing.Point(243, 61);
            this.l_drinkstatus.Name = "l_drinkstatus";
            this.l_drinkstatus.Size = new System.Drawing.Size(37, 13);
            this.l_drinkstatus.TabIndex = 9;
            this.l_drinkstatus.Text = "Status";
            // 
            // l_drinkprice
            // 
            this.l_drinkprice.AutoSize = true;
            this.l_drinkprice.Location = new System.Drawing.Point(60, 58);
            this.l_drinkprice.Name = "l_drinkprice";
            this.l_drinkprice.Size = new System.Drawing.Size(31, 13);
            this.l_drinkprice.TabIndex = 9;
            this.l_drinkprice.Text = "Price";
            // 
            // bt_add_Drink
            // 
            this.bt_add_Drink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_add_Drink.Location = new System.Drawing.Point(455, 15);
            this.bt_add_Drink.Name = "bt_add_Drink";
            this.bt_add_Drink.Size = new System.Drawing.Size(79, 47);
            this.bt_add_Drink.TabIndex = 10;
            this.bt_add_Drink.Text = "Add";
            this.bt_add_Drink.UseVisualStyleBackColor = true;
            // 
            // bt_Edit_Drink
            // 
            this.bt_Edit_Drink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Edit_Drink.Location = new System.Drawing.Point(554, 15);
            this.bt_Edit_Drink.Name = "bt_Edit_Drink";
            this.bt_Edit_Drink.Size = new System.Drawing.Size(79, 47);
            this.bt_Edit_Drink.TabIndex = 11;
            this.bt_Edit_Drink.Text = "Edit";
            this.bt_Edit_Drink.UseVisualStyleBackColor = true;
            // 
            // bt_delete_drink
            // 
            this.bt_delete_drink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_delete_drink.Location = new System.Drawing.Point(650, 15);
            this.bt_delete_drink.Name = "bt_delete_drink";
            this.bt_delete_drink.Size = new System.Drawing.Size(79, 47);
            this.bt_delete_drink.TabIndex = 12;
            this.bt_delete_drink.Text = "Delete";
            this.bt_delete_drink.UseVisualStyleBackColor = true;
            // 
            // bt_save_Drink
            // 
            this.bt_save_Drink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_save_Drink.Location = new System.Drawing.Point(746, 15);
            this.bt_save_Drink.Name = "bt_save_Drink";
            this.bt_save_Drink.Size = new System.Drawing.Size(79, 47);
            this.bt_save_Drink.TabIndex = 13;
            this.bt_save_Drink.Text = "Save";
            this.bt_save_Drink.UseVisualStyleBackColor = true;
            // 
            // bt_orders_drink
            // 
            this.bt_orders_drink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_orders_drink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_orders_drink.Location = new System.Drawing.Point(554, 86);
            this.bt_orders_drink.Name = "bt_orders_drink";
            this.bt_orders_drink.Size = new System.Drawing.Size(75, 60);
            this.bt_orders_drink.TabIndex = 18;
            this.bt_orders_drink.Text = "Orders";
            this.bt_orders_drink.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(286, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // bt_mat
            // 
            this.bt_mat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_mat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_mat.Location = new System.Drawing.Point(654, 86);
            this.bt_mat.Name = "bt_mat";
            this.bt_mat.Size = new System.Drawing.Size(75, 60);
            this.bt_mat.TabIndex = 20;
            this.bt_mat.Text = "Material";
            this.bt_mat.UseVisualStyleBackColor = false;
            // 
            // bt_emp
            // 
            this.bt_emp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_emp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_emp.Location = new System.Drawing.Point(455, 86);
            this.bt_emp.Name = "bt_emp";
            this.bt_emp.Size = new System.Drawing.Size(75, 60);
            this.bt_emp.TabIndex = 21;
            this.bt_emp.Text = "Employee";
            this.bt_emp.UseVisualStyleBackColor = false;
            // 
            // l_matid
            // 
            this.l_matid.AutoSize = true;
            this.l_matid.Location = new System.Drawing.Point(60, 105);
            this.l_matid.Name = "l_matid";
            this.l_matid.Size = new System.Drawing.Size(44, 13);
            this.l_matid.TabIndex = 22;
            this.l_matid.Text = "Material";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(111, 102);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 23;
            // 
            // bt_topping_drink
            // 
            this.bt_topping_drink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_topping_drink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_topping_drink.Location = new System.Drawing.Point(746, 86);
            this.bt_topping_drink.Name = "bt_topping_drink";
            this.bt_topping_drink.Size = new System.Drawing.Size(75, 60);
            this.bt_topping_drink.TabIndex = 25;
            this.bt_topping_drink.Text = "Topping";
            this.bt_topping_drink.UseVisualStyleBackColor = false;
            // 
            // Drink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 570);
            this.Controls.Add(this.bt_topping_drink);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.l_matid);
            this.Controls.Add(this.bt_emp);
            this.Controls.Add(this.bt_mat);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bt_orders_drink);
            this.Controls.Add(this.bt_save_Drink);
            this.Controls.Add(this.bt_delete_drink);
            this.Controls.Add(this.bt_Edit_Drink);
            this.Controls.Add(this.bt_add_Drink);
            this.Controls.Add(this.l_drinkprice);
            this.Controls.Add(this.l_drinkstatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.l_drinkname);
            this.Controls.Add(this.l_drinkid);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Drink";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafe/Drink";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.TextBox textBox3;
        internal System.Windows.Forms.TextBox textBox4;
        internal System.Windows.Forms.Label l_drinkid;
        internal System.Windows.Forms.Label l_drinkname;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label l_drinkstatus;
        internal System.Windows.Forms.Label l_drinkprice;
        internal System.Windows.Forms.Button bt_add_Drink;
        internal System.Windows.Forms.Button bt_Edit_Drink;
        internal System.Windows.Forms.Button bt_delete_drink;
        internal System.Windows.Forms.Button bt_save_Drink;
        internal System.Windows.Forms.Button bt_orders_drink;
        internal System.Windows.Forms.ComboBox comboBox1;
        internal System.Windows.Forms.Button bt_mat;
        internal System.Windows.Forms.Button bt_emp;
        internal System.Windows.Forms.Label l_matid;
        internal System.Windows.Forms.ComboBox comboBox2;
        internal System.Windows.Forms.Button bt_topping_drink;
    }
}