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
    public partial class AdminLayer : Form
    {

       
        public AdminLayer()
        {
            InitializeComponent();
        }

        private void ViewStock_Click(object sender, EventArgs e)
        {
            ViewStockLayer vsl = new ViewStockLayer();
            vsl.Show();
            this.Hide();
        }

        private void ModifyItem_Click(object sender, EventArgs e)
        {


            MedicineModifyLayer mml = new MedicineModifyLayer();
            mml.Show();
            this.Hide();
            //AddMedicineLayer aml = new AddMedicineLayer();

            //try
            //{

            //    string Medicine_Name, Medicine_Catagory, Manufacturer;

            //    int Medicine_Quantity;


            //    DateTime Entry_Date;
            //    DateTime Production_Date;
            //    DateTime Expire_Date;

            //    int Buying_Price;
            //    int Selling_Price;
            //    int Medicine_Id;


    //            Medicine_Name = textBox1.Text;
    //            Medicine_Catagory = textBox2.Text;
    //            Manufacturer = comboBox1.Text;
    //            Medicine_Quantity = Convert.ToInt32(textBox3.Text);
    //            Entry_Date = Convert.ToDateTime(dateTimePicker1.Text);
    //            Production_Date = Convert.ToDateTime(dateTimePicker2.Text);
    //            Expire_Date = Convert.ToDateTime(dateTimePicker3.Text);
    //            Buying_Price = Convert.ToInt32(textBox4.Text);
    //            Selling_Price = Convert.ToInt32(textBox5.Text);
    //            Medicine_Id = Convert.ToInt32(textBox6.Text);



    //            var context = new DataInformationContext();


    //        var AllMedicine = (from Medicine in context.MedicineInfos
    //                           where (Medicine.Medicine_Id.ToString() == x || Medicine.Medicine_Name == x || Medicine.Medicine_Catagory == x)
    //                           select Medicine);

            
    //        foreach (MedicineData Medicine in AllMedicine)
    //        {
    //            Medicine.Medicine_ = int.Parse(pAmount);
    //        }
    //        try
    //        {
    //            e1.SubmitChanges();
    //        }
    //        catch
    //        {
    //            MessageBox.Show("wrong input");
    //        }

    //        MessageBox.Show("Item updated Successfully");
    //        panel1.Enabled = true;
    //    } catch
    //        {
    //            MessageBox.Show("Search Item 1st");
    //        }


    //        try
    //        {
    //            td.insertTransection(DateTime.Now, false, false, int.Parse(pAmount), 0, 0, ((int.Parse(pAmount)) * (int.Parse(pPrice))), pName, sl.currentUserS());
    //        }
    //        catch { MessageBox.Show("problem in updating Transection"); }
        

    //}




    //        ................
       }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            DeleteMedicineLayer dml = new DeleteMedicineLayer();
            dml.Show();
            this.Hide();

        }

        private void AddMedicine_Click(object sender, EventArgs e)
        {
            AddMedicineLayer aml =new AddMedicineLayer();
            aml.Show();
            




        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeLayer ael = new AddEmployeeLayer();
            ael.Show();
            this.Hide();

        }

        private void ViewEmployee_Click(object sender, EventArgs e)
        {
            ViewEmployeeLayer vel = new ViewEmployeeLayer();
            vel.Show();
            this.Hide();
        }

        private void ModifyEmployee_Click(object sender, EventArgs e)
        {
            EmployeeModifyLayer eml = new EmployeeModifyLayer();
            eml.Show();
            this.Hide();

        }

        private void DeleteEmployee_Click(object sender, EventArgs e)
        {
            DeleteEmployeeLayer del = new DeleteEmployeeLayer();
            del.Show();
            this.Hide();


        }

        private void RetailSale_Click(object sender, EventArgs e)
        {

            RetailSaleLayer rsl = new RetailSaleLayer();
            rsl.Show();
            this.Hide();
            //MedicineSellLayer msl = new MedicineSellLayer();
            //msl.Show();
            //this.Hide();
          
        }

        private void ViewSale_Click(object sender, EventArgs e)
        {
            OrderReport or = new OrderReport();
            or.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void AdminLayer_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            CustomerDetails cd = new CustomerDetails();
            cd.Show();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            OrderLayer ol = new OrderLayer();
            ol.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ViewCustomerLayer vcl = new ViewCustomerLayer();
            vcl.Show();
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ModifyCustomerLayer mcl = new ModifyCustomerLayer();
            mcl.Show();
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            DeleteCustomerLayer dcl = new DeleteCustomerLayer();
            dcl.Show();
            this.Hide();
        }
    }
}







