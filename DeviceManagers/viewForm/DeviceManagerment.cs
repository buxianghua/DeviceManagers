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
    public partial class DeviceManagerment : Form
    {
        #region 变量
        private DbUtils dbUtil = new DbUtils();
        DataSet ds = new DataSet(); //生成部门集合
        #endregion
        #region 构造函数
        public DeviceManagerment()
        {
            InitializeComponent();
        }
        #endregion

        #region 事件
        #region 点击刷新事件
        private void button_flash_Click(object sender, EventArgs e)
        {
            //初始化搜索表单中的设备信息
            SetcombocClass();
            //初始化表格数据
            SetDataStaff();
        }
        #endregion
        #region 窗体加载事件
        private void DeviceManagerment_Load(object sender, EventArgs e)
        {
            //初始化搜索表单中的设备信息
            SetcombocClass();
            //初始化表格数据
            SetDataStaff();
        }
        #endregion
        #region 搜索设备
        private void button_search_Click(object sender, EventArgs e)
        {
            //发现设备
            FindDevice();
        }
        #endregion
        #region 修改设备事件
        private void button_modify_Click(object sender, EventArgs e)
        {
            viewForm.AddDevice modifyDevice = new viewForm.AddDevice();
            //获取用户点击索引
            modifyDevice.commodityID = Convert.ToString(dataGridView_deviceList.CurrentRow.Cells[0].Value);
            modifyDevice.ShowDialog();
            //当修改完成后，需要刷新表格内容
            this.SetDataStaff();
        }
        #endregion
        #endregion
        #region 方法
        #region 方法
        private void FindDevice()
        {
            ds = new DataSet();
            StringBuilder sb = new StringBuilder();
            //员工编号 姓名 部门
            
            string ename = "e.ename";
            sb.AppendFormat("select d.dname as'部门名称', e.ename as'设备名称',d.ddevicenums as '数量' from d_departments as d,d_departments_and_e_device as ed, e_device as e where d.did = ed.did and ed.eid = e.eid");

            
            if (comboBox_deviceDepart.Text.Trim() != "")
            {
                ename = comboBox_deviceDepart.Text.Trim();
                sb.AppendFormat(" and e.ename like '%{0}%'", ename);
            }

            //搜索条件 按照员工id排序
            sb.AppendFormat(" order by d.did asc");
            try
            {
                //执行数据库连接
                MySqlDataAdapter adapter = new MySqlDataAdapter(sb.ToString(), dbUtil.Connection);
                //开始填充表格
                adapter.Fill(ds, "Comminty");
                this.dataGridView_deviceList.DataSource = this.ds.Tables["Comminty"];

            }
            catch (Exception)
            {
                MessageBox.Show("数据库操作错误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region 搜索表单中部门信息
        private void SetcombocClass()
        {
            try
            {
                //创建sql查询
                string sql = string.Format(@"select d.eid, d.ename from e_device as d");
                //执行数据库连接
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, dbUtil.Connection);

                //开始查询
                adapter.Fill(ds, "Comminty");
                //开始赋值
                //this.comboBox_staffDepart.Items.Add("请选择...");
                this.comboBox_deviceDepart.DataSource = ds.Tables["Comminty"]; // 绑定数据源
                //部门编号
                this.comboBox_deviceDepart.ValueMember = "eid";
                //部门名称
                this.comboBox_deviceDepart.DisplayMember = "ename";
                this.comboBox_deviceDepart.SelectedIndex = -1;
                this.comboBox_deviceDepart.SelectedText = "请选择";

            }
            catch (Exception)
            {
                MessageBox.Show("数据库操作错误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
        #region 初始化表格设备数据
        private void SetDataStaff()
        {

            ds = new DataSet();
            //创建sql语句
            //select s.scard as'员工编号', s.sname as'员工姓名', s.ssex as'员工性别',s.sage as'员工年龄', s.saddress as'员工地址',s.money as'员工工资', d.dname as '所属部门', e.ename as '设备', s.sdevicenums as '数量' from d_departments as d, e_device as e, s_staff as s where d.did = s.sdepartment and s.sdevice = e.eid;
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select d.dname as'部门名称', e.ename as'设备名称',d.ddevicenums as '数量' from d_departments as d,d_departments_and_e_device as ed, e_device as e where d.did = ed.did and ed.eid = e.eid");
            //搜索条件 按照员工id排序
            sb.AppendFormat(" order by e.eid asc");
            try
            {
                //执行数据库连接
                MySqlDataAdapter adapter = new MySqlDataAdapter(sb.ToString(), dbUtil.Connection);
                //开始填充表格
                adapter.Fill(ds, "Comminty");
                this.dataGridView_deviceList.DataSource = this.ds.Tables["Comminty"];

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
