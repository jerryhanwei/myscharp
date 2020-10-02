using System;
using System.Collections.Generic;
using System.Text;

namespace myscharp.com.rss.model
{
    class Car
    {
        private string carID;
        private string customerID;
        private string outletID;
        private string carModel;
        private string carRegistNum;

        public string OutletID { get => OutletID1; set => OutletID1 = value; }
        public string CarID { get => carID; set => carID = value; }
        public string CustomerID { get => customerID; set => customerID = value; }
        public string OutletID1 { get => outletID; set => outletID = value; }
        public string CarModel { get => carModel; set => carModel = value; }
        public string CarRegistNum { get => carRegistNum; set => carRegistNum = value; }
    }
}
