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
    public partial class MedicineModifyLayer : Form
    {
        private DataInformationContext db = new DataInformationContext();
        public MedicineModifyLayer()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=MAB-ASLAM\\MDASLAMBAGH;Initial Catalog=PharmacyDatabase;Integrated Security=True");
        SqlDataAdapter sda;
        DataTable dt;
        SqlCommandBuilder builder;

        private void button1_Click(object sender, EventArgs e)
        {
            AdminLayer al = new AdminLayer();
            al.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            String Search = textBox1.Text;
            if (Search == textBox1.Text)
            {

                var AllMedicine = db.MedicineInfos.Where(c => c.Medicine_Id.ToString() == Search || c.Medicine_Name == Search);
                dataGridView1.DataSource = AllMedicine.ToList();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter("select * from MedicineInfoes", con);
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
    }
}
