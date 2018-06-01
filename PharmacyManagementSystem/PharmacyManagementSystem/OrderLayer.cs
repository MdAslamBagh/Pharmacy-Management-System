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
using System.Data.SqlClient;
using EntityLayer;

namespace PharmacyManagementSystem
{
    public partial class OrderLayer : Form
    {
        public OrderLayer()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=MAB-ASLAM\\MDASLAMBAGH;Initial Catalog=PharmacyDatabase;Integrated Security=True");
        SqlDataAdapter sda;
        DataTable dt;
        SqlCommandBuilder builder;

        private void button1_Click(object sender, EventArgs e)
        {
            int Order_Id;
            int Customer_Id;
            int Medicine_Id;

            DateTime Order_Date;

            Order_Id = Convert.ToInt32(textBox1.Text);
            Customer_Id = Convert.ToInt32(textBox2.Text);
            Medicine_Id= Convert.ToInt32(textBox3.Text);
            Order_Date = Convert.ToDateTime(dateTimePicker1.Text);
          

            OrderData.InsertOrderData(Order_Id,Customer_Id,Medicine_Id,Order_Date);


            MessageBox.Show("Customer Order Take Successful");
            this.Hide();
            AdminLayer al = new AdminLayer();
            al.Show();
            



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter("select * from OrderInfoes", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
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

        private void button6_Click(object sender, EventArgs e)
        {
            DataInformationContext db = new DataInformationContext();
            DialogResult rs = MessageBox.Show("Are u sure u want to delete?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            int i = (int)dataGridView1.SelectedCells[0].Value;


            if (rs == DialogResult.OK)
            {
                if (i > -1)
                {



                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = " DELETE FROM OrderInfoes WHERE Id='" + i + "'";
                    MessageBox.Show("Customer Order Deleted Successfully");
                    cmd.ExecuteNonQuery();
                    con.Close();

                }

            }
            else
            {
                MessageBox.Show("Not Deleted Any Value");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminLayer al = new AdminLayer();
            al.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {


                builder = new SqlCommandBuilder(sda);
                sda.Update(dt);
                MessageBox.Show("Insert successfully");

            }
            catch (Exception ab)
            {
                MessageBox.Show("some error");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
