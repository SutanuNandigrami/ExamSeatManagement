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
    public partial class AddSem : UserControl
    {
        
        private static AddSem _instance;

        public static AddSem Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddSem();
                return _instance;
            }
        }
        public AddSem()
        {
            InitializeComponent();
            fillDept();
        }

        void fillDept()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con.Open();
            string query = "select * from Dept";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            try
            {
                while (dr.Read())
                {
                    string DeptName = dr.GetString(dr.GetOrdinal("DeptName"));
                    deptdrp.AddItem(DeptName);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            con.Close();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            deptdrp.Clear();
            fillDept();
        }

        private void addBatchbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            
            try
            {
                con.Open();
                string query = "insert into Batch values('" + Textbox1.Text + "','" + deptdrp.selectedValue + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                statuslbl.ForeColor = System.Drawing.Color.White;
                statuslbl.Text = "Batch Added Successfully!!";
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
