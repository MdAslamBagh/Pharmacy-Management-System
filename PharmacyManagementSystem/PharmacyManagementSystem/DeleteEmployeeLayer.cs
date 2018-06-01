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
using System.Data.Entity;


using System.Data.SqlClient;


namespace PharmacyManagementSystem
{
    public partial class DeleteEmployeeLayer : Form
    {
        DataInformationContext db = new DataInformationContext();
        
        public DeleteEmployeeLayer()
        {
            InitializeComponent();
        }
        int count;
        SqlConnection con = new SqlConnection("Data Source=MAB-ASLAM\\MDASLAMBAGH;Initial Catalog=PharmacyDatabase;Integrated Security=True");
        SqlDataAdapter sda=new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();

        SqlCommandBuilder builder;
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string x = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            String Search = textBox1.Text;
            if (Search == textBox1.Text)
            {

                var AllEmployee = db.EmployeeInfos.Where(E => E.Id.ToString() == Search || E.FullName == Search);
                dataGridView1.DataSource = AllEmployee.ToList();





                //string x = textBox1.Text;
                //count = 0;
                //con.Open();
                //SqlCommand cmd = con.CreateCommand();
                //cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "Select * from EmployeeInf 
                //cmd.ExecuteNonQuery();
                //DataTable dt = new DataTable();
                //SqlDataAdapter sda = new SqlDataAdapter(cmd);
                //sda.Fill(dt);
                //count = Convert.ToInt32(dt.Rows.Count.ToString());
                //dataGridView1.DataSource = dt;
                //con.Close();
                //if(count==0)
                //{

                //    MessageBox.Show("Employees are not Found");
                //}


            }



            }
           
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //con.Open();
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "Select *from EmployeeInfoes";
            //cmd.ExecuteNonQuery();
            //DataTable dt = new DataTable();
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //sda.Fill(dt);
            //dataGridView1.DataSource = dt;
            //con.Close();



            sda = new SqlDataAdapter("select *from EmployeeInfoes", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;




        }

        private void button3_Click(object sender, EventArgs e)
        {

            DataInformationContext db = new DataInformationContext();
            DialogResult rs = MessageBox.Show("Are u sure u want to delete?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            
            int i =(int)dataGridView1.SelectedCells[0].Value;


            if (rs == DialogResult.OK)
            {
                if (i> -1)
                {
                    
                   
                   
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = " DELETE FROM EmployeeInfoes WHERE Id='" +i + "'";
                    MessageBox.Show("Employee Deleted Successfully");
                    cmd.ExecuteNonQuery();
                    con.Close();

                }

            }
            else
            {
                MessageBox.Show("Not Deleted Any Value");
            }
          



            //var AllEmployee = db.EmployeeInfos.Select(E => E.Id);
            //if (AllEmployee != null)
            //{
            //    db.EmployeeInfos.Remove();
            //    db.SaveChanges();
            //}

            ////EmployeeData ed = new EmployeeData();
            //var context = new DataInformationContext();
            //var allEmployee =context.EmployeeInfos.Where(c=>c.Id ==c.Id).FirstOrDefault();
            //if (allEmployee.Count() != 0)
            //{

            //    var result = MessageBox.Show("Delete this customer?", "Not Deleted", MessageBoxButtons.YesNo);
            //    if (result == DialogResult.Yes)
            //    {
            //        foreach (var emp in allEmployee)
            //        {
            //           context.EmployeeInfos.DeleteOnSubmit(emp);
            //        }
            //        try {
            //            //context.SubmitChanges();
            //        }
            //        catch {
            //            MessageBox.Show("Cant delete");
            //        }

            //        MessageBox.Show("Employee deleted");
            //        this.Hide();
            //    }
            //    else {

            //       this.Hide();
            //    }

            //}
            //else { MessageBox.Show("No User Found"); }
        }


    

            
           


        private void button4_Click(object sender, EventArgs e)
        {
            AdminLayer al = new AdminLayer();
            al.Show();
            this.Hide();
        }

        private void DeleteEmployeeLayer_Load(object sender, EventArgs e)
        {
           

        }
    }
}
