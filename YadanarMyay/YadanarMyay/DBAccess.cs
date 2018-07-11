using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace YadanarMyay
{
    class DBAccess
    {
        public void SaveDomesticPackage(DomesticPackage dp)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=SC;Initial Catalog=yadanarmyay;Integrated Security=true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert Into DomesticPackage Values('" + dp.Packagename + "','" + dp.Schedule + "'," + dp.Amount + ")";

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void SaveInternationalPackage(InternationalPackage ip)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=NYIHEINHTET;Initial Catalog=yadanarmyay;Integrated Security=true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert Into InternationalPackage Values('" + ip.Packagename + "','" + ip.Schedule + "'," + ip.Amount + ")";

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateDomPackageName(DomesticPackage dp)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=NYIHEINHTET;Initial Catalog=yadanarmyay;Integrated Security=true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update DomesticPackage set PackageName='" + dp.Packagename + "' where Schedule='" + dp.Schedule + "' and Amount=" + dp.Amount + "";

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateInterPackageName(InternationalPackage ip)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=NYIHEINHTET;Initial Catalog=yadanarmyay;Integrated Security=true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update InternationalPackage set PackageName='" + ip.Packagename + "' where Schedule='" + ip.Schedule + "' and Amount=" + ip.Amount + "";

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public void UpdateDomSchAmo(DomesticPackage dp)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=NYIHEINHTET;Initial Catalog=yadanarmyay;Integrated Security=true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update DomesticPackage set Schedule='" + dp.Schedule + "',Amount=" + dp.Amount + " where PackageName='" + dp.Packagename + "'";

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateInterSchAmo(InternationalPackage ip)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=NYIHEINHTET;Initial Catalog=yadanarmyay;Integrated Security=true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update InternationalPackage set Schedule='" + ip.Schedule + "',Amount=" + ip.Amount + " where PackageName='" + ip.Packagename + "'";

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteDomesticPackage(DomesticPackage dp)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=NYIHEINHTET;Initial Catalog=yadanarmyay;Integrated Security=true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from DomesticPackage where PackageName='" + dp.Packagename + "'";

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteInternationalPackage(InternationalPackage ip)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=NYIHEINHTET;Initial Catalog=yadanarmyay;Integrated Security=true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from InternationalPackage where PackageName='" + ip.Packagename + "'";

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable DisplayAllDomesticPackages()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=NYIHEINHTET;Initial Catalog=yadanarmyay;Integrated Security=true";

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand();
            sda.SelectCommand.Connection = con;
            sda.SelectCommand.CommandText = "Select * From DomesticPackage ";

            DataSet ds = new DataSet();
            sda.Fill(ds, "DomesticPackage");
            DataTable dt = ds.Tables["DomesticPackage"];
            return dt;
        }
        public DataTable DisplayAllInternationalPackages()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=NYIHEINHTET;Initial Catalog=yadanarmyay;Integrated Security=true";

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand();
            sda.SelectCommand.Connection = con;
            sda.SelectCommand.CommandText = "Select * From InternationalPackage ";

            DataSet ds = new DataSet();
            sda.Fill(ds, "InternationalPackage");
            DataTable dt = ds.Tables["InternationalPackage"];
            return dt;

        }


        //!!to use the method underneath to show packages with comboox parameter passing
        //public DataTable DisplayPackage(string pc)
        //{
        //    SqlConnection con = new SqlConnection();
        //    con.ConnectionString = "Data Source=NYIHEINHTET;Initial Catalog=yadanarmyay;Integrated Security=true";

        //    SqlDataAdapter sda = new SqlDataAdapter();
        //    sda.SelectCommand = new SqlCommand();
        //    sda.SelectCommand.Connection = con;
        //    sda.SelectCommand.CommandText = "Select * From "+pc+"";


        //    DataSet ds = new DataSet();
        //    sda.Fill(ds, ""+pc+"");

        //    DataTable dt = ds.Tables[""+pc+""];
        //    return dt;

        //}


        public void SaveCustomer(Customer c)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=NYIHEINHTET;Initial Catalog=yadanarmyay;Integrated Security=true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert Into Customers2(Name,Nrc,Address,Phone) Values('" + c.Name + "','" + c.Nrc + "','" + c.Address + "','" + c.Phone + "')";

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable DisplayDomesticPackageName()   //these methods use combobox column display without parameter
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=NYIHEINHTET;Initial Catalog=yadanarmyay;Integrated Security=true";

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand();
            sda.SelectCommand.Connection = con;
            sda.SelectCommand.CommandText = "Select distinct Packagename From DomesticPackage";

            DataSet ds = new DataSet();
            sda.Fill(ds, "DomesticPackage");

            DataTable dt = ds.Tables["DomesticPackage"];
            return dt;
        }

        public DataTable DisplayInternationalPackageName() //these method use combobox column display without parameter
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=NYIHEINHTET;Initial Catalog=yadanarmyay;Integrated Security=true";

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand();
            sda.SelectCommand.Connection = con;
            sda.SelectCommand.CommandText = "Select distinct Packagename From InternationalPackage";

            DataSet ds = new DataSet();
            sda.Fill(ds, "InternationalPackage");

            DataTable dt = ds.Tables["InternationalPackage"];
            return dt;
        }


        public DataTable DisplayPackage2(string cm) //this method used to utilize paramter(get text) for combobox column display
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=NYIHEINHTET;Initial Catalog=yadanarmyay;Integrated Security=true";

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand();
            sda.SelectCommand.Connection = con;
            sda.SelectCommand.CommandText = "Select Distinct PackageName From " + cm + "";


            DataSet ds = new DataSet();
            sda.Fill(ds, "" + cm + "");

            DataTable dt = ds.Tables["" + cm + ""];
            return dt;

        }

        public object DisplayAmount(string tbname, string pcname) //this method used to utilize paramter(get text) for combobox column display
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=NYIHEINHTET;Initial Catalog=yadanarmyay;Integrated Security=true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select Amount From " + tbname + " where PackageName ='" + pcname + "'";

            con.Open();
            object obj = cmd.ExecuteScalar();
            con.Close();
            return obj;

            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=NYIHEINHTET;Initial Catalog=yadanarmyay;Integrated Security=true";

            //SqlDataAdapter sda = new SqlDataAdapter();
            //sda.SelectCommand = new SqlCommand();
            //sda.SelectCommand.Connection = con;
            //sda.SelectCommand.CommandText = "Select Amount From " + tbname + " where PackageName ='" + pcname + "'";


            //DataSet ds = new DataSet();
            //sda.Fill(ds, "" + tbname + "");

            //DataTable dt = ds.Tables["" + tbname + ""];
            //return dt;

            ///



            //line below is count testing
            //question.. can i write a method in this Db scope??
            //string a = obj.ToString();
            //int c = int.Parse(a);
            //if (c >=650)
            //{
            //    string b = "yes EU";
            //    return b;
            //}
            //else if(c<650) 
            //{
            //    string b = "no EU";
            //    return b;
            //}
            //return pcname;
            //return tbname;
            //end of testing here



        }

        //public void Register(Customer cs,Register r,Package p)
        //{
        //    SqlConnection con = new SqlConnection();
        //    con.ConnectionString = "Data Source=NYIHEINHTET;Initial Catalog=yadanarmyay;Integrated Security=true";
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = "Insert Into regi3(CName,RegisterNo,RegisterDate,Nrc,Address,Phone,NoofPassengers,PackageName,Amount) Values('" + cs.Name + "'," + r.Registerno + ",'" + r.Registerdate +
        //        "','"+cs.Nrc+"','"+cs.Address+"','"+cs.Phone+"',"+r.Noofpassengers+",'"+p.Packagename+"',"+p.Amount+")";

        //    con.Open();
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //}

        public void Register2(Customer cs, Register r, Package p)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=NYIHEINHTET;Initial Catalog=yadanarmyay;Integrated Security=true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert Into regi7(RegisterDate,CID,CName,Nrc,Address,Phone,NoofPassengers,PackageName,Amount,Member,Discount,Total) Values('" + r.Registerdate + "','" + cs.Cid + "','" + cs.Name + "','" + cs.Nrc + "','" + cs.Address + "','" + cs.Phone + "'," + r.Noofpassengers + ",'" + p.Packagename + "'," + r.Amount + ",'" + r.Member + "'," + r.totaldiscount() + "," + r.Total() + ")";

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable DisplayRegister(string cid, string pcname)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=NYIHEINHTET;Initial Catalog=yadanarmyay;Integrated Security=true";

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand();
            sda.SelectCommand.Connection = con;
            sda.SelectCommand.CommandText = "Select Top 1 RegisterNo,RegisterDate,CID,CName,Nrc,Address,Phone,NoofPassengers,PackageName,Amount,Member,Discount,Total from regi7 where CID='" + cid + "' and PackageName='" + pcname + "' order by RegisterNo desc";

            DataSet ds = new DataSet();
            sda.Fill(ds, "regi7");

            DataTable dt = ds.Tables["regi7"];
            return dt;
        }


        public DataTable DisplayDailyReport(string date, string month, string year)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=NYIHEINHTET;Initial Catalog=yadanarmyay;Integrated Security=true";

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand();
            sda.SelectCommand.Connection = con;
            sda.SelectCommand.CommandText = "Select PackageName as TourPackage,sum(NoofPassengers) as NumberOFpeople From regi7 where RegisterDate='" + date + "/" + month + "/" + year + "' Group by PackageName Order by sum(NoofPassengers) ";

            DataSet ds = new DataSet();
            sda.Fill(ds, "regi7");
            DataTable dt = ds.Tables["regi7"];
            return dt;
        }

        public string CountMember(string cuid)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=NYIHEINHTET;Initial Catalog=yadanarmyay;Integrated Security=true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select count(*) as Countt from regi7 where CID='" + cuid + "'";

            con.Open();
            object obj = cmd.ExecuteScalar();
            con.Close();
            //return obj;
            //line below is count testing
            //question.. can i write a method in this Db scope??
            string a = obj.ToString();
            int c = int.Parse(a);
            if (c >= 2)
            {
                string b = "YES";
                return b;
            }
            else
            {
                string b = "NO";
                return b;
            }

            //return tbname;
            //end of testing here

            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=NYIHEINHTET;Initial Catalog=yadanarmyay;Integrated Security=true";

            //SqlDataAdapter sda = new SqlDataAdapter();
            //sda.SelectCommand = new SqlCommand();
            //sda.SelectCommand.Connection = con;
            //sda.SelectCommand.CommandText = "Select Amount From " + tbname + " where PackageName ='" + pcname + "'";


            //DataSet ds = new DataSet();
            //sda.Fill(ds, "" + tbname + "");

            //DataTable dt = ds.Tables["" + tbname + ""];
            //return dt;

        }


        //public string Countdate(string date, string month, string year)
        //{
        //    SqlConnection con = new SqlConnection();
        //    con.ConnectionString = "Data Source=NYIHEINHTET;Initial Catalog=yadanarmyay;Integrated Security=true";
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = "Select count(*) as Datee from regi7 where RegisterDate='" + date + "/" + month + "/" + year + "'";

        //    con.Open();
        //    object obj = cmd.ExecuteScalar();
        //    con.Close();
        //    //return obj;
        //    //line below is count testing
        //    //question.. can i write a method in this Db scope??
        //    string a = obj.ToString();
        //    //int c = int.Parse(a);

        //    return a;


        //}
    }
}
