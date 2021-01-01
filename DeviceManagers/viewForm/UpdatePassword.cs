using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DeviceManagers.viewForm
{
    public partial class UpdatePassword : Form
    {
        #region 变量
        public User user;
        private DbUtils dbUtil = new DbUtils();
        #endregion
        #region 构造函数
        public UpdatePassword()
        {
            InitializeComponent();
        }
        #endregion

        #region 事件
        #region 取消修改事件
        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 确认修改事件
        private void button_confirm_Click(object sender, EventArgs e)
        {
            //确认用户输入是否为合法
            //开始修改
            if (CheckInput())
            {
                UpdatePass();
            }
        }
        #endregion
        #endregion

        #region 方法
        #region 表单验证
        private bool CheckInput()
        {
            if (textBox_oldPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("原始密码不能为空","验证提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
            if (textBox_oldPassword.Text.Trim() != user.Password)
            {
                MessageBox.Show("原始密码输入错误", "验证提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (textBox_newPassword1.Text.Trim().Length == 0)
            {
                MessageBox.Show("新密码不能为空", "验证提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (textBox_newPassword1.Text.Trim() != textBox_newPassword2.Text.Trim())
            {
                MessageBox.Show("新密码输入不一致", "验证提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        #endregion
        #region 修改密码
        private void UpdatePass()
        {
            try
            {
                //创建数据库语句
                string sql = string.Format(@"update admin_user set password='{0}' where id='{1}'", textBox_newPassword1.Text.Trim(), user.Uid);
                //执行数据库连接
                MySqlCommand comm = new MySqlCommand(sql, dbUtil.Connection);
                //打开数据库
                dbUtil.OpenConnection();
                //开始写入数据
                int result = comm.ExecuteNonQuery();
                //结果提示
                if(result == 1)
                {
                    MessageBox.Show("修改成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("数据库操作错误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                dbUtil.CloseConnection();
            }
        }
        #endregion
        #endregion

    }
}
