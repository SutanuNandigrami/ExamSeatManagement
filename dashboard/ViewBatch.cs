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
    public partial class ViewBatch : UserControl
    {
        private static ViewBatch _instance;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");


        public static ViewBatch Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ViewBatch();
                return _instance;
            }
        }
        public ViewBatch()
        {
            InitializeComponent();
            
        }

        public void showall()
        {
            SqlConnection mcon = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            mcon.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Subject", mcon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGrid.DataSource = dt;
            mcon.Close();
            editpnl.Visible = false;
        }

        private void ViewBatch_Load(object sender, EventArgs e)
        {
            showall();
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
             Textbox1.Text = DataGrid.SelectedRows[0].Cells[0].Value.ToString();
             Textbox2.Text = DataGrid.SelectedRows[0].Cells[1].Value.ToString();
            Textbox3.Text = DataGrid.SelectedRows[0].Cells[2].Value.ToString();
            Textbox4.Text = DataGrid.SelectedRows[0].Cells[3].Value.ToString();

            editpnl.Visible = true;

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {
            editpnl.Visible = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update Subject set Subject='" + Textbox2.Text + "',Dept='"+ Textbox3.Text + "',sem='"+ Textbox4.Text + "' where PaperCode='" + Textbox1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            editpnl.Visible = false;
            showall();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "delete from Subject where PaperCode='" + Textbox1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            editpnl.Visible = false;
            showall();
        }

        private void viewallbtn_Click(object sender, EventArgs e)
        {
            showall();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "select * from Subject where (PaperCode='" + searchbox.Text + "' or Subject='" + searchbox.Text + "' or Sem='" + searchbox.Text + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGrid.DataSource = dt;
                searchbox.Text = "";
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
