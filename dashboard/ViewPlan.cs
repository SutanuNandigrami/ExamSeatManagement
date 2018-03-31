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
        int PlanNo = 0;
        
        string PaperCode="", Sem="", Subject="", Dept="", Sem2 = "", Subject2 = "", Dept2 = "", RoomNo ="", RoomNo2 = "", Duration ="", RollS="", RollE="", RollS2 = "", RollE2 = "", PaperCode2 = "";
        DateTime Date=DateTime.Now.Date;

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

        void eraseArr()
        {
            SqlConnection con3 = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con3.Open();
            string query = "truncate table Arrangement ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con3);
            sda.SelectCommand.ExecuteNonQuery();
            con3.Close();
        }

        private void DataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            eraseArr();
            clr();

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True;MultipleActiveResultSets=True");
            con.Open();

            PlanNo = int.Parse(DataGrid.SelectedRows[0].Cells[0].Value.ToString());
            
            string query1 = "select * from AddPlan where PlanNo='" + PlanNo + "'";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while(dr1.Read())
            {
                //string Duration = dr1.GetString(dr1.GetOrdinal("Duration"));
                Sem = dr1.GetString(dr1.GetOrdinal("Sem"));
                 Dept = dr1.GetString(dr1.GetOrdinal("Dept"));
                 Subject = dr1.GetString(dr1.GetOrdinal("Subject"));
                 Sem2 = dr1.GetString(dr1.GetOrdinal("Sem2"));
                 Dept2 = dr1.GetString(dr1.GetOrdinal("Dept2"));
                 Subject2 = dr1.GetString(dr1.GetOrdinal("Subject2"));
                PaperCode = dr1.GetString(dr1.GetOrdinal("PaperCode"));
                PaperCode2 = dr1.GetString(dr1.GetOrdinal("PaperCode2"));
                RollS = dr1.GetString(dr1.GetOrdinal("RollS"));
                RollE = dr1.GetString(dr1.GetOrdinal("RollE"));
                RoomNo = dr1.GetString(dr1.GetOrdinal("RoomNo"));
                RollS2 = dr1.GetString(dr1.GetOrdinal("RollS2"));
                RollE2 = dr1.GetString(dr1.GetOrdinal("RollE2"));
                RoomNo2 = dr1.GetString(dr1.GetOrdinal("RoomNo2"));
                
            }
            con.Close();

            firstdeptadd();
            seconddeptadd();

            
            
            SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True;MultipleActiveResultSets=True");
            string query3 = "update AddPlan set A='" + 1.ToString() + "' where (PlanNo='" + PlanNo + "'  ) ";
            con2.Open();
            SqlCommand cmd2 = new SqlCommand(query3, con2);
            cmd2.ExecuteNonQuery();
            con2.Close();

            SeatingArrangementcs b = new SeatingArrangementcs();


            b.Show();

            
        }

        public void firstdeptadd()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True;MultipleActiveResultSets=True");
            con.Open();
            string query = "select RegNo,UnivRollNo,Name,Stream from Student where (Sem='" + Sem + "' and Stream='" + Dept + "' and (HonsPaper='" + Subject + "' or Pass1='" + Subject + "' or Pass2='" + Subject + "')) ORDER BY RegNo ASC";
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

                        String query2 = "insert into Arrangement (RegNo,UnivRollNo,Name,Stream,PaperCode,Subject,Sem,RollS,RollE,RoomNo,Duration,PaperCode2,Subject2,Sem2,RollS2,RollE2,RoomNo2,Dept2) values('" + RegNo + "','" + UnivRollNo + "','" + Name + "','" + Stream + "','" + PaperCode + "','" + Subject + "','" + Sem + "','" + RollS + "','" + RollE + "','" + RoomNo + "','" + Duration + "','" + PaperCode2 + "','" + Subject2 + "','" + Sem2 + "','" + RollS2 + "','" + RollE2 + "','" + RoomNo2 + "','" + Dept2 + "') ";
                        SqlDataAdapter dAdop = new SqlDataAdapter(query2, con);
                        dAdop.SelectCommand.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        // MessageBox.Show(k.ToString());
                        continue;
                    }
                }

                // MessageBox.Show("Insertion Completed!!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Outer Catch" + ex.ToString());
            }


            con.Close();
        }

        public void seconddeptadd()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True;MultipleActiveResultSets=True");
            con.Open();
            string query = "select RegNo,UnivRollNo,Name,Stream from Student where (Sem = '" + Sem2 + "' and Stream = '" + Dept2 + "' and(HonsPaper = '" + Subject2 + "' or Pass1 = '" + Subject2 + "' or Pass2 = '" + Subject2 + "')) ORDER BY RegNo ASC";
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

                        String query2 = "insert into Arrangement (RegNo,UnivRollNo,Name,Stream,PaperCode,Subject,Sem,RollS,RollE,RoomNo,Duration,PaperCode2,Subject2,Sem2,RollS2,RollE2,RoomNo2,Dept2) values('" + RegNo + "','" + UnivRollNo + "','" + Name + "','" + Stream + "','" + PaperCode + "','" + Subject + "','" + Sem + "','" + RollS + "','" + RollE + "','" + RoomNo + "','" + Duration + "','" + PaperCode2 + "','" + Subject2 + "','" + Sem2 + "','" + RollS2 + "','" + RollE2 + "','" + RoomNo2 + "','" + Dept2 + "') ";
                        SqlDataAdapter dAdop = new SqlDataAdapter(query2, con);
                        dAdop.SelectCommand.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        // MessageBox.Show(k.ToString());
                        continue;
                    }
                }

                // MessageBox.Show("Insertion Completed!!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Outer Catch" + ex.ToString());
            }


            con.Close();
        }

        void eraseDesign()
        {
            SqlConnection con3 = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con3.Open();
            string query = "truncate table Design ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con3);
            sda.SelectCommand.ExecuteNonQuery();
            con3.Close();
        }

        public void clr()
        {
            eraseDesign();

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True;MultipleActiveResultSets=True");
            string query = "update AddPlan set A='" + 0.ToString() + "' where (PlanNo='" + PlanNo + "' )";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

           
        }

        private void datepkr_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");

                con.Open();
                string query = "select * from AddPlan where Date='" + datepkr.Value.Date + "' ";
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

        private void PrntScheduleBtn_Click(object sender, EventArgs e)
        {

            ReportForm a = new ReportForm();
            a.ShowDialog();
            
        }

        
        private void ViewRoomArgBtn_Click(object sender, EventArgs e)
        {

            RoomArrangement b = new RoomArrangement();
            b.ShowDialog();
            eraseArr();
           
        }
    }
}
