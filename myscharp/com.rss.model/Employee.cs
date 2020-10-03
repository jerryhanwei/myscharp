using System;
using System.Collections.Generic;
using System.Text;

namespace myscharp.com.rss.model
{
    class Employee
    {
        
        private string empID;
        private string userID;
        private string outLetID;
        private string empFirstName;
        private string empLastName;
        private string empMobile;
        private string managerID;

        public string EmpID { get => empID; set => empID = value; }
        public string UserID { get => userID; set => userID = value; }
        public string OutLetID { get => outLetID; set => outLetID = value; }
        public string EmpFirstName { get => empFirstName; set => empFirstName = value; }
        public string EmpLastName { get => empLastName; set => empLastName = value; }
        public string EmpMobile { get => empMobile; set => empMobile = value; }
        public string ManagerID { get => managerID; set => managerID = value; }
    }
}
