using myscharp.com.rss.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace myscharp.com.rss.service.dao
{
    class DictionaryDao : CrudDAO, DictionaryService
    {
        public bool deleteOneDictionary(DataDictionary dic)
        {
            throw new NotImplementedException();
        }

        public bool insertOneDictionary(DataDictionary dic)
        {
            string sql = "insert into t_data_dic values(null,'"+dic.DicName+"','"+dic.DicType+"')";
            return this.autoUpdateDeleteUpdate(sql);
        }

        public DataTable loadAllDictionary(string typeDic)
        {
            string sql = "select * from t_data_dic";
            return this.GetDataTable(sql);
        }

        public bool updateOneDictionary(DataDictionary dic)
        {
           
            StringBuilder su = new StringBuilder();
            su.Append("update t_data_dic set ");


            if (dic.DicName != null)
            {
                su.Append(" t_name_dic='" + dic.DicName + "',");
            }

            if (dic.DicType != null)
            {
                su.Append(" t_type_dic='" + dic.DicType + "',");
            }

            su.Length = su.Length - 1;
            su.Append(" where t_dic_id=" + dic.DicID + "");

            return this.autoUpdateDeleteUpdate(su.ToString());
        }
    }
}
