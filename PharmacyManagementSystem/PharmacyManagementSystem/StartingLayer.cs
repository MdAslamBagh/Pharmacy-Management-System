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
    public partial class StartingLayer : Form
    {
        //DataInformationContext db = new DataInformationContext();

        public StartingLayer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {


           SignUpLayer sl = new SignUpLayer();
           sl.Show();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {

               
                    using (DataInformationContext db = new DataInformationContext())
                    {


                        var user = db.UserInfos.SingleOrDefault(u => u.UserName == textBox1.Text);


                        if (user == null)
                        {

                            MessageBox.Show("UserName or Password is Wrong");

                        }

                        else if (user.UserName == textBox1.Text && user.Password == textBox2.Text)
                        {
                            var type = user.UserType.ToString();
                            var password = user.Password.ToString();


                            if (password == user.Password && type == "Admin")
                            {
                                AdminLayer al = new AdminLayer();
                                al.Show();
                                this.Hide();


                            }

                            else if (password == user.Password && type == "User")
                            {

                                UserLayer ul = new UserLayer();
                                ul.Show();

                            }

                        }



                        else
                        {

                            MessageBox.Show("UserName or Password Wrong");
                        }


                    }

                }
               
                else
                {
                    MessageBox.Show("Please Fill UserName and Password");
                }
            


            }
           
        }
    }


