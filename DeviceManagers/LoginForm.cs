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

namespace DeviceManagers
{
    public partial class UserLogin : Form
    {
        #region 引入变量
        public User user = new User();
        private DbUtils dbUtil = new DbUtils();
        #endregion
        #region 构造函数
        public UserLogin()
        {
            InitializeComponent();
        }
        #endregion

        #region 事件
        #region 重置事件
        private void button_reset_Click(object sender, EventArgs e)
        {
            SetFormNull();
        }
        #endregion
        #region 登录事件
        private void button_login_Click(object sender, EventArgs e)
        {
            //验证登录
            //数据验证
            if (CheckInput())
            {
                Login();
            }

        }
        #endregion

        #endregion
        #region 方法
        #region 重置方法
        private void SetFormNull()
        {
            text_username.Text = "";
            text_password.Text = "";
        }

        #endregion
        #region 验证表单
        private bool CheckInput()
        {
            if (text_username.Text.Trim().Length == 0)
            {
                MessageBox.Show("用户名不为空", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (text_password.Text.Trim().Length == 0)
            {
                MessageBox.Show("密码不为空", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        #endregion
        #region 登录方法
        private void Login()
        {
            try
            {
                //创建sql查询
                string sql = string.Format("select * from admin_user where username='{0}' and password='{1}'", text_username.Text.Trim(), text_password.Text.Trim());
                //执行数据库连接
                MySqlCommand com = new MySqlCommand(sql, dbUtil.Connection);
                //打开数据库
                dbUtil.OpenConnection();
                //开始查询
                MySqlDataReader reader = com.ExecuteReader();
                //开始验证
                if (reader.Read())
                {
                    //记录用户信息
                    user.Uid = Convert.ToInt32(reader[0]);
                    user.Username = reader[1].ToString();
                    user.Password = reader[2].ToString();

                    //登录成功
                    MainForm mainform = new MainForm();
                    mainform.user = user;
                    mainform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名或密码不存在", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("数据库操作异常", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
