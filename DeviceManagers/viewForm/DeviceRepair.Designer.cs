namespace DeviceManagers.viewForm
{
    partial class DeviceRepair
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceRepair));
            this.textBox_staffName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_staffNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_staffDevice = new System.Windows.Forms.ComboBox();
            this.numericUpDown_nums = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.button_submit = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nums)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_staffName
            // 
            this.textBox_staffName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_staffName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_staffName.Location = new System.Drawing.Point(219, 175);
            this.textBox_staffName.Name = "textBox_staffName";
            this.textBox_staffName.Size = new System.Drawing.Size(200, 26);
            this.textBox_staffName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(104, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "员工姓名：";
            // 
            // textBox_staffNum
            // 
            this.textBox_staffNum.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_staffNum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_staffNum.Location = new System.Drawing.Point(219, 72);
            this.textBox_staffNum.Name = "textBox_staffNum";
            this.textBox_staffNum.Size = new System.Drawing.Size(200, 26);
            this.textBox_staffNum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(104, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "员工编号：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(349, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 14);
            this.label9.TabIndex = 17;
            this.label9.Text = "X";
            // 
            // comboBox_staffDevice
            // 
            this.comboBox_staffDevice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox_staffDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_staffDevice.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_staffDevice.FormattingEnabled = true;
            this.comboBox_staffDevice.Location = new System.Drawing.Point(219, 296);
            this.comboBox_staffDevice.Name = "comboBox_staffDevice";
            this.comboBox_staffDevice.Size = new System.Drawing.Size(123, 24);
            this.comboBox_staffDevice.TabIndex = 16;
            // 
            // numericUpDown_nums
            // 
            this.numericUpDown_nums.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.numericUpDown_nums.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_nums.Location = new System.Drawing.Point(370, 296);
            this.numericUpDown_nums.Name = "numericUpDown_nums";
            this.numericUpDown_nums.Size = new System.Drawing.Size(49, 26);
            this.numericUpDown_nums.TabIndex = 15;
            this.numericUpDown_nums.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(104, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "员工设备：";
            // 
            // button_submit
            // 
            this.button_submit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_submit.BackgroundImage = global::DeviceManagers.Properties.Resources.updatepasswordbackground;
            this.button_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_submit.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_submit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_submit.Location = new System.Drawing.Point(117, 400);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(96, 47);
            this.button_submit.TabIndex = 18;
            this.button_submit.Text = "提交";
            this.button_submit.UseVisualStyleBackColor = false;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_cancel.BackgroundImage = global::DeviceManagers.Properties.Resources.updatepasswordbackground;
            this.button_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_cancel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cancel.Location = new System.Drawing.Point(309, 400);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(96, 47);
            this.button_cancel.TabIndex = 18;
            this.button_cancel.Text = "取消";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // DeviceRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeviceManagers.Properties.Resources.updatepasswordbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 520);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox_staffDevice);
            this.Controls.Add(this.numericUpDown_nums);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_staffName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_staffNum);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeviceRepair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设备报修";
            this.Load += new System.EventHandler(this.DeviceRepair_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nums)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_staffName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_staffNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_staffDevice;
        private System.Windows.Forms.NumericUpDown numericUpDown_nums;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Button button_cancel;
    }
}