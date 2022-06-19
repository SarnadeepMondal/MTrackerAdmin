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



namespace MTrackerDesktop
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
                // Login Button

                SqlConnection con = new SqlConnection(@"Persist Security Info = False; User ID = sa; Password = 7101; Initial Catalog = MTrackerDBWeb; Data Source = LAPTOP-22L160U3\SQLEXPRESS;");
                SqlCommand cmd = new SqlCommand();
                string GetDetails = "Select * from Organization where OrgEmail='" + LogEmail.Text + "' and password ='" + LogPass.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(GetDetails,con);
                DataTable dt = new DataTable(); 
                adapter.Fill(dt);
                if(dt.Rows.Count == 1)
                {
                    AddProduct form = new AddProduct();
                    this.Hide();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Login Credential Mismatch");
                }

            }
          

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {   //login Email
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
           // logIn.
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Go to register button
            
            frmRegistration form = new frmRegistration();
            form.Show();
        }
    }
}
