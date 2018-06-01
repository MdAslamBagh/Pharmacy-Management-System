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

namespace PharmacyManagementSystem
{
    public partial class ViewCustomerLayer : Form
    {
        DataInformationContext db = new DataInformationContext();
        public ViewCustomerLayer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var AllCustomer = db.CustomerInfos.Where(c => c.Id == c.Id);
            dataGridView1.DataSource = AllCustomer.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminLayer al = new AdminLayer();
            al.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            String Search = textBox1.Text;
            if (Search == textBox1.Text)
            {

                var AllCustomer = db.CustomerInfos.Where(c => c.Id.ToString() == Search || c.CustomerName == Search);
                dataGridView1.DataSource = AllCustomer.ToList();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
