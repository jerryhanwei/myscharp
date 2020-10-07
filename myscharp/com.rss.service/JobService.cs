using myscharp.com.rss.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace myscharp.com.rss.service
{
    interface JobService
    {

        public Boolean insertOrUpdateOneJob(Job job);

        public Boolean deleteOneJob(Job job);

        public List<Job> searchJobs(Job job);
        /// <summary>
        /// the manager assign one job for one worker
        /// </summary>
        /// <param name="job"></param>
        /// <returns></returns>
        public Boolean assignOneJobForWorker(Job job);
        /// <summary>
        /// how many repair jobs dose one worker has now?
        /// </summary>
        /// <returns></returns>
        public string checkWorkLoadByWorkerID(string workerID);
        /// <summary>
        /// close one job by one worker
        /// update close date and job status
        /// </summary>
        /// <param name="job"></param>
        /// <returns></returns>
        public Boolean closeJobByWorker(Job job);
    }
}
