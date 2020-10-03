using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
/*
   Install-Package linq2db.SQLite
 */
namespace myscharp.com.rss.db
{
    public sealed class DbConnFactory
    {
        private static readonly DbConnFactory instance = new DbConnFactory();

        string path = @"TOYOTA_RSS.db";

        public SQLiteConnection getSQLiteConn()
        {
            return new SQLiteConnection("Data Source=" + path + ";Version=3;");
         
        }



        static DbConnFactory()
        {
        }

        private DbConnFactory()
        {
        }



        public static DbConnFactory getSingleInstance
        {
            get
            {
                return instance;
            }
        }

    }
}
