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
    public partial class Update_Form : Form
    {
        public Update_Form()
        {
            InitializeComponent();
            
        }
        public Update_Form(string itemid, string itemname, string amount, string owner)
        {
            InitializeComponent();
            txtitmid.Text = itemid;
            txtItemName.Text = itemname;
            txtAmount.Text = amount;
            txtoOwnrname.Text = owner;
        }

        private void Update_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Persist Security Info = False; User ID = sa; Password = 7101; Initial Catalog = MTrackerDBWeb; Data Source = LAPTOP-22L160U3\SQLEXPRESS;");
            SqlCommand cmd = new SqlCommand("AddProductUpdate", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ItemID", txtitmid.Text);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i != 0)
            {
                MessageBox.Show("Updated succcessful");
                this.Close();   
                Update obj = new Update();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Oops!! Error Occured");
            }

        }
    }
}
