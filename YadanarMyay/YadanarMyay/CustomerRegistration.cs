using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YadanarMyay
{
    public partial class CustomerRegistration : Form
    {
        public CustomerRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer cs = new Customer();
            cs.Name = textBox1.Text;
            cs.Nrc = textBox2.Text;
            cs.Address = textBox3.Text;
            cs.Phone = textBox4.Text;
            //Package p = new Package();
            //p.Amount = dataGridView1
            DBAccess dbp = new DBAccess();
            dbp.SaveCustomer(cs);
        }

        private void CustomerRegistration_Load(object sender, EventArgs e)
        {
            

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cm = comboBox1.Text;      //!!these methods use parameter for select from combobox with get text
            DBAccess ds = new DBAccess();
            DataTable dt = ds.DisplayPackage2(cm);
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "PackageName";
            //dataGridView1.DataSource = dt;

            //if (comboBox1.SelectedIndex == 0) !!!!!!!these methods used for combobox select without parameter use
            //{
            //    //string cm1 = comboBox1.Text;
            //    DBAccess ds = new DBAccess();
            //    DataTable dt = ds.DisplayDomesticPackageName();
            //    comboBox2.DataSource = dt;
            //    comboBox2.DisplayMember = "PackageName";

            //}

            //else if (comboBox1.SelectedIndex == 1)
            //{
            //    //string cm1 = comboBox1.Text;
            //    DBAccess ds = new DBAccess();
            //    DataTable dt = ds.DisplayInternationalPackageName();
            //    comboBox2.DataSource = dt;
            //    comboBox2.DisplayMember = "PackageName";

            //}
            //else
            //{
            //    MessageBox.Show("Please Select the Combobox");
            //}
        }

        private void label11_Click(object sender, EventArgs e)
        {
            
            


            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string cm = comboBox1.Text; //!!these methods use parameter for select from combobox with get text
            //string price = comboBox2.Text;
            //DBAccess ds = new DBAccess();
            //DataTable dt = ds.DisplayAmount(cm, price);
            //comboBox3.DataSource = dt;
            //comboBox3.DisplayMember = "Amount";

          
            
            
            
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string tbname = comboBox1.Text; //!!these methods use parameter for select from combobox with get text
            string pcname = comboBox2.Text;
            DBAccess ds = new DBAccess();
            object obj = ds.DisplayAmount(tbname, pcname);
            textBox8.Text=obj.ToString();
            
            //line below is count testing
            //string b = ds.DisplayAmount(tbname, pcname);
            //textBox8.Text = b;
            


            //string a = obj.ToString();
            //int c = int.Parse(a);

            //if (c >= 650 && c<=2100) 
            //{
            //    textBox8.Text = "EU pacakge";
            //}
            //else if (c == 2900)
            //{
            //    textBox8.Text = "Japan";
            //}
            //else if (c < 650)
            //{
            //    textBox8.Text = "Pyi Twinn Bro!";
            //}

            //else 
            //{
            //    textBox8.Text = "Unknown";
            //}
            
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox5.Text == "" || textBox10.Text == "" || textBox8.Text == "" || comboBox2.Text == "")
            //{
            //    MessageBox.Show("Please Fill all fields correctly and do not leave blank", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            if (textBox1.Text == "" )
            {
                MessageBox.Show("Please Fill Name field correctly and do not leave blank", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Please Fill Nrc field correctly and do not leave blank", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Please Fill Address field correctly and do not leave blank", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Please Fill Phone Number field correctly and do not leave blank", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("Please Fill Number of Passengers field correctly and do not leave blank", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show("Please Fill CustomerID field correctly and do not leave blank", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox7.Text == "")
            {
                MessageBox.Show("Please Fill RegisterDate field correctly and do not leave blank", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Please Choose PackageCategory field correctly and do not leave blank", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox2.Text == "")
            {
                MessageBox.Show("Please Choose PackageName field correctly and do not leave blank", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //if(textBox5.Text=="0")
            //{
            //    MessageBox.Show("Please Enter Number of Passengers wih at least 1", "Passenger Quantity Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

              
            //int np=int.Parse(textBox5.Text);
            //if(np<=0)
            //{
            // MessageBox.Show("Noofpassengers less than or equals zero!!" + "\n 1. Old PackageName for Updating Schedule & Amount" + "\n 2. New Schedule for Updating" + "\n 3. New Amount for Updating");
            
            //}

            else 
            {
                try
                {
                    if (int.Parse(textBox5.Text) <= 0)
                    {
                        MessageBox.Show("Please Enter Number of Passengers wih at least 1", "Passenger Quantity Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    else 
                    {
                        Customer cs = new Customer();
                        cs.Name = textBox1.Text;
                        cs.Nrc = textBox2.Text;
                        cs.Address = textBox3.Text;
                        cs.Phone = textBox4.Text;
                        cs.Cid = textBox6.Text;
                        Register r = new Register();
                        //r.Registerno = int.Parse(textBox6.Text);
                        r.Registerdate = textBox7.Text;
                        r.Noofpassengers = int.Parse(textBox5.Text);
                        r.Member = textBox10.Text;
                        r.Amount = double.Parse(textBox8.Text);
                        Package p = new Package();
                        p.Packagename = comboBox2.Text;

                        DBAccess db = new DBAccess();
                        db.Register2(cs, r, p);

                        //DBAccess db2 = new DBAccess();
                        string cid = textBox6.Text;
                        string pcname = comboBox2.Text;
                        DataTable dt = db.DisplayRegister(cid, pcname);
                        dataGridView1.DataSource = dt;
                        MessageBox.Show("Registered Successfully", "Success!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                   
                }
                catch (FormatException)
                {
                    
                    MessageBox.Show("Please Enter Correct Number format for Number of Passengers", "Passenger Quantity Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                catch (OverflowException)
                {

                    MessageBox.Show("Please Enter Correct Sensible Number of Passengers", "Passenger Quantity Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            //comboBox2.DisplayMember = "PackageName";
            //Package p = new Package();
            //p.Amount = dataGridView1
            //DBAccess dbp = new DBAccess();
            //dbp.SaveCustomer(cs);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string date = textBox9.Text;
            //DBAccess ds = new DBAccess();
            //DataTable dt = ds.DisplayDailyReport(date);
            ////comboBox2.DataSource = dt;
            ////comboBox2.DisplayMember = "PackageName";
            //dataGridView2.DataSource = dt;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
             //!!these methods use parameter for select from combobox with get text
            string cuid = textBox6.Text;
            DBAccess ds = new DBAccess();
            //object obj = ds.DisplayAmount(tbname, pcname);
            //textBox8.Text=obj.ToString();

            //line below is count testing
            string b = ds.CountMember(cuid);
            textBox10.Text = b;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PackageDisplay p = new PackageDisplay();
            this.Hide();
            p.ShowDialog();
            this.Close();
        }
    }
}
