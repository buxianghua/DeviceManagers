namespace DeviceManagers.viewForm
{
    partial class ClientManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientManagement));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_clientList = new System.Windows.Forms.DataGridView();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_modify = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.comboBox_clientClass = new System.Windows.Forms.ComboBox();
            this.textBox_clientName = new System.Windows.Forms.TextBox();
            this.textBox_clientScard = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clientList)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DeviceManagers.Properties.Resources.autobackground;
            this.pictureBox1.Location = new System.Drawing.Point(0, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1147, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.BackgroundImage = global::DeviceManagers.Properties.Resources.autoback;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.dataGridView_clientList);
            this.groupBox1.Controls.Add(this.button_delete);
            this.groupBox1.Controls.Add(this.button_modify);
            this.groupBox1.Controls.Add(this.button_search);
            this.groupBox1.Controls.Add(this.comboBox_clientClass);
            this.groupBox1.Controls.Add(this.textBox_clientName);
            this.groupBox1.Controls.Add(this.textBox_clientScard);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1147, 439);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索条件";
            // 
            // dataGridView_clientList
            // 
            this.dataGridView_clientList.AllowUserToAddRows = false;
            this.dataGridView_clientList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_clientList.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridView_clientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_clientList.Location = new System.Drawing.Point(47, 93);
            this.dataGridView_clientList.Name = "dataGridView_clientList";
            this.dataGridView_clientList.RowTemplate.Height = 23;
            this.dataGridView_clientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_clientList.Size = new System.Drawing.Size(1035, 282);
            this.dataGridView_clientList.TabIndex = 4;
            // 
            // button_delete
            // 
            this.button_delete.Image = global::DeviceManagers.Properties.Resources.autoback;
            this.button_delete.Location = new System.Drawing.Point(640, 383);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(95, 34);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "删 除";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_modify
            // 
            this.button_modify.Image = global::DeviceManagers.Properties.Resources.autoback;
            this.button_modify.Location = new System.Drawing.Point(320, 383);
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
            this.button_search.Location = new System.Drawing.Point(1009, 42);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(95, 34);
            this.button_search.TabIndex = 3;
            this.button_search.Text = "搜 索";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // comboBox_clientClass
            // 
            this.comboBox_clientClass.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox_clientClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_clientClass.FormattingEnabled = true;
            this.comboBox_clientClass.Location = new System.Drawing.Point(824, 42);
            this.comboBox_clientClass.Name = "comboBox_clientClass";
            this.comboBox_clientClass.Size = new System.Drawing.Size(136, 27);
            this.comboBox_clientClass.TabIndex = 2;
            // 
            // textBox_clientName
            // 
            this.textBox_clientName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_clientName.Location = new System.Drawing.Point(466, 42);
            this.textBox_clientName.Name = "textBox_clientName";
            this.textBox_clientName.Size = new System.Drawing.Size(157, 29);
            this.textBox_clientName.TabIndex = 1;
            // 
            // textBox_clientScard
            // 
            this.textBox_clientScard.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_clientScard.Location = new System.Drawing.Point(155, 42);
            this.textBox_clientScard.Name = "textBox_clientScard";
            this.textBox_clientScard.Size = new System.Drawing.Size(157, 29);
            this.textBox_clientScard.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = global::DeviceManagers.Properties.Resources.autoback;
            this.label3.Location = new System.Drawing.Point(674, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "客户类别：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = global::DeviceManagers.Properties.Resources.autoback;
            this.label2.Location = new System.Drawing.Point(354, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "客户姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::DeviceManagers.Properties.Resources.autoback;
            this.label1.Location = new System.Drawing.Point(43, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "客户编号：";
            // 
            // ClientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeviceManagers.Properties.Resources.autoback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1145, 609);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClientManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客户管理";
            this.Load += new System.EventHandler(this.ClientManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clientList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_clientList;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_modify;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.ComboBox comboBox_clientClass;
        private System.Windows.Forms.TextBox textBox_clientName;
        private System.Windows.Forms.TextBox textBox_clientScard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}