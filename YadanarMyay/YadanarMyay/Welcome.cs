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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                Login c = new Login();
                this.Hide();
                c.ShowDialog();
                this.Close();

                //CustomerRegistration c = new CustomerRegistration();
                //c.Show();
                //Login l = new Login();
                //l.Close();



            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PackageDisplay pd = new PackageDisplay();
            this.Hide();
            pd.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            this.Close();
            //this.Hide();
        }
    }
}
