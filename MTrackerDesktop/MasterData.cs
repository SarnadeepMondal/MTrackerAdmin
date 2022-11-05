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
    public partial class MasterData : Form
    {
        public MasterData()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MasterData_Load(object sender, EventArgs e)
        {
            //form load
            FetchDetails();
        }
        public void FetchDetails()
        {
            SqlConnection con = new SqlConnection(@"Persist Security Info = False; User ID = sa; Password = 7101; Initial Catalog = MTrackerDBWeb; Data Source = LAPTOP-22L160U3\SQLEXPRESS;");
            SqlCommand cmd = new SqlCommand("Select * from AddProduct Where Status=0", con);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   //close button
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //add product button
            AddProduct form = new AddProduct();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn inw = new LogIn();
            inw.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Persist Security Info = False; User ID = sa; Password = 7101; Initial Catalog = MTrackerDBWeb; Data Source = LAPTOP-22L160U3\SQLEXPRESS;");
            SqlCommand cmd = new SqlCommand("Select * from AddProduct where Item_Name='" + txtSearch.Text + "' or Item_Catagory='" + txtSearch.Text + "' ", con);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();


            adapter.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FetchDetails();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Search_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Search", Search);
        }

        private void update_Click(object sender, EventArgs e)
        {
           
            Update obj = new Update();
            obj.ShowDialog();
        }
    }
}
