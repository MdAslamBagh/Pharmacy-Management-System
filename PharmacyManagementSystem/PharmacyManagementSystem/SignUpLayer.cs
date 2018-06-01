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
    public partial class SignUpLayer : Form
    {
        public SignUpLayer()
        {
            InitializeComponent();
        }

        private void SignUpLayer_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox5.Text == textBox6.Text)
            {

                string Name,Gender,Address, MobileNumber,UserType,UserName,Password;

             
                Name = textBox1.Text;

                Gender = "";
                bool isChecked = radioButton1.Checked;
                if (isChecked)
                    Gender = radioButton1.Text;
                else
                    Gender = radioButton2.Text;

                Address = textBox2.Text;
                MobileNumber = textBox3.Text;
                UserType = comboBox1.Text;
                UserName = textBox4.Text;
                Password = textBox5.Text;

               

                UserData.Insertuser(Name, Gender, Address, MobileNumber, UserType, UserName, Password);
                MessageBox.Show("User Registation successful");

                this.Hide();
                StartingLayer sl = new StartingLayer();
                sl.Show();




            }

            else
                MessageBox.Show("Password is not matching");
        }


    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           
           
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
