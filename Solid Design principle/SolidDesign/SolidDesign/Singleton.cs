using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesign
{
    public class Singleton
    {
        protected  Singleton()
        {
        }
        private static Singleton _instance =null;
        private static readonly object lockibj = new object();

        public static Singleton instance {
            get {
                lock (lockibj)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();

                    }
                }
                
                return _instance;
            }
        }
    }
}
