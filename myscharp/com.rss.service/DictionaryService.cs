using myscharp.com.rss.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace myscharp.com.rss.service
{
    interface DictionaryService
    {
        public DataTable loadAllDictionary(string typeDic);

        public Boolean insertOneDictionary(DataDictionary dic);

        public Boolean updateOneDictionary(DataDictionary dic);

        public Boolean deleteOneDictionary(DataDictionary dic);


    }
}
