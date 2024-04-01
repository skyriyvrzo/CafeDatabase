namespace Main
{
    partial class Menu
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.l_order_id = new System.Windows.Forms.Label();
            this.l_Order_date = new System.Windows.Forms.Label();
            this.l_empid = new System.Windows.Forms.Label();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(113, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
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
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 570);
            this.Controls.Add(this.l_empid);
            this.Controls.Add(this.l_Order_date);
            this.Controls.Add(this.l_order_id);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Menu";
            this.Text = "Cafe/Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label l_order_id;
        private System.Windows.Forms.Label l_Order_date;
        private System.Windows.Forms.Label l_empid;
    }
}