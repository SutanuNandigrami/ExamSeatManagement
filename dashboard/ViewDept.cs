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
    public partial class ViewDept : UserControl
    {
        private static ViewDept _instance;
        
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");


        public static ViewDept Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ViewDept();
                return _instance;
            }
        }
        public ViewDept()
        {
            InitializeComponent();
            //editpnl.Visible = false;
            Display();
            
        }
        

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {
            editpnl.Visible = false;
        }

        private void DataGrid_MouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            editpnl.Visible = true;

            Textbox1.Text = DataGrid.SelectedRows[0].Cells[0].Value.ToString();
            Textbox2.Text = DataGrid.SelectedRows[0].Cells[1].Value.ToString();
            
        }
        
        private void ViewDept_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Dept", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGrid.DataSource = dt;
            con.Close();
            editpnl.Visible = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            
            string query = "update Dept set DeptName='" + Textbox2.Text + "' where DeptId='" + Textbox1.Text + "'";
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
            string query = "delete from Dept where DeptId='" + Textbox1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            Blank();
            editpnl.Visible = false;
            Display();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "select * from Dept where DeptId='" + searchbox.Text + "' or DeptName='" + searchbox.Text + "' ";
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

        private void viewallbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Dept", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGrid.DataSource = dt;
            con.Close();
            editpnl.Visible = false;
        }
        public void Display()
        {
            con.Open();
            string query = "select * from Dept";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataGrid.DataSource = dt;
            con.Close();
        }

        public void Blank()
        {
            Textbox1.Text = "";
            Textbox2.Text = "";
           
            
        }
    }
}
