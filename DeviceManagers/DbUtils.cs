#region <remark>>
/*----------------------------------------------------------------
//// All rights reserved.
//// author : jake
//// File   : DbUtils.cs
//// Summary: DbUtils
//// Date   : 2020/6/12 15:14:30
*******************************************************************
* Copyright @ jake 2020. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DeviceManagers
{
    class DbUtils
    {
        private static string dbUrl = @" Database=device;DataSource=127.0.0.1;UserId=root;Password=root;pooling=false;CharSet=utf8;port=3306";
        private MySqlConnection connection;

        // 连接数据库
        public MySqlConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = new MySqlConnection(dbUrl);
                }
                return connection;
            }
        }
        // 打开数据库
        public void OpenConnection()
        {
            string s = Connection.State.ToString();
            if (Connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            else if (Connection.State == System.Data.ConnectionState.Broken)
            {
                connection.Close();
                connection.Open();
            }
        }
        //关闭数据库
        public void CloseConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Closed || Connection.State == System.Data.ConnectionState.Broken || Connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}

