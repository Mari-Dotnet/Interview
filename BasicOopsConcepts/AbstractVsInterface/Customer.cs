using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVsInterface
{
    public abstract class Customer : ICustomer
    {
        public string Name { get; set; }
        public void Enquery()
        {
            Console.WriteLine("Explain to him product");
        }
        public abstract decimal discount();

    }


    public class PlatiniumCustomer : Customer
    {
        public override decimal discount()
        {
            return 0;
        }

    }

    public class WalkinCustomer : Customer
    {
        public override decimal discount()
        {
            return 0;
        }

    }

    public interface ICustomer
    {
        string Name { get; set; }
        void Enquery();
        decimal discount();

    }

    public abstract class Customerabstract
    {
        public abstract string Name { get; set; }
        public abstract void Enquery();
        public abstract decimal discount();
    }

    public class asbtractWalkinCustomer : Customerabstract
    {
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override decimal discount()
        {
            throw new NotImplementedException();
        }

        public override void Enquery()
        {
            throw new NotImplementedException();
        }
    }


}
