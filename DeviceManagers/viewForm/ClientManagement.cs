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
    public partial class ClientManagement : Form
    {
        #region 变量
        private DbUtils dbUtil = new DbUtils();
        DataSet ds = new DataSet(); //生成客户集合
        #endregion
        #region 构造函数
        public ClientManagement()
        {
            InitializeComponent();
        }
        #endregion

        #region 事件
        #region 删除客户事件
        private void button_delete_Click(object sender, EventArgs e)
        {
            //通过id删除客户
            DeleteClientById();
        }
        #endregion
        #region 客户搜索事件
        private void button_search_Click(object sender, EventArgs e)
        {
            //点击搜索客户
            FindClient();
        }
        #endregion
        #region 窗体加载事件
        private void ClientManagement_Load(object sender, EventArgs e)
        {
            //初始化搜索表单中的客户类别信息
            SetcombocClient();
            //初始化表格数据
            SetDataClient();
        }
        #endregion
        #region 点击修改客户事件
        private void button_modify_Click(object sender, EventArgs e)
        {
            viewForm.AddClient addClient = new viewForm.AddClient();
            //获取用户点击索引
            addClient.commodityID = Convert.ToString(dataGridView_clientList.CurrentRow.Cells[0].Value);
            addClient.ShowDialog();
            //当修改完成后，需要刷新表格内容
            //this.SetcombocClient();
            this.SetDataClient();
        }
        #endregion
        #endregion
        #region 方法
        #region 删除客户
        private void DeleteClientById()
        {
            //判定是否选中了数据
            //给出提示是否要删除
            if (this.dataGridView_clientList.CurrentRow != null)
            {
                DialogResult dr = MessageBox.Show("确定要删除客户为：" + dataGridView_clientList.CurrentRow.Cells[2].Value, "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        //创建sql语句
                        string sql = string.Format("delete from c_client where ccard ={0}", dataGridView_clientList.CurrentRow.Cells[0].Value);
                        //执行数据库连接
                        MySqlCommand comm = new MySqlCommand(sql, dbUtil.Connection);
                        //打开数据库连接
                        dbUtil.OpenConnection();
                        //开始执行
                        int result = comm.ExecuteNonQuery();
                        if (result == 1)
                        {
                            MessageBox.Show("删除成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //初始化表格数据
                            this.SetDataClient();
                            
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
                    
                }
            }
        }
        #endregion
        #region 查找客户
        private void FindClient()
        {
            ds = new DataSet();
            StringBuilder sb = new StringBuilder();
            //员工编号 姓名 级别
            string scard = "s.ccard";
            string sname = "s.cname";
            string dname = "c.class";
            sb.AppendFormat("select s.ccard as'客户编号',c.class as '客户级别', s.cname as'客户姓名', s.ctele as '客户电话', s.ccompany as '公司名称' from c_client as s,class as c where s.cclass = c.cid");

            if (textBox_clientScard.Text.Trim() != "")
            {
                //编号值
                scard = textBox_clientScard.Text.Trim();
                sb.AppendFormat(" and s.ccard='{0}'", scard);
            }

            if (textBox_clientName.Text.Trim() != "")
            {
                sname = textBox_clientName.Text.Trim();
                sb.AppendFormat(" and s.cname like '%{0}%'", sname);
            }
            if (comboBox_clientClass.Text.Trim() != "")
            {
                dname = comboBox_clientClass.Text.Trim();
                sb.AppendFormat(" and c.class like '%{0}%'", dname);
            }

            //搜索条件 按照员工id排序
            sb.AppendFormat(" order by s.cid asc");
            try
            {
                //执行数据库连接
                MySqlDataAdapter adapter = new MySqlDataAdapter(sb.ToString(), dbUtil.Connection);
                //开始填充表格
                adapter.Fill(ds, "Comminty");
                this.dataGridView_clientList.DataSource = this.ds.Tables["Comminty"];

            }
            catch (Exception)
            {
                MessageBox.Show("数据库操作错误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region 初始化表格客户数据
        private void SetDataClient()
        {

            ds = new DataSet();
            //创建sql语句
            //select s.ccard as'客户编号',c.class as '客户级别', s.cname as'客户姓名', s.ctele as '客户电话', s.ccompany as '公司名称' from c_client as s,class as c where s.cclass = c.cid;
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select s.ccard as'客户编号',c.class as '客户级别', s.cname as'客户姓名', s.ctele as '客户电话', s.ccompany as '公司名称' from c_client as s,class as c where s.cclass = c.cid");
            //搜索条件 按照员工id排序
            sb.AppendFormat(" order by s.cid asc");
            try
            {
                //执行数据库连接
                MySqlDataAdapter adapter = new MySqlDataAdapter(sb.ToString(), dbUtil.Connection);
                //开始填充表格
                adapter.Fill(ds, "Comminty");
                this.dataGridView_clientList.DataSource = this.ds.Tables["Comminty"];

            }
            catch (Exception)
            {
                MessageBox.Show("数据库操作错误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region 初始化客户级别信息
        private void SetcombocClient()
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
