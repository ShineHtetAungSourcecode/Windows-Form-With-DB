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
    public partial class PackageDisplay : Form
    {
        public PackageDisplay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) 
            {
                DBAccess dbp = new DBAccess();
                DataTable dt = dbp.DisplayAllDomesticPackages();
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.SelectedIndex == 1) 
            {
                DBAccess dbp = new DBAccess();
                DataTable dt = dbp.DisplayAllInternationalPackages();
                dataGridView1.DataSource = dt;
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                DBAccess dbp = new DBAccess();
                DataTable dt = dbp.DisplayAllDomesticPackages();
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                DBAccess dbp = new DBAccess();
                DataTable dt = dbp.DisplayAllInternationalPackages();
                dataGridView1.DataSource = dt;
            }



            //to use the line underneath to select packages with combobox parameter passing
            //string pc = comboBox1.Text;
            //DBPackage ds = new DBPackage();
            //DataTable dt = ds.DisplayPackage(pc);
            //dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerRegistration c = new CustomerRegistration();
            this.Hide();
            c.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Welcome w = new Welcome();
            this.Hide();
            w.ShowDialog();
            this.Close();
        }

    }
}
