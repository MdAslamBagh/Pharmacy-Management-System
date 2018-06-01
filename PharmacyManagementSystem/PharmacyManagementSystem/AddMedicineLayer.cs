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
using EntityLayer;

namespace PharmacyManagementSystem
{
    public partial class AddMedicineLayer : Form
    {
 
        DataInformationContext db = new DataInformationContext();
      
        public AddMedicineLayer()
        {
            InitializeComponent();
        }


        private void Save_Click(object sender, EventArgs e)
        {

            //var Medicine = db.MedicineInfos.SingleOrDefault(u => u.Medicine_Name == textBox1.Text);
            if (textBox6.Text != "")
            {
               


                //int mid = Convert.ToInt32(textBox6.Text);
                
                //var Medicine_Id = db.MedicineInfos.Select(u => u.Medicine_Id);
                //if (Medicine_Id == null)
                //{
                //    MessageBox.Show("This Id Already Added!'Medicine Id Must be Unique'");

                //}

                    try
                    {

                        string Medicine_Name, Medicine_Catagory, Dosage, Manufacturer;

                        int Medicine_Available;


                        DateTime Entry_Date;
                        DateTime Production_Date;
                        DateTime Expire_Date;

                        int Buying_Price;
                        int Selling_Price;
                        int Medicine_Id;


                        Medicine_Name = textBox1.Text;
                        Medicine_Catagory = textBox2.Text;
                        Dosage = textBox7.Text;
                        Manufacturer = comboBox1.Text;
                        
                        Medicine_Available= Convert.ToInt32(textBox8.Text);
                        Entry_Date = Convert.ToDateTime(dateTimePicker1.Text);
                        Production_Date = Convert.ToDateTime(dateTimePicker2.Text);
                        Expire_Date = Convert.ToDateTime(dateTimePicker3.Text);
                        Buying_Price = Convert.ToInt32(textBox4.Text);
                        Selling_Price = Convert.ToInt32(textBox5.Text);
                        Medicine_Id = Convert.ToInt32(textBox6.Text);

                        MedicineData.InsertPermacyData(Medicine_Name, Medicine_Catagory, Dosage, Manufacturer, Medicine_Available, Entry_Date, Production_Date, Expire_Date, Buying_Price, Selling_Price, Medicine_Id);
                        MessageBox.Show("Medicine Added Successfully");


                        this.Hide();

                    }



                    catch (Exception)
                    {

                        MessageBox.Show("please fill all information");
                    }
                }


            
            else
            {
                MessageBox.Show("Medicine Id Must Needed");
            }
            
        }
        
    private void Exit_Click(object sender, EventArgs e)
        {
            
            this.Hide();

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

        private void AddMedicineLayer_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //if(textBox6.Text != null)
            //{
            //    MessageBox.Show("Please fill");
            //}
            //else
            //{

            //}
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
