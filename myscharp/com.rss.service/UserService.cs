using myscharp.com.rss.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace myscharp.com.rss.service
{
    interface UserService
    {
       public Boolean login(UserAccount user);

       public Boolean logout();

       public List<UserAccount> loadAllUsers();

        public Boolean resetPwdForOneUser(UserAccount user);
        
    }
}
