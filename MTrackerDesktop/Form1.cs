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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Persist Security Info = False; User ID = sa; Password = 7101; Initial Catalog = MTrackerDBWeb; Data Source = LAPTOP - 22L160U3\\SQLEXPRESS;");
            SqlCommand cmd = new SqlCommand("OganizationInsert", con);
            cmd.Parameters.AddWithValue("@OrgName",txtOrgName.Text);
            cmd.Parameters.AddWithValue("@OrgEmail", txtOrgEmail.Text);
            cmd.Parameters.AddWithValue("@Password", txtPass.Text);
            cmd.Parameters.AddWithValue("@OrgContact", txtOrgCon.Text);
            cmd.Parameters.AddWithValue("@OrgAddress", txtAdd.Text);
            cmd.Parameters.AddWithValue("@GST", txtGst.Text);
            cmd.Parameters.AddWithValue("@State", comState.Text);
            cmd.Parameters.AddWithValue("@city", comCity.Text);
            cmd.Parameters.AddWithValue("@ZIP", txtZip.Text);
            con.Open();
            int i= cmd.ExecuteNonQuery();
            con.Close();
            if (i!=0)
            {
                MessageBox.Show("Data save succcessful");
            }
            else
            {
                MessageBox.Show("Oops!! Error Occured");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}