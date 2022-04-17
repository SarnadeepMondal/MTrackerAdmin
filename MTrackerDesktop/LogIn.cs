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
            //Login Button
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(textBox1, "MTrackerDesktop Demo app");
                MessageBox.Show(textBox3, "MTrackerDesktop Demo app");
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {   //login Email
            if(string.IsNullOrWhiteSpace(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProviderApp.SetError(textBox1,"Email is Required");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
           // logIn.
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                e.Cancel = true;
                textBox3.Focus();
                errorProviderApp.SetError(textBox3, "Password is Required");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Go to register button
            frmRegistration form = new frmRegistration();
            form.Show();
        }
    }
}
