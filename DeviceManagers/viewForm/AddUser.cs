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
    public partial class AddUser : Form
    {
        #region 变量
        public User user;
        private DbUtils dbUtil = new DbUtils();
        #endregion
        #region 构造函数
        public AddUser()
        {
            InitializeComponent();
        }
        #endregion

        #region 事件
        #region 取消事件
        private void button_cancelAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 增加用户事件
        private void button_confirmAdd_Click(object sender, EventArgs e)
        {
            //确认用户输入是否为合法
            //开始修改
            if (CheckInput())
            {
                AddAdmin();
            }
        }
        #endregion
        #endregion
        #region 方法
        #region 验证方法
        private bool CheckInput()
        {
            if (textBox_adduser.Text.Trim().Length == 0 || textBox_addpassword1.Text.Trim().Length == 0)
            {
                MessageBox.Show("用户名或密码不为空", "验证提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            
            if (textBox_addpassword1.Text.Trim() != textBox_addPassword2.Text.Trim())
            {
                MessageBox.Show("密码输入不一致", "验证提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        #endregion
        #region 增加用户方法
        private void AddAdmin()
        {
            try
            {
                //创建数据库语句
                string sql = string.Format(@"insert into admin_user(username,password) values('{0}','{1}')", textBox_adduser.Text.Trim(), textBox_addpassword1.Text.Trim());
                //执行数据库连接
                MySqlCommand comm = new MySqlCommand(sql, dbUtil.Connection);
                //打开数据库
                dbUtil.OpenConnection();
                //开始写入数据
                int result = comm.ExecuteNonQuery();
                //结果提示
                if (result == 1)
                {
                    MessageBox.Show("添加成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
