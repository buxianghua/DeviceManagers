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
    public partial class AddDepartment : Form
    {
        #region 变量
        private DbUtils dbUtil = new DbUtils();
        DataSet ds = new DataSet();  // 集合
        DataSet dr = new DataSet();
        //0为添加 非0为修改
        public string commodityID = "0";
        #endregion
        #region 构造函数
        public AddDepartment()
        {
            InitializeComponent();
        }
        #endregion
        #region 事件
        #region 修改部门重置事件
        private void button_reset_Click(object sender, EventArgs e)
        {
            SetNull();
        }
        #endregion
        #region 窗体加载事件
        private void AddDepartment_Load(object sender, EventArgs e)
        {
            //初始化设备
            SetCombox_device();
            
            if (commodityID == "0")
            {
                
                //初始化设备列表
                SetCombox_device();
            }
            else
            {
                //修改
                //初始化表单数据
                this.SetDepartmentById();
                //初始化设备列表
                SetCombox_device();
                this.button_addDepartment.Text = "修改";
            }
        }
        #endregion
        #region 点击添加事件
        private void button_addDepartment_Click(object sender, EventArgs e)
        {
            //判断表单是否满足条件
            //判断修改还是添加
            //开始添加或修改
            if (CheckInput())
            {
                if (commodityID == "0")
                {
                    //添加部门
                    AddDepart();
                }
                else
                {
                    //更新部门
                    UpdateDepart();
                    
                    //dataGridView_staffList.CurrentRow.Cells[0].Value
                }
            }
        }

        #endregion

        #endregion
        #region 方法
        #region 修改部门信息
        private void UpdateDepart()
        {
            
            try
            {
                //创建sql语句
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("update d_departments set dname='{0}'", textBox_departName.Text.Trim());
                sb.AppendFormat(",ddescription='{0}'", textBox_departDesc.Text.Trim());
                
                
                
                sb.AppendFormat(",ddevice={0}", FindDeviceIndex(comboBox_departDevice.Text.Trim()));
                sb.AppendFormat(",ddevicenums={0}", Convert.ToInt32(numericUpDown_nums.Text.Trim()));
                sb.AppendFormat(" where did={0}", commodityID);
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

            //try
            //{
            //    //创建sql语句
            //    StringBuilder sb = new StringBuilder();
            //    sb.AppendFormat("update d_departments_and_e_device set did='{0}'", commodityID);
            //    sb.AppendFormat(",eid='{0}'", FindDeviceIndex(comboBox_departDevice.Text.Trim()));
                
            //    sb.AppendFormat(" where did={0}",commodityID);
            //    //执行数据库连接
            //    MySqlCommand comm = new MySqlCommand(sb.ToString(), dbUtil.Connection);
            //    //打开连接
            //    dbUtil.OpenConnection();
            //    //开始执行
            //    int result = comm.ExecuteNonQuery();
            //    if (result == 1)
            //    {
            //        //MessageBox.Show("修改成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("数据库操作错误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}
            //finally
            //{
            //    dbUtil.CloseConnection();
            //}
        }
        #endregion
        #region 修改部门数据初始化表单数据
        private void SetDepartmentById()
        {
            string s = "";
            //初始化下拉列表
            SetCombox_device();
            try
            {
                //创建sql语句
                string sql = string.Format(@"select * from d_departments where did='{0}'", commodityID);
                //执行数据库连接
                MySqlCommand comm = new MySqlCommand(sql, dbUtil.Connection);
                //打开连接
                dbUtil.OpenConnection();
                //开始执行
                MySqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    s = reader["did"].ToString();
                    this.textBox_departName.Text = reader["dname"].ToString();
                    
                    this.textBox_departDesc.Text = reader["ddescription"].ToString();
                    
                    //this.comboBox_departDevice.SelectedValue = Convert.ToDecimal(reader["ddeivce"]);
                    
                    this.numericUpDown_nums.Value = Convert.ToDecimal(reader["ddevicenums"]);
                    

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
                string sql = string.Format(@"select * from d_departments_and_e_device where did='{0}'", s);
                //执行数据库连接
                MySqlCommand comm = new MySqlCommand(sql, dbUtil.Connection);
                //打开连接
                dbUtil.OpenConnection();
                //开始执行
                MySqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    this.comboBox_departDevice.SelectedValue = reader["did"].ToString();
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
                this.comboBox_departDevice.DataSource = dr.Tables["Comminty"]; // 绑定数据源

                this.comboBox_departDevice.ValueMember = "eid";  //部门编号
                //部门名称
                this.comboBox_departDevice.DisplayMember = "ename";
                //this.comboBox_staffdepartment.SelectedIndex = -1;
                //this.comboBox_staffdepartment.SelectedText = "请选择";

            }
            catch (Exception)
            {
                MessageBox.Show("数据库操作错误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region 添加部门方法
        private void AddDepart()
        {
            
            
            try
            {
                //创建sql语句
                string sql = string.Format("insert into d_departments values(null,'{0}','{1}',{2},{3})",
                    textBox_departName.Text.Trim(),
                    textBox_departDesc.Text.Trim(),
                    FindDeviceIndex(comboBox_departDevice.Text.Trim()),
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
                string sql = string.Format("insert into d_departments_and_e_device values(null,{0},{1})",
                    FindDepartIndex(textBox_departName.Text.Trim()),
                    FindDeviceIndex(comboBox_departDevice.Text.Trim())
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
                    //this.SetNull();
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
        #region 表单指控方法
        private void SetNull()
        {
            
            textBox_departName.Text = "";
            textBox_departDesc.Text = "";
            numericUpDown_nums.Text = "1";
        }
        #endregion
        #region 验证表单数据
        private bool CheckInput()
        {
            if (textBox_departName.Text.Trim().Length == 0)
            {
                MessageBox.Show("部门不能为空", "验证提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (textBox_departDesc.Text.Trim().Length == 0)
            {
                MessageBox.Show("部门描述不能为空", "验证提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            
            return true;
        }
        #endregion
        #endregion


    }
}
