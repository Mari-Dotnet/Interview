using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVsInterface
{
    public class methodOverloading
    {
        public void Name()
        {
            Console.WriteLine("method 1");
        }

        public void Name(string Name)
        {
            Console.WriteLine("method 2 with parameter passing");
        }
    }
}
