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
            SqlConnection con = new SqlConnection(@"Persist Security Info = False; User ID = sa; Password = 7101; Initial Catalog = MTrackerDBWeb; Data Source = LAPTOP-22L160U3\SQLEXPRESS;");
            SqlCommand cmd = new SqlCommand("Select * from AddProduct", con);
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
    }
}
