using System;
using System.Collections.Generic;
using System.Text;

namespace myscharp.com.rss.model
{
    class Job
    {
        private string jobID;
        private string deskStaffID;
        private string workerID;
        private string carID;
        private string jobType;
        private string jobStatus;
        private string openDate;
        private string closeDate;
        private string priorityLevel;

        public string JobID { get => jobID; set => jobID = value; }
        public string DeskStaffID { get => deskStaffID; set => deskStaffID = value; }
        public string WorkerID { get => workerID; set => workerID = value; }
        public string CarID { get => carID; set => carID = value; }
        public string JobType { get => jobType; set => jobType = value; }
        public string JobStatus { get => jobStatus; set => jobStatus = value; }
        public string OpenDate { get => openDate; set => openDate = value; }
        public string CloseDate { get => closeDate; set => closeDate = value; }
        public string PriorityLevel { get => priorityLevel; set => priorityLevel = value; }
    }
}
