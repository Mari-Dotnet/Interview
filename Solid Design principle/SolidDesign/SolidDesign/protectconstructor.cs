using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesign
{
    internal class protectconstructor
    {
        
        protected protectconstructor()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    internal class testprotconstructor
    {
        public int childid { get; set; }
    }
}
