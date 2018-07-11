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
    public partial class AdminSide : Form
    {
        public AdminSide()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PackageForm p = new PackageForm();
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewReport v = new ViewReport();
            this.Hide();
            v.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.ShowDialog();
            this.Close();
        }
    }
}
