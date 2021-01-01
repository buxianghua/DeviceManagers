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
    public partial class AddClient : Form
    {
        #region 变量
        private DbUtils dbUtil = new DbUtils();
        DataSet ds = new DataSet();  // 集合
        DataSet dr = new DataSet();
        //0为添加 非0为修改
        public string commodityID = "0";
        #endregion
        #region 构造函数
        public AddClient()
        {
            InitializeComponent();
        }
        #endregion

        #region 事件
        #region 窗体加载事件
        private void AddClient_Load(object sender, EventArgs e)
        {
            //判断表单是否满足条件
            //判断修改还是添加
            //开始添加或修改

            if (commodityID == "0")
            {
                //添加员工
                //添加设备
                //初始化客户级别数据
                this.SetClientById();
            }
            else
            {
                //修改
                //初始化客户数据
                this.SetCliById();
                this.button_addClient.Text = "修改";
            }
        }
        #endregion
        #region 取消事件
        private void button_cancle_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        #endregion
        #region 添加或修改客户事件
        private void button_addClient_Click(object sender, EventArgs e)
        {
            //判断表单是否满足条件
            //判断修改还是添加
            //开始添加或修改
            if (CheckInput())
            {
                if (commodityID == "0")
                {
                    //添加客户
                    AddCli();
                }
                else
                {
                    //更新客户信息
                    UpdateCli();

                    //dataGridView_staffList.CurrentRow.Cells[0].Value
                }
            }
        }
        #endregion
        #endregion

        #region 方法
        #region 修改客户数据初始化表单数据
        private void SetCliById()
        {
            string s = "";
            //初始化下拉列表
            SetClientById();
            try
            {
                //创建sql语句
                string sql = string.Format(@"select * from c_client where ccard='{0}'", commodityID);
                //执行数据库连接
                MySqlCommand comm = new MySqlCommand(sql, dbUtil.Connection);
                //打开连接
                dbUtil.OpenConnection();
                //开始执行
                MySqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    s = reader["cclass"].ToString();
                    this.textBox_clientName.Text = reader["cname"].ToString();

                    this.textBox_clientNum.Text = reader["ccard"].ToString();

                    //this.comboBox_departDevice.SelectedValue = Convert.ToDecimal(reader["ddeivce"]);

                    this.textBox_clientTele.Text = reader["ctele"].ToString();
                    this.textBox_clientCompany.Text = reader["ccompany"].ToString();



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

            try
            {
                //创建sql语句
                string sql = string.Format(@"select * from class where cid={0}", Convert.ToInt32(s));
                //执行数据库连接
                MySqlCommand comm = new MySqlCommand(sql, dbUtil.Connection);
                //打开连接
                dbUtil.OpenConnection();
                //开始执行
                MySqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    this.comboBox_clientClass.SelectedIndex = Convert.ToInt32(reader[0]) - 1;
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
        #region 修改客户信息
        private void UpdateCli()
        {

            try
            {
                //创建sql语句
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("update c_client set ccard='{0}'", textBox_clientNum.Text.Trim());
                sb.AppendFormat(",cclass={0}", FindClass(comboBox_clientClass.Text.Trim()));

                sb.AppendFormat(",cname='{0}'", textBox_clientName.Text.Trim());
                sb.AppendFormat(",ctele='{0}'", textBox_clientTele.Text.Trim());
                sb.AppendFormat(",ccompany='{0}'", textBox_clientCompany.Text.Trim());
                sb.AppendFormat(" where ccard='{0}'", commodityID);
                //执行数据库连接
                MySqlCommand comm = new MySqlCommand(sb.ToString(), dbUtil.Connection);
                //打开连接
                dbUtil.OpenConnection();
                //开始执行
                int result = comm.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("修改成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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
        #region 添加客户方法
        private void AddCli()
        {
            try
            {
                //创建sql语句
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("insert into c_client values(null,'{0}',{1},'{2}','{3}','{4}')",
                    textBox_clientNum.Text.Trim(),
                    FindClass(comboBox_clientClass.Text.Trim())
                    , textBox_clientName.Text.Trim()
                    , textBox_clientTele.Text.Trim()
                    , textBox_clientCompany.Text.Trim());
                //执行数据库连接
                MySqlCommand comm = new MySqlCommand(sb.ToString(), dbUtil.Connection);
                //打开数据库连接
                dbUtil.OpenConnection();
                //开始执行
                int result = comm.ExecuteNonQuery();
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
                MessageBox.Show("数据库操作错误", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally
            {
                dbUtil.CloseConnection();
            }
        }
        #endregion
        #region 查找级别索引
        private int FindClass(string str)
        {
            int i = 1;
            try
            {
                //select d.did from d_departments as d where d.dname='财务部';
                //创建sql查询
                string sql = string.Format(@"select d.cid,d.class from class as d where d.class='{0}'", str);
                //执行数据库连接
                MySqlCommand com = new MySqlCommand(sql, dbUtil.Connection);
                //打开数据库
                dbUtil.OpenConnection();
                //开始查询
                MySqlDataReader reader = com.ExecuteReader();
                //开始验证
                if (reader.Read())
                {
                    i = Convert.ToInt32(reader[0].ToString());
                }
                else
                {
                    MessageBox.Show("没查到", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            return i;
        }
        #endregion
        #region 验证表单
        private bool CheckInput()
        {
            if (textBox_clientNum.Text.Trim().Length == 0)
            {
                MessageBox.Show("客户名称不为空", "验证提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (textBox_clientTele.Text.Trim().Length == 0)
            {
                MessageBox.Show("客户电话不为空", "验证提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (textBox_clientNum.Text.Trim().Length == 0)
            {
                MessageBox.Show("客户编号不为空", "验证提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }


        #endregion
        #region 初始化客户级别数据
        private void SetClientById()
        {

            try
            {
                //创建sql查询
                string sql = string.Format(@"select d.cid, d.class from class as d");
                //执行数据库连接
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, dbUtil.Connection);

                //开始查询
                adapter.Fill(ds, "Comminty");
                //开始赋值
                //this.comboBox_staffDepart.Items.Add("请选择...");
                this.comboBox_clientClass.DataSource = ds.Tables["Comminty"]; // 绑定数据源
                //部门编号
                this.comboBox_clientClass.ValueMember = "cid";
                //部门名称
                this.comboBox_clientClass.DisplayMember = "class";
                this.comboBox_clientClass.SelectedIndex = -1;
                this.comboBox_clientClass.SelectedText = "请选择";

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
