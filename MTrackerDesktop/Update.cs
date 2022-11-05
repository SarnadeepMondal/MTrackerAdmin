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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        

        private void Update_Load(object sender, EventArgs e)
        {
            FetchDetails();
        }
        public void FetchDetails()
        {
            SqlConnection con = new SqlConnection(@"Persist Security Info = False; User ID = sa; Password = 7101; Initial Catalog = MTrackerDBWeb; Data Source = LAPTOP-22L160U3\SQLEXPRESS;");
            SqlCommand cmd = new SqlCommand("Select ItemID ,Item_Name ,Net_Forecust_of_Settlement_Amount,Owner_Name  from AddProduct Where Status=0", con);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            dataGridView2.DataSource = dt;
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string itemid = this.dataGridView2.CurrentRow.Cells[0].Value.ToString();
            string itemname = this.dataGridView2.CurrentRow.Cells[1].Value.ToString();
            string amount = this.dataGridView2.CurrentRow.Cells[2].Value.ToString();
            string owner = this.dataGridView2.CurrentRow.Cells[3].Value.ToString();
            Update_Form obj=new Update_Form(itemid,itemname,amount,owner);
            
            obj.ShowDialog();
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
