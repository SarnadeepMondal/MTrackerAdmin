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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertAddproduct();
        }
        private void InsertAddproduct()
        {
            SqlConnection con = new SqlConnection(@"Persist Security Info = False; User ID = sa; Password = 7101; Initial Catalog = MTrackerDBWeb; Data Source = LAPTOP-22L160U3\SQLEXPRESS;");
            SqlCommand cmd = new SqlCommand("AddProductInsert", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Item_Name", itmname.Text);
            cmd.Parameters.AddWithValue("@Item_Catagory", itmcata.Text);
            cmd.Parameters.AddWithValue("@Item_Description", itmdesc.Text);
            cmd.Parameters.AddWithValue("Date", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Item_Valuation", itmvaluation.Text);
            cmd.Parameters.AddWithValue("@Fund_Claim_Against_Item", fundclm.Text);
            cmd.Parameters.AddWithValue("@Interest_Amount", interestamnt.Text);
            cmd.Parameters.AddWithValue("@Expected_Settlement_Date", dateTimePicker2.Text);
            cmd.Parameters.AddWithValue("@Net_Forecust_of_Settlement_Amount", netsttlmntamnt.Text);
            cmd.Parameters.AddWithValue("@Owner_Name", ownername.Text);
            cmd.Parameters.AddWithValue("@Owner_Contact_No", ownercon.Text);
            cmd.Parameters.AddWithValue("@Owner_Address", owneradd.Text);
            cmd.Parameters.AddWithValue("@Owner_ID_Proof", owneridproof.Text);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i != 0)
            {
                MessageBox.Show("Data save succcessful");
                clearcode();
            }
            else
            {
                MessageBox.Show("Oops!! Error Occured");
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {

            clearcode();
        }
        private void clearcode()
        {
            ownername.Text = "";
            owneradd.Text = "";
            owneridproof.Text = "";
            ownercon.Text = "";
            itmname.Text = "";
            itmdesc.Text = "";
            itmcata.Text = "";
            itmvaluation.Text = "";
            netsttlmntamnt.Text = "";
            interestamnt.Text = "";
            fundclm.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
