using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YadanarMyay
{
    class Register
    {
        int registerno;
        string registerdate;
        int noofpassengers;
        double amount;
        //int memberdiscount;
        //int discount;
        //int total;
        string member;
        public Register() { }

        public Register(int registerno, string registerdate,int noofpassengers,string member,double amount) 
        {
            Registerno = registerno;
            Registerdate = registerdate;
            Noofpassengers = noofpassengers;
            Amount = amount;
        }
        public int Registerno 
        {
            get 
            {
                return registerno;
            }

            set
            {
                if (value >= 1000 && value <= 9999)
                {
                    registerno = value;
                }
                else 
                {
                    registerno = 0;
                }
            }
        }

        public string Registerdate 
        {
            get 
            {
                return registerdate;
            }

            set 
            {
                if (value != null)
                {
                    registerdate = value;
                }
                else 
                {
                    registerdate = "Unknown";
                }
            }
        }

        public int Noofpassengers
        {
            get
            {
                return noofpassengers;
            }

            set
            {
                if (value>0)
                {
                    noofpassengers = value;
                }
                else
                {
                    noofpassengers = 0;
                }
            }
        }

        public string Member
        {
            get
            {
                return member;
            }

            set
            {
                if (value!=null)
                {
                    member = value;
                }
                else
                {
                    member = "Unknown";
                }
            }
        }

        public double Amount
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

        //public int Memberdiscount
        //{
        //    get
        //    {
        //        return memberdiscount;
        //    }

        //    set
        //    {
        //        if (value > 0)
        //        {
        //            memberdiscount = value;
        //        }
        //        else
        //        {
        //            memberdiscount = 0;
        //        }
        //    }
        //}

       
        public double checkmember() 
        {
            if (Member == "YES")
            {
                double memberdiscount = 15;
                return memberdiscount;
            }
            else 
            {
                double memberdiscount = 0;
                return memberdiscount;
            }
        }

        public double packagediscount() 
        {
            if (Noofpassengers >= 10)
            {
                double discount = 5;
                return discount;
            }
            else 
            {
                double discount = 0;
                return discount;
            }
        }
        public double totaldiscount()
        {
            double totaldis=checkmember()+packagediscount();
            return totaldis;
        }
        public double DiscountAmount() 
        {
            double discountAmount = (Amount * (totaldiscount())) / 100;
            return discountAmount;
        }
        public double Total() 
        {
            double total = (Amount - DiscountAmount()) * Noofpassengers;
            return total;
        }
        
    }
}
