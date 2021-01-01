using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceManagers.viewForm
{
    public partial class DeviceRepair : Form
    {
        #region 变量
        private DbUtils dbUtil = new DbUtils();
        DataSet ds = new DataSet();  // 集合
        DataSet dr = new DataSet();
        #endregion
        #region 构造方法
        public DeviceRepair()
        {
            InitializeComponent();
        }
        #endregion

        #region 事件
        #region 取消事件
        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region 初始化加载窗口事件
        private void DeviceRepair_Load(object sender, EventArgs e)
        {
            //初始化设备
            SetCombox_device();
        }
        #endregion
        #region 提交事件
        private void button_submit_Click(object sender, EventArgs e)
        {
            //提交方法
            //确认用户输入是否为合法
            //开始修改
            if (CheckInput())
            {
                AddRepair();
            }
        }
        #endregion
        #endregion
        #region 方法
        #region 增加用户方法
        private void AddRepair()
        {
            try
            {
                //创建数据库语句
                string sql = string.Format(@"insert into repair values(null,'{0}','{1}','{2}',1)", 
                    textBox_staffNum.Text.Trim(), textBox_staffName.Text.Trim(),
                    comboBox_staffDevice.Text.Trim());
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
        #region 验证方法
        private bool CheckInput()
        {
            if (textBox_staffName.Text.Trim().Length == 0)
            {
                MessageBox.Show("员工姓名不为空", "验证提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (textBox_staffNum.Text.Trim().Length == 0)
            {
                MessageBox.Show("员工编号不为空", "验证提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if(!searchID(textBox_staffNum.Text.Trim()))
            {
                MessageBox.Show("您的编号不在数据库中", "验证提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        #endregion
        #region 查找ID
        private bool searchID(string str)
        {
            bool b = false;
            //创建数据库语句
            string sql = string.Format(@"select * from s_staff where scard='{0}'",
                str);
            //执行数据库连接
            MySqlCommand comm = new MySqlCommand(sql, dbUtil.Connection);
            //打开数据库
            dbUtil.OpenConnection();
            //开始写入数据
            int result = comm.ExecuteNonQuery();
            //结果提示
            if (result == 1)
            {
                //MessageBox.Show("添加成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();
                b = true;
            }
            else
            {
                MessageBox.Show("您输入的信息有误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            return b;
        }
        #endregion
        #region 初始化设备列表
        private void SetCombox_device()
        {
            try
            {
                dr = new DataSet();
                //创建sql查询
                string sql = string.Format(@"select e.eid, e.ename from e_device as e");
                //执行数据库连接
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, dbUtil.Connection);

                //开始查询
                adapter.Fill(dr, "Comminty");
                //开始赋值
                //this.comboBox_staffDepart.Items.Add("请选择...");
                this.comboBox_staffDevice.DataSource = dr.Tables["Comminty"]; // 绑定数据源

                this.comboBox_staffDevice.ValueMember = "eid";  //部门编号
                //部门名称
                this.comboBox_staffDevice.DisplayMember = "ename";
                //this.comboBox_staffdepartment.SelectedIndex = -1;
                //this.comboBox_staffdepartment.SelectedText = "请选择";

            }
            catch (Exception)
            {
                MessageBox.Show("数据库操作错误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
       
        #endregion


    }
}
