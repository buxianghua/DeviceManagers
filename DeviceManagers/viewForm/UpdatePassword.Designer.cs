namespace DeviceManagers.viewForm
{
    partial class UpdatePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePassword));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_oldPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_newPassword1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_newPassword2 = new System.Windows.Forms.TextBox();
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(124, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "原始密码：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_oldPassword
            // 
            this.textBox_oldPassword.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_oldPassword.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_oldPassword.Location = new System.Drawing.Point(248, 97);
            this.textBox_oldPassword.Name = "textBox_oldPassword";
            this.textBox_oldPassword.PasswordChar = '*';
            this.textBox_oldPassword.Size = new System.Drawing.Size(170, 29);
            this.textBox_oldPassword.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(124, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "新的密码：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_newPassword1
            // 
            this.textBox_newPassword1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_newPassword1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_newPassword1.Location = new System.Drawing.Point(248, 194);
            this.textBox_newPassword1.Name = "textBox_newPassword1";
            this.textBox_newPassword1.PasswordChar = '*';
            this.textBox_newPassword1.Size = new System.Drawing.Size(170, 29);
            this.textBox_newPassword1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(124, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "确认密码：";
            // 
            // textBox_newPassword2
            // 
            this.textBox_newPassword2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_newPassword2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_newPassword2.Location = new System.Drawing.Point(248, 306);
            this.textBox_newPassword2.Name = "textBox_newPassword2";
            this.textBox_newPassword2.PasswordChar = '*';
            this.textBox_newPassword2.Size = new System.Drawing.Size(170, 29);
            this.textBox_newPassword2.TabIndex = 3;
            // 
            // button_confirm
            // 
            this.button_confirm.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button_confirm.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_confirm.Image = global::DeviceManagers.Properties.Resources.updatepassword;
            this.button_confirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_confirm.Location = new System.Drawing.Point(123, 413);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(118, 43);
            this.button_confirm.TabIndex = 4;
            this.button_confirm.Text = "确认修改";
            this.button_confirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_confirm.UseVisualStyleBackColor = false;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button_cancel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_cancel.Image = global::DeviceManagers.Properties.Resources._return;
            this.button_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cancel.Location = new System.Drawing.Point(300, 413);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(118, 43);
            this.button_cancel.TabIndex = 5;
            this.button_cancel.Text = "取消修改";
            this.button_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // UpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeviceManagers.Properties.Resources.updatepasswordbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(575, 572);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.textBox_newPassword2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_newPassword1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_oldPassword);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UpdatePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_oldPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_newPassword1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_newPassword2;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Button button_cancel;
    }
}