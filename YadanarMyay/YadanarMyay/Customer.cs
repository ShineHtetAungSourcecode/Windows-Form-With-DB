using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YadanarMyay
{
    class Customer
    {

        string name;
        string nrc;
        string address;
        string phone;
        string cid;


        public Customer() 
        {
        }

        public Customer(string name, string address, string nrc,string phone,string cid) 
        {
            Name = name;
            Address = address;
            Nrc = nrc;
            Phone = phone;
            Cid = cid;
        }


        public string Name
        {
            get 
            {
                return name;
            }

            set
            {
                if (value != null)
                {
                    name = value;
                }
                else 
                {
                    name = "Unknown";
                }
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                if (value != null)
                {
                    address = value;
                }
                else
                {
                    address = "Unknown";
                }
            }
        }

        public string Phone 
        {
            get 
            {
                return phone;
            }

            set 
            {
                if (value!=null)
                {
                    phone = value;
                }

                else 
                {
                    phone = "Unknown";
                }
            }
        }
            
        public string Nrc
        {
            get 
            {
                return nrc;
            }

            set 
            {
                if (value != null)
                {
                    nrc = value;
                }

                else 
                {
                    nrc = "Unknown";
                }
            }
        }

        public string Cid
        {
            get
            {
                return cid;
            }

            set
            {
                if (value != null)
                {
                    cid = value;
                }

                else
                {
                    cid = "Unknown";
                }
            }
        }


    }
}
