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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "s" && textBox2.Text == "1")
            {
                AdminSide a = new AdminSide();
                this.Hide();
                a.ShowDialog();
                this.Close();  

            }
            else if (textBox1.Text != "s" && textBox2.Text == "1") 
            {
                MessageBox.Show("Pls enter UserName Again.", "Wrong UserName!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                //textBox2.Text = "";
            }

            else if (textBox1.Text == "s" && textBox2.Text != "1")
            {
                MessageBox.Show("Pls enter Password Again.", "Wrong Password!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //textBox1.Text = "";
                textBox2.Text = "";
            }
            else 
            {
                MessageBox.Show("Pls enter UserName And Password Again.", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Welcome w = new Welcome();
            this.Hide();
            w.ShowDialog();
            this.Close();
        }
    }
}
