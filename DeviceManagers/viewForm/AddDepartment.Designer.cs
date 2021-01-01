namespace DeviceManagers.viewForm
{
    partial class AddDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDepartment));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_addDepartment = new System.Windows.Forms.Button();
            this.textBox_departName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_departDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_departDevice = new System.Windows.Forms.ComboBox();
            this.numericUpDown_nums = new System.Windows.Forms.NumericUpDown();
            this.button_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nums)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DeviceManagers.Properties.Resources.autobackground;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(672, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Image = global::DeviceManagers.Properties.Resources.autoback;
            this.label1.Location = new System.Drawing.Point(148, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "部门名称：";
            // 
            // button_addDepartment
            // 
            this.button_addDepartment.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_addDepartment.Image = global::DeviceManagers.Properties.Resources.autoback;
            this.button_addDepartment.Location = new System.Drawing.Point(181, 403);
            this.button_addDepartment.Name = "button_addDepartment";
            this.button_addDepartment.Size = new System.Drawing.Size(105, 39);
            this.button_addDepartment.TabIndex = 3;
            this.button_addDepartment.Text = "添加";
            this.button_addDepartment.UseVisualStyleBackColor = true;
            this.button_addDepartment.Click += new System.EventHandler(this.button_addDepartment_Click);
            // 
            // textBox_departName
            // 
            this.textBox_departName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_departName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_departName.Location = new System.Drawing.Point(263, 165);
            this.textBox_departName.Name = "textBox_departName";
            this.textBox_departName.Size = new System.Drawing.Size(254, 29);
            this.textBox_departName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Image = global::DeviceManagers.Properties.Resources.autoback;
            this.label2.Location = new System.Drawing.Point(148, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "部门描述：";
            // 
            // textBox_departDesc
            // 
            this.textBox_departDesc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_departDesc.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_departDesc.Location = new System.Drawing.Point(263, 216);
            this.textBox_departDesc.Name = "textBox_departDesc";
            this.textBox_departDesc.Size = new System.Drawing.Size(254, 29);
            this.textBox_departDesc.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Image = global::DeviceManagers.Properties.Resources.autoback;
            this.label3.Location = new System.Drawing.Point(148, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "部门设备：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(416, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 14);
            this.label9.TabIndex = 16;
            this.label9.Text = "X";
            // 
            // comboBox_departDevice
            // 
            this.comboBox_departDevice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox_departDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_departDevice.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_departDevice.FormattingEnabled = true;
            this.comboBox_departDevice.Location = new System.Drawing.Point(263, 290);
            this.comboBox_departDevice.Name = "comboBox_departDevice";
            this.comboBox_departDevice.Size = new System.Drawing.Size(141, 24);
            this.comboBox_departDevice.TabIndex = 15;
            // 
            // numericUpDown_nums
            // 
            this.numericUpDown_nums.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.numericUpDown_nums.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_nums.Location = new System.Drawing.Point(447, 291);
            this.numericUpDown_nums.Name = "numericUpDown_nums";
            this.numericUpDown_nums.Size = new System.Drawing.Size(70, 26);
            this.numericUpDown_nums.TabIndex = 14;
            this.numericUpDown_nums.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_reset
            // 
            this.button_reset.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_reset.Image = global::DeviceManagers.Properties.Resources.autoback;
            this.button_reset.Location = new System.Drawing.Point(386, 403);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(105, 39);
            this.button_reset.TabIndex = 4;
            this.button_reset.Text = "重置";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // AddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeviceManagers.Properties.Resources.autoback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 542);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox_departDevice);
            this.Controls.Add(this.numericUpDown_nums);
            this.Controls.Add(this.textBox_departDesc);
            this.Controls.Add(this.textBox_departName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_addDepartment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "部门增加";
            this.Load += new System.EventHandler(this.AddDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nums)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_addDepartment;
        private System.Windows.Forms.TextBox textBox_departName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_departDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_departDevice;
        private System.Windows.Forms.NumericUpDown numericUpDown_nums;
        private System.Windows.Forms.Button button_reset;
    }
}