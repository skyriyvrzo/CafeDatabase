namespace Main
{
    partial class Material
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
            this.l_material_Material = new System.Windows.Forms.Label();
            this.l_Materialname_Material = new System.Windows.Forms.Label();
            this.tb_matid = new System.Windows.Forms.TextBox();
            this.tb_matname = new System.Windows.Forms.TextBox();
            this.bt_add_Material = new System.Windows.Forms.Button();
            this.bt_Edit_Material = new System.Windows.Forms.Button();
            this.bt_delete_Material = new System.Windows.Forms.Button();
            this.bt_save_Material = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_employee = new System.Windows.Forms.Button();
            this.bt_order = new System.Windows.Forms.Button();
            this.bt_od = new System.Windows.Forms.Button();
            this.bt_drink = new System.Windows.Forms.Button();
            this.bt_mod = new System.Windows.Forms.Button();
            this.bt_mat = new System.Windows.Forms.Button();
            this.bt_topping = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(913, 356);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // l_material_Material
            // 
            this.l_material_Material.AutoSize = true;
            this.l_material_Material.Location = new System.Drawing.Point(71, 87);
            this.l_material_Material.Name = "l_material_Material";
            this.l_material_Material.Size = new System.Drawing.Size(58, 13);
            this.l_material_Material.TabIndex = 1;
            this.l_material_Material.Text = "Material ID";
            // 
            // l_Materialname_Material
            // 
            this.l_Materialname_Material.AutoSize = true;
            this.l_Materialname_Material.Location = new System.Drawing.Point(71, 140);
            this.l_Materialname_Material.Name = "l_Materialname_Material";
            this.l_Materialname_Material.Size = new System.Drawing.Size(35, 13);
            this.l_Materialname_Material.TabIndex = 2;
            this.l_Materialname_Material.Text = "Name";
            // 
            // tb_matid
            // 
            this.tb_matid.Location = new System.Drawing.Point(145, 84);
            this.tb_matid.Name = "tb_matid";
            this.tb_matid.Size = new System.Drawing.Size(100, 20);
            this.tb_matid.TabIndex = 3;
            // 
            // tb_matname
            // 
            this.tb_matname.Location = new System.Drawing.Point(145, 137);
            this.tb_matname.Name = "tb_matname";
            this.tb_matname.Size = new System.Drawing.Size(100, 20);
            this.tb_matname.TabIndex = 4;
            // 
            // bt_add_Material
            // 
            this.bt_add_Material.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_add_Material.Location = new System.Drawing.Point(359, 74);
            this.bt_add_Material.Name = "bt_add_Material";
            this.bt_add_Material.Size = new System.Drawing.Size(79, 47);
            this.bt_add_Material.TabIndex = 11;
            this.bt_add_Material.Text = "Add";
            this.bt_add_Material.UseVisualStyleBackColor = true;
            this.bt_add_Material.Click += new System.EventHandler(this.bt_add_Material_Click);
            // 
            // bt_Edit_Material
            // 
            this.bt_Edit_Material.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Edit_Material.Location = new System.Drawing.Point(444, 74);
            this.bt_Edit_Material.Name = "bt_Edit_Material";
            this.bt_Edit_Material.Size = new System.Drawing.Size(79, 47);
            this.bt_Edit_Material.TabIndex = 12;
            this.bt_Edit_Material.Text = "Edit";
            this.bt_Edit_Material.UseVisualStyleBackColor = true;
            this.bt_Edit_Material.Click += new System.EventHandler(this.bt_Edit_Material_Click);
            // 
            // bt_delete_Material
            // 
            this.bt_delete_Material.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_delete_Material.Location = new System.Drawing.Point(529, 74);
            this.bt_delete_Material.Name = "bt_delete_Material";
            this.bt_delete_Material.Size = new System.Drawing.Size(79, 47);
            this.bt_delete_Material.TabIndex = 13;
            this.bt_delete_Material.Text = "Delete";
            this.bt_delete_Material.UseVisualStyleBackColor = true;
            this.bt_delete_Material.Click += new System.EventHandler(this.bt_delete_Material_Click);
            // 
            // bt_save_Material
            // 
            this.bt_save_Material.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_save_Material.Location = new System.Drawing.Point(614, 74);
            this.bt_save_Material.Name = "bt_save_Material";
            this.bt_save_Material.Size = new System.Drawing.Size(79, 47);
            this.bt_save_Material.TabIndex = 14;
            this.bt_save_Material.Text = "Save";
            this.bt_save_Material.UseVisualStyleBackColor = true;
            this.bt_save_Material.Click += new System.EventHandler(this.bt_save_Material_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.bt_employee);
            this.panel1.Controls.Add(this.bt_order);
            this.panel1.Controls.Add(this.bt_od);
            this.panel1.Controls.Add(this.bt_drink);
            this.panel1.Controls.Add(this.bt_mod);
            this.panel1.Controls.Add(this.bt_mat);
            this.panel1.Controls.Add(this.bt_topping);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 37);
            this.panel1.TabIndex = 30;
            // 
            // bt_employee
            // 
            this.bt_employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.bt_employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_employee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.bt_employee.FlatAppearance.BorderSize = 0;
            this.bt_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_employee.Location = new System.Drawing.Point(133, 0);
            this.bt_employee.Name = "bt_employee";
            this.bt_employee.Size = new System.Drawing.Size(97, 37);
            this.bt_employee.TabIndex = 29;
            this.bt_employee.Text = "Employee";
            this.bt_employee.UseVisualStyleBackColor = false;
            this.bt_employee.Click += new System.EventHandler(this.bt_employee_Click);
            // 
            // bt_order
            // 
            this.bt_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.bt_order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_order.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.bt_order.FlatAppearance.BorderSize = 0;
            this.bt_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_order.Location = new System.Drawing.Point(18, 0);
            this.bt_order.Name = "bt_order";
            this.bt_order.Size = new System.Drawing.Size(97, 37);
            this.bt_order.TabIndex = 15;
            this.bt_order.Text = "Orders";
            this.bt_order.UseVisualStyleBackColor = false;
            this.bt_order.Click += new System.EventHandler(this.bt_order_Click);
            // 
            // bt_od
            // 
            this.bt_od.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.bt_od.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_od.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.bt_od.FlatAppearance.BorderSize = 0;
            this.bt_od.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_od.Location = new System.Drawing.Point(708, 0);
            this.bt_od.Name = "bt_od";
            this.bt_od.Size = new System.Drawing.Size(96, 37);
            this.bt_od.TabIndex = 27;
            this.bt_od.Text = "Order detail";
            this.bt_od.UseVisualStyleBackColor = false;
            this.bt_od.Click += new System.EventHandler(this.bt_od_Click);
            // 
            // bt_drink
            // 
            this.bt_drink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.bt_drink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_drink.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.bt_drink.FlatAppearance.BorderSize = 0;
            this.bt_drink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_drink.Location = new System.Drawing.Point(247, 0);
            this.bt_drink.Name = "bt_drink";
            this.bt_drink.Size = new System.Drawing.Size(96, 37);
            this.bt_drink.TabIndex = 18;
            this.bt_drink.Text = "Drink";
            this.bt_drink.UseVisualStyleBackColor = false;
            this.bt_drink.Click += new System.EventHandler(this.bt_drink_Click);
            // 
            // bt_mod
            // 
            this.bt_mod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.bt_mod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_mod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.bt_mod.FlatAppearance.BorderSize = 0;
            this.bt_mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_mod.Location = new System.Drawing.Point(591, 0);
            this.bt_mod.Name = "bt_mod";
            this.bt_mod.Size = new System.Drawing.Size(96, 37);
            this.bt_mod.TabIndex = 26;
            this.bt_mod.Text = "Material of Drink";
            this.bt_mod.UseVisualStyleBackColor = false;
            this.bt_mod.Click += new System.EventHandler(this.bt_mod_Click);
            // 
            // bt_mat
            // 
            this.bt_mat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(204)))));
            this.bt_mat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_mat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.bt_mat.FlatAppearance.BorderSize = 0;
            this.bt_mat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_mat.Location = new System.Drawing.Point(361, 0);
            this.bt_mat.Name = "bt_mat";
            this.bt_mat.Size = new System.Drawing.Size(96, 37);
            this.bt_mat.TabIndex = 20;
            this.bt_mat.Text = "Material";
            this.bt_mat.UseVisualStyleBackColor = false;
            this.bt_mat.Click += new System.EventHandler(this.bt_mat_Click);
            // 
            // bt_topping
            // 
            this.bt_topping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.bt_topping.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_topping.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.bt_topping.FlatAppearance.BorderSize = 0;
            this.bt_topping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_topping.Location = new System.Drawing.Point(477, 0);
            this.bt_topping.Name = "bt_topping";
            this.bt_topping.Size = new System.Drawing.Size(96, 37);
            this.bt_topping.TabIndex = 25;
            this.bt_topping.Text = "Topping";
            this.bt_topping.UseVisualStyleBackColor = false;
            this.bt_topping.Click += new System.EventHandler(this.bt_topping_Click);
            // 
            // Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_save_Material);
            this.Controls.Add(this.bt_delete_Material);
            this.Controls.Add(this.bt_Edit_Material);
            this.Controls.Add(this.bt_add_Material);
            this.Controls.Add(this.tb_matname);
            this.Controls.Add(this.tb_matid);
            this.Controls.Add(this.l_Materialname_Material);
            this.Controls.Add(this.l_material_Material);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Material";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafe/Material";
            this.Load += new System.EventHandler(this.Material_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Label l_material_Material;
        internal System.Windows.Forms.Label l_Materialname_Material;
        internal System.Windows.Forms.TextBox tb_matid;
        internal System.Windows.Forms.TextBox tb_matname;
        internal System.Windows.Forms.Button bt_add_Material;
        internal System.Windows.Forms.Button bt_Edit_Material;
        internal System.Windows.Forms.Button bt_delete_Material;
        internal System.Windows.Forms.Button bt_save_Material;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button bt_employee;
        internal System.Windows.Forms.Button bt_order;
        internal System.Windows.Forms.Button bt_od;
        internal System.Windows.Forms.Button bt_drink;
        internal System.Windows.Forms.Button bt_mod;
        internal System.Windows.Forms.Button bt_mat;
        internal System.Windows.Forms.Button bt_topping;
    }
}