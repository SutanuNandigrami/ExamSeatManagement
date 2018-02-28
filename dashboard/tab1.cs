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
        }

        private void addroombtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into Room values('" + Textbox1.Text + "','" + Textbox2.Text + "','" + Textbox3.Text + "','" + Textbox4.Text + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                statuslbl.ForeColor = System.Drawing.Color.White;
                statuslbl.Text="INSERTION SUCCESSFULL";
            }
            catch
            {
                statuslbl.ForeColor = System.Drawing.Color.Red;
                statuslbl.Text="Duplicate Entry!!";
            }

            finally
            {
                con.Close();
                
            }
        }
    }
}
