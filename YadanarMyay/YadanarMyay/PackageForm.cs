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
    public partial class PackageForm : Form
    {
        public PackageForm()
        {
            InitializeComponent();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0) 
            {
                if (checkBox1.Checked == false) 
                {
                    MessageBox.Show("Please select Add Package checkbox above for Adding Package", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                else if(checkBox1.Enabled)
                {
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                    {
                        MessageBox.Show("Please Fill correctly and do not leave blank" + "\n 1.PackageName" + "\n 2.Schedule" + "\n 3.Amount", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else 
                    {
                        try
                        {
                            if (int.Parse(textBox3.Text) <= 0)
                            {
                                MessageBox.Show("Please Enter Amount of Package wih at least $100", "Amount Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else 
                            {
                                DomesticPackage pc = new DomesticPackage();
                                pc.Packagename = textBox1.Text;
                                pc.Schedule = textBox2.Text;
                                pc.Amount = int.Parse(textBox3.Text);
                                DBAccess dbp = new DBAccess();
                                dbp.SaveDomesticPackage(pc);
                                MessageBox.Show("Package Has Been Added", "Success!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                        catch (FormatException)
                        {

                            MessageBox.Show("Please Enter Correct Number format for Amount of Packages", "Amount Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (OverflowException)
                        {

                            MessageBox.Show("Please Enter Correct Sensible Amount of Package", "Package Amount Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (checkBox1.Checked == false)
                {
                    MessageBox.Show("Please select Add Package checkbox above for Adding Package", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



                else if (checkBox1.Enabled)
                {
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                    {
                        MessageBox.Show("Please Fill correctly and do not leave blank" + "\n 1.PackageName" + "\n 2.Schedule" + "\n 3.Amount", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else 
                    {
                        try
                        {
                            if (int.Parse(textBox3.Text) <= 0)
                            {
                                MessageBox.Show("Please Enter Amount of Package wih at least $100", "Amount Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else 
                            {
                                InternationalPackage pc = new InternationalPackage();
                                pc.Packagename = textBox1.Text;
                                pc.Schedule = textBox2.Text;
                                pc.Amount = int.Parse(textBox3.Text);
                                DBAccess dbp = new DBAccess();
                                dbp.SaveInternationalPackage(pc);
                                MessageBox.Show("Package Has Been Added", "Success!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      
                            }
                        }
                        catch (FormatException)
                        {

                            MessageBox.Show("Please Enter Correct Number format for Amount of Packages", "Amount Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (OverflowException)
                        {

                            MessageBox.Show("Please Enter Correct Sensible Amount of Package", "Package Amount Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            else 
            {
                MessageBox.Show("Please Select the Package Category", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (checkBox2.Checked == false)
                {
                    MessageBox.Show("Please select Update Package Name checkbox above for Updating", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                

                else if(checkBox2.Enabled)
                {
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                    {
                        MessageBox.Show("Please Fill correctly and do not leave blank" + "\n 1.New PackageName for Update" + "\n 2.Old Schedule for Updating PackageName" + "\n3.Old Amount for Updating PackageName", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else 
                    {
                        try
                        {
                            if (int.Parse(textBox3.Text) <= 0)
                            {
                                MessageBox.Show("Please Enter Amount of Package wih at least $100", "Amount Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else 
                            {
                                DomesticPackage pc = new DomesticPackage();
                                pc.Packagename = textBox1.Text;
                                pc.Schedule = textBox2.Text;
                                pc.Amount = int.Parse(textBox3.Text);
                                DBAccess dbp = new DBAccess();
                                dbp.UpdateDomPackageName(pc);
                                MessageBox.Show("PackageName Has Been Updated", "Success!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                            }
                        }
                        catch (FormatException)
                        {

                            MessageBox.Show("Please Enter Correct Number format for Amount of Packages", "Amount Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (OverflowException)
                        {

                            MessageBox.Show("Please Enter Correct Sensible Amount of Package", "Package Amount Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (checkBox2.Checked == false)
                {
                    MessageBox.Show("Please select Update Package Name checkbox above for Updating", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

               

                else if(checkBox2.Enabled)
                {
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                    {
                        MessageBox.Show("Please Fill correctly and do not leave blank" + "\n 1. New PackageName for Update" + "\n 2. Old Schedule for Updating PackageName" + "\n 3. Old Amount for Updaing PackageName", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else 
                    {
                        try
                        {
                            if (int.Parse(textBox3.Text) <= 0)
                            {
                                MessageBox.Show("Please Enter Amount of Package wih at least $100", "Amount Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else 
                            {
                                InternationalPackage pc = new InternationalPackage();
                                pc.Packagename = textBox1.Text;
                                pc.Schedule = textBox2.Text;
                                pc.Amount = int.Parse(textBox3.Text);
                                DBAccess dbp = new DBAccess();
                                dbp.UpdateInterPackageName(pc);
                                MessageBox.Show("PackageName Has Been Updated", "Success!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                            }
                        }
                        catch (FormatException)
                        {

                            MessageBox.Show("Please Enter Correct Number format for Amount of Packages", "Amount Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (OverflowException)
                        {

                            MessageBox.Show("Please Enter Correct Sensible Amount of Package", "Package Amount Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Please Select the Package Category", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (checkBox3.Checked == false)
                {
                    MessageBox.Show("Please select Update Schedule & Amount checkbox above for Updating", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
               
                else if(checkBox3.Enabled)
                {
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                    {
                        MessageBox.Show("Please Fill correctly and do not leave blank" + "\n 1. Old PackageName for Updating Schedule & Amount" + "\n 2. New Schedule for Updating" + "\n 3. New Amount for Updating", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else 
                    {
                        try
                        {
                            if (int.Parse(textBox3.Text) <= 0)
                            {
                                MessageBox.Show("Please Enter Amount of Package wih at least $100", "Amount Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else 
                            {
                                DomesticPackage pc = new DomesticPackage();
                                pc.Packagename = textBox1.Text;
                                pc.Schedule = textBox2.Text;
                                pc.Amount = int.Parse(textBox3.Text);
                                DBAccess dbp = new DBAccess();
                                dbp.UpdateDomSchAmo(pc);
                                MessageBox.Show("Schedule & Amount Has Been Updated", "Success!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                            }
                            }
                        catch (FormatException)
                        {

                            MessageBox.Show("Please Enter Correct Number format for Amount of Packages", "Amount Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        catch (OverflowException)
                        {

                            MessageBox.Show("Please Enter Correct Sensible Amount of Package", "Package Amount Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (checkBox3.Checked == false)
                {
                    MessageBox.Show("Please select Update Schedule & Amount checkbox above for Updating", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                else if (checkBox3.Enabled)
                {
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                    {
                        MessageBox.Show("Please Fill correctly and do not leave blank" + "\n 1. Old PackageName for Updating Schedule & Amount" + "\n 2. New Schedule for Updating" + "\n 3. New Amount for Updating", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else 
                    {
                        try
                        {
                            if (int.Parse(textBox3.Text) <= 0)
                            {
                                MessageBox.Show("Please Enter Amount of Package wih at least $100", "Amount Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else 
                            {
                                InternationalPackage pc = new InternationalPackage();
                                pc.Packagename = textBox1.Text;
                                pc.Schedule = textBox2.Text;
                                pc.Amount = int.Parse(textBox3.Text);
                                DBAccess dbp = new DBAccess();
                                dbp.UpdateInterSchAmo(pc);
                                MessageBox.Show("Schedule & Amount Has Been Updated", "Success!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                            }
                        }
                        catch (FormatException)
                        {

                            MessageBox.Show("Please Enter Correct Number format for Amount of Packages", "Amount Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (OverflowException)
                        {

                            MessageBox.Show("Please Enter Correct Sensible Amount of Package", "Package Amount Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
           
            }
            else
            {
                MessageBox.Show("Please Select the Package Category", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            if (comboBox1.SelectedIndex == 0)
            {
                if(checkBox4.Checked==false )
                {
                    MessageBox.Show("Please select delete checkbox above for Deleting Package", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                
                }
                

                else if(checkBox4.Enabled)
                {
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Please Fill correctly and do not leave blank" + "\n 1.PackageName to Delete", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else 
                    {
                        DomesticPackage pc = new DomesticPackage();
                        pc.Packagename = textBox1.Text;
                        // pc.Schedule = textBox2.Text;
                        //pc.Amount = int.Parse(textBox3.Text);
                        DBAccess dbp = new DBAccess();
                        dbp.DeleteDomesticPackage(pc);
                        MessageBox.Show("Package Has Been Deleted", "Success!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {

                if (checkBox4.Checked == false)
                {
                    MessageBox.Show("Please select delete checkbox above for Deleting Package", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                
                 else if(checkBox4.Enabled)
                {
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Please Fill correctly and do not leave blank" + "\n 1.PackageName to Delete", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else 
                    {
                        InternationalPackage pc = new InternationalPackage();
                        pc.Packagename = textBox1.Text;
                        //pc.Schedule = textBox2.Text;
                        //pc.Amount = int.Parse(textBox3.Text);
                        DBAccess dbp = new DBAccess();
                        dbp.DeleteInternationalPackage(pc);
                        MessageBox.Show("Package Has Been Deleted", "Success!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            
            }
            else if(comboBox1.SelectedIndex<=0)
            {
                MessageBox.Show("Please Select the Package Category", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button5_Click(object sender, EventArgs e)
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
            else
            {
                MessageBox.Show("Please Select the Package Category", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminSide a = new AdminSide();
            this.Hide();
            a.ShowDialog();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled=false;
            }

            if (!checkBox1.Checked)
            {

                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {

                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                button1.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }

            if (!checkBox2.Checked)
            {

                checkBox1.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                button1.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {

                checkBox2.Enabled = false;
                checkBox1.Enabled = false;
                checkBox4.Enabled = false;
                button2.Enabled = false;
                button1.Enabled = false;
                button4.Enabled = false;
            }

            if (!checkBox3.Checked)
            {

                checkBox2.Enabled = true;
                checkBox1.Enabled = true;
                checkBox4.Enabled = true;
                button2.Enabled = true;
                button1.Enabled = true;
                button4.Enabled = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {

                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button1.Enabled = false;
            }

            if (!checkBox4.Checked)
            {

                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button1.Enabled = true;
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
        }
    }
}
