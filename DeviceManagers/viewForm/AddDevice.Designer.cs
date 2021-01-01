namespace DeviceManagers.viewForm
{
    partial class AddDevice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDevice));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_deviceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_nums = new System.Windows.Forms.NumericUpDown();
            this.button_addDevice = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_devicePrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nums)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DeviceManagers.Properties.Resources.autobackground;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_deviceName
            // 
            this.textBox_deviceName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_deviceName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_deviceName.Location = new System.Drawing.Point(188, 165);
            this.textBox_deviceName.Name = "textBox_deviceName";
            this.textBox_deviceName.Size = new System.Drawing.Size(140, 26);
            this.textBox_deviceName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(73, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "设备名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(73, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "设备数量：";
            // 
            // numericUpDown_nums
            // 
            this.numericUpDown_nums.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.numericUpDown_nums.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_nums.Location = new System.Drawing.Point(188, 274);
            this.numericUpDown_nums.Name = "numericUpDown_nums";
            this.numericUpDown_nums.Size = new System.Drawing.Size(140, 26);
            this.numericUpDown_nums.TabIndex = 6;
            this.numericUpDown_nums.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_addDevice
            // 
            this.button_addDevice.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_addDevice.Image = global::DeviceManagers.Properties.Resources.autoback;
            this.button_addDevice.Location = new System.Drawing.Point(77, 463);
            this.button_addDevice.Name = "button_addDevice";
            this.button_addDevice.Size = new System.Drawing.Size(105, 39);
            this.button_addDevice.TabIndex = 3;
            this.button_addDevice.Text = "添加";
            this.button_addDevice.UseVisualStyleBackColor = true;
            this.button_addDevice.Click += new System.EventHandler(this.button_addDevice_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_cancel.Image = global::DeviceManagers.Properties.Resources.autoback;
            this.button_cancel.Location = new System.Drawing.Point(223, 463);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(105, 39);
            this.button_cancel.TabIndex = 4;
            this.button_cancel.Text = "取消";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(73, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "设备价格：";
            // 
            // textBox_devicePrice
            // 
            this.textBox_devicePrice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_devicePrice.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_devicePrice.Location = new System.Drawing.Point(188, 363);
            this.textBox_devicePrice.Name = "textBox_devicePrice";
            this.textBox_devicePrice.Size = new System.Drawing.Size(140, 26);
            this.textBox_devicePrice.TabIndex = 2;
            // 
            // AddDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeviceManagers.Properties.Resources.autoback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(437, 552);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_addDevice);
            this.Controls.Add(this.numericUpDown_nums);
            this.Controls.Add(this.textBox_devicePrice);
            this.Controls.Add(this.textBox_deviceName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设备添加";
            this.Load += new System.EventHandler(this.AddDevice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nums)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_deviceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_nums;
        private System.Windows.Forms.Button button_addDevice;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_devicePrice;
    }
}