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
    public partial class Duration : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");

        private static Duration _instance;

        public static Duration Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Duration();
                return _instance;
            }
        }
        public Duration()
        {
            InitializeComponent();
        }

        private void addDurbtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into Duration(Duration) values('" + Textbox1.Text + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                statuslbl.ForeColor = System.Drawing.Color.White;
                statuslbl.Text = "Duration Added Successfully.";
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
    }
}
