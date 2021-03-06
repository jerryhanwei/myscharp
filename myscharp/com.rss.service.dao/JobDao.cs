﻿
using myscharp.com.rss.model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.Text;

namespace myscharp.com.rss.service.dao
{
    class JobDao : CrudDAO, JobService
    {
        public bool assignOneJobForWorker(Job job)
        {
            string sql = "update t_job set t_worker_id="+job.WorkerID+" where t_job_id='"+job.JobID+"'";

            return autoUpdateDeleteUpdate(sql);
        }

        public string checkWorkLoadByWorkerID(string workerID)
        {
            string sql = "select count(1) from t_emp e left join t_job j on e.t_emp_id=j.t_worker_id"
                         + " where e.t_emp_id = "+workerID+"";
            SQLiteDataReader reader = this.query(sql);
            if (reader != null) {
                reader.Read();
              return reader.GetInt32(0).ToString();
            }  
            return null;
        }

        public bool closeJobByWorker(Job job)
        {
            string dt = DateTime.Now.ToString("MMM dd ddd yyyy", CultureInfo.CreateSpecificCulture("en-GB"));

            string sql = "update t_job set t_close_date='"+ dt + "',t_job_status='closed' where t_job_id='" + job.JobID+"'";
           
            return autoUpdateDeleteUpdate(sql);
        }

        public bool deleteOneJob(Job job)
        {
            return false;
        }

        public bool insertOrUpdateOneJob(Job job)
        {
         
            if (job.JobID == null)
            {
                string sql = "insert into t_job values(null,'" + job.DeskStaffID + "'," +
              "'" + job.WorkerID + "','" + job.CarID + "'," +
              "'" + job.JobType + "','" + job.JobStatus + "','" + job.OpenDate + "'," +
              "'" + job.CloseDate + "','" + job.PriorityLevel + "')";
                return autoUpdateDeleteUpdate(sql);
            }
            else {

                StringBuilder su = new StringBuilder();
                su.Append("update t_job set ");
                  

                    if (job.DeskStaffID != null) {
                    su.Append("t_desk_staff_id='" + job.DeskStaffID + "',");
                }
               
                if (job.WorkerID != null)
                {
                    su.Append("t_worker_id='" + job.WorkerID + "',");
                }


                if (job.CarID != null)
                {
                    su.Append("car_id='" + job.CarID + "',");
                }

                if (job.JobType != null)
                {
                    su.Append("t_job_type='" + job.JobType + "',");
                }

                if (job.JobStatus != null)
                {
                    su.Append("t_job_status='" + job.JobStatus + "',");
                }

                if (job.OpenDate != null)
                {
                    su.Append("t_open_date='" + job.OpenDate + "',");
                }

                if (job.CloseDate != null)
                {
                    su.Append("t_close_date='" + job.CloseDate + "',");
                }

                if (job.PriorityLevel != null)
                {
                    su.Append("t_priority_level='" + job.PriorityLevel + "',");
                }


                su.Length = su.Length - 1;
                su.Append(" where t_job_id='" + job.JobID + "'");

                
                return autoUpdateDeleteUpdate(su.ToString());

            }

         

           
        }

        public List<Job> searchJobs(Job job)
        {
            throw new NotImplementedException();
        }
    }
}
