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
            this.bt_Menu_or = new System.Windows.Forms.Button();
            this.bt_orders_drink = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.l_drinkid.Location = new System.Drawing.Point(48, 15);
            this.l_drinkid.Name = "l_drinkid";
            this.l_drinkid.Size = new System.Drawing.Size(43, 13);
            this.l_drinkid.TabIndex = 6;
            this.l_drinkid.Text = "DrinkID";
            // 
            // l_drinkname
            // 
            this.l_drinkname.AutoSize = true;
            this.l_drinkname.Location = new System.Drawing.Point(220, 15);
            this.l_drinkname.Name = "l_drinkname";
            this.l_drinkname.Size = new System.Drawing.Size(60, 13);
            this.l_drinkname.TabIndex = 7;
            this.l_drinkname.Text = "DrinkName";
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
            this.l_drinkstatus.Location = new System.Drawing.Point(220, 61);
            this.l_drinkstatus.Name = "l_drinkstatus";
            this.l_drinkstatus.Size = new System.Drawing.Size(62, 13);
            this.l_drinkstatus.TabIndex = 9;
            this.l_drinkstatus.Text = "DrinkStatus";
            // 
            // l_drinkprice
            // 
            this.l_drinkprice.AutoSize = true;
            this.l_drinkprice.Location = new System.Drawing.Point(48, 61);
            this.l_drinkprice.Name = "l_drinkprice";
            this.l_drinkprice.Size = new System.Drawing.Size(56, 13);
            this.l_drinkprice.TabIndex = 9;
            this.l_drinkprice.Text = "DrinkPrice";
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
            // bt_Menu_or
            // 
            this.bt_Menu_or.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_Menu_or.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Menu_or.Location = new System.Drawing.Point(455, 86);
            this.bt_Menu_or.Name = "bt_Menu_or";
            this.bt_Menu_or.Size = new System.Drawing.Size(75, 60);
            this.bt_Menu_or.TabIndex = 17;
            this.bt_Menu_or.Text = "Menu";
            this.bt_Menu_or.UseVisualStyleBackColor = false;
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
            // Drink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 570);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bt_orders_drink);
            this.Controls.Add(this.bt_Menu_or);
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
            this.Name = "Drink";
            this.Text = "Cafe/Drink";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label l_drinkid;
        private System.Windows.Forms.Label l_drinkname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_drinkstatus;
        private System.Windows.Forms.Label l_drinkprice;
        private System.Windows.Forms.Button bt_add_Drink;
        private System.Windows.Forms.Button bt_Edit_Drink;
        private System.Windows.Forms.Button bt_delete_drink;
        private System.Windows.Forms.Button bt_save_Drink;
        private System.Windows.Forms.Button bt_Menu_or;
        private System.Windows.Forms.Button bt_orders_drink;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}