using myscharp.com.rss.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace myscharp.com.rss.service
{
    interface CustomerService
    {
        public Boolean insertOrUpdateOneCustomer(Customer cus);

        public List<Customer> searchCustomerByPhoneOrName(Customer c);

        public List<Customer> loadAllCustomers();


    }
}
