using System;
using System.Collections.Generic;
using System.Text;

namespace myscharp.com.rss.model
{
    class Outlet
    {
        private string outletID;
        private string outletName;
        private string outletAddress;
        private string outletCity;
        private string outletPhone;

        public string OutletID { get => outletID; set => outletID = value; }
        public string OutletName { get => outletName; set => outletName = value; }
        public string OutletAddress { get => outletAddress; set => outletAddress = value; }
        public string OutletCity { get => outletCity; set => outletCity = value; }
        public string OutletPhone { get => outletPhone; set => outletPhone = value; }
    }
}
