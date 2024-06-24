using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesign
{
    /// <summary>
    /// all the base class methods must be applicable for deervied class.
    /// </summary>

    #region liskov substitution principle
    internal class LSP
    {
    }
    #endregion

    #region LSP violation
    public class EmployeeLSP
    {
        public virtual int calcuatesalary()
        {
            return 10000;
        }

        public virtual int calculatebonous()
        {
            return 10000;
        }
    }


    public class permanenteployee : EmployeeLSP
    {
        public override int calcuatesalary()
        {
            return 20000;
        }

        
    }
    // below mentioned calculate bonous is not applicable for contract employee
    //in this case we can thow some exception for calcuatebonous
    //if some one create object for contractemploy and access the bonous its will thorw error.
    public class contracteployee : EmployeeLSP
    {
        public override int calcuatesalary()
        {
            return 20000;
        }

        public override int calculatebonous()
        {
            throw new NotImplementedException();
        }

    }
    #endregion
}
