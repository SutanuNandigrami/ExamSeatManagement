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
using CrystalDecisions.CrystalReports.Engine;

namespace dashboard
{
    public partial class ViewPlan : UserControl
    {
        private static ViewPlan _instance;


        public static ViewPlan Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ViewPlan();
                return _instance;
            }
        }
        public ViewPlan()
        {
            InitializeComponent();
            ViewRoomArgBtn.selected = false;
        }

        public void showall()
        {
            SqlConnection mcon = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            mcon.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from AddPlan", mcon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGrid.DataSource = dt;
            mcon.Close();
            
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");

                con.Open();
                string query = "select * from AddPlan where PaperCode='" + searchBox.Text + "' or Sem='" + searchBox.Text + "' or Subject='" + searchBox.Text + "' or Dept='" + searchBox.Text + "' or RoomNo='" + searchBox.Text + "' or Duration='" + searchBox.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGrid.DataSource = dt;
                searchBox.Text = "";
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ViewPlan_Load(object sender, EventArgs e)
        {
            showall();
        }

        private void viewallbtn_Click(object sender, EventArgs e)
        {
            showall();
        }

        private void dtpkr_onValueChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");

                con.Open();
                string query = "select * from AddPlan where Date='"+dtpkr.Value.Date+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGrid.DataSource = dt;
                searchBox.Text = "";
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void PrntScheduleBtn_Click(object sender, EventArgs e)
        {

            ReportForm a = new ReportForm();
            a.ShowDialog();
            
        }

        private void DataGrid_MouseClick(object sender, MouseEventArgs e)
        {
            //ViewRoomArgBtn.selected = true;
            SeatingArrangementcs b = new SeatingArrangementcs();
            b.ShowDialog();
        }
    }
}
