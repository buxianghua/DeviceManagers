namespace DeviceManagers.viewForm
{
    partial class DepartmentManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentManagement));
            this.groupBox_departmentList = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_findDepartment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView_departmentList = new System.Windows.Forms.DataGridView();
            this.button_modify = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.groupBox_departmentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_departmentList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_departmentList
            // 
            this.groupBox_departmentList.BackgroundImage = global::DeviceManagers.Properties.Resources.autoback;
            this.groupBox_departmentList.Controls.Add(this.button1);
            this.groupBox_departmentList.Controls.Add(this.textBox_findDepartment);
            this.groupBox_departmentList.Controls.Add(this.label1);
            this.groupBox_departmentList.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_departmentList.Location = new System.Drawing.Point(84, 138);
            this.groupBox_departmentList.Name = "groupBox_departmentList";
            this.groupBox_departmentList.Size = new System.Drawing.Size(694, 79);
            this.groupBox_departmentList.TabIndex = 0;
            this.groupBox_departmentList.TabStop = false;
            this.groupBox_departmentList.Text = "搜索条件";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::DeviceManagers.Properties.Resources.autoback;
            this.button1.Location = new System.Drawing.Point(576, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "搜索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_findDepartment
            // 
            this.textBox_findDepartment.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_findDepartment.Location = new System.Drawing.Point(246, 31);
            this.textBox_findDepartment.Name = "textBox_findDepartment";
            this.textBox_findDepartment.Size = new System.Drawing.Size(289, 26);
            this.textBox_findDepartment.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Image = global::DeviceManagers.Properties.Resources.autoback;
            this.label1.Location = new System.Drawing.Point(98, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "部门名称：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DeviceManagers.Properties.Resources.autobackground;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(861, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView_departmentList
            // 
            this.dataGridView_departmentList.AllowUserToAddRows = false;
            this.dataGridView_departmentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_departmentList.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView_departmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_departmentList.Location = new System.Drawing.Point(84, 223);
            this.dataGridView_departmentList.Name = "dataGridView_departmentList";
            this.dataGridView_departmentList.RowTemplate.Height = 23;
            this.dataGridView_departmentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_departmentList.Size = new System.Drawing.Size(694, 188);
            this.dataGridView_departmentList.TabIndex = 3;
            // 
            // button_modify
            // 
            this.button_modify.BackgroundImage = global::DeviceManagers.Properties.Resources.autoback;
            this.button_modify.Location = new System.Drawing.Point(206, 417);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(85, 36);
            this.button_modify.TabIndex = 2;
            this.button_modify.Text = "修改";
            this.button_modify.UseVisualStyleBackColor = true;
            this.button_modify.Click += new System.EventHandler(this.button_modify_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackgroundImage = global::DeviceManagers.Properties.Resources.autoback;
            this.button_delete.Location = new System.Drawing.Point(534, 417);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(85, 36);
            this.button_delete.TabIndex = 2;
            this.button_delete.Text = "删除";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // DepartmentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeviceManagers.Properties.Resources.autoback;
            this.ClientSize = new System.Drawing.Size(859, 462);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_modify);
            this.Controls.Add(this.dataGridView_departmentList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox_departmentList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DepartmentManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "部门管理";
            this.Load += new System.EventHandler(this.DepartmentManagement_Load);
            this.groupBox_departmentList.ResumeLayout(false);
            this.groupBox_departmentList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_departmentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_departmentList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_findDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView_departmentList;
        private System.Windows.Forms.Button button_modify;
        private System.Windows.Forms.Button button_delete;
    }
}