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
    public partial class StaffManagement : Form
    {
        #region 变量
        private DbUtils dbUtil = new DbUtils();
        DataSet ds = new DataSet(); //生成部门集合
        #endregion
        #region 构造函数
        public StaffManagement()
        {
            InitializeComponent();
        }
        #endregion

        #region 事件
        #region 点击删除员工事件
        private void button_delete_Click(object sender, EventArgs e)
        {
            //点击删除方法
            DeleteStaffById();
        }
        #endregion
        #region 窗体加载事件
        private void StaffManagement_Load(object sender, EventArgs e)
        {
            //初始化搜索表单中的部门信息
            SetcombocClass();
            //初始化表格数据
            SetDataStaff();
        }
        #endregion
        #region 点击搜索事件
        private void button_search_Click(object sender, EventArgs e)
        {
            //调用搜索方法
            FindStaff();
        }
        #endregion
        #region 修改员工事件
        private void button_modify_Click(object sender, EventArgs e)
        {
            viewForm.AddStaff addStaff = new viewForm.AddStaff();
            //获取用户点击索引
            addStaff.commodityID = Convert.ToString(dataGridView_staffList.CurrentRow.Cells[0].Value);
            addStaff.ShowDialog();
            //当修改完成后，需要刷新表格内容
            this.SetDataStaff();
        }
        #endregion
        #endregion
        #region 方法
        #region 删除部门
        private void DeleteStaffById()
        {
            //判定是否选中了数据
            //给出提示是否要删除
            if (this.dataGridView_staffList.CurrentRow != null)
            {
                DialogResult dr = MessageBox.Show("确定要删除员工为：" + dataGridView_staffList.CurrentRow.Cells[1].Value, "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        //创建sql语句
                        string sql = string.Format("delete from s_staff where scard ='{0}'", dataGridView_staffList.CurrentRow.Cells[0].Value);
                        //执行数据库连接
                        MySqlCommand comm = new MySqlCommand(sql, dbUtil.Connection);
                        //打开数据库连接
                        dbUtil.OpenConnection();
                        //开始执行
                        int result = comm.ExecuteNonQuery();
                        if (result == 1)
                        {
                            //MessageBox.Show("删除成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //this.SetCombox_department();
                        }
                        else
                        {
                            MessageBox.Show("操作失败，请重试", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("数据操作错误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    finally
                    {
                        dbUtil.CloseConnection();
                    }
                    try
                    {
                        //创建sql语句
                        string sql = string.Format("delete from e_device_and_s_staff where scard ='{0}'", dataGridView_staffList.CurrentRow.Cells[0].Value);
                        //执行数据库连接
                        MySqlCommand comm = new MySqlCommand(sql, dbUtil.Connection);
                        //打开数据库连接
                        dbUtil.OpenConnection();
                        //开始执行
                        int result = comm.ExecuteNonQuery();
                        if (result == 1)
                        {
                            MessageBox.Show("删除成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.SetcombocClass();
                        }
                        else
                        {
                            MessageBox.Show("操作成功", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("数据操作错误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    finally
                    {
                        dbUtil.CloseConnection();
                    }
                }
            }
        }
        #endregion
        #region 查找部门
        private void FindStaff()
        {
            ds = new DataSet();
            StringBuilder sb = new StringBuilder();
            //员工编号 姓名 部门
            string scard = "s.scard";
            string sname = "s.sname";
            string dname = "d.dname";
            sb.AppendFormat("select s.scard as'员工编号', s.sname as'员工姓名', s.ssex as'员工性别',s.sage as'员工年龄', s.saddress as'员工地址',s.money as'员工工资', d.dname as '所属部门', e.ename as '设备', s.sdevicenums as '数量' from d_departments as d, e_device as e, s_staff as s where d.did = s.sdepartment and s.sdevice=e.eid");

            if (textBox_staffScard.Text.Trim() != "")
            {
                //编号值
                scard = textBox_staffScard.Text.Trim();
                sb.AppendFormat(" and s.scard='{0}'", scard);
            }

            if (textBox_staffName.Text.Trim() != "")
            {
                sname = textBox_staffName.Text.Trim();
                sb.AppendFormat(" and s.sname like '%{0}%'", sname);
            }
            if (comboBox_staffDepart.Text.Trim() != "")
            {
                dname = comboBox_staffDepart.Text.Trim();
                sb.AppendFormat(" and d.dname like '%{0}%'", dname);
            }

            //搜索条件 按照员工id排序
            sb.AppendFormat(" order by s.sid asc");
            try
            {
                //执行数据库连接
                MySqlDataAdapter adapter = new MySqlDataAdapter(sb.ToString(), dbUtil.Connection);
                //开始填充表格
                adapter.Fill(ds, "Comminty");
                this.dataGridView_staffList.DataSource = this.ds.Tables["Comminty"];

            }
            catch (Exception)
            {
                MessageBox.Show("数据库操作错误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } 
        #endregion
        #region 初始化表格员工数据
        private void SetDataStaff()
        {
            
            ds = new DataSet();
            //创建sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select s.scard as'员工编号', s.sname as'员工姓名', s.ssex as'员工性别',s.sage as'员工年龄', s.saddress as'员工地址',s.money as'员工工资', d.dname as '所属部门', e.ename as '设备', s.sdevicenums as '数量' from d_departments as d, e_device as e, s_staff as s where d.did = s.sdepartment and s.sdevice=e.eid");
            //搜索条件 按照员工id排序
            sb.AppendFormat(" order by s.sid asc");
            try
            {
                //执行数据库连接
                MySqlDataAdapter adapter = new MySqlDataAdapter(sb.ToString(), dbUtil.Connection);
                //开始填充表格
                adapter.Fill(ds, "Comminty");
                this.dataGridView_staffList.DataSource = this.ds.Tables["Comminty"];

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
                string sql = string.Format(@"select d.did, d.dname from d_departments as d");
                //执行数据库连接
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, dbUtil.Connection);

                //开始查询
                adapter.Fill(ds, "Comminty");
                //开始赋值
                //this.comboBox_staffDepart.Items.Add("请选择...");
                this.comboBox_staffDepart.DataSource = ds.Tables["Comminty"]; // 绑定数据源
                //部门编号
                this.comboBox_staffDepart.ValueMember = "did";
                //部门名称
                this.comboBox_staffDepart.DisplayMember = "dname";
                this.comboBox_staffDepart.SelectedIndex = -1;
                this.comboBox_staffDepart.SelectedText = "请选择";

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
