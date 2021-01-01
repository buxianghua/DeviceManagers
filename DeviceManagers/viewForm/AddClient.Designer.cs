namespace DeviceManagers.viewForm
{
    partial class AddClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClient));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox_clientClass = new System.Windows.Forms.ComboBox();
            this.textBox_clientTele = new System.Windows.Forms.TextBox();
            this.textBox_clientNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_addClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_cancle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_clientCompany = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_clientName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DeviceManagers.Properties.Resources.autobackground;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(737, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox_clientClass
            // 
            this.comboBox_clientClass.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox_clientClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_clientClass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_clientClass.FormattingEnabled = true;
            this.comboBox_clientClass.Location = new System.Drawing.Point(292, 295);
            this.comboBox_clientClass.Name = "comboBox_clientClass";
            this.comboBox_clientClass.Size = new System.Drawing.Size(254, 24);
            this.comboBox_clientClass.TabIndex = 22;
            // 
            // textBox_clientTele
            // 
            this.textBox_clientTele.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_clientTele.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_clientTele.Location = new System.Drawing.Point(292, 363);
            this.textBox_clientTele.Name = "textBox_clientTele";
            this.textBox_clientTele.Size = new System.Drawing.Size(254, 29);
            this.textBox_clientTele.TabIndex = 3;
            // 
            // textBox_clientNum
            // 
            this.textBox_clientNum.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_clientNum.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_clientNum.Location = new System.Drawing.Point(292, 163);
            this.textBox_clientNum.Name = "textBox_clientNum";
            this.textBox_clientNum.Size = new System.Drawing.Size(254, 29);
            this.textBox_clientNum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Image = global::DeviceManagers.Properties.Resources.autoback;
            this.label2.Location = new System.Drawing.Point(177, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "客户电话：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Image = global::DeviceManagers.Properties.Resources.autoback;
            this.label3.Location = new System.Drawing.Point(177, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "客户级别：";
            // 
            // button_addClient
            // 
            this.button_addClient.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_addClient.Image = global::DeviceManagers.Properties.Resources.autoback;
            this.button_addClient.Location = new System.Drawing.Point(188, 508);
            this.button_addClient.Name = "button_addClient";
            this.button_addClient.Size = new System.Drawing.Size(105, 39);
            this.button_addClient.TabIndex = 5;
            this.button_addClient.Text = "添加";
            this.button_addClient.UseVisualStyleBackColor = true;
            this.button_addClient.Click += new System.EventHandler(this.button_addClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Image = global::DeviceManagers.Properties.Resources.autoback;
            this.label1.Location = new System.Drawing.Point(177, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "客户编号：";
            // 
            // button_cancle
            // 
            this.button_cancle.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_cancle.Image = global::DeviceManagers.Properties.Resources.autoback;
            this.button_cancle.Location = new System.Drawing.Point(410, 508);
            this.button_cancle.Name = "button_cancle";
            this.button_cancle.Size = new System.Drawing.Size(105, 39);
            this.button_cancle.TabIndex = 6;
            this.button_cancle.Text = "取消";
            this.button_cancle.UseVisualStyleBackColor = true;
            this.button_cancle.Click += new System.EventHandler(this.button_cancle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Image = global::DeviceManagers.Properties.Resources.autoback;
            this.label4.Location = new System.Drawing.Point(177, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "客户公司：";
            // 
            // textBox_clientCompany
            // 
            this.textBox_clientCompany.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_clientCompany.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_clientCompany.Location = new System.Drawing.Point(292, 423);
            this.textBox_clientCompany.Name = "textBox_clientCompany";
            this.textBox_clientCompany.Size = new System.Drawing.Size(254, 29);
            this.textBox_clientCompany.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Image = global::DeviceManagers.Properties.Resources.autoback;
            this.label5.Location = new System.Drawing.Point(177, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "客户姓名：";
            // 
            // textBox_clientName
            // 
            this.textBox_clientName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_clientName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_clientName.Location = new System.Drawing.Point(292, 236);
            this.textBox_clientName.Name = "textBox_clientName";
            this.textBox_clientName.Size = new System.Drawing.Size(254, 29);
            this.textBox_clientName.TabIndex = 2;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeviceManagers.Properties.Resources.autoback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(736, 573);
            this.Controls.Add(this.comboBox_clientClass);
            this.Controls.Add(this.textBox_clientCompany);
            this.Controls.Add(this.textBox_clientTele);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_clientName);
            this.Controls.Add(this.textBox_clientNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_cancle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_addClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客户添加";
            this.Load += new System.EventHandler(this.AddClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox_clientClass;
        private System.Windows.Forms.TextBox textBox_clientTele;
        private System.Windows.Forms.TextBox textBox_clientNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_addClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_cancle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_clientCompany;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_clientName;
    }
}