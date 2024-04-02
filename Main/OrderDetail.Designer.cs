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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drink";
            // 
            // cb_order
            // 
            this.cb_order.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_order.FormattingEnabled = true;
            this.cb_order.Location = new System.Drawing.Point(80, 36);
            this.cb_order.Name = "cb_order";
            this.cb_order.Size = new System.Drawing.Size(181, 21);
            this.cb_order.TabIndex = 2;
            // 
            // cb_drink
            // 
            this.cb_drink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_drink.FormattingEnabled = true;
            this.cb_drink.Location = new System.Drawing.Point(80, 82);
            this.cb_drink.Name = "cb_drink";
            this.cb_drink.Size = new System.Drawing.Size(181, 21);
            this.cb_drink.TabIndex = 3;
            // 
            // cb_topping
            // 
            this.cb_topping.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_topping.FormattingEnabled = true;
            this.cb_topping.Location = new System.Drawing.Point(341, 36);
            this.cb_topping.Name = "cb_topping";
            this.cb_topping.Size = new System.Drawing.Size(181, 21);
            this.cb_topping.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Topping";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity";
            // 
            // tb_quantity
            // 
            this.tb_quantity.Location = new System.Drawing.Point(341, 82);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(181, 20);
            this.tb_quantity.TabIndex = 7;
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(646, 39);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(78, 38);
            this.bt_add.TabIndex = 8;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(730, 39);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(78, 38);
            this.bt_edit.TabIndex = 9;
            this.bt_edit.Text = "Edit";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(646, 85);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(78, 38);
            this.bt_delete.TabIndex = 10;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(730, 85);
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(972, 330);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // OrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 570);
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
            this.Text = "Cafe/OrdersDetail";
            this.Load += new System.EventHandler(this.OrderDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}