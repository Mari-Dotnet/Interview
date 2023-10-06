using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVsInterface
{
    public class methodhiding
    {
        public void method()
        {
            Console.WriteLine("base method");
        }
    }
    public class dervemethodhiding: methodhiding
    {
        public new void method()
        {
            Console.WriteLine("derive method");
        }
    }
}
