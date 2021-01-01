namespace DeviceManagers.viewForm
{
    partial class AboutSys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutSys));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Image = global::DeviceManagers.Properties.Resources.autoback;
            this.label2.Location = new System.Drawing.Point(155, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "《易软企业资源管理系统》";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Image = global::DeviceManagers.Properties.Resources.autoback;
            this.label1.Location = new System.Drawing.Point(195, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "本系统使用了C#技术属于窗体应用开发";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Image = global::DeviceManagers.Properties.Resources.autoback;
            this.label3.Location = new System.Drawing.Point(157, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(429, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "本系统是一套结构相对完整的企业资源管理系统";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Image = global::DeviceManagers.Properties.Resources.autoback;
            this.label4.Location = new System.Drawing.Point(231, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "诚邀感兴趣的开发者一同优化";
            // 
            // AboutSys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeviceManagers.Properties.Resources.autoback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(755, 419);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AboutSys";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}