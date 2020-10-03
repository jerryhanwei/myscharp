using myscharp.com.rss.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace myscharp.com.rss.service
{
    interface EmployeeService
    {
        public Boolean insertOrUpdateOneEmp(Employee e);

        public Boolean deleteOneEmp(Employee e);

        public Boolean assignEmpByLevel(Employee e);


    }
}
