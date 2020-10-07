using myscharp.com.rss.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace myscharp.com.rss.service.dao
{
    class LoginDao : CrudDAO, UserService

    {
        public List<UserAccount> loadAllUsers()
        {
            throw new NotImplementedException();
        }

        public UserAccount login(UserAccount user)
        {

          
            string sql = "select * from t_user_account u where u.user_name = '"+user.UserName+"' and u.user_pwd = '"+user.UserPwd+"'";
           
            SQLiteDataReader userReader = this.query(sql);
            if (userReader != null)
            {
                UserAccount userOnline = new UserAccount();
                while (userReader.Read())
                {
                    userOnline.UserID = userReader["user_id"].ToString();
                    userOnline.UserName = userReader["user_name"].ToString();
                    userOnline.UserPwd = userReader["user_pwd"].ToString();
                    userOnline.UserRole = userReader["user_role"].ToString();

                }

                return userOnline;
            }
        
                return null;
      
        }

        public bool logout()
        {
            throw new NotImplementedException();
        }

        public bool resetPwdForOneUser(UserAccount user)
        {
            throw new NotImplementedException();
        }
    }
}
