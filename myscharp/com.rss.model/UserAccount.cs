using System;
using System.Collections.Generic;
using System.Text;

namespace myscharp.com.rss.model
{
    class UserAccount
    {
        private string userID;
        private string userRole;
        private string userName;
        private string userPwd;



        public string UserRole { get => userRole; set => userRole = value; }
        public string UserName { get => userName; set => userName = value; }
        public string UserPwd { get => userPwd; set => userPwd = value; }
        public string UserID { get => userID; set => userID = value; }
    }
}
