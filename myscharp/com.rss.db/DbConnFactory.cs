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

        SQLiteConnection dbConnection;

        private SQLiteCommand dbCommand;

        private SQLiteDataReader dataReader;

    
        public SQLiteConnection openSQLiteDatabase()
        {
            dbConnection = new SQLiteConnection("Data Source=" + path + ";Version=3;");
            dbConnection.Open();
            return dbConnection;


        }

        public void closeSQLiteDatabase()
        {
            if (dbCommand != null)
            {
                dbCommand.Cancel();
            }
            dbCommand = null;
        
            if (dataReader != null)
            {
                dataReader.Close();
            }
            dataReader = null;
         
            if (dbConnection != null)
            {
                dbConnection.Close();
            }
            dbConnection = null;


        }

        public int insertOrUpdateOrDelete(string sql) {
            dbCommand = new SQLiteCommand(sql, dbConnection);
            return dbCommand.ExecuteNonQuery();

        }

        public SQLiteDataReader query(string sql) {

            dbCommand = new SQLiteCommand(sql, dbConnection);
            return dbCommand.ExecuteReader();
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
