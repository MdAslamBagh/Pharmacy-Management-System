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
using System.Data.SqlClient;



namespace PharmacyManagementSystem
{
    public partial class ModifyCustomerLayer : Form
    {
        DataInformationContext db = new DataInformationContext();
        public ModifyCustomerLayer()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=MAB-ASLAM\\MDASLAMBAGH;Initial Catalog=PharmacyDatabase;Integrated Security=True");
        SqlDataAdapter sda;
        DataTable dt;
        SqlCommandBuilder builder;

        private void button3_Click(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter("select * from CustomerInfoes", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;



            //var AllCustomer = db.CustomerInfos.Where(c => c.Id == c.Id);//r
            //dataGridView1.DataSource = AllCustomer.ToList();//r
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            String Search = textBox1.Text;
            if (Search == textBox1.Text)
            {

                var AllCustomer = db.CustomerInfos.Where(c => c.Customer_Id.ToString() == Search || c.CustomerName == Search);
                dataGridView1.DataSource = AllCustomer.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminLayer al = new AdminLayer();
            al.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {


                builder = new SqlCommandBuilder(sda);
                sda.Update(dt);
                MessageBox.Show("Update successfully");

            }
            catch (Exception ab)
            {
                MessageBox.Show("some error");
            }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}