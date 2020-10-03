using myscharp.com.rss.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace myscharp.com.rss.service
{
    interface LogService
    {
        public Boolean insertOrUpdateLog(JobLog log);

        public Boolean deleteLog(JobLog log);
    }
}
