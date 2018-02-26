using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace dashboard
{
    public partial class LoginSignUp : Form
    {
        public LoginSignUp()
        {
            InitializeComponent();
            panel1.Visible = false;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Successfull Login");
            Dashboard a = new Dashboard();
            a.ShowDialog();

        }

        private void signup_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        
        
    }
}
