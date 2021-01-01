namespace DeviceManagers
{
    partial class UserLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            this.label_username = new System.Windows.Forms.Label();
            this.text_username = new System.Windows.Forms.TextBox();
            this.text_password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_username.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_username.Image = global::DeviceManagers.Properties.Resources.username;
            this.label_username.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_username.Location = new System.Drawing.Point(729, 219);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(111, 19);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "  用户名：";
            this.label_username.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // text_username
            // 
            this.text_username.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_username.ForeColor = System.Drawing.SystemColors.WindowText;
            this.text_username.Location = new System.Drawing.Point(843, 214);
            this.text_username.Name = "text_username";
            this.text_username.Size = new System.Drawing.Size(168, 29);
            this.text_username.TabIndex = 1;
            // 
            // text_password
            // 
            this.text_password.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_password.ForeColor = System.Drawing.SystemColors.WindowText;
            this.text_password.Location = new System.Drawing.Point(843, 306);
            this.text_password.Name = "text_password";
            this.text_password.PasswordChar = '*';
            this.text_password.Size = new System.Drawing.Size(168, 29);
            this.text_password.TabIndex = 2;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_password.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_password.Image = global::DeviceManagers.Properties.Resources.password;
            this.label_password.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_password.Location = new System.Drawing.Point(727, 310);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(113, 19);
            this.label_password.TabIndex = 2;
            this.label_password.Text = "  密  码：";
            this.label_password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_login.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_login.Image = global::DeviceManagers.Properties.Resources.login;
            this.button_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_login.Location = new System.Drawing.Point(764, 403);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(74, 52);
            this.button_login.TabIndex = 3;
            this.button_login.Text = "登录";
            this.button_login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_reset
            // 
            this.button_reset.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_reset.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_reset.Image = global::DeviceManagers.Properties.Resources.reset;
            this.button_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_reset.Location = new System.Drawing.Point(901, 403);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(77, 52);
            this.button_reset.TabIndex = 4;
            this.button_reset.Text = "重置";
            this.button_reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(397, 602);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "作者：金彬彬  学号：201722450813  班级：网络二班";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(1053, 613);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "版权所有--Copyright © 暗组科技";
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeviceManagers.Properties.Resources.loginbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1269, 636);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.text_username);
            this.Controls.Add(this.label_username);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设备管理系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox text_username;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

