using myscharp.com.rss.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace myscharp.com.rss.service.dao
{
    class EmpDao : CrudDAO, EmployeeService
    {
        public bool assignEmpByLevel(Employee e)
        {
            string sql = "update t_emp set t_manager_id='"+e.ManagerID+"' where t_emp_id='"+e.EmpID+"'";
            return this.autoUpdateDeleteUpdate(sql);
        }

        public bool deleteOneEmp(Employee e)
        {
            string sql = "delete from t_emp where t_emp_id='"+e.EmpID+"'";
            return this.autoUpdateDeleteUpdate(sql);

        }

        public bool insertOrUpdateOneEmp(Employee e)
        {
            String sql = "insert into t_emp values(null,'"+e.UserID+"','"+e.OutLetID+"'," +
                "'"+e.EmpFirstName+"'," +
                "'"+e.EmpLastName+"','"+e.EmpMobile+"','"+e.ManagerID+"');";
            return  this.autoUpdateDeleteUpdate(sql);
        }
    }
}
