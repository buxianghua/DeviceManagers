namespace DeviceManagers.viewForm
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.button_cancelAdd = new System.Windows.Forms.Button();
            this.button_confirmAdd = new System.Windows.Forms.Button();
            this.textBox_addPassword2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_addpassword1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_adduser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_cancelAdd
            // 
            this.button_cancelAdd.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button_cancelAdd.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_cancelAdd.Image = global::DeviceManagers.Properties.Resources._return;
            this.button_cancelAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cancelAdd.Location = new System.Drawing.Point(309, 409);
            this.button_cancelAdd.Name = "button_cancelAdd";
            this.button_cancelAdd.Size = new System.Drawing.Size(118, 43);
            this.button_cancelAdd.TabIndex = 5;
            this.button_cancelAdd.Text = "取消增加";
            this.button_cancelAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_cancelAdd.UseVisualStyleBackColor = false;
            this.button_cancelAdd.Click += new System.EventHandler(this.button_cancelAdd_Click);
            // 
            // button_confirmAdd
            // 
            this.button_confirmAdd.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button_confirmAdd.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_confirmAdd.Image = global::DeviceManagers.Properties.Resources.updatepassword;
            this.button_confirmAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_confirmAdd.Location = new System.Drawing.Point(132, 409);
            this.button_confirmAdd.Name = "button_confirmAdd";
            this.button_confirmAdd.Size = new System.Drawing.Size(118, 43);
            this.button_confirmAdd.TabIndex = 4;
            this.button_confirmAdd.Text = "确认增加";
            this.button_confirmAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_confirmAdd.UseVisualStyleBackColor = false;
            this.button_confirmAdd.Click += new System.EventHandler(this.button_confirmAdd_Click);
            // 
            // textBox_addPassword2
            // 
            this.textBox_addPassword2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_addPassword2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_addPassword2.Location = new System.Drawing.Point(257, 302);
            this.textBox_addPassword2.Name = "textBox_addPassword2";
            this.textBox_addPassword2.PasswordChar = '*';
            this.textBox_addPassword2.Size = new System.Drawing.Size(170, 29);
            this.textBox_addPassword2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(133, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "确认密码：";
            // 
            // textBox_addpassword1
            // 
            this.textBox_addpassword1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_addpassword1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_addpassword1.Location = new System.Drawing.Point(257, 190);
            this.textBox_addpassword1.Name = "textBox_addpassword1";
            this.textBox_addpassword1.PasswordChar = '*';
            this.textBox_addpassword1.Size = new System.Drawing.Size(170, 29);
            this.textBox_addpassword1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(133, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "用户密码：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_adduser
            // 
            this.textBox_adduser.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_adduser.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_adduser.Location = new System.Drawing.Point(257, 93);
            this.textBox_adduser.Name = "textBox_adduser";
            this.textBox_adduser.Size = new System.Drawing.Size(170, 29);
            this.textBox_adduser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(133, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "用户姓名：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeviceManagers.Properties.Resources.updatepasswordbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(558, 545);
            this.Controls.Add(this.button_cancelAdd);
            this.Controls.Add(this.button_confirmAdd);
            this.Controls.Add(this.textBox_addPassword2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_addpassword1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_adduser);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增管理员";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cancelAdd;
        private System.Windows.Forms.Button button_confirmAdd;
        private System.Windows.Forms.TextBox textBox_addPassword2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_addpassword1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_adduser;
        private System.Windows.Forms.Label label1;
    }
}