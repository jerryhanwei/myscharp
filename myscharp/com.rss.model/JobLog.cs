using System;
using System.Collections.Generic;
using System.Text;

namespace myscharp.com.rss.model
{
    class JobLog
    {
        private string logID;
        private string jobRepairID;
        private string empID;
        private string logDesc;
        private string logDate;

        public string LogID { get => logID; set => logID = value; }
        public string JobRepairID { get => jobRepairID; set => jobRepairID = value; }
        public string EmpID { get => empID; set => empID = value; }
        public string LogDesc { get => logDesc; set => logDesc = value; }
        public string LogDate { get => logDate; set => logDate = value; }
    }
}
