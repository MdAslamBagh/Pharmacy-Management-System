using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using EntityLayer;


namespace PharmacyManagementSystem
{
    public partial class DeleteMedicineLayer : Form
    {
        DataInformationContext db = new DataInformationContext();
        public DeleteMedicineLayer()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=MAB-ASLAM\\MDASLAMBAGH;Initial Catalog=PharmacyDatabase;Integrated Security=True");
        SqlDataAdapter sda;

        DataTable dt;
        SqlCommandBuilder builder;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void DeleteMedicineLayer_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter("select * from MedicineInfoes", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //List<DataGridViewRow> rowsToDelete = new List<DataGridViewRow>();

            SqlConnection con = new SqlConnection("Data Source=MAB-ASLAM\\MDASLAMBAGH;Initial Catalog=PharmacyDatabase;Integrated Security=True");

            DialogResult rs = MessageBox.Show("Are u sure u want to delete?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            int i = (int)dataGridView1.SelectedCells[0].Value;

            if (rs == DialogResult.OK)
            {
                if (i > 0)
                {

                    con.Open();

                    SqlCommand cmd = new SqlCommand("delete from MedicineInfoes Where Id=" + i + "", con);
                    MessageBox.Show("Medicine Deleted Successfully");

                    cmd.ExecuteNonQuery();

                    con.Close();

                }
            }
            else
            {
                MessageBox.Show("Not Deleted Any Value");
            }


            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    if (Convert.ToBoolean(dataGridView1.Rows[row.Index].Cells[0].Value))
            //    {

            //        dataGridView1.Rows.Remove(row);
            //       // con.Open();
            //        SqlCommand cmd = new SqlCommand("delete from MedicineInfoes Where Id=" + a+ "", con);
            //        cmd.ExecuteNonQuery();
            //    }

            // }






        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminLayer al = new AdminLayer();
            al.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            String Search = textBox1.Text;
            if (Search == textBox1.Text)
            {

                var AllMedicine = db.MedicineInfos.Where(c => c.Medicine_Id.ToString() == Search || c.Medicine_Name == Search);
                dataGridView1.DataSource = AllMedicine.ToList();

            }
        }
    }
}
