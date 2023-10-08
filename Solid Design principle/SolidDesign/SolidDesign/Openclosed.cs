using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesign
{
    #region OCP
    // the software entites open for extension and closed for modification
    public class Openclosed
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public double Balance { get; set; }
    }
    public interface IOpenclosed
    {
        double calculatinterest(Account account);
    }

    public class SavingAccount : IOpenclosed
    {
        public double calculatinterest(Account account)
        {
            return account.Balance * 0.5;
        }
    }
    public class currentAccount : IOpenclosed
    {
        public double calculatinterest(Account account)
        {
            return account.Balance * 0.4;
        }
    }

    #endregion

    #region OCP not implemented

    //before the implemetation
    //if any new accouttype will come we can add one more if condition for that new account
    public class Account
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public double Balance { get; set; }

        public double calculateinterest(string account)
        {
            if(account == "saving")
            {
                return this.Balance * 0.5;
            }
            else
            {
                return this.Balance * 0.3;
            }
        }
    }
    #endregion
}
