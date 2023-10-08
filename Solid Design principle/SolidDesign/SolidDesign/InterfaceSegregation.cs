using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesign
{
    /// <summary>
    /// segregate your interface as much as smaller
    /// have multiple smaller interface than larger interfaces.
    /// </summary>
    #region have multiple smaller interface than larger interfaces.

    public interface Icar
    {
        void drive();
    }
    public interface IFlycar
    {
        void Fly();
    }
    public class Flycar : IFlycar,Icar
    {
        public void drive()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }
    }

    public class Normalcar : Icar
    {
        public void drive()
        {
            throw new NotImplementedException();
        }
    }
    internal class InterfaceSegregation
    {
    }
    #endregion

    #region ISP issue occcur
    public interface Ivechile
    {
        void drive();
        void fly();
    }

    //car don't have functiolity for flying
    public class car : Ivechile
    {
        public void drive()
        {
            Console.WriteLine("drive");
        }

        public void fly()
        {
            Console.WriteLine("flying car");
        }
    }
    #endregion
}
