using System;
using System.Collections.Generic;
using System.Text;

namespace myscharp.com.rss.model
{
    class Customer
    {
        private string customerID;
        private string userID;
        private string cFirstName;
        private string cLastName;
        private string customerPhone;
        private string customerEmail;
        private string customerAddress;

        public string CustomerID { get => customerID; set => customerID = value; }
        public string UserID { get => userID; set => userID = value; }
        public string CFirstName { get => cFirstName; set => cFirstName = value; }
        public string CLastName { get => cLastName; set => cLastName = value; }
        public string CustomerPhone { get => customerPhone; set => customerPhone = value; }
        public string CustomerEmail { get => customerEmail; set => customerEmail = value; }
        public string CustomerAddress { get => customerAddress; set => customerAddress = value; }
    }

    }
