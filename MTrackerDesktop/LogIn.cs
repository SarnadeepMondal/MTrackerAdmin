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
using System.Text.RegularExpressions;

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
            if(remember.Checked==true)
            {
                Properties.Settings.Default.UserName = LogEmail.Text;
                Properties.Settings.Default.Password = LogPass.Text;
                Properties.Settings.Default.Save();
            }
            if(remember.Checked==false)
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }

            if (IsValidEmail(LogEmail.Text))
            {
                SqlConnection con = new SqlConnection(@"Persist Security Info = False; User ID = sa; Password = 7101; Initial Catalog = MTrackerDBWeb; Data Source = LAPTOP-22L160U3\SQLEXPRESS;");
                SqlCommand cmd = new SqlCommand();
                string GetDetails = "Select * from Organization where OrgEmail='" + LogEmail.Text + "' and password ='" + LogPass.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(GetDetails, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count == 1)
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
            else
            {
                MessageBox.Show("Invalid Username. Please try with valid user !");
            }

            }
          

        bool IsValidEmail(string strIn)
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void LogIn_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.UserName != String.Empty)
            {
                LogEmail.Text = Properties.Settings.Default.UserName;
                LogPass.Text = Properties.Settings.Default.Password;
            }
        }
    }
}
