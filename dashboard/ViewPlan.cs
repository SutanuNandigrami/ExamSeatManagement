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
        int cap,capasity;
        
        string PaperCode="", Sem="", Subject="", Dept="", RoomNo="", Duration="", RollS="", RollE="",strDate;
        DateTime Date = DateTime.Now;

        public delegate void SetTextValueCallback(string str);
        public SetTextValueCallback pp;

        //public PlanVar pp { get; set; }
         

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

        private void DataGrid_MouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PaperCode = DataGrid.SelectedRows[0].Cells[0].Value.ToString();
            Sem = DataGrid.SelectedRows[0].Cells[1].Value.ToString();
            Subject = DataGrid.SelectedRows[0].Cells[2].Value.ToString();
            Dept = DataGrid.SelectedRows[0].Cells[3].Value.ToString();
            RoomNo = DataGrid.SelectedRows[0].Cells[4].Value.ToString();
            Duration = DataGrid.SelectedRows[0].Cells[5].Value.ToString();
            /*strDate = DataGrid.SelectedRows[0].Cells[6].Value.ToString() ;
            Date = DateTime.ParseExact(strDate, "dd/MM/YYYY", System.Globalization.CultureInfo.InvariantCulture);
             RollS = DataGrid.SelectedRows[0].Cells[7].Value.ToString(); 
             RollE = DataGrid.SelectedRows[0].Cells[8].Value.ToString(); */
            //capasity = MaxCap(RoomNo);

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True;MultipleActiveResultSets=True");
            string query = "update AddPlan set A='" + 1.ToString() + "' where (PaperCode='" + PaperCode + "' ) ";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            SeatingArrangementcs b = new SeatingArrangementcs();


            b.Show();
        }

        public ViewPlan()
        {
            InitializeComponent();
            ViewRoomArgBtn.selected = false;
            showall();
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

        

       

       

        private void ViewRoomArgBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
