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
            this.label3 = new System.Windows.Forms.Label();
            this.l_drinkstatus = new System.Windows.Forms.Label();
            this.l_drinkprice = new System.Windows.Forms.Label();
            this.bt_add_Drink = new System.Windows.Forms.Button();
            this.bt_Edit_Drink = new System.Windows.Forms.Button();
            this.bt_delete_drink = new System.Windows.Forms.Button();
            this.bt_save_Drink = new System.Windows.Forms.Button();
            this.bt_orders_drink = new System.Windows.Forms.Button();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.bt_mat = new System.Windows.Forms.Button();
            this.bt_emp = new System.Windows.Forms.Button();
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
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tb_drink_id
            // 
            this.tb_drink_id.Location = new System.Drawing.Point(111, 12);
            this.tb_drink_id.Name = "tb_drink_id";
            this.tb_drink_id.Size = new System.Drawing.Size(100, 20);
            this.tb_drink_id.TabIndex = 2;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(286, 12);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 20);
            this.tb_name.TabIndex = 4;
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(111, 54);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(100, 20);
            this.tb_price.TabIndex = 5;
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
            this.bt_add_Drink.Click += new System.EventHandler(this.bt_add_Drink_Click);
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
            this.bt_Edit_Drink.Click += new System.EventHandler(this.bt_Edit_Drink_Click);
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
            this.bt_delete_drink.Click += new System.EventHandler(this.bt_delete_drink_Click);
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
            this.bt_save_Drink.Click += new System.EventHandler(this.bt_save_Drink_Click);
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
            // cb_status
            // 
            this.cb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(286, 58);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(100, 21);
            this.cb_status.TabIndex = 19;
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
            this.Controls.Add(this.bt_emp);
            this.Controls.Add(this.bt_mat);
            this.Controls.Add(this.cb_status);
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
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_drink_id);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Drink";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafe/Drink";
            this.Load += new System.EventHandler(this.Drink_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label l_drinkstatus;
        internal System.Windows.Forms.Label l_drinkprice;
        internal System.Windows.Forms.Button bt_add_Drink;
        internal System.Windows.Forms.Button bt_Edit_Drink;
        internal System.Windows.Forms.Button bt_delete_drink;
        internal System.Windows.Forms.Button bt_save_Drink;
        internal System.Windows.Forms.Button bt_orders_drink;
        internal System.Windows.Forms.ComboBox cb_status;
        internal System.Windows.Forms.Button bt_mat;
        internal System.Windows.Forms.Button bt_emp;
        internal System.Windows.Forms.Button bt_topping_drink;
    }
}