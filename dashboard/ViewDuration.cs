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
    public partial class ViewDuration : UserControl
    {
        private static ViewDuration _instance;

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");

        public static ViewDuration Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ViewDuration();
                return _instance;
            }
        }
        public ViewDuration()
        {
            InitializeComponent();
        }

        private void ViewDuration_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Duration", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGrid.DataSource = dt;
            con.Close();
            editpnl.Visible = false;
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            editpnl.Visible = true;
            editpnl.Refresh();
            Textbox1.Text = DataGrid.SelectedRows[0].Cells[1].Value.ToString();
            Textbox2.Text = DataGrid.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {
            editpnl.Visible = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update Duration set Duration='" + Textbox1.Text + "'where Id='" + Textbox2.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            Blank();
            editpnl.Visible = false;
            Display();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "delete from Duration where Id='" + Textbox2.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            Blank();
            editpnl.Visible = false;
            Display();
        }

        public void Display()
        {
            con.Open();
            string query = "select * from Duration";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataGrid.DataSource = dt;
            con.Close();
        }

        public void Blank()
        {
            Textbox1.Text = "";
           

        }

        private void viewallbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Duration", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGrid.DataSource = dt;
            con.Close();
            editpnl.Visible = false;
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "select * from Duration where Duration='" + searchbox.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGrid.DataSource = dt;

                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
