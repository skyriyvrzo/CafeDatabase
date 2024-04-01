namespace Main
{
    partial class Main
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
            this.tb_empid = new System.Windows.Forms.TextBox();
            this.tb_fname = new System.Windows.Forms.TextBox();
            this.tb_lname = new System.Windows.Forms.TextBox();
            this.tb_salary = new System.Windows.Forms.TextBox();
            this.tb_sex = new System.Windows.Forms.TextBox();
            this.l_emp_id = new System.Windows.Forms.Label();
            this.l_fname = new System.Windows.Forms.Label();
            this.l_lname = new System.Windows.Forms.Label();
            this.l_sex = new System.Windows.Forms.Label();
            this.l_salary = new System.Windows.Forms.Label();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.tb_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(913, 356);
            this.dataGridView1.TabIndex = 0;
            // 
            // tb_empid
            // 
            this.tb_empid.Location = new System.Drawing.Point(119, 23);
            this.tb_empid.Name = "tb_empid";
            this.tb_empid.Size = new System.Drawing.Size(100, 20);
            this.tb_empid.TabIndex = 1;
            // 
            // tb_fname
            // 
            this.tb_fname.Location = new System.Drawing.Point(119, 56);
            this.tb_fname.Name = "tb_fname";
            this.tb_fname.Size = new System.Drawing.Size(100, 20);
            this.tb_fname.TabIndex = 2;
            // 
            // tb_lname
            // 
            this.tb_lname.Location = new System.Drawing.Point(119, 85);
            this.tb_lname.Name = "tb_lname";
            this.tb_lname.Size = new System.Drawing.Size(100, 20);
            this.tb_lname.TabIndex = 3;
            // 
            // tb_salary
            // 
            this.tb_salary.Location = new System.Drawing.Point(119, 115);
            this.tb_salary.Name = "tb_salary";
            this.tb_salary.Size = new System.Drawing.Size(100, 20);
            this.tb_salary.TabIndex = 4;
            // 
            // tb_sex
            // 
            this.tb_sex.Location = new System.Drawing.Point(119, 141);
            this.tb_sex.Name = "tb_sex";
            this.tb_sex.Size = new System.Drawing.Size(100, 20);
            this.tb_sex.TabIndex = 5;
            // 
            // l_emp_id
            // 
            this.l_emp_id.AutoSize = true;
            this.l_emp_id.Location = new System.Drawing.Point(49, 26);
            this.l_emp_id.Name = "l_emp_id";
            this.l_emp_id.Size = new System.Drawing.Size(64, 13);
            this.l_emp_id.TabIndex = 6;
            this.l_emp_id.Text = "EmployeeID";
            //this.l_emp_id.Click += new System.EventHandler(this.label1_Click);
            // 
            // l_fname
            // 
            this.l_fname.AutoSize = true;
            this.l_fname.Location = new System.Drawing.Point(49, 56);
            this.l_fname.Name = "l_fname";
            this.l_fname.Size = new System.Drawing.Size(54, 13);
            this.l_fname.TabIndex = 7;
            this.l_fname.Text = "FirstName";
            // 
            // l_lname
            // 
            this.l_lname.AutoSize = true;
            this.l_lname.Location = new System.Drawing.Point(49, 85);
            this.l_lname.Name = "l_lname";
            this.l_lname.Size = new System.Drawing.Size(55, 13);
            this.l_lname.TabIndex = 8;
            this.l_lname.Text = "LastName";
            // 
            // l_sex
            // 
            this.l_sex.AutoSize = true;
            this.l_sex.Location = new System.Drawing.Point(57, 141);
            this.l_sex.Name = "l_sex";
            this.l_sex.Size = new System.Drawing.Size(25, 13);
            this.l_sex.TabIndex = 9;
            this.l_sex.Text = "Sex";
            // 
            // l_salary
            // 
            this.l_salary.AutoSize = true;
            this.l_salary.Location = new System.Drawing.Point(57, 115);
            this.l_salary.Name = "l_salary";
            this.l_salary.Size = new System.Drawing.Size(36, 13);
            this.l_salary.TabIndex = 10;
            this.l_salary.Text = "Salary";
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(294, 16);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 11;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(375, 16);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(75, 23);
            this.bt_edit.TabIndex = 12;
            this.bt_edit.Text = "Edit";
            this.bt_edit.UseVisualStyleBackColor = true;
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(456, 16);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(75, 23);
            this.bt_delete.TabIndex = 13;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            // 
            // tb_save
            // 
            this.tb_save.Location = new System.Drawing.Point(537, 16);
            this.tb_save.Name = "tb_save";
            this.tb_save.Size = new System.Drawing.Size(75, 23);
            this.tb_save.TabIndex = 14;
            this.tb_save.Text = "Save";
            this.tb_save.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 570);
            this.Controls.Add(this.tb_save);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.l_salary);
            this.Controls.Add(this.l_sex);
            this.Controls.Add(this.l_lname);
            this.Controls.Add(this.l_fname);
            this.Controls.Add(this.l_emp_id);
            this.Controls.Add(this.tb_sex);
            this.Controls.Add(this.tb_salary);
            this.Controls.Add(this.tb_lname);
            this.Controls.Add(this.tb_fname);
            this.Controls.Add(this.tb_empid);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Main";
            this.Text = "Cafe/Employee";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_empid;
        private System.Windows.Forms.TextBox tb_fname;
        private System.Windows.Forms.TextBox tb_lname;
        private System.Windows.Forms.TextBox tb_salary;
        private System.Windows.Forms.TextBox tb_sex;
        private System.Windows.Forms.Label l_emp_id;
        private System.Windows.Forms.Label l_fname;
        private System.Windows.Forms.Label l_lname;
        private System.Windows.Forms.Label l_sex;
        private System.Windows.Forms.Label l_salary;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button tb_save;
    }
}

