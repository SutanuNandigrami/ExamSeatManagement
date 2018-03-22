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

       // public delegate void SetTextValueCallback(string str);
       // public SetTextValueCallback pp;

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

        private void DataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            eraseArr();

            PaperCode = DataGrid.SelectedRows[0].Cells[0].Value.ToString();
            Sem = DataGrid.SelectedRows[0].Cells[1].Value.ToString();
            Subject = DataGrid.SelectedRows[0].Cells[2].Value.ToString();
            Dept = DataGrid.SelectedRows[0].Cells[3].Value.ToString();
            RollS = DataGrid.SelectedRows[0].Cells[7].Value.ToString();
            RollE = DataGrid.SelectedRows[0].Cells[8].Value.ToString();
            RoomNo = DataGrid.SelectedRows[0].Cells[4].Value.ToString();
            Duration = DataGrid.SelectedRows[0].Cells[5].Value.ToString();

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True;MultipleActiveResultSets=True");
            con.Open();
            string query = "select RegNo,UnivRollNo,Name,Stream from Student where Sem='" + Sem + "' and Stream='" + Dept + "' and (HonsPaper='" + Subject + "' or Pass1='" + Subject + "' or Pass2='" + Subject + "') ORDER BY RegNo ASC";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            
            
            try
            {
                while (dr.Read())
                {
                    try
                    {
                        string RegNo = dr.GetString(dr.GetOrdinal("RegNo"));
                        string UnivRollNo = dr.GetString(dr.GetOrdinal("UnivRollNo"));
                        string Name = dr.GetString(dr.GetOrdinal("Name"));
                        string Stream = dr.GetString(dr.GetOrdinal("Stream"));

                        String query2 = "insert into Arrangement (RegNo,UnivRollNo,Name,Stream,PaperCode,Subject,Sem,RollS,RollE,RoomNo,Duration) values('" + RegNo + "','" + UnivRollNo + "','" + Name + "','" + Stream + "','" + PaperCode + "','" + Subject + "','"+Sem+"','"+RollS+"','"+RollE+"','"+RoomNo+"','"+Duration+"') ";
                        SqlDataAdapter dAdop = new SqlDataAdapter(query2, con);
                        dAdop.SelectCommand.ExecuteNonQuery();
                    }
                    catch (Exception )
                    {
                       
                        continue;
                    }
                }

                MessageBox.Show("Insertion Completed!!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Outer Catch"+ex.ToString());
            }


            con.Close();
        
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



        void eraseArr()
        {
            SqlConnection con3 = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con3.Open();
            string query = "truncate table Arrangement ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con3);
            sda.SelectCommand.ExecuteNonQuery();
            con3.Close();
        }



        private void ViewRoomArgBtn_Click(object sender, EventArgs e)
        {

            RoomArrangement b = new RoomArrangement();
            b.ShowDialog();
            //eraseArr();
           
        }
    }
}
