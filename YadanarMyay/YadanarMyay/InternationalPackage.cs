using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YadanarMyay
{
    class InternationalPackage:Package
    {

        public InternationalPackage() 
        {
        
        }

        public InternationalPackage(string packagename, string schedule, int amount):base(packagename,schedule,amount) { }
    }
}
