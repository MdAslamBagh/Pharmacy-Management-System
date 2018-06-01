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
    public partial class DeleteCustomerLayer : Form
    {
        private DataInformationContext db = new DataInformationContext();
        public DeleteCustomerLayer()
        {
            InitializeComponent();
        }
        int count;
        SqlConnection con = new SqlConnection("Data Source=MAB-ASLAM\\MDASLAMBAGH;Initial Catalog=PharmacyDatabase;Integrated Security=True");
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();

        SqlCommandBuilder builder;

        private void button3_Click(object sender, EventArgs e)
        {
            AdminLayer al = new AdminLayer();
            al.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            String Search = textBox1.Text;
            if (Search == textBox1.Text)
            {

                var AllCustomer = db.CustomerInfos.Where(c => c.Id.ToString() == Search || c.CustomerName == Search);
                dataGridView1.DataSource = AllCustomer.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter("select *from CustomerInfoes", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
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
                    cmd.CommandText = " DELETE FROM CustomerInfoes WHERE Id='" + i + "'";
                    MessageBox.Show("Customer Deleted Successfully");
                    cmd.ExecuteNonQuery();
                    con.Close();

                }

            }
            else
            {
                MessageBox.Show("Not Deleted Any Value");
            }


        }
    }
}
