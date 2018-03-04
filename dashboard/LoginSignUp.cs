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
using System.Data.SqlClient;

namespace dashboard
{
    public partial class LoginSignUp : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");

        public LoginSignUp()
        {
            InitializeComponent();
            panel1.Visible = false;
            
        }
        public static class LoginInfo
        {
            public static string UserId;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            STextbox1.Text = "";
            STextbox2.Text = "";
            STextbox3.Text = "";
            STextbox4.Text = "";
            STextbox5.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Textbox1.Text = "";
            Textbox2.Text = "";
        }

        private void loginbtn_Click(object sender, EventArgs e)
        { 

            if (Textbox1.Text != "User Name" && Textbox2.Text != "Password")
            {
                Textbox1.LineIdleColor=System.Drawing.Color.FromArgb(255, 125, 0);
                Textbox2.LineIdleColor=System.Drawing.Color.FromArgb(255, 125, 0);
                try
                {

                    con.Open();

                    string query = "select * from Account where Email = '" + Textbox1.Text + "'and Password ='" + Textbox2.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);



                    if (dt.Rows.Count > 0)
                    {
                        this.Hide();

                        LoginInfo.UserId = Textbox1.Text;
                        MessageBox.Show("Successfull Login");
                        Dashboard a = new Dashboard();
                        a.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invalid UserName or Password!!");
                    }
                    con.Close();


                }

                catch (Exception)
                {

                    MessageBox.Show("Problem in Code!!");
                }
            }
            else
            {
                Textbox1.ForeColor = System.Drawing.Color.Red;
                Textbox2.ForeColor = System.Drawing.Color.Red;

            }
            

        }

        private void signup_Click(object sender, EventArgs e)
        {
            if (STextbox1 != null && STextbox2 != null && STextbox3 != null)
            {
                STextbox1.LineIdleColor = System.Drawing.Color.FromArgb(255, 125, 0);
                STextbox2.LineIdleColor = System.Drawing.Color.FromArgb(255, 125, 0);
                STextbox3.LineIdleColor = System.Drawing.Color.FromArgb(255, 125, 0);

                if (STextbox4.Text == STextbox5.Text)
                {
                    STextbox4.LineIdleColor = System.Drawing.Color.FromArgb(255, 125, 0);
                    STextbox5.LineIdleColor = System.Drawing.Color.FromArgb(255, 125, 0);

                    if (check.Checked == true)
                    {
                        term.ForeColor = System.Drawing.Color.FromArgb(255,125,0);
                        panel1.Visible = false;
                        try
                        {
                            con.Open();
                            string query = "insert into Account values('" + STextbox3.Text + "','" + STextbox1.Text + "','" + STextbox2.Text + "','" + STextbox4.Text + "')";
                            SqlDataAdapter sda = new SqlDataAdapter(query, con);
                            sda.SelectCommand.ExecuteNonQuery();
                            MessageBox.Show("Inserted");
                            con.Close();

                        }
                        catch (Exception k)
                        {

                            MessageBox.Show(k.ToString());
                        }
                    }
                    else
                        term.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    STextbox4.LineIdleColor = System.Drawing.Color.Red;
                    STextbox5.LineIdleColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                STextbox1.LineIdleColor = System.Drawing.Color.Red;
                STextbox2.LineIdleColor = System.Drawing.Color.Red;
                STextbox3.LineIdleColor = System.Drawing.Color.Red;


            }

        }
    }
}
