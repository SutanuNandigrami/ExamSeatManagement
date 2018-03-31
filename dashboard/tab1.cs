using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace dashboard
{
    public partial class tab1 : UserControl
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");


        private static tab1 _instance;

        public static tab1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new tab1();
                return _instance;
            }
        }
        public tab1()
        {
            InitializeComponent();
            blankError.Text = "";
            statuslbl.Text = "";
        }

        private void addroombtn_Click(object sender, EventArgs e)
        {
            blankError.Text = "";
            if (Textbox1.Text != null && Textbox2.Text != null && Textbox3.Text != null && Textbox4.Text != null)
            {
                try
                {
                    con.Open();
                    string query = "insert into Room values('" + int.Parse(Textbox1.Text) + "','" + Textbox2.Text + "','" + int.Parse(Textbox3.Text) + "','" + int.Parse(Textbox4.Text) + "')";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    statuslbl.ForeColor = System.Drawing.Color.White;
                    statuslbl.Text = "INSERTION SUCCESSFULL";
                }
                catch
                {
                    statuslbl.ForeColor = System.Drawing.Color.Red;
                    statuslbl.Text = "Duplicate Entry!!";
                }

                finally
                {
                    con.Close();

                }
            }
            else
            {
                blankError.ForeColor = Color.Red;
                blankError.Text = "FILL ALL THE FIELDS!!";
            }
        }
    }
}
