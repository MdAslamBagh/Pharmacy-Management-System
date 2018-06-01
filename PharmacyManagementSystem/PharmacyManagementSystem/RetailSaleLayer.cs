using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using EntityLayer;
using System.Data.SqlClient;




namespace PharmacyManagementSystem
{
    public partial class RetailSaleLayer : Form
    {
        //private SqlConnection con = new SqlConnection();
        SqlConnection con = new SqlConnection("Data Source=MAB-ASLAM\\MDASLAMBAGH;Initial Catalog=PharmacyDatabase;Integrated Security=True"); //new
        SqlCommand cmd;//new
        //private SqlConnection con = new SqlConnection();
        //private DataInformationContext db = new DataInformationContext();



        public RetailSaleLayer()
        {
            InitializeComponent();
            //SqlConnection con = new SqlConnection(@"Data Source=MAB-ASLAM\\MDASLAMBAGH;Initial Catalog=PharmacyDatabase;Integrated Security=True");
        }

        float Quantity = 0;
        float Sellprice = 0;
        float Amount = 0;
        int total = 0;
        int totalamount = 0;
        int countamount = 0;
        float discount = 0;
       // float calculate = 0;
        float calculatetotal = 0;

        // SqlCommand cmd=new SqlCommand();
         SqlDataAdapter sda;
         DataTable dt;
        SqlCommand cmd2 = new SqlCommand();


        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void RetailSaleLayer_Load(object sender, EventArgs e)
        {
            // SqlConnection con = new SqlConnection(@"Data Source = MAB - ASLAM\\MDASLAMBAGH; Initial Catalog = PharmacyDatabase; Integrated Security = True");

            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd2 = con.CreateCommand();


            cmd.CommandType = CommandType.Text;
            cmd2.CommandType = CommandType.Text;
            cmd.CommandText = "Select Medicine_Name from MedicineInfoes";
            cmd2.CommandText = "Select Order_Id from OrderInfoes";


            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
            sda.Fill(dt);
            sda2.Fill(dt);



            foreach (DataRow dr in dt.Rows)
            {

        
              
                    comboBox1.Items.Add(dr["Medicine_Name"].ToString());
                    comboBox2.Items.Add(dr["Order_Id"].ToString());
        

            }




                con.Close();


        










































            //SqlConnection con = new SqlConnection("Data Source=MAB-ASLAM\\MDASLAMBAGH;Initial Catalog=PharmacyDatabase;Integrated Security=True");

            //// SqlDataReader reader = null;

            // try
            // {
            //     //SqlConnection con = new SqlConnection("Data Source=MAB-ASLAM\\MDASLAMBAGH;Initial Catalog=PharmacyDatabase;Integrated Security=True");
            //     con.Open();


            //     string query = "Select * from MedicineInfoes";
            //     SqlCommand cmd = new SqlCommand(query,con);
            //     cmd.CommandText = query;
            //     SqlDataReader reader = cmd.ExecuteReader();
            //     while (reader.Read())
            //     {
            //         comboBox1.Items.Add(reader["Medicine_Name"].ToString());


            //     }
            //     con.Close();
            //     //cmd.con = con;






            // }
            // catch (Exception ex)
            // {
            //     MessageBox.Show("Eror");
            // }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {









        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from MedicineInfoes where Medicine_Name='" + comboBox1.Text + "'", con);
             con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string Medicine_Available = (string)sdr["Medicine_Available"].ToString();
                textBox2.Text = Medicine_Available;
                string Dosage = (string)sdr["Dosage"].ToString();
                textBox3.Text = Dosage;
                string Selling_Price = (string)sdr["Selling_Price"].ToString();
                textBox5.Text = Selling_Price;
            }

            con.Close();

        }

        private void SubQuantity()
        {
            SqlConnection con = new SqlConnection("Data Source=MAB-ASLAM\\MDASLAMBAGH;Initial Catalog=PharmacyDatabase;Integrated Security=True");
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            total = int.Parse(textBox2.Text) - int.Parse(textBox1.Text);


            //cmd = new SqlCommand("UPDATE MedicineInfoes SET Medicine_Available ='" + total + "'",con);
            cmd = new SqlCommand("UPDATE MedicineInfoes SET Medicine_Available ='" + total + "' where Medicine_Name='" + comboBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Update(dt);
            textBox2.Text = total.ToString();


        }

        private void CountTotalAmount()
        {
         
           total = int.Parse(textBox4.Text);
           totalamount= totalamount + total;
           

            textBox7.Text = totalamount.ToString();
          

            



        }


        private void CountAmount()
        {

            total = int.Parse(textBox7.Text);
           


            textBox9.Text = total.ToString();






        }
















        //  cmd = new SqlCommand("select * from MedicineInfoes where Medicine_Name='" + comboBox1.Text + "'", con);
        //con.Open();
        // cmd.ExecuteNonQuery();


        // SqlDataReader sdr = cmd.ExecuteReader();
        // while (sdr.Read())
        // {


        //     //string Medicine_Available = (string)sdr["Medicine_Available"].ToString();
        //     //textBox2.Text = Medicine_Available;
        //     //Quantity = float.Parse(textBox1.Text);

        //     //SqlConnection con = new SqlConnection("Data Source=MAB-ASLAM\\MDASLAMBAGH;Initial Catalog=PharmacyDatabase;Integrated Security=True");


        //     int q1 = Convert.ToInt32(textBox2.Text);
        //     int q2 = Convert.ToInt32(textBox1.Text);

        //     int total = q1 - q2;

        //     string query = "UPDATE [MedicineInfoes] SET [Medicine_Availabe]= ' + total + ' WHERE Medicine_Id=1";
        //     SqlCommand cmd = new SqlCommand(query, con);


        //string Selling_Price = (string)sdr["Selling_Price"].ToString();
        // textBox5.Text = Selling_Price;








        //{
        //    int total = 0;
        //    total = int.Parse(textBox2.Text) - int.Parse(textBox1.Text);

        //    textBox2.Text = total.ToString();

        //}




        private void MuliplyAmount()
        {
            Quantity = float.Parse(textBox1.Text);
            Sellprice = float.Parse(textBox5.Text);
            Amount = Quantity * Sellprice;
            textBox4.Text = Amount.ToString();


           





        }

        private void Discount()
        {
            totalamount = int.Parse(textBox7.Text);
            //if (textBox8.Text == null)
            //{
                discount = float.Parse(textBox8.Text);
                discount = ((totalamount * discount) / 100);
                calculatetotal = discount;
                textBox9.Text = calculatetotal.ToString();
            //}
            //else
            
                //totalamount = int.Parse(textBox7.Text);
                //textBox9.Text = totalamount.ToString();


            



        }

       
        //private void Count()
        //{
        //    Amount++;

        //}



        //private void TotalAmount()
        //{

        //    Sellprice = float.Parse(textBox5.Text);
        //    Amount = Quantity * Sellprice;
        //    textBox4.Text = Amount.ToString();
        //}

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           

           

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubQuantity();


            MuliplyAmount();

            CountTotalAmount();

           
            int row = 0;
      

           
            dataGridView1.Rows.Add();
            row = dataGridView1.Rows.Count - 2;
          
            dataGridView1["Medicine_Name", row].Value = comboBox1.Text;
            dataGridView1["Dosage", row].Value = textBox3.Text;
            dataGridView1["Medicine_Quantity", row].Value = textBox1.Text;
            dataGridView1["Selling_Price", row].Value = textBox5.Text;
            dataGridView1["Total_Amount", row].Value = textBox4.Text;

      








            //TotalAmount();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AdminLayer al = new AdminLayer();
            al.Show();
            this.Hide();

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
           
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox8.Text != null && !string.IsNullOrWhiteSpace(textBox8.Text))
            {
                Discount();
               
            }
            else
            {
                CountAmount();

            }

            //if (textBox8.Text == "0")
            //{
            //    CountAmount();
            //}





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from OrderInfoes where Order_Id='" + comboBox2.Text + "'", con);
            //con.Open();
            //cmd.ExecuteNonQuery();
            //SqlDataReader sdr = cmd.ExecuteReader();
            //while (sdr.Read())
            //{
              
            //}

            //con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {


            MedicineReport mr = new MedicineReport();
            mr.Show();
            this.Hide();


        }
    }

    // //var medicine = new DataInformationContext();
    // //x = (from c in db.MedicineInfos
    // //select new { c.Medicine_Name}).ToList();




    // string x=comboBox1.Text;


    // //DataInformationContext db = new DataInformationContext();

    // if (comboBox1.Text == x)
    // {

    //     var medicine = db.MedicineInfos.Select(m => m.Medicine_Name == x);
    // }



    //// comboBox1.Text= "select Medicine_Name from MedicineInfoes";


    // //sda = new SqlDataAdapter("SELECT Medicine_Name from MedicineInfoes", con);
    // //dt = new DataTable();
    // //sda.Fill(dt);
    // //foreach (DataRow dr in dt.Rows)
    // //{
    // //    comboBox1.Text = dr["Medicine_Name"].ToString();
    //     //    textBox3.Text = dr["Dosage"].ToString();
    //     //    textBox5.Text = dr["Selling_Price"].ToString();




    // }
    // //con.Close();







    // //DataTable dt;
    // //SqlCommandBuilder builder;

}

    






