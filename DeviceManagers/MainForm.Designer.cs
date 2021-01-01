namespace DeviceManagers
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdataPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DepartmentManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DepartmentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeviceManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeviceListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeviceRepairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem,
            this.DepartmentManagerToolStripMenuItem,
            this.EmployeeManagementToolStripMenuItem,
            this.DeviceManagementToolStripMenuItem,
            this.toolStripMenuItem1,
            this.AboutUsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1271, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdataPasswordToolStripMenuItem,
            this.AddUserToolStripMenuItem,
            this.ExitSystemToolStripMenuItem});
            this.SettingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuText;
            this.SettingsToolStripMenuItem.Image = global::DeviceManagers.Properties.Resources.系统设置;
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(110, 28);
            this.SettingsToolStripMenuItem.Text = "系统设置";
            // 
            // UpdataPasswordToolStripMenuItem
            // 
            this.UpdataPasswordToolStripMenuItem.Name = "UpdataPasswordToolStripMenuItem";
            this.UpdataPasswordToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.UpdataPasswordToolStripMenuItem.Text = "修改密码";
            this.UpdataPasswordToolStripMenuItem.Click += new System.EventHandler(this.UpdataPasswordToolStripMenuItem_Click);
            // 
            // AddUserToolStripMenuItem
            // 
            this.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem";
            this.AddUserToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.AddUserToolStripMenuItem.Text = "新增用户";
            this.AddUserToolStripMenuItem.Click += new System.EventHandler(this.AddUserToolStripMenuItem_Click);
            // 
            // ExitSystemToolStripMenuItem
            // 
            this.ExitSystemToolStripMenuItem.Name = "ExitSystemToolStripMenuItem";
            this.ExitSystemToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.ExitSystemToolStripMenuItem.Text = "退出系统";
            this.ExitSystemToolStripMenuItem.Click += new System.EventHandler(this.ExitSystemToolStripMenuItem_Click);
            // 
            // DepartmentManagerToolStripMenuItem
            // 
            this.DepartmentManagerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DepartmentListToolStripMenuItem,
            this.AddDepartmentToolStripMenuItem});
            this.DepartmentManagerToolStripMenuItem.Image = global::DeviceManagers.Properties.Resources.部门管理;
            this.DepartmentManagerToolStripMenuItem.Name = "DepartmentManagerToolStripMenuItem";
            this.DepartmentManagerToolStripMenuItem.Size = new System.Drawing.Size(110, 28);
            this.DepartmentManagerToolStripMenuItem.Text = "部门管理";
            // 
            // DepartmentListToolStripMenuItem
            // 
            this.DepartmentListToolStripMenuItem.Name = "DepartmentListToolStripMenuItem";
            this.DepartmentListToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.DepartmentListToolStripMenuItem.Text = "部门列表";
            this.DepartmentListToolStripMenuItem.Click += new System.EventHandler(this.DepartmentListToolStripMenuItem_Click);
            // 
            // AddDepartmentToolStripMenuItem
            // 
            this.AddDepartmentToolStripMenuItem.Name = "AddDepartmentToolStripMenuItem";
            this.AddDepartmentToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.AddDepartmentToolStripMenuItem.Text = "部门添加";
            this.AddDepartmentToolStripMenuItem.Click += new System.EventHandler(this.AddDepartmentToolStripMenuItem_Click);
            // 
            // EmployeeManagementToolStripMenuItem
            // 
            this.EmployeeManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmployeeListToolStripMenuItem,
            this.AddEmployeeToolStripMenuItem});
            this.EmployeeManagementToolStripMenuItem.Image = global::DeviceManagers.Properties.Resources.员工管理;
            this.EmployeeManagementToolStripMenuItem.Name = "EmployeeManagementToolStripMenuItem";
            this.EmployeeManagementToolStripMenuItem.Size = new System.Drawing.Size(110, 28);
            this.EmployeeManagementToolStripMenuItem.Text = "员工管理";
            // 
            // EmployeeListToolStripMenuItem
            // 
            this.EmployeeListToolStripMenuItem.Name = "EmployeeListToolStripMenuItem";
            this.EmployeeListToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.EmployeeListToolStripMenuItem.Text = "员工列表";
            this.EmployeeListToolStripMenuItem.Click += new System.EventHandler(this.EmployeeListToolStripMenuItem_Click);
            // 
            // AddEmployeeToolStripMenuItem
            // 
            this.AddEmployeeToolStripMenuItem.Name = "AddEmployeeToolStripMenuItem";
            this.AddEmployeeToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.AddEmployeeToolStripMenuItem.Text = "添加员工";
            this.AddEmployeeToolStripMenuItem.Click += new System.EventHandler(this.AddEmployeeToolStripMenuItem_Click);
            // 
            // DeviceManagementToolStripMenuItem
            // 
            this.DeviceManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeviceListToolStripMenuItem,
            this.DeviceRepairToolStripMenuItem,
            this.AddDeviceToolStripMenuItem});
            this.DeviceManagementToolStripMenuItem.Image = global::DeviceManagers.Properties.Resources.设备管理;
            this.DeviceManagementToolStripMenuItem.Name = "DeviceManagementToolStripMenuItem";
            this.DeviceManagementToolStripMenuItem.Size = new System.Drawing.Size(110, 28);
            this.DeviceManagementToolStripMenuItem.Text = "设备管理";
            // 
            // DeviceListToolStripMenuItem
            // 
            this.DeviceListToolStripMenuItem.Name = "DeviceListToolStripMenuItem";
            this.DeviceListToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.DeviceListToolStripMenuItem.Text = "设备列表";
            this.DeviceListToolStripMenuItem.Click += new System.EventHandler(this.DeviceListToolStripMenuItem_Click);
            // 
            // DeviceRepairToolStripMenuItem
            // 
            this.DeviceRepairToolStripMenuItem.Name = "DeviceRepairToolStripMenuItem";
            this.DeviceRepairToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.DeviceRepairToolStripMenuItem.Text = "设备维修";
            this.DeviceRepairToolStripMenuItem.Click += new System.EventHandler(this.DeviceRepairToolStripMenuItem_Click);
            // 
            // AddDeviceToolStripMenuItem
            // 
            this.AddDeviceToolStripMenuItem.Name = "AddDeviceToolStripMenuItem";
            this.AddDeviceToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.AddDeviceToolStripMenuItem.Text = "添加设备";
            this.AddDeviceToolStripMenuItem.Click += new System.EventHandler(this.AddDeviceToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientListToolStripMenuItem,
            this.ClientAddToolStripMenuItem});
            this.toolStripMenuItem1.Image = global::DeviceManagers.Properties.Resources.客户管理;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(110, 28);
            this.toolStripMenuItem1.Text = "客户管理";
            // 
            // ClientListToolStripMenuItem
            // 
            this.ClientListToolStripMenuItem.Name = "ClientListToolStripMenuItem";
            this.ClientListToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.ClientListToolStripMenuItem.Text = "客户列表";
            this.ClientListToolStripMenuItem.Click += new System.EventHandler(this.ClientListToolStripMenuItem_Click);
            // 
            // ClientAddToolStripMenuItem
            // 
            this.ClientAddToolStripMenuItem.Name = "ClientAddToolStripMenuItem";
            this.ClientAddToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.ClientAddToolStripMenuItem.Text = "客户添加";
            this.ClientAddToolStripMenuItem.Click += new System.EventHandler(this.ClientAddToolStripMenuItem_Click);
            // 
            // AboutUsToolStripMenuItem
            // 
            this.AboutUsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpToolStripMenuItem,
            this.AboutSystemToolStripMenuItem,
            this.AboutDeveloperToolStripMenuItem});
            this.AboutUsToolStripMenuItem.Image = global::DeviceManagers.Properties.Resources.关于;
            this.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem";
            this.AboutUsToolStripMenuItem.Size = new System.Drawing.Size(110, 28);
            this.AboutUsToolStripMenuItem.Text = "关于我们";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.HelpToolStripMenuItem.Text = "获取帮助";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // AboutSystemToolStripMenuItem
            // 
            this.AboutSystemToolStripMenuItem.Name = "AboutSystemToolStripMenuItem";
            this.AboutSystemToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.AboutSystemToolStripMenuItem.Text = "关于系统";
            this.AboutSystemToolStripMenuItem.Click += new System.EventHandler(this.AboutSystemToolStripMenuItem_Click);
            // 
            // AboutDeveloperToolStripMenuItem
            // 
            this.AboutDeveloperToolStripMenuItem.Name = "AboutDeveloperToolStripMenuItem";
            this.AboutDeveloperToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.AboutDeveloperToolStripMenuItem.Text = "关于开发者";
            this.AboutDeveloperToolStripMenuItem.Click += new System.EventHandler(this.AboutDeveloperToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton5,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 32);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1271, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::DeviceManagers.Properties.Resources.部门列表;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(94, 25);
            this.toolStripButton1.Text = "部门列表";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::DeviceManagers.Properties.Resources.员工列表;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(94, 25);
            this.toolStripButton2.Text = "员工列表";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::DeviceManagers.Properties.Resources.设备列表;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(94, 25);
            this.toolStripButton3.Text = "设备列表";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = global::DeviceManagers.Properties.Resources.客户列表;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(94, 25);
            this.toolStripButton5.Text = "客户列表";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::DeviceManagers.Properties.Resources.退出系统_;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(94, 25);
            this.toolStripButton4.Text = "退出系统";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::DeviceManagers.Properties.Resources.mainbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1271, 634);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "易软企业资源管理系统V1.0.6";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdataPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DepartmentManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DepartmentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmployeeManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmployeeListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeviceManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeviceListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeviceRepairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripMenuItem AddDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutDeveloperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ClientListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
    }
}