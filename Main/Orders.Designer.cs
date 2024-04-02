namespace Main
{
    partial class Orders
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
            this.tb_orderid = new System.Windows.Forms.TextBox();
            this.bt_orderdate = new System.Windows.Forms.TextBox();
            this.tb_empid_or = new System.Windows.Forms.TextBox();
            this.l_order_id = new System.Windows.Forms.Label();
            this.l_Order_date = new System.Windows.Forms.Label();
            this.l_empid = new System.Windows.Forms.Label();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.bt_add_or = new System.Windows.Forms.Button();
            this.bt_edit_or = new System.Windows.Forms.Button();
            this.bt_delete_or = new System.Windows.Forms.Button();
            this.bt_save_or = new System.Windows.Forms.Button();
            this.bt_Menu_or = new System.Windows.Forms.Button();
            this.bt_drink_or = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(913, 341);
            this.dataGridView1.TabIndex = 0;
            // 
            // tb_orderid
            // 
            this.tb_orderid.Location = new System.Drawing.Point(113, 22);
            this.tb_orderid.Name = "tb_orderid";
            this.tb_orderid.Size = new System.Drawing.Size(100, 20);
            this.tb_orderid.TabIndex = 1;
            // 
            // bt_orderdate
            // 
            this.bt_orderdate.Location = new System.Drawing.Point(113, 51);
            this.bt_orderdate.Name = "bt_orderdate";
            this.bt_orderdate.Size = new System.Drawing.Size(100, 20);
            this.bt_orderdate.TabIndex = 2;
            // 
            // tb_empid_or
            // 
            this.tb_empid_or.Location = new System.Drawing.Point(113, 84);
            this.tb_empid_or.Name = "tb_empid_or";
            this.tb_empid_or.Size = new System.Drawing.Size(100, 20);
            this.tb_empid_or.TabIndex = 3;
            // 
            // l_order_id
            // 
            this.l_order_id.AutoSize = true;
            this.l_order_id.Location = new System.Drawing.Point(28, 25);
            this.l_order_id.Name = "l_order_id";
            this.l_order_id.Size = new System.Drawing.Size(44, 13);
            this.l_order_id.TabIndex = 4;
            this.l_order_id.Text = "OrderID";
            // 
            // l_Order_date
            // 
            this.l_Order_date.AutoSize = true;
            this.l_Order_date.Location = new System.Drawing.Point(28, 54);
            this.l_Order_date.Name = "l_Order_date";
            this.l_Order_date.Size = new System.Drawing.Size(56, 13);
            this.l_Order_date.TabIndex = 5;
            this.l_Order_date.Text = "OrderDate";
            // 
            // l_empid
            // 
            this.l_empid.AutoSize = true;
            this.l_empid.Location = new System.Drawing.Point(28, 87);
            this.l_empid.Name = "l_empid";
            this.l_empid.Size = new System.Drawing.Size(64, 13);
            this.l_empid.TabIndex = 6;
            this.l_empid.Text = "EmployeeID";
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // bt_add_or
            // 
            this.bt_add_or.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_add_or.Location = new System.Drawing.Point(288, 12);
            this.bt_add_or.Name = "bt_add_or";
            this.bt_add_or.Size = new System.Drawing.Size(79, 47);
            this.bt_add_or.TabIndex = 7;
            this.bt_add_or.Text = "Add";
            this.bt_add_or.UseVisualStyleBackColor = true;
            // 
            // bt_edit_or
            // 
            this.bt_edit_or.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_edit_or.Location = new System.Drawing.Point(391, 12);
            this.bt_edit_or.Name = "bt_edit_or";
            this.bt_edit_or.Size = new System.Drawing.Size(79, 47);
            this.bt_edit_or.TabIndex = 8;
            this.bt_edit_or.Text = "Edit";
            this.bt_edit_or.UseVisualStyleBackColor = true;
            // 
            // bt_delete_or
            // 
            this.bt_delete_or.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_delete_or.Location = new System.Drawing.Point(496, 12);
            this.bt_delete_or.Name = "bt_delete_or";
            this.bt_delete_or.Size = new System.Drawing.Size(79, 47);
            this.bt_delete_or.TabIndex = 9;
            this.bt_delete_or.Text = "Delete";
            this.bt_delete_or.UseVisualStyleBackColor = true;
            // 
            // bt_save_or
            // 
            this.bt_save_or.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_save_or.Location = new System.Drawing.Point(591, 12);
            this.bt_save_or.Name = "bt_save_or";
            this.bt_save_or.Size = new System.Drawing.Size(79, 47);
            this.bt_save_or.TabIndex = 10;
            this.bt_save_or.Text = "Save";
            this.bt_save_or.UseVisualStyleBackColor = true;
            // 
            // bt_Menu_or
            // 
            this.bt_Menu_or.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_Menu_or.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Menu_or.Location = new System.Drawing.Point(288, 84);
            this.bt_Menu_or.Name = "bt_Menu_or";
            this.bt_Menu_or.Size = new System.Drawing.Size(75, 60);
            this.bt_Menu_or.TabIndex = 16;
            this.bt_Menu_or.Text = "Menu";
            this.bt_Menu_or.UseVisualStyleBackColor = false;
            // 
            // bt_drink_or
            // 
            this.bt_drink_or.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_drink_or.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_drink_or.Location = new System.Drawing.Point(391, 84);
            this.bt_drink_or.Name = "bt_drink_or";
            this.bt_drink_or.Size = new System.Drawing.Size(75, 60);
            this.bt_drink_or.TabIndex = 17;
            this.bt_drink_or.Text = "Drink";
            this.bt_drink_or.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 570);
            this.Controls.Add(this.bt_drink_or);
            this.Controls.Add(this.bt_Menu_or);
            this.Controls.Add(this.bt_save_or);
            this.Controls.Add(this.bt_delete_or);
            this.Controls.Add(this.bt_edit_or);
            this.Controls.Add(this.bt_add_or);
            this.Controls.Add(this.l_empid);
            this.Controls.Add(this.l_Order_date);
            this.Controls.Add(this.l_order_id);
            this.Controls.Add(this.tb_empid_or);
            this.Controls.Add(this.bt_orderdate);
            this.Controls.Add(this.tb_orderid);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafe/Orders";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.TextBox tb_orderid;
        internal System.Windows.Forms.TextBox bt_orderdate;
        internal System.Windows.Forms.TextBox tb_empid_or;
        internal System.Windows.Forms.Label l_order_id;
        internal System.Windows.Forms.Label l_Order_date;
        internal System.Windows.Forms.Label l_empid;
        internal MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        internal System.Windows.Forms.Button bt_add_or;
        internal System.Windows.Forms.Button bt_edit_or;
        internal System.Windows.Forms.Button bt_delete_or;
        internal System.Windows.Forms.Button bt_save_or;
        internal System.Windows.Forms.Button bt_Menu_or;
        internal System.Windows.Forms.Button bt_drink_or;
    }
}