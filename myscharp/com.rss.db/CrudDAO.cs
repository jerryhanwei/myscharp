using myscharp.com.rss.db;
using myscharp.com.rss.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace myscharp.com.rss.service
{
    public abstract class CrudDAO
    {

        private SQLiteConnection dbConnection;

        private SQLiteCommand dbCommand;

        private SQLiteDataReader dataReader;

        public DataTable GetDataTable(string sql) {

            DataTable dt = new DataTable();
            using (SQLiteConnection dbConnection = DbConnFactory.getSingleInstance.getSQLiteConn())
            {
                SQLiteCommand comm = new SQLiteCommand(sql,dbConnection);

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(comm);

                adapter.Fill(dt);

            }


                return dt;
        
        } 

        private int insertOrUpdateOrDelete(string sql)
        {
            dbConnection = DbConnFactory.getSingleInstance.getSQLiteConn();

            dbConnection.Open();
            dbCommand = new SQLiteCommand(sql, dbConnection);
            return dbCommand.ExecuteNonQuery();

        }

        public SQLiteDataReader query(string sql)
        {

            dbConnection = DbConnFactory.getSingleInstance.getSQLiteConn();

            dbConnection.Open();
            dbCommand = new SQLiteCommand(sql, dbConnection);
            return dbCommand.ExecuteReader();
        }


        public Boolean autoUpdateDeleteUpdate(string sql)
        {
            dbConnection = DbConnFactory.getSingleInstance.getSQLiteConn();

            dbConnection.Open(); 
            if (this.insertOrUpdateOrDelete(sql) > 0)
            {
                this.closeSQLiteDatabase();
                return true;
            }

            this.closeSQLiteDatabase();
            return false;
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


  

        public bool insertObj(string tableName, string[] paraArray)
        {
            StringBuilder sql = new StringBuilder();
            // insert
            if (paraArray.Length>0 && paraArray[0] == "null") {

                sql.Append("insert into " + tableName + " values(null");

                for (int i = 1; i < paraArray.Length; i++) {

                    sql.Append(",'"+paraArray[i]+"'");
                }

                sql.Append(")");
            }


           return this.autoUpdateDeleteUpdate(sql.ToString());
        }

      
       
    }
}
