using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace PharmacyManagementSystem
{
    public partial class AddEmployeeLayer : Form
    {
        public AddEmployeeLayer()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == textBox8.Text)
            {
                try
                {

                    string FullName, MobileNumber;
                    DateTime Dob;
                    string Address, Email;
                    int Salary;
                    string UserName;
                    string Password;


                    FullName = textBox1.Text;
                    MobileNumber = textBox2.Text;
                    Dob = Convert.ToDateTime(dateTimePicker1.Text);
                    Address = textBox3.Text;
                    Email = textBox4.Text;
                    Salary = Convert.ToInt32(textBox5.Text);
                    UserName = textBox6.Text;
                    Password = textBox7.Text;

                    EmployeeData.InsertEmployee(FullName,MobileNumber,Dob,Address,Email,Salary,UserName,Password);


                    MessageBox.Show("Employee Registered Successful");

                }

                catch (Exception)
                {

                    MessageBox.Show("Please fill the form");
                }
            }

            else
            { 
                MessageBox.Show("Password is not matching");
            }
        }

             

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLayer al = new AdminLayer();
            al.Show();
        }

        private void AddEmployeeLayer_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
          
                
}
