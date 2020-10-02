using System;
using System.Collections.Generic;
using System.Text;

namespace myscharp.com.rss.model
{
    class DataDictionary
    {
        private string dicID;
        private string dicName;
        private string dicType;

        public string DicID { get => dicID; set => dicID = value; }
        public string DicName { get => dicName; set => dicName = value; }
        public string DicType { get => dicType; set => dicType = value; }
    }
}
