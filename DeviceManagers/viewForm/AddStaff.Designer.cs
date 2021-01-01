namespace DeviceManagers.viewForm
{
    partial class AddStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStaff));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_staffNum = new System.Windows.Forms.TextBox();
            this.radioButton_staffBoy = new System.Windows.Forms.RadioButton();
            this.numericUpDown_staffAge = new System.Windows.Forms.NumericUpDown();
            this.comboBox_staffdepartment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_staffName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton_staffGirl = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_staffMoney = new System.Windows.Forms.TextBox();
            this.button_staffAdd = new System.Windows.Forms.Button();
            this.button_staffReset = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_staffDevice = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_staffAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown_nums = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_staffAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nums)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DeviceManagers.Properties.Resources.autobackground;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(861, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(85, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "员工编号：";
            // 
            // textBox_staffNum
            // 
            this.textBox_staffNum.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_staffNum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_staffNum.Location = new System.Drawing.Point(200, 150);
            this.textBox_staffNum.Name = "textBox_staffNum";
            this.textBox_staffNum.Size = new System.Drawing.Size(181, 26);
            this.textBox_staffNum.TabIndex = 1;
            // 
            // radioButton_staffBoy
            // 
            this.radioButton_staffBoy.AutoSize = true;
            this.radioButton_staffBoy.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.radioButton_staffBoy.Checked = true;
            this.radioButton_staffBoy.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_staffBoy.ForeColor = System.Drawing.SystemColors.WindowText;
            this.radioButton_staffBoy.Location = new System.Drawing.Point(221, 213);
            this.radioButton_staffBoy.Name = "radioButton_staffBoy";
            this.radioButton_staffBoy.Size = new System.Drawing.Size(43, 20);
            this.radioButton_staffBoy.TabIndex = 3;
            this.radioButton_staffBoy.TabStop = true;
            this.radioButton_staffBoy.Text = "男";
            this.radioButton_staffBoy.UseVisualStyleBackColor = false;
            // 
            // numericUpDown_staffAge
            // 
            this.numericUpDown_staffAge.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.numericUpDown_staffAge.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_staffAge.Location = new System.Drawing.Point(581, 204);
            this.numericUpDown_staffAge.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_staffAge.Name = "numericUpDown_staffAge";
            this.numericUpDown_staffAge.Size = new System.Drawing.Size(200, 26);
            this.numericUpDown_staffAge.TabIndex = 5;
            this.numericUpDown_staffAge.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // comboBox_staffdepartment
            // 
            this.comboBox_staffdepartment.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox_staffdepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_staffdepartment.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_staffdepartment.FormattingEnabled = true;
            this.comboBox_staffdepartment.Location = new System.Drawing.Point(207, 270);
            this.comboBox_staffdepartment.Name = "comboBox_staffdepartment";
            this.comboBox_staffdepartment.Size = new System.Drawing.Size(174, 24);
            this.comboBox_staffdepartment.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(466, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "员工姓名：";
            // 
            // textBox_staffName
            // 
            this.textBox_staffName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_staffName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_staffName.Location = new System.Drawing.Point(581, 146);
            this.textBox_staffName.Name = "textBox_staffName";
            this.textBox_staffName.Size = new System.Drawing.Size(200, 26);
            this.textBox_staffName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(85, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "员工性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(466, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "员工年龄：";
            // 
            // radioButton_staffGirl
            // 
            this.radioButton_staffGirl.AutoSize = true;
            this.radioButton_staffGirl.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.radioButton_staffGirl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_staffGirl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.radioButton_staffGirl.Location = new System.Drawing.Point(303, 213);
            this.radioButton_staffGirl.Name = "radioButton_staffGirl";
            this.radioButton_staffGirl.Size = new System.Drawing.Size(43, 20);
            this.radioButton_staffGirl.TabIndex = 4;
            this.radioButton_staffGirl.Text = "女";
            this.radioButton_staffGirl.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(85, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "所属部门：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(466, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "员工工资：";
            // 
            // textBox_staffMoney
            // 
            this.textBox_staffMoney.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_staffMoney.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_staffMoney.Location = new System.Drawing.Point(581, 264);
            this.textBox_staffMoney.Name = "textBox_staffMoney";
            this.textBox_staffMoney.Size = new System.Drawing.Size(200, 26);
            this.textBox_staffMoney.TabIndex = 7;
            // 
            // button_staffAdd
            // 
            this.button_staffAdd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_staffAdd.BackgroundImage = global::DeviceManagers.Properties.Resources.updatepasswordbackground;
            this.button_staffAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_staffAdd.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_staffAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_staffAdd.Location = new System.Drawing.Point(268, 390);
            this.button_staffAdd.Name = "button_staffAdd";
            this.button_staffAdd.Size = new System.Drawing.Size(96, 47);
            this.button_staffAdd.TabIndex = 11;
            this.button_staffAdd.Text = "添加";
            this.button_staffAdd.UseVisualStyleBackColor = false;
            this.button_staffAdd.Click += new System.EventHandler(this.button_staffAdd_Click);
            // 
            // button_staffReset
            // 
            this.button_staffReset.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_staffReset.BackgroundImage = global::DeviceManagers.Properties.Resources.updatepasswordbackground;
            this.button_staffReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_staffReset.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_staffReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_staffReset.Location = new System.Drawing.Point(473, 390);
            this.button_staffReset.Name = "button_staffReset";
            this.button_staffReset.Size = new System.Drawing.Size(96, 47);
            this.button_staffReset.TabIndex = 12;
            this.button_staffReset.Text = "重置";
            this.button_staffReset.UseVisualStyleBackColor = false;
            this.button_staffReset.Click += new System.EventHandler(this.button_staffReset_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(466, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "员工设备：";
            // 
            // comboBox_staffDevice
            // 
            this.comboBox_staffDevice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox_staffDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_staffDevice.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_staffDevice.FormattingEnabled = true;
            this.comboBox_staffDevice.Location = new System.Drawing.Point(581, 330);
            this.comboBox_staffDevice.Name = "comboBox_staffDevice";
            this.comboBox_staffDevice.Size = new System.Drawing.Size(123, 24);
            this.comboBox_staffDevice.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(80, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "员工住址：";
            // 
            // textBox_staffAddress
            // 
            this.textBox_staffAddress.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_staffAddress.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_staffAddress.Location = new System.Drawing.Point(200, 336);
            this.textBox_staffAddress.Name = "textBox_staffAddress";
            this.textBox_staffAddress.Size = new System.Drawing.Size(181, 26);
            this.textBox_staffAddress.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(711, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 14);
            this.label9.TabIndex = 13;
            this.label9.Text = "X";
            // 
            // numericUpDown_nums
            // 
            this.numericUpDown_nums.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.numericUpDown_nums.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_nums.Location = new System.Drawing.Point(732, 330);
            this.numericUpDown_nums.Name = "numericUpDown_nums";
            this.numericUpDown_nums.Size = new System.Drawing.Size(49, 26);
            this.numericUpDown_nums.TabIndex = 5;
            this.numericUpDown_nums.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeviceManagers.Properties.Resources.updatepasswordbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 449);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button_staffReset);
            this.Controls.Add(this.button_staffAdd);
            this.Controls.Add(this.comboBox_staffDevice);
            this.Controls.Add(this.comboBox_staffdepartment);
            this.Controls.Add(this.numericUpDown_nums);
            this.Controls.Add(this.numericUpDown_staffAge);
            this.Controls.Add(this.radioButton_staffGirl);
            this.Controls.Add(this.radioButton_staffBoy);
            this.Controls.Add(this.textBox_staffMoney);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_staffName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_staffAddress);
            this.Controls.Add(this.textBox_staffNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工修改";
            this.Load += new System.EventHandler(this.AddStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_staffAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nums)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_staffNum;
        private System.Windows.Forms.RadioButton radioButton_staffBoy;
        private System.Windows.Forms.NumericUpDown numericUpDown_staffAge;
        private System.Windows.Forms.ComboBox comboBox_staffdepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_staffName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton_staffGirl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_staffMoney;
        private System.Windows.Forms.Button button_staffAdd;
        private System.Windows.Forms.Button button_staffReset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_staffDevice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_staffAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown_nums;
    }
}