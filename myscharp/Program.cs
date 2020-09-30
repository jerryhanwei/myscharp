using System;
using System.Data.SQLite;
using System.Globalization;

namespace myscharp
{
    class Program
    {
        //数据库连接
        SQLiteConnection m_dbConnection;
       

       // string path = @"c:\Users\wayne\source\testdb.db";
        string path = @"TOYOTA_RSS.db";

        static void Main(string[] args)
        {
            Program p = new Program();
        }

        public Program()
        {
           // createNewDatabase();
            connectToDatabase();
            // createTable();
            // fillTable();
            // printHighscores();


            /*  string sql = "select p.p_name,p.personid,m.personid as m_id,m.p_name as m_name from t_person p,t_person m"
                           + " where p.manager_id = m.personid";
  */
            string sql = "select * from t_user_account as u left join" 
            +" t_person as p on u.user_id = p.personid";

            // multipleQuery(sql);

            getDate();
        }

        void getDate() {



            string dt = DateTime.Now.ToString("MMMM.dd.ddd yyyy", CultureInfo.CreateSpecificCulture("en-GB"));
            
            
            Console.WriteLine(dt);
        }

        //创建一个空的数据库
        void createNewDatabase()
        {
           
            SQLiteConnection.CreateFile(path);
        }

        //创建一个连接到指定数据库
        void connectToDatabase()
        {
            m_dbConnection = new SQLiteConnection("Data Source="+path+";Version=3;");
            m_dbConnection.Open();
        }

        //在指定数据库中创建一个table
        void createTable()
        {
            string sql = "create table t_person (personid INTEGER PRIMARY KEY AUTOINCREMENT,p_name varchar(20),manager_id integer(50))";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        //插入一些数据
        void fillTable()
        {
            string sql = "insert into t_person values (NULL,'han', 890)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

             sql = "insert into t_person values (NULL,'wei', 123)";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

             sql = "insert into t_person values (NULL,'jerry', 998)";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        //使用sql查询语句，并显示结果
        void printHighscores()
        {
            string sql = "select * from highscores order by score desc";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                Console.WriteLine("Name: " + reader["name"] + "\tScore: " + reader["score"]);
            Console.ReadLine();
        }

        void multipleQuery(String sql)
        {
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                Console.WriteLine("Name: " + reader["user_name"] + "\tScore: " + reader["p_name"]);



        }
    }

}
