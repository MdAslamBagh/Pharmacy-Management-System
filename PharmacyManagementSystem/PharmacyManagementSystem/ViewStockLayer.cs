using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataLayer;


namespace PharmacyManagementSystem
{
    public partial class ViewStockLayer : Form
    {
        DataInformationContext db = new DataInformationContext();
        
       

        public ViewStockLayer()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void ViewStockLayer_Load(object sender, EventArgs e)
        {
           
            var context = new DataInformationContext();



            var AllMedicine = (from Medicine in context.MedicineInfos
                               select Medicine);

            dataGridView1.DataSource= AllMedicine.ToList();


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            dataGridView1.Enabled = true;

     
            
            string x = textBox1.Text;




            string comboText = comboBox1.Text;


                var context = new DataInformationContext();

            //var AllMedicine = (from Medicine in context.MedicineInfos
            //                   where (Medicine.Medicine_Id.ToString() == x || Medicine.Medicine_Name == x || Medicine.Medicine_Catagory == x)
            //                   select Medicine);

            if (comboText == "Medicine_Id")
            {
                try
                {
                   int mid = Convert.ToInt32(textBox1.Text);
                    var AllMedicine = db.MedicineInfos.Where(m => m.Medicine_Id == mid);

                    dataGridView1.DataSource = AllMedicine.ToList();
                }
                catch(Exception)
                {
                    MessageBox.Show("Please Searching Choose Type");
                }
                
                

            }
            else if (comboText == "Medicine_Name")
            {
                var AllMedicine = db.MedicineInfos.Where(m => m.Medicine_Name == textBox1.Text);
                dataGridView1.DataSource = AllMedicine.ToList();
            }

            else if (comboText == "Medicine_Catagory")
            {
                var AllMedicine = db.MedicineInfos.Where(m => m.Medicine_Catagory == textBox1.Text);
                dataGridView1.DataSource = AllMedicine.ToList();
            }

     
        }
        
        
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string y = comboBox1.Text;
            //dataGridView1.Enabled = true;
            
           //var context = new DataInformationContext();

           

            //var medicine = db.MedicineInfos.Select(u => u.Medicine_Name);

             

           

            
            //var AllMedicine = (from Medicine in context.MedicineInfos
            //                   where (Medicine.Medicine_Id.ToString() == y || Medicine.Medicine_Name == y || Medicine.Medicine_Catagory == y)
            //                   select Medicine);

            //dataGridView1.DataSource = AllMedicine.ToList();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //dataGridView1.Enabled = true;
            //string x =textBox1.Text;
            //var context = new DataInformationContext();
            //var AllMedicine = (from Medicine in context.MedicineInfos
            //                   where(Medicine.Medicine_Name==x || Medicine.Medicine_Catagory==x)
            //                   select Medicine);

            //dataGridView1.DataSource = AllMedicine.ToList();


        }

        private void label1_Click(object sender, EventArgs e)
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

