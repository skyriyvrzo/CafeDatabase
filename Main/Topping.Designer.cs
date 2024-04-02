namespace Main
{
    partial class Topping
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
            this.l_toppingid = new System.Windows.Forms.Label();
            this.l_toppingname = new System.Windows.Forms.Label();
            this.l_toppingprice = new System.Windows.Forms.Label();
            this.tb_tp_id = new System.Windows.Forms.TextBox();
            this.tb_tp_name = new System.Windows.Forms.TextBox();
            this.tb_tp_price = new System.Windows.Forms.TextBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_order_emp = new System.Windows.Forms.Button();
            this.bt_drink_emp = new System.Windows.Forms.Button();
            this.bt_mat = new System.Windows.Forms.Button();
            this.bt_emp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(913, 356);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // l_toppingid
            // 
            this.l_toppingid.AutoSize = true;
            this.l_toppingid.Location = new System.Drawing.Point(25, 24);
            this.l_toppingid.Name = "l_toppingid";
            this.l_toppingid.Size = new System.Drawing.Size(46, 13);
            this.l_toppingid.TabIndex = 2;
            this.l_toppingid.Text = "Topping";
            // 
            // l_toppingname
            // 
            this.l_toppingname.AutoSize = true;
            this.l_toppingname.Location = new System.Drawing.Point(25, 62);
            this.l_toppingname.Name = "l_toppingname";
            this.l_toppingname.Size = new System.Drawing.Size(74, 13);
            this.l_toppingname.TabIndex = 3;
            this.l_toppingname.Text = "ToppingName";
            // 
            // l_toppingprice
            // 
            this.l_toppingprice.AutoSize = true;
            this.l_toppingprice.Location = new System.Drawing.Point(25, 99);
            this.l_toppingprice.Name = "l_toppingprice";
            this.l_toppingprice.Size = new System.Drawing.Size(70, 13);
            this.l_toppingprice.TabIndex = 4;
            this.l_toppingprice.Text = "ToppingPrice";
            // 
            // tb_tp_id
            // 
            this.tb_tp_id.Location = new System.Drawing.Point(105, 24);
            this.tb_tp_id.Name = "tb_tp_id";
            this.tb_tp_id.Size = new System.Drawing.Size(100, 20);
            this.tb_tp_id.TabIndex = 5;
            // 
            // tb_tp_name
            // 
            this.tb_tp_name.Location = new System.Drawing.Point(105, 59);
            this.tb_tp_name.Name = "tb_tp_name";
            this.tb_tp_name.Size = new System.Drawing.Size(100, 20);
            this.tb_tp_name.TabIndex = 6;
            // 
            // tb_tp_price
            // 
            this.tb_tp_price.Location = new System.Drawing.Point(105, 92);
            this.tb_tp_price.Name = "tb_tp_price";
            this.tb_tp_price.Size = new System.Drawing.Size(100, 20);
            this.tb_tp_price.TabIndex = 7;
            // 
            // bt_add
            // 
            this.bt_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_add.Location = new System.Drawing.Point(297, 45);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(79, 47);
            this.bt_add.TabIndex = 12;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_Edit
            // 
            this.bt_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Edit.Location = new System.Drawing.Point(382, 45);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(79, 47);
            this.bt_Edit.TabIndex = 13;
            this.bt_Edit.Text = "Edit";
            this.bt_Edit.UseVisualStyleBackColor = true;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_delete.Location = new System.Drawing.Point(467, 45);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(79, 47);
            this.bt_delete.TabIndex = 14;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_save
            // 
            this.bt_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_save.Location = new System.Drawing.Point(552, 45);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(79, 47);
            this.bt_save.TabIndex = 15;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_order_emp
            // 
            this.bt_order_emp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_order_emp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_order_emp.Location = new System.Drawing.Point(301, 99);
            this.bt_order_emp.Name = "bt_order_emp";
            this.bt_order_emp.Size = new System.Drawing.Size(75, 60);
            this.bt_order_emp.TabIndex = 16;
            this.bt_order_emp.Text = "Orders";
            this.bt_order_emp.UseVisualStyleBackColor = false;
            // 
            // bt_drink_emp
            // 
            this.bt_drink_emp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_drink_emp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_drink_emp.Location = new System.Drawing.Point(467, 98);
            this.bt_drink_emp.Name = "bt_drink_emp";
            this.bt_drink_emp.Size = new System.Drawing.Size(75, 60);
            this.bt_drink_emp.TabIndex = 19;
            this.bt_drink_emp.Text = "Drink";
            this.bt_drink_emp.UseVisualStyleBackColor = false;
            // 
            // bt_mat
            // 
            this.bt_mat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_mat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_mat.Location = new System.Drawing.Point(382, 99);
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
            this.bt_emp.Location = new System.Drawing.Point(552, 99);
            this.bt_emp.Name = "bt_emp";
            this.bt_emp.Size = new System.Drawing.Size(75, 60);
            this.bt_emp.TabIndex = 22;
            this.bt_emp.Text = "Employee";
            this.bt_emp.UseVisualStyleBackColor = false;
            // 
            // Topping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 570);
            this.Controls.Add(this.bt_emp);
            this.Controls.Add(this.bt_mat);
            this.Controls.Add(this.bt_drink_emp);
            this.Controls.Add(this.bt_order_emp);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_Edit);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.tb_tp_price);
            this.Controls.Add(this.tb_tp_name);
            this.Controls.Add(this.tb_tp_id);
            this.Controls.Add(this.l_toppingprice);
            this.Controls.Add(this.l_toppingname);
            this.Controls.Add(this.l_toppingid);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Topping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafe/Topping";
            this.Load += new System.EventHandler(this.Topping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Label l_toppingid;
        internal System.Windows.Forms.Label l_toppingname;
        internal System.Windows.Forms.Label l_toppingprice;
        internal System.Windows.Forms.TextBox tb_tp_id;
        internal System.Windows.Forms.TextBox tb_tp_name;
        internal System.Windows.Forms.TextBox tb_tp_price;
        internal System.Windows.Forms.Button bt_add;
        internal System.Windows.Forms.Button bt_Edit;
        internal System.Windows.Forms.Button bt_delete;
        internal System.Windows.Forms.Button bt_save;
        internal System.Windows.Forms.Button bt_order_emp;
        internal System.Windows.Forms.Button bt_drink_emp;
        internal System.Windows.Forms.Button bt_mat;
        internal System.Windows.Forms.Button bt_emp;
    }
}