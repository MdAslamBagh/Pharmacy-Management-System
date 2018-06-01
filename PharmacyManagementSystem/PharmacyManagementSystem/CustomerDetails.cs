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
    public partial class CustomerDetails : Form
    {
        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


         if (textBox1.Text != null)
            {
                try
                {

                    
        
      
                    string CustomerName,Phone,Address,City, PostalCode,Country;
                    int Customer_Id;

                    Customer_Id = Convert.ToInt32(textBox1.Text);
                    CustomerName = textBox2.Text;
                    Phone = textBox3.Text;
                    Address = textBox4.Text;       
                    City = textBox5.Text;
                    PostalCode = textBox6.Text;
                    Country = textBox7.Text;

                   CustomerData.InsertCustomerData(Customer_Id,CustomerName, Phone, Address,City,PostalCode,Country);


                    MessageBox.Show("Customer Added Successful");
                    this.Hide();

                }

                catch (Exception)
                {

                    MessageBox.Show("Please fill the form");
                }
            }

            else
            { 
                MessageBox.Show("Id must be Needed");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void CustomerDetails_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminLayer al = new AdminLayer();
            al.Show();
            this.Hide();
        }
    }
    }

