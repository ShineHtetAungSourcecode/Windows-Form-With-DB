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
    public partial class ViewReport : Form
    {
        public ViewReport()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string date = textBox1.Text;
            string date = comboBox1.Text;
            string month = comboBox2.Text;
            string year = comboBox3.Text;

            DBAccess ds = new DBAccess();
            //string a = ds.Countdate(date,month,year);

            if (comboBox1.SelectedIndex < 0 || comboBox2.SelectedIndex < 0 || comboBox3.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select All and Do not leave unchosen\n 1.Date \n 2.Month \n 3.Year", "Date Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                //if (int.Parse(a) == 0)
                //{
                //    MessageBox.Show("The current date has no sales!!", "Please choose another date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}

                //else {
                    // DBAccess ds = new DBAccess();
                    DataTable dt = ds.DisplayDailyReport(date, month, year);
                    //comboBox2.DataSource = dt;
                    //comboBox2.DisplayMember = "PackageName";
                    dataGridView1.DataSource = dt;
                    //MessageBox.Show("Report Generated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminSide a = new AdminSide();
            this.Hide();
            a.ShowDialog();
            this.Close();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
