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
    public partial class ViewRoom : UserControl
    {
        private static ViewRoom _instance;

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");

        public static ViewRoom Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ViewRoom();
                return _instance;
            }
        }
        public ViewRoom()
        {
            InitializeComponent();
        }

        private void ViewRoom_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Room", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGrid.DataSource = dt;
            con.Close();
            editpnl.Visible = false;
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            editpnl.Visible = true;

            textbox1.Text = DataGrid.SelectedRows[0].Cells[0].Value.ToString();
            textbox2.Text = DataGrid.SelectedRows[0].Cells[1].Value.ToString();
            textbox3.Text = DataGrid.SelectedRows[0].Cells[2].Value.ToString();
            textbox4.Text = DataGrid.SelectedRows[0].Cells[3].Value.ToString();
          
        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {
            editpnl.Visible = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "update Room set Location='" + textbox2.Text + "',ColumnNo='" + textbox3.Text + "',BenchCapasity='" + textbox4.Text + "' where RoomNo='" + textbox1.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                Blank();
                editpnl.Visible = false;
                Display();
            }
            catch (Exception)
            {

                MessageBox.Show("Duplicate Entry");
            }
           
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "delete from Room where RoomNo='" + textbox1.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                Blank();
                editpnl.Visible = false;
                Display();
            }
            catch (Exception)
            {

                MessageBox.Show("Record Not Found ");;
            }
            
        }

        public void Display()
        {
            con.Open();
            string query = "select * from Room";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataGrid.DataSource = dt;
            con.Close();
        }

        public void Blank()
        {
            textbox1.Text = "";
            textbox2.Text = "";
            textbox3.Text = "";
            textbox4.Text = "";
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "select * from Room where RoomNo='" + int.Parse(searchBox.Text) + "'";
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
            string query = "select * from Room";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataGrid.DataSource = dt;
            con.Close();
        }
    }

}
   

