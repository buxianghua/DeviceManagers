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
    public partial class AddDevice : Form
    {
        #region 变量
        private DbUtils dbUtil = new DbUtils();
        DataSet ds = new DataSet();  // 集合
        DataSet dr = new DataSet();
        //0为添加 非0为修改
        public string commodityID = "0";
        #endregion
        #region 构造函数
        public AddDevice()
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
        #region 窗口加载事件
        private void AddDevice_Load(object sender, EventArgs e)
        {
            //判断表单是否满足条件
            //判断修改还是添加
            //开始添加或修改
            
            if (commodityID == "0")
            {

                //添加设备
                //初始化表单数据
                //this.SetDeviceById();
            }
            else
            {
                //修改
                //初始化表单数据
                this.SetDeviceById();
                this.button_addDevice.Text = "修改";
            }
            
            
        }
        #endregion
        #region 添加设备事件
        private void button_addDevice_Click(object sender, EventArgs e)
        {
            //判断表单是否满足条件
            //判断修改还是添加
            //开始添加或修改
            if (CheckInput())
            {
                if (commodityID == "0")
                {
                    //添加设备
                    AddDev();
                }
                else
                {
                    //更新部门
                    UpdateDevt();

                    //dataGridView_staffList.CurrentRow.Cells[0].Value
                }
            }

        }
        #endregion
        #endregion
        #region 方法
        #region 修改设备信息
        private void UpdateDevt()
        {
            string s = "";
            try
            {
                //创建sql语句
                string sql = string.Format(@"select * from d_departments where dname='{0}'", commodityID);
                //执行数据库连接
                MySqlCommand comm = new MySqlCommand(sql, dbUtil.Connection);
                //打开连接
                dbUtil.OpenConnection();
                //开始执行
                MySqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    s = reader["did"].ToString();

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
                sb.AppendFormat("update e_device set ename='{0}'", textBox_deviceName.Text.Trim());
                sb.AppendFormat(",enums={0}", numericUpDown_nums.Text.Trim());



                
                sb.AppendFormat(",evalue={0}", Convert.ToInt32(textBox_devicePrice.Text.Trim()));
                sb.AppendFormat(" where eid='{0}'", s);
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
        #region 初始化设备数据
        private void SetDeviceById()
        {
            string s = "";
            try
            {
                //创建sql语句
                string sql = string.Format(@"select * from d_departments where dname='{0}'", commodityID);
                //执行数据库连接
                MySqlCommand comm = new MySqlCommand(sql, dbUtil.Connection);
                //打开连接
                dbUtil.OpenConnection();
                //开始执行
                MySqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    s = reader["did"].ToString();

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

            string did = "";
            string eid = "";
            try
            {
                //创建sql语句
                string sql = string.Format(@"select * from d_departments_and_e_device where edid={0}", s);
                //执行数据库连接
                MySqlCommand comm = new MySqlCommand(sql, dbUtil.Connection);
                //打开连接
                dbUtil.OpenConnection();
                //开始执行
                MySqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    did = reader["did"].ToString();
                    eid = reader["eid"].ToString();
                    
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
                string sql = string.Format(@"select e.ename, d.ddevicenums,e.evalue from d_departments as d, e_device as e where e.eid={0} and d.did ={1}",
                    eid,did);
                //执行数据库连接
                MySqlCommand comm = new MySqlCommand(sql, dbUtil.Connection);
                //打开连接
                dbUtil.OpenConnection();
                //开始执行
                MySqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    this.textBox_deviceName.Text = reader["ename"].ToString();
                    this.textBox_devicePrice.Text = reader["evalue"].ToString();
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

        }
        #endregion
        #region 添加设备方法
        private void AddDev()
        {
            try
            {
                //创建sql语句
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("insert into e_device values(null,'{0}',{1},1,{2})",
                    textBox_deviceName.Text.Trim(),
                    Convert.ToInt32(numericUpDown_nums.Text.Trim())
                    , Convert.ToInt32(textBox_devicePrice.Text.Trim()));
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
        #region 验证表单
        private bool CheckInput()
        {
            if (textBox_deviceName.Text.Trim().Length == 0)
            {
                MessageBox.Show("设备名字不为空", "验证提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            
            if (textBox_devicePrice.Text.Trim().Length == 0)
            {
                MessageBox.Show("设备价格不为空", "验证提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            
            return true;
        }


        #endregion

        #endregion

        
    }
}
