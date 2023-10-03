using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVsInterface
{
    public class virtualoverride
    {
        public int Id { get; set; } 
        public string? Name { get; set; }
        public virtual void Description()
        {
            Console.WriteLine("virtual method");
        }
    }

    public class Overidden : virtualoverride
    {
        public override void Description()
        {
            Console.WriteLine("overidden class");
        }
    }
}
