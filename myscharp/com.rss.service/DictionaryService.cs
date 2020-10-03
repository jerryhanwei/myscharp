using myscharp.com.rss.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace myscharp.com.rss.service
{
    interface DictionaryService
    {
        public List<DataDictionary> loadAllDictionary();

        public Boolean insertOrUpdateOneDictionary(DataDictionary dic);

        public Boolean deleteOneDictionary(DataDictionary dic);


    }
}
