using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YadanarMyay
{
    class Package
    {

        string packagename;
        string schedule;
        int amount;

        public Package(){}

        public Package(string packagename,string schedule,int amount) 
        {
            Packagename = packagename;
            Schedule = schedule;
            Amount = amount;
        }
        public string Packagename
        {
            get 
            {
                return packagename;
            }
            set 
            {
                if (value != null)
                {
                    packagename = value;
                }
                else 
                {
                    packagename = "Unknown";
                }
            }
        }

        public string Schedule 
        {
            get 
            {
                return schedule;
            }
            set 
            {
                if (value != null)
                {
                    schedule = value;
                }
                else 
                {
                    schedule = "Unknown";
                }
            }
        }

        public int Amount 
        {
            get 
            {
                return amount;
            }
            set 
            {
                if (value > 0)
                {
                    amount = value;
                }
                else 
                {
                    amount = 0;
                }
            }
        }
    }
}
