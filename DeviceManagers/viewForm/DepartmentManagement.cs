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
    public partial class DepartmentManagement : Form
    {
        #region 变量
        private DbUtils dbUtil = new DbUtils();
        DataSet ds = new DataSet();  // 集合
        DataSet dr = new DataSet();
        public string commodityID = "0";
        #endregion
        #region 构造函数
        public DepartmentManagement()
        {
            InitializeComponent();
        }
        #endregion

        #region 事件
        #region 点击删除事件
        private void button_delete_Click(object sender, EventArgs e)
        {
            //删除部门方法
            DeleteDepartById();

        }
        #endregion
        #region 窗体加载事件
        private void DepartmentManagement_Load(object sender, EventArgs e)
        {
            //初始化部门表单
            SetCombox_department();
        }
        #endregion
        #region 部门搜索事件
        private void button1_Click(object sender, EventArgs e)
        {
            //部门检索方法
            FindDepartment();
        }
        #endregion
        #region 修改部门事件
        private void button_modify_Click(object sender, EventArgs e)
        {
            viewForm.AddDepartment addDepart = new viewForm.AddDepartment();
            //获取用户点击索引
            addDepart.commodityID = Convert.ToString(dataGridView_departmentList.CurrentRow.Cells[0].Value);
            addDepart.ShowDialog();
            //当修改完成后，需要刷新表格内容
            this.SetCombox_department();
        }
        #endregion
        #endregion
        #region 方法
        #region 初始化部门信息列表事件
        private void SetCombox_department()
        {
            try
            {
                //ds = new DataSet();
                ds = new DataSet();
                //创建sql查询
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat(@"select d.did as '部门编号', d.dname as '部门名称', d.ddescription as '部门表述',e.ename as '部门设备',d.ddevicenums as '设备数量' from d_departments as d,e_device as e where e.eid = d.ddevice");

                //赋值
                this.dataGridView_departmentList.DataSource = ds.Tables["Comminty"]; // 绑定数据源
                                                                                     //搜索条件 按照员工id排序
                sb.AppendFormat(" order by d.did asc");
                try
                {
                    //执行数据库连接
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sb.ToString(), dbUtil.Connection);
                    //开始填充表格
                    adapter.Fill(ds, "Comminty");
                    this.dataGridView_departmentList.DataSource = this.ds.Tables["Comminty"];

                }
                catch (Exception)
                {
                    MessageBox.Show("数据库操作错误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("数据库操作错误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region 查找部门
        private void FindDepartment()
        {
            try
            {
                //ds = new DataSet();
                ds = new DataSet();
                //创建sql查询
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat(@"select d.did as '部门编号', d.dname as '部门名称', d.ddescription as '部门表述',e.ename as '部门设备',d.ddevicenums as '设备数量' from d_departments as d,e_device as e where e.eid = d.ddevice");
                if (textBox_findDepartment.Text.Trim() != "")
                {
                    sb.AppendFormat(" and d.dname like '%{0}%'", textBox_findDepartment.Text.Trim());
                }
                //赋值
                this.dataGridView_departmentList.DataSource = ds.Tables["Comminty"]; // 绑定数据源
                                                                                     //搜索条件 按照员工id排序
                sb.AppendFormat(" order by d.did asc");
                try
                {
                    //执行数据库连接
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sb.ToString(), dbUtil.Connection);
                    if (adapter.ToString() != "")
                    {
                        //开始填充表格
                        adapter.Fill(ds, "Comminty");
                        this.dataGridView_departmentList.DataSource = this.ds.Tables["Comminty"];
                    }
                    else
                    {
                        MessageBox.Show("没有这部门", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("数据库操作错误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("数据库操作错误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion
        #region 删除部门
        private void DeleteDepartById()
        {
            //判定是否选中了数据
            //给出提示是否要删除
            if (this.dataGridView_departmentList.CurrentRow != null)
            {
                DialogResult dr = MessageBox.Show("确定要删除部门为：" + dataGridView_departmentList.CurrentRow.Cells[1].Value, "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        //创建sql语句
                        string sql = string.Format("delete from d_departments where did ={0}", dataGridView_departmentList.CurrentRow.Cells[0].Value);
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
                        string sql = string.Format("delete from d_departments_and_e_device where did ={0}", dataGridView_departmentList.CurrentRow.Cells[0].Value);
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
                        string sql = string.Format("delete from s_staff where sdepartment ={0}", dataGridView_departmentList.CurrentRow.Cells[0].Value);
                        //执行数据库连接
                        MySqlCommand comm = new MySqlCommand(sql, dbUtil.Connection);
                        //打开数据库连接
                        dbUtil.OpenConnection();
                        //开始执行
                        int result = comm.ExecuteNonQuery();
                        if (result == 1)
                        {
                            MessageBox.Show("删除成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.SetCombox_department();
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
        #endregion


    }
}
