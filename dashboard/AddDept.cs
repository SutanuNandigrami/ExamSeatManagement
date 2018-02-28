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
    public partial class AddDept : UserControl
    {
        string s;
        private static AddDept _instance;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");


        public static AddDept Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddDept();
                return _instance;
            }
        }
        public AddDept()
        {
            InitializeComponent();
        }

        private void addDeptbtn_Click(object sender, EventArgs e)
        {
            try
            {
                 s=("UnSpecified").ToString();
                con.Open();
                if (radioButton1.Checked == true)
                    s = "Active";
                else if (radioButton2.Checked == true)
                    s = "Inactive";
                string query = "insert into Dept values('" + Textbox2.Text + "','" + Textbox1.Text + "','" + s + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                statuslbl.ForeColor = System.Drawing.Color.White;
                statuslbl.Text = "INSERTION SUCCESSFULL";
            }
            catch(Exception k)
            {
                MessageBox.Show(k.ToString());
                statuslbl.ForeColor = System.Drawing.Color.Red;
                statuslbl.Text = "Duplicate Entry!!";
            }

            finally
            {
                con.Close();

            }
        }
    }
}
