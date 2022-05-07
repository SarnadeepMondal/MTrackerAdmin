using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTrackerDesktop
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }
        private void drpOrgCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ValidationnControl()
        {
            //Validation for winfrom example

            if (txtOrgName.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Org Name", "Required feild Validation");
                return;
            }
            if (txtOrgCon.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Contact No.", "Required Feild Validation");
                return;
            }
            if (txtOrgEmail.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Email", "Required Feild Validation");
                return;
            }
            if (txtPass.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Password", "Required Feild Validation");
                return;
            }
            if (txtAdd.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Address", "Required Feild Validation");
                return;
            }
            if (comCity.Text == String.Empty)
            {
                MessageBox.Show("Please Select City", "Required Feild Validation");
                return;
            }
            if (comState.Text == String.Empty)
            {
                MessageBox.Show("Please Select State", "Required Feild Validation");
                return;
            }
            if (txtZip.Text == String.Empty)
            {
                MessageBox.Show("Please Enter ZIP", "Required Feild Validation");
                return;
            }
            if (txtGst.Text == String.Empty)
            {
                MessageBox.Show("Please Enter GST", "Required Feild Validation");
                return;
            }

            //Password and Confirm pass check
            if (txtPass.Text != txtOrgConPass.Text)
            {
                MessageBox.Show("Password mismatched", "Required Feild Validation");
                return;
            }
            else
            {
                //
            }
        }
        private void clearcode()
        {
            txtOrgName.Text = "";
            txtAdd.Text = "";
            txtOrgEmail.Text = "";
            txtPass.Text = "";
            txtOrgConPass.Text = "";
            txtOrgCon.Text = "";
            comState.Text = "";
            comCity.Text = "";
            txtZip.Text = "";
            txtGst.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ValidationnControl();

            SqlConnection con = new SqlConnection(@"Persist Security Info = False; User ID = sa; Password = 7101; Initial Catalog = MTrackerDBWeb; Data Source = LAPTOP-22L160U3\SQLEXPRESS;");
            SqlCommand cmd = new SqlCommand("OganizationInsert", con);
            cmd.Parameters.AddWithValue("@orgName", txtOrgName.Text);
            cmd.Parameters.AddWithValue("@orgEmail", txtOrgEmail.Text);
            cmd.Parameters.AddWithValue("@password", txtPass.Text);
            cmd.Parameters.AddWithValue("@orgContact", txtOrgCon.Text);
            cmd.Parameters.AddWithValue("@orgAddress", txtAdd.Text);
            cmd.Parameters.AddWithValue("@gst", txtGst.Text);
            cmd.Parameters.AddWithValue("@state", comState.Text);
            cmd.Parameters.AddWithValue("@city", comCity.Text);
            cmd.Parameters.AddWithValue("@zip", txtZip.Text);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i != 0)
            {
                MessageBox.Show("Data save succcessful");
            }
            else
            {
                MessageBox.Show("Oops!! Error Occured");
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            clearcode();
        }

        private void drpOrgState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
