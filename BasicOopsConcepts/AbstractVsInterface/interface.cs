using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVsInterface
{
    public interface Icustomerdetails
    {
        void customerName();
        void customeradress(string name);
    }

    public interface Icustomerbankdetais : Icustomerdetails
    {
        void Customerbankdetails();
    }

    public class customerdetail : Icustomerdetails, Icustomerbankdetais
    {
        public void customeradress(string name)
        {
            Console.WriteLine("Hai");
        }

        public void Customerbankdetails()
        {
            throw new NotImplementedException();
        }

        public void customerName()
        {
            throw new NotImplementedException();
        }
    }
}
