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
            this.bt_mat = new System.Windows.Forms.Button();
            this.bt_drink_od = new System.Windows.Forms.Button();
            this.bt_emp = new System.Windows.Forms.Button();
            this.bt_topping_mat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.l_material_Material.Location = new System.Drawing.Point(75, 33);
            this.l_material_Material.Name = "l_material_Material";
            this.l_material_Material.Size = new System.Drawing.Size(58, 13);
            this.l_material_Material.TabIndex = 1;
            this.l_material_Material.Text = "Material ID";
            // 
            // l_Materialname_Material
            // 
            this.l_Materialname_Material.AutoSize = true;
            this.l_Materialname_Material.Location = new System.Drawing.Point(75, 86);
            this.l_Materialname_Material.Name = "l_Materialname_Material";
            this.l_Materialname_Material.Size = new System.Drawing.Size(35, 13);
            this.l_Materialname_Material.TabIndex = 2;
            this.l_Materialname_Material.Text = "Name";
            // 
            // tb_matid
            // 
            this.tb_matid.Location = new System.Drawing.Point(149, 30);
            this.tb_matid.Name = "tb_matid";
            this.tb_matid.Size = new System.Drawing.Size(100, 20);
            this.tb_matid.TabIndex = 3;
            // 
            // tb_matname
            // 
            this.tb_matname.Location = new System.Drawing.Point(149, 83);
            this.tb_matname.Name = "tb_matname";
            this.tb_matname.Size = new System.Drawing.Size(100, 20);
            this.tb_matname.TabIndex = 4;
            // 
            // bt_add_Material
            // 
            this.bt_add_Material.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_add_Material.Location = new System.Drawing.Point(363, 20);
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
            this.bt_Edit_Material.Location = new System.Drawing.Point(448, 20);
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
            this.bt_delete_Material.Location = new System.Drawing.Point(533, 20);
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
            this.bt_save_Material.Location = new System.Drawing.Point(618, 20);
            this.bt_save_Material.Name = "bt_save_Material";
            this.bt_save_Material.Size = new System.Drawing.Size(79, 47);
            this.bt_save_Material.TabIndex = 14;
            this.bt_save_Material.Text = "Save";
            this.bt_save_Material.UseVisualStyleBackColor = true;
            this.bt_save_Material.Click += new System.EventHandler(this.bt_save_Material_Click);
            // 
            // bt_mat
            // 
            this.bt_mat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_mat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_mat.Location = new System.Drawing.Point(448, 90);
            this.bt_mat.Name = "bt_mat";
            this.bt_mat.Size = new System.Drawing.Size(75, 60);
            this.bt_mat.TabIndex = 19;
            this.bt_mat.Text = "Material";
            this.bt_mat.UseVisualStyleBackColor = false;
            // 
            // bt_drink_od
            // 
            this.bt_drink_od.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_drink_od.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_drink_od.Location = new System.Drawing.Point(529, 90);
            this.bt_drink_od.Name = "bt_drink_od";
            this.bt_drink_od.Size = new System.Drawing.Size(75, 60);
            this.bt_drink_od.TabIndex = 21;
            this.bt_drink_od.Text = "Drink";
            this.bt_drink_od.UseVisualStyleBackColor = false;
            // 
            // bt_emp
            // 
            this.bt_emp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_emp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_emp.Location = new System.Drawing.Point(363, 90);
            this.bt_emp.Name = "bt_emp";
            this.bt_emp.Size = new System.Drawing.Size(75, 60);
            this.bt_emp.TabIndex = 22;
            this.bt_emp.Text = "Employee";
            this.bt_emp.UseVisualStyleBackColor = false;
            // 
            // bt_topping_mat
            // 
            this.bt_topping_mat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_topping_mat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_topping_mat.Location = new System.Drawing.Point(618, 90);
            this.bt_topping_mat.Name = "bt_topping_mat";
            this.bt_topping_mat.Size = new System.Drawing.Size(75, 60);
            this.bt_topping_mat.TabIndex = 24;
            this.bt_topping_mat.Text = "Topping";
            this.bt_topping_mat.UseVisualStyleBackColor = false;
            // 
            // Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 570);
            this.Controls.Add(this.bt_topping_mat);
            this.Controls.Add(this.bt_emp);
            this.Controls.Add(this.bt_drink_od);
            this.Controls.Add(this.bt_mat);
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
        internal System.Windows.Forms.Button bt_mat;
        internal System.Windows.Forms.Button bt_drink_od;
        internal System.Windows.Forms.Button bt_emp;
        internal System.Windows.Forms.Button bt_topping_mat;
    }
}