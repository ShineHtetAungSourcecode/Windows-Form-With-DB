using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YadanarMyay
{
    class DomesticPackage:Package
    {

        public DomesticPackage() 
        {
        
        }

        public DomesticPackage(string packagename, string schedule, int amount):base(packagename,schedule,amount) { }
    }
}
