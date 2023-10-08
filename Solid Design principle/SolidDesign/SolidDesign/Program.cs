using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesign
{
    internal class Program
    {
        /// <summary>
        /// a. out vs ref is c# keyword
        ///b. ref is two way from caller and calle and back.
        //c. out is one way send data back from calle to caller.
        /// </summary>
        /// <param name="somevalue"></param>
        public static void reffunction(ref int somevalue)//calle
        {
            somevalue += somevalue;
        }

        public static void outfntion(out int somevalue) //calle
        {
            somevalue= 0;
            somevalue += somevalue;
        }
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine("using ref a values before method call", a);
            reffunction(ref a); //caller 
            Console.WriteLine("using ref a values is",a);
            int b = 20;
            Console.WriteLine("using out a values before method call", b);
            outfntion(out b); //caller
            Console.WriteLine("using out a values before method call", b);
            EmployeeLSP employeeLSP = new EmployeeLSP();
            permanenteployee permanenteployee  =  new permanenteployee();
            contracteployee  contracteployee = new contracteployee();
           // contracteployee.calculatebonous();
        }
    }
}
