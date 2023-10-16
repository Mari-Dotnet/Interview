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

            string rever_str = "marimuthu";
            string Afterrever= new string(rever_str.Reverse().ToArray());
            object ac = "mari";
            object bc = new string("mari".ToCharArray());
            if (ac.Equals(bc))
            {
                //true
            }

            if (ac==bc)
            {
                //false going
            }
            Singleton singleton = Singleton.instance;

            //protectconstructor ct=new protectconstructor();
            //protected constructor does not allow to create object fot base class = new child class
            //protectconstructor testprotconstructor = new testprotconstructor();

            #region get the repeat letter  count and select the letter

            string repeat = "hello world";
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (char data in repeat)
            {
                if (char.IsLetter(data))
                {
                    if (map.Keys.Where(x => x == data).Any() == true)
                    {
                        map[data] = map[data] + 1;
                    }
                    else
                    {
                        map.Add(data,1 );
                    }
                }
            }

            var maxvlaus = map.FirstOrDefault(x => x.Value == map.Values.Max());
            Console.WriteLine($"the most repeat letter is {maxvlaus.Key} and count is {maxvlaus.Value}");
            #endregion

            Console.ReadKey(); 
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
