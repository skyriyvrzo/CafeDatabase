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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.l_topping = new System.Windows.Forms.Label();
            this.l_drinkid_od = new System.Windows.Forms.Label();
            this.l_quantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 202);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(362, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(112, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(362, 34);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
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
            // OrdersDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 570);
            this.Controls.Add(this.l_quantity);
            this.Controls.Add(this.l_drinkid_od);
            this.Controls.Add(this.l_topping);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label l_topping;
        private System.Windows.Forms.Label l_drinkid_od;
        private System.Windows.Forms.Label l_quantity;
    }
}