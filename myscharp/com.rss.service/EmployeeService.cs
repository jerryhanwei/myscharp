using myscharp.com.rss.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace myscharp.com.rss.service
{
    interface EmployeeService
    {
        public Boolean insertOneEmp(Employee e);

        public Boolean updateOneEmp(Employee e);

        public Boolean deleteOneEmp(Employee e);

        public Boolean assignEmpByLevel(Employee e);

        public DataTable getALlEmps();


    }
}
