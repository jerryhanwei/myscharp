using myscharp.com.rss.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace myscharp.com.rss.service
{
    interface OutletService
    {
        public Boolean insertOrUpdateOutlet(Outlet outlet);

        public Boolean deleteOutlet(Outlet outlet);

    }
}
