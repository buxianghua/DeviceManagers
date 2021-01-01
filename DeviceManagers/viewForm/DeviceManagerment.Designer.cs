namespace DeviceManagers.viewForm
{
    partial class DeviceManagerment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceManagerment));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_deviceDepart = new System.Windows.Forms.ComboBox();
            this.dataGridView_deviceList = new System.Windows.Forms.DataGridView();
            this.button_flash = new System.Windows.Forms.Button();
            this.button_modify = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_deviceList)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DeviceManagers.Properties.Resources.autobackground;
            this.pictureBox1.Location = new System.Drawing.Point(2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(969, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.BackgroundImage = global::DeviceManagers.Properties.Resources.autoback;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.comboBox_deviceDepart);
            this.groupBox1.Controls.Add(this.dataGridView_deviceList);
            this.groupBox1.Controls.Add(this.button_flash);
            this.groupBox1.Controls.Add(this.button_modify);
            this.groupBox1.Controls.Add(this.button_search);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(2, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(959, 463);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索条件";
            // 
            // comboBox_deviceDepart
            // 
            this.comboBox_deviceDepart.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox_deviceDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_deviceDepart.FormattingEnabled = true;
            this.comboBox_deviceDepart.Location = new System.Drawing.Point(526, 56);
            this.comboBox_deviceDepart.Name = "comboBox_deviceDepart";
            this.comboBox_deviceDepart.Size = new System.Drawing.Size(211, 27);
            this.comboBox_deviceDepart.TabIndex = 5;
            // 
            // dataGridView_deviceList
            // 
            this.dataGridView_deviceList.AllowUserToAddRows = false;
            this.dataGridView_deviceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_deviceList.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridView_deviceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_deviceList.Location = new System.Drawing.Point(57, 93);
            this.dataGridView_deviceList.Name = "dataGridView_deviceList";
            this.dataGridView_deviceList.RowTemplate.Height = 23;
            this.dataGridView_deviceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_deviceList.Size = new System.Drawing.Size(826, 291);
            this.dataGridView_deviceList.TabIndex = 4;
            // 
            // button_flash
            // 
            this.button_flash.Image = global::DeviceManagers.Properties.Resources.autoback;
            this.button_flash.Location = new System.Drawing.Point(600, 408);
            this.button_flash.Name = "button_flash";
            this.button_flash.Size = new System.Drawing.Size(95, 34);
            this.button_flash.TabIndex = 3;
            this.button_flash.Text = "刷 新";
            this.button_flash.UseVisualStyleBackColor = true;
            this.button_flash.Click += new System.EventHandler(this.button_flash_Click);
            // 
            // button_modify
            // 
            this.button_modify.Image = global::DeviceManagers.Properties.Resources.autoback;
            this.button_modify.Location = new System.Drawing.Point(212, 408);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(95, 34);
            this.button_modify.TabIndex = 3;
            this.button_modify.Text = "修 改";
            this.button_modify.UseVisualStyleBackColor = true;
            this.button_modify.Click += new System.EventHandler(this.button_modify_Click);
            // 
            // button_search
            // 
            this.button_search.Image = global::DeviceManagers.Properties.Resources.autoback;
            this.button_search.Location = new System.Drawing.Point(772, 51);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(95, 34);
            this.button_search.TabIndex = 3;
            this.button_search.Text = "搜 索";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::DeviceManagers.Properties.Resources.autoback;
            this.label1.Location = new System.Drawing.Point(411, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "设备名称：";
            // 
            // DeviceManagerment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeviceManagers.Properties.Resources.autoback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(958, 593);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DeviceManagerment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设备管理列表";
            this.Load += new System.EventHandler(this.DeviceManagerment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_deviceList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_deviceList;
        private System.Windows.Forms.Button button_flash;
        private System.Windows.Forms.Button button_modify;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_deviceDepart;
    }
}