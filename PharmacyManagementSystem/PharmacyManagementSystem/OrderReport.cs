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
using System.Configuration;
using Dapper;
using EntityLayer;

namespace PharmacyManagementSystem
{
    public partial class OrderReport : Form
    {
        public OrderReport()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=MAB-ASLAM\\MDASLAMBAGH;Initial Catalog=PharmacyDatabase;Integrated Security=True");
        SqlDataAdapter sda;
        DataTable dt;
        SqlCommandBuilder builder;

        private void OrderReport_Load(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection("Data Source=MAB-ASLAM\\MDASLAMBAGH;Initial Catalog=PharmacyDatabase;Integrated Security=True"))
            using (SqlCommand cmd = con.CreateCommand())
            {
                con.Open();

                //cmd.CommandText = " select CO.Order_Id,C.CustomerName,C.Phone,CO.OrderDate FROM OrderInfoes CO INNER JOIN CustomerInfoes C ON CO.Customer_Id=C.Customer_Id where OrderDate BETWEEN Convert.ToDateTime(dtFromDate.Value) and Convert.ToDateTime(dtToDate.Value)";
                // CONVERT{ dtFromDate.Value} and CONVERT{ dtToDate.Value}";


                //cmd.CommandText = "select O.Order_Id,C.CustomerName,C.Address,C.Phone,C.City,C.Country,M.Medicine_Name,M.Medicine_Quantity,O.OrderDate" + "from((OrderInfoes O inner join CustomerInfoes C on O.Customer_Id = C.Customer_Id)inner join MedicineInfoes M on O.Medicine_Id = M.Medicine_Id)" + $" Where O.OrderDate between { dtFromDate.Value} and { dtToDate.Value}";



                cmd.CommandText = " select CO.Order_Id,C.CustomerName,C.Address,C.PostalCode,C.City,C.Phone,C.Country,CO.OrderDate" +
                  " FROM OrderInfoes CO INNER JOIN CustomerInfoes C ON CO.Customer_Id=C.Customer_Id" +
                 $" where CO.OrderDate BETWEEN '{dtFromDate.Value}' and '{dtToDate.Value}'";

                //cmd.CommandText = " select CO.Order_Id,C.CustomerName,C.Address,C.PostalCode,C.City,C.Phone,C.Country,CO.OrderDate" +
                //  " FROM OrderInfoes CO INNER JOIN CustomerInfoes C ON CO.Customer_Id=C.Customer_Id" +
                // $" where CO.OrderDate BETWEEN '{dtFromDate.Value}' and '{dtToDate.Value}'";


                //$"'2018/05/06' AND '2018/08/08'";

                //SELECT pb.OrderId, pb.N, pb.MobileNo, e.email FROM phonebook pb INNER JOIN email e ON e.Id = pb.Id";
                //cmd.CommandText = "select o.Order_Id,c.CustomerName,c.Phone,o.OrderDate"
                //       + "from OrderInfoes o inner join CustomerInfoes c on o.Customer_Id = c.Customer_Id" +
                //     $" where o.OrderDate between { dtFromDate.Value} and { dtToDate.Value}";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                // dt = new DataTable();
                DataSet ds = new DataSet();
                //sda.Fill(dt);
                sda.Fill(ds);
                // dataGridView1.DataSource = ds;
                dataGridView1.DataSource = ds.Tables[0].DefaultView;

            }









            //SqlConnection con = new SqlConnection("Data Source=MAB-ASLAM\\MDASLAMBAGH;Initial Catalog=PharmacyDatabase;Integrated Security=True");
            //con.Open();
            //try
            //{
            //    SqlCommand cmd = con.CreateCommand();
            //    cmd.CommandText = "SELECT * FROM CustomerInfoes";
            //    cmd.CommandText = "SELECT * FROM OrderInfoes";
            //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //    DataSet ds = new DataSet();
            //    sda.Fill(ds);
            //    dataGridView1.DataSource = ds.Tables[0].DefaultView;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}


            //sda = new SqlDataAdapter("select o.Order_Id,c.CustomerName,c.Phone,o.OrderDate"
            //               + "from OrderInfoes o inner join CustomerInfoes c on o.Customer_Id = c.Customer_Id" +
            //               $" where o.OrderDate between { dtFromDate.Value} and { dtToDate.Value}",con);
            //dt = new DataTable();
            //sda.Fill(dt);
            //dataGridView1.DataSource = dt;



            //using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
            //{

            //}
        }

        private void dtToDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtFromDate_ValueChanged(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            AdminLayer al = new AdminLayer();
            al.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PrintLayer pl = new PrintLayer();
            pl.Show();

            //foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            //{
            //    //OrderInfo obj = dataGridView1.sele as OrderInfo;
                //if (obj != null)
              

                //using (SqlConnection con = new SqlConnection("Data Source=MAB-ASLAM\\MDASLAMBAGH;Initial Catalog=PharmacyDatabase;Integrated Security=True"))
                //using (SqlCommand cmd = con.CreateCommand())
                //{
                //    con.Open();


                //    cmd.CommandText = "select O.Order_Id,C.CustomerName,M.Medicine_Name from((OrderInfoes O inner join CustomerInfoes C on O.Customer_Id = C.Customer_Id)inner join MedicineInfoes M on O.Medicine_Id = M.Medicine_Id) ORDER by O.Order_Id";



                //    SqlDataAdapter sda = new SqlDataAdapter(cmd);

                //    DataSet ds = new DataSet();

                //    sda.Fill(ds);

                //    dataGridView1.DataSource = ds.Tables[0].DefaultView;

                //List<OrderInfo> list = con.Query<OrderInfo>(query,commandType: CommandType.Text).ToList();
                ////List<CustomerInfo> ___list = con.Query<OrderInfo>(query, commandType: CommandType.Text).ToList();

                //PrintLayer pl = new PrintLayer();
               // pl.Show();
                
                        
                        

                }

            }
        }
    

