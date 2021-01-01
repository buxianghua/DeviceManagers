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
    public partial class AddStaff : Form
    {
        #region 变量
        private DbUtils dbUtil = new DbUtils();
        DataSet ds = new DataSet();  // 集合
        DataSet dr = new DataSet();
        //0为添加 非0为修改
        public string commodityID = "0";
        #endregion
        #region 构造函数
        public AddStaff()
        {
            InitializeComponent();
        }
        #endregion

        #region 事件
        #region 修改员工重置事件
        private void button_staffReset_Click(object sender, EventArgs e)
        {
            SetNull();
        }
        #endregion
        #region 添加事件
        private void button_staffAdd_Click(object sender, EventArgs e)
        {
            //判断表单是否满足条件
            //判断修改还是添加
            //开始添加或修改
            if (CheckInput())
            {
                if (commodityID == "0")
                {
                    //添加员工
                    AddSta();
                }
                else
                {
                    //更新员工
                    UpdateSatff();
                }
            }
        }
        #endregion
        #region 窗体加载事件
        private void AddStaff_Load(object sender, EventArgs e)
        {
            if (commodityID == "0")
            {
                //初始化部门列表
                SetCombox_department();
                //初始化设备列表
                SetCombox_device();
            }
            else
            {
                //修改
                //初始化表单数据
                this.SetStaffById();
                this.button_staffAdd.Text = "修改";
            }
        }
        #endregion
        #endregion
        #region 方法
        string s = "";
        #region 修改员工数据初始化表单数据
        private void SetStaffById()
        {
            //初始化下拉列表
            SetCombox_department();
            SetCombox_device();
            try
            {
                //创建sql语句
                string sql = string.Format(@"select * from s_staff where scard='{0}'", commodityID);
                //执行数据库连接
                MySqlCommand comm = new MySqlCommand(sql, dbUtil.Connection);
                //打开连接
                dbUtil.OpenConnection();
                //开始执行
                MySqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    this.textBox_staffNum.Text = reader["scard"].ToString();
                    s = reader["scard"].ToString();
                    this.textBox_staffName.Text = reader["sname"].ToString();
                    if (reader["ssex"].ToString() == "男")
                    {
                        this.radioButton_staffBoy.Checked = true;
                    }
                    else
                    {
                        this.radioButton_staffGirl.Checked = false;
                    }
                    this.numericUpDown_staffAge.Value = Convert.ToDecimal(reader["sage"]);
                    this.textBox_staffAddress.Text = reader["saddress"].ToString();
                    this.comboBox_staffdepartment.SelectedValue = reader["sdepartment"].ToString();
                    this.textBox_staffMoney.Text = reader["money"].ToString();

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
                string sql = string.Format(@"select * from e_device_and_s_staff where scard='{0}'", this.textBox_staffNum.Text);
                //执行数据库连接
                MySqlCommand comm = new MySqlCommand(sql, dbUtil.Connection);
                //打开连接
                dbUtil.OpenConnection();
                //开始执行
                MySqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    this.comboBox_staffDevice.SelectedValue = reader["eid"].ToString();
                    this.numericUpDown_nums.Value = Convert.ToDecimal(reader["eidnums"]);
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
        #region 添加员工
        private void AddSta()
        {
            string sex = "";
            if (radioButton_staffBoy.Checked)
            {
                sex = "男";
            }
            else if (radioButton_staffGirl.Checked)
            {
                sex = "女";
            }
            //int dep = FindDepartIndex(comboBox_staffdepartment.Text.Trim());
            //int dev = FindDeviceIndex(comboBox_staffDevice.Text.Trim());
            try
            {
                //创建sql语句
                string sql = string.Format("insert into s_staff values(null,'{0}','{1}','{2}',{3},'{4}',{5},{6},{7},{8})",
                    textBox_staffNum.Text.Trim(),
                    textBox_staffName.Text.Trim(),
                    sex,
                    Convert.ToInt32(numericUpDown_staffAge.Text.Trim()),
                    textBox_staffAddress.Text.Trim(),
                    Convert.ToInt32(textBox_staffMoney.Text.Trim()),
                    FindDepartIndex(comboBox_staffdepartment.Text.Trim()),
                    FindDeviceIndex(comboBox_staffDevice.Text.Trim()),
                    Convert.ToInt32(numericUpDown_nums.Text.Trim())
                    );
                //执行数据库连接
                MySqlCommand comm = new MySqlCommand(sql, dbUtil.Connection);
                //打开数据库连接
                dbUtil.OpenConnection();
                //开始执行
                int result = comm.ExecuteNonQuery();
                if (result == 1)
                {
                    //MessageBox.Show("添加成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.SetNull();
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

            try
            {
                //创建sql语句
                string sql = string.Format("insert into e_device_and_s_staff values(null,'{0}',{1},{2})",
                    textBox_staffNum.Text.Trim(),
                    FindDeviceIndex(comboBox_staffDevice.Text.Trim()),
                    Convert.ToInt32(numericUpDown_nums.Text.Trim())
                    );
                //执行数据库连接
                MySqlCommand comm = new MySqlCommand(sql, dbUtil.Connection);
                //打开数据库连接
                dbUtil.OpenConnection();
                //开始执行
                int result = comm.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("添加成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.SetNull();
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
        #region 验证表单
        private bool CheckInput()
        {
            if (textBox_staffNum.Text.Trim().Length == 0)
            {
                MessageBox.Show("员工ID不为空", "验证提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (textBox_staffName.Text.Trim().Length == 0)
            {
                MessageBox.Show("员工姓名不为空", "验证提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (textBox_staffMoney.Text.Trim().Length == 0)
            {
                MessageBox.Show("员工工资不为空", "验证提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (textBox_staffAddress.Text.Trim().Length == 0)
            {
                MessageBox.Show("员工住址不为空", "验证提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (comboBox_staffdepartment.Text.Trim() == "请选择")
            {
                MessageBox.Show("请选择员工所属部门", "验证提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        #endregion
        #region 表单置空方法
        private void SetNull()
        {
            textBox_staffNum.Text = "";
            textBox_staffName.Text = "";
            textBox_staffAddress.Text = "";
            //comboBox_staffdepartment.SelectedValue = "";
            textBox_staffMoney.Text = "";
            numericUpDown_staffAge.Text = "20";

        }

        #endregion
        #region 设备索引查询
        private int FindDeviceIndex(string str)
        {
            int n = 1;
            try
            {
                //select d.did from d_departments as d where d.dname='财务部';
                //创建sql查询
                //string sql = string.Format(@"select e.eid,e.ename from e_device as e where e.ename='{0}'", str);
                string sql = string.Format(@"select e.eid,e.ename from e_device as e where e.ename='{0}'", str);
                //执行数据库连接
                MySqlCommand com = new MySqlCommand(sql, dbUtil.Connection);
                //打开数据库
                dbUtil.OpenConnection();
                //开始查询
                MySqlDataReader reader = com.ExecuteReader();
                //开始验证
                if (reader.Read())
                {
                    n = Convert.ToInt32(reader[0].ToString());
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
            return n;
        }
        #endregion
        #region 部门索引查询
        private int FindDepartIndex(string str)
        {
            int i = 1;
            try
            {
                //select d.did from d_departments as d where d.dname='财务部';
                //创建sql查询
                //string sql = string.Format(@"select d.did,d.dname from d_departments as d where d.dname='{0}'",str);select e.eid,e.ename from e_device as e where e.ename='电脑'
                string sql = string.Format(@"select d.did,d.dname from d_departments as d where d.dname='{0}'", str);
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
        #region 初始化设备列表
        private void SetCombox_device()
        {
            try
            {
                //dr = new DataSet();
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
        #region 初始化部门信息列表事件
        private void SetCombox_department()
        {
            try
            {
                //ds = new DataSet();
                //创建sql查询
                string sql = string.Format(@"select d.did, d.dname from d_departments as d");
                //执行数据库连接
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, dbUtil.Connection);

                //开始查询
                adapter.Fill(ds, "Comminty");
                //开始赋值
                //this.comboBox_staffDepart.Items.Add("请选择...");
                this.comboBox_staffdepartment.DataSource = ds.Tables["Comminty"]; // 绑定数据源
                //部门编号
                this.comboBox_staffdepartment.ValueMember = "did";
                //部门名称
                this.comboBox_staffdepartment.DisplayMember = "dname";
                this.comboBox_staffdepartment.SelectedIndex = -1;
                this.comboBox_staffdepartment.SelectedText = "请选择";

            }
            catch (Exception)
            {
                MessageBox.Show("数据库操作错误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region 修改员工方法
        private void UpdateSatff()
        {
            string sex = "";
            if (radioButton_staffBoy.Checked)
            {
                sex = "男";
            }
            else if (radioButton_staffGirl.Checked)
            {
                sex = "女";
            }
            try
            {
                //创建sql语句
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("update s_staff set scard='{0}'", textBox_staffNum.Text.Trim());
                sb.AppendFormat(",sname='{0}'", textBox_staffName.Text.Trim());
                sb.AppendFormat(",ssex='{0}'", sex);
                sb.AppendFormat(",sage='{0}'", Convert.ToInt32(numericUpDown_staffAge.Text.Trim()));
                sb.AppendFormat(",saddress='{0}'", textBox_staffAddress.Text.Trim());

                sb.AppendFormat(",money='{0}'", textBox_staffMoney.Text.Trim());
                sb.AppendFormat(",sdepartment='{0}'", FindDepartIndex(comboBox_staffdepartment.Text.Trim()));
                sb.AppendFormat(",sdevice='{0}'", FindDeviceIndex(comboBox_staffDevice.Text.Trim()));
                sb.AppendFormat(",sdevicenums='{0}'", Convert.ToInt32(numericUpDown_nums.Text.Trim()));
                sb.AppendFormat(" where scard='{0}'", commodityID);
                //执行数据库连接
                MySqlCommand comm = new MySqlCommand(sb.ToString(), dbUtil.Connection);
                //打开连接
                dbUtil.OpenConnection();
                //开始执行
                int result = comm.ExecuteNonQuery();
                if (result == 1)
                {
                    //MessageBox.Show("修改成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("update e_device_and_s_staff set scard='{0}'", textBox_staffNum.Text.Trim());

                sb.AppendFormat(",eid='{0}'", FindDeviceIndex(comboBox_staffDevice.Text.Trim()));
                sb.AppendFormat(",eidnums='{0}'", Convert.ToInt32(numericUpDown_nums.Text.Trim()));
                sb.AppendFormat(" where scard='{0}'", s);
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
                else
                {
                    MessageBox.Show("操作成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        #endregion


    }
}
