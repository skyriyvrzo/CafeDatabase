namespace Main
{
    partial class MaterialofDrink
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
            this.cb_drink = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_material = new System.Windows.Forms.ComboBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_emp = new System.Windows.Forms.Button();
            this.bt_topping = new System.Windows.Forms.Button();
            this.bt_mat = new System.Windows.Forms.Button();
            this.bt_orders = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drink";
            // 
            // cb_drink
            // 
            this.cb_drink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_drink.FormattingEnabled = true;
            this.cb_drink.Location = new System.Drawing.Point(80, 36);
            this.cb_drink.Name = "cb_drink";
            this.cb_drink.Size = new System.Drawing.Size(177, 21);
            this.cb_drink.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Material";
            // 
            // cb_material
            // 
            this.cb_material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_material.FormattingEnabled = true;
            this.cb_material.Location = new System.Drawing.Point(80, 74);
            this.cb_material.Name = "cb_material";
            this.cb_material.Size = new System.Drawing.Size(177, 21);
            this.cb_material.TabIndex = 3;
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(590, 26);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(85, 39);
            this.bt_add.TabIndex = 4;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(681, 26);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(85, 39);
            this.bt_edit.TabIndex = 5;
            this.bt_edit.Text = "Edit";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(772, 26);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(85, 39);
            this.bt_delete.TabIndex = 6;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(863, 26);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(85, 39);
            this.bt_save.TabIndex = 7;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_emp
            // 
            this.bt_emp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_emp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_emp.Location = new System.Drawing.Point(590, 88);
            this.bt_emp.Name = "bt_emp";
            this.bt_emp.Size = new System.Drawing.Size(75, 60);
            this.bt_emp.TabIndex = 22;
            this.bt_emp.Text = "Employee";
            this.bt_emp.UseVisualStyleBackColor = false;
            // 
            // bt_topping
            // 
            this.bt_topping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_topping.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_topping.Location = new System.Drawing.Point(863, 88);
            this.bt_topping.Name = "bt_topping";
            this.bt_topping.Size = new System.Drawing.Size(75, 60);
            this.bt_topping.TabIndex = 28;
            this.bt_topping.Text = "Topping";
            this.bt_topping.UseVisualStyleBackColor = false;
            // 
            // bt_mat
            // 
            this.bt_mat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_mat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_mat.Location = new System.Drawing.Point(772, 88);
            this.bt_mat.Name = "bt_mat";
            this.bt_mat.Size = new System.Drawing.Size(75, 60);
            this.bt_mat.TabIndex = 27;
            this.bt_mat.Text = "Material";
            this.bt_mat.UseVisualStyleBackColor = false;
            // 
            // bt_orders
            // 
            this.bt_orders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_orders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_orders.Location = new System.Drawing.Point(681, 88);
            this.bt_orders.Name = "bt_orders";
            this.bt_orders.Size = new System.Drawing.Size(75, 60);
            this.bt_orders.TabIndex = 26;
            this.bt_orders.Text = "Orders";
            this.bt_orders.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(973, 335);
            this.dataGridView1.TabIndex = 29;
            // 
            // MaterialofDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 570);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_topping);
            this.Controls.Add(this.bt_mat);
            this.Controls.Add(this.bt_orders);
            this.Controls.Add(this.bt_emp);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.cb_material);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_drink);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MaterialofDrink";
            this.Text = "Cafe/MaterialofDrink";
            this.Load += new System.EventHandler(this.MaterialofDrink_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox cb_drink;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox cb_material;
        internal System.Windows.Forms.Button bt_add;
        internal System.Windows.Forms.Button bt_edit;
        internal System.Windows.Forms.Button bt_delete;
        internal System.Windows.Forms.Button bt_save;
        internal System.Windows.Forms.Button bt_emp;
        internal System.Windows.Forms.Button bt_topping;
        internal System.Windows.Forms.Button bt_mat;
        internal System.Windows.Forms.Button bt_orders;
        internal System.Windows.Forms.DataGridView dataGridView1;
    }
}