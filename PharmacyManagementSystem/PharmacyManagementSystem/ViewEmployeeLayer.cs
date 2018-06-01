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

namespace PharmacyManagementSystem
{
    public partial class ViewEmployeeLayer : Form
    {
        DataInformationContext db = new DataInformationContext();
        public ViewEmployeeLayer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            var AllEmployee = db.EmployeeInfos.Where(E=> E.Id==E.Id);
            dataGridView1.DataSource = AllEmployee.ToList();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

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

                var AllEmployee = db.EmployeeInfos.Where(c => c.Id.ToString() == Search || c.FullName == Search);
                dataGridView1.DataSource = AllEmployee.ToList();

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
            string Search = textBox1.Text;
           
           


        }
    }
}
