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
            statuslbl.Text = "";

        }

        private void addDeptbtn_Click(object sender, EventArgs e)
        {
            statuslbl.Text = "";
            if (Textbox1.Text != null && Textbox2.Text != null)
            {
                try
                {
                    con.Open();
                    string query = "insert into Dept values('" + Textbox2.Text + "','" + Textbox1.Text + "','"+1.ToString()+"')";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.SelectCommand.ExecuteNonQuery();
                    
                    statuslbl.ForeColor = System.Drawing.Color.White;
                    statuslbl.Text = "Department Added Successfully.";
                }
                catch (Exception k)
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

            else
                blankError.Text = "FILL ALL THE FIELDS!!";
        }
    }
}
