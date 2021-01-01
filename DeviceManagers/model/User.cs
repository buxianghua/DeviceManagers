#region <remark>>
/*----------------------------------------------------------------
//// All rights reserved.
//// author : jake
//// File   : User.cs
//// Summary: User
//// Date   : 2020/6/12 15:17:46
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

namespace DeviceManagers
{
    public class User
    {
        private int uid;
        private string username;
        private string password;

        public int Uid
        {
            get
            {
                return uid;
            }
            set
            {
                uid = value;
            }
        }
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
    }
}
