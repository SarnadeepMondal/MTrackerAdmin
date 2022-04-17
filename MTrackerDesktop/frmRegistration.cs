using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if (txtOrgPass.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Password", "Required Feild Validation");
                return;
            }
            if (txtOrgAdd.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Address", "Required Feild Validation");
                return;
            }
            if (drpOrgCity.Text == String.Empty)
            {
                MessageBox.Show("Please Select City", "Required Feild Validation");
                return;
            }
            if (drpOrgState.Text == String.Empty)
            {
                MessageBox.Show("Please Select State", "Required Feild Validation");
                return;
            }
            if (txtOrgZip.Text == String.Empty)
            {
                MessageBox.Show("Please Enter ZIP", "Required Feild Validation");
                return;
            }
            if (txtOrgGst.Text == String.Empty)
            {
                MessageBox.Show("Please Enter GST", "Required Feild Validation");
                return;
            }

            //Password and Confirm pass check
            if (txtOrgPass.Text != txtOrgConPass.Text)
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
            txtOrgAdd.Text = "";
            txtOrgEmail.Text = "";
            txtOrgPass.Text = "";
            txtOrgConPass.Text = "";
            txtOrgCon.Text = "";
            drpOrgState.Text = "";
            drpOrgCity.Text = "";
            txtOrgZip.Text = "";
            txtOrgGst.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ValidationnControl();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            clearcode();
        }

        private void drpOrgState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
