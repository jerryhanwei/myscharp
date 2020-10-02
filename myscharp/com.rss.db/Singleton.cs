using System;
using System.Collections.Generic;
using System.Text;

namespace myscharp.com.rss.db
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();

     
        static Singleton()
        {
        }

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
