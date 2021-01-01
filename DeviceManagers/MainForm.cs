using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceManagers
{
    public partial class MainForm : Form
    {
        #region 变量
        public User user;
        #endregion
        #region 构造函数
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region 事件
        #region 退出系统
        private void ExitSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("您确定退出系统嘛？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //返回值为OK则退出系统
            if (dia == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        #endregion

        #region 修改密码
        private void UpdataPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewForm.UpdatePassword updatepass = new viewForm.UpdatePassword();
            //传递参数
            updatepass.user = this.user;
            //显示修改窗口
            updatepass.ShowDialog();
        }
        #endregion

        #region 新增用户
        private void AddUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewForm.AddUser adduser = new viewForm.AddUser();
            //显示窗口
            adduser.ShowDialog();
        }
        #endregion
        #region 查看员工列表
        private void EmployeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewForm.StaffManagement staffManagement = new viewForm.StaffManagement();
            staffManagement.Show();
        }

        #endregion
        #region 添加员工
        private void AddEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewForm.AddStaff addStaff = new viewForm.AddStaff();
            //0表示添加
            addStaff.commodityID = "0";
            addStaff.ShowDialog();
        }
        #endregion
        #region 部门列表
        private void DepartmentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewForm.DepartmentManagement departmentManagement = new viewForm.DepartmentManagement();
            departmentManagement.ShowDialog();
        }
        #endregion
        #region 部门添加事件
        private void AddDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewForm.AddDepartment addDepartment = new viewForm.AddDepartment();
            addDepartment.ShowDialog();
        }
        #endregion
        #region 设备加载事件
        private void DeviceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewForm.DeviceManagerment deviceManagerment = new viewForm.DeviceManagerment();
            deviceManagerment.ShowDialog();
        }
        #endregion
        #region 设备保修事件
        private void DeviceRepairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewForm.DeviceRepair deviceRepair = new viewForm.DeviceRepair();
            deviceRepair.ShowDialog();
        }
        #endregion
        #region 添加设备事件
        private void AddDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewForm.AddDevice addDevice = new viewForm.AddDevice();
            addDevice.ShowDialog();
        }
        #endregion
        #region 获取帮助事件
        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewForm.Help help = new viewForm.Help();
            help.ShowDialog();
        }
        #endregion
        #region 关于开发者事件
        private void AboutDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewForm.AboutDeveloper aboutDeveloper = new viewForm.AboutDeveloper();
            aboutDeveloper.ShowDialog();
        }
        #endregion
        #region 关于系统
        private void AboutSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewForm.AboutSys aboutSys = new viewForm.AboutSys();
            aboutSys.ShowDialog();
        }
        #endregion
        #region 部门列表
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            viewForm.DepartmentManagement departmentManagement = new viewForm.DepartmentManagement();
            departmentManagement.ShowDialog();
        }
        #endregion
        #region 员工列表
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            viewForm.StaffManagement staffManagement = new viewForm.StaffManagement();
            staffManagement.ShowDialog();
        }

        #endregion
        #region 设备列表
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            viewForm.DeviceManagerment deviceManagerment = new viewForm.DeviceManagerment();
            deviceManagerment.ShowDialog();
        }
        #endregion
        #region 退出系统
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("您是否要退出系统" , "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dr == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }
        #endregion
        #region 客户列表
        private void ClientListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewForm.ClientManagement clientManagement = new viewForm.ClientManagement();
            clientManagement.ShowDialog();
        }
        #endregion
        #region 添加客户事件
        private void ClientAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewForm.AddClient addClient = new viewForm.AddClient();
            addClient.ShowDialog();
        }
        #endregion
        #region 客户管理事件
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            viewForm.ClientManagement clientManagement = new viewForm.ClientManagement();
            clientManagement.ShowDialog();
        }
        #endregion
        #endregion


    }
}
