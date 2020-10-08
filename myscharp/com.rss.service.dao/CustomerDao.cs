using myscharp.com.rss.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace myscharp.com.rss.service.dao
{
    class CustomerDao : CrudDAO, CustomerService
    {
        public bool insertOneCustomer(Customer cus)
        {
            String sql = "insert into t_customer values(null,'"+cus.UserID+ "','" + cus.CFirstName + "','"+cus.CLastName+ "','" + cus.CustomerPhone + "','" + cus.CustomerEmail + "','" + cus.CustomerAddress + "');";
           return this.autoUpdateDeleteUpdate(sql);
           
        }

        public List<Customer> loadAllCustomers()
        {
            string sql = "select * from t_customer";

            return null;
        }

        public List<Customer> searchCustomerByPhoneOrName(Customer c)
        {
            throw new NotImplementedException();
        }

        public bool updateOneCustomer(Customer cus)
        {
            return false;
        }
    }
}
