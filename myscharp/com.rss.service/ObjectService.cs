using System;
using System.Collections.Generic;
using System.Text;

namespace myscharp.com.rss.service
{
    interface ObjectService
    {
        public Boolean insertObj(string tableName,string[] paraArray);

        public Boolean updateObj(string tableName,string attibuteName, string[] paraArray);


        public Boolean deleteObj(string tableName, string entryID);

        public List<object> loadAllObjs(string tableName,string[] paraArray,object obj);
    }
}
