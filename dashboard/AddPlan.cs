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
    public partial class AddPlan : UserControl
    {
        private static AddPlan _instance;

        public static AddPlan Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddPlan();
                return _instance;
            }
        }
        public AddPlan()
        {
            InitializeComponent();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            deptdrp.Clear();
            batchdrp.Clear();
            roomdrp.Clear();
            durdrp.Clear();
            fillDept();
            fillBatch();
            fillDur();
            fillRoom();
            
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

        void fillBatch()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con.Open();
            string query = "select * from Batch";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            try
            {
                while (dr.Read())
                {
                    string BatchName = dr.GetString(dr.GetOrdinal("BatchName"));
                    batchdrp.AddItem(BatchName);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            con.Close();
        }

        void fillDur()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con.Open();
            string query = "select * from Duration";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            try
            {
                while (dr.Read())
                {
                    string Duration = dr.GetString(dr.GetOrdinal("Duration"));
                    durdrp.AddItem(Duration);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            con.Close();
        }

        void fillRoom()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con.Open();
            string query = "select * from Room";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            try
            {
                while (dr.Read())
                {
                    int RoomNo = dr.GetInt32(dr.GetOrdinal("RoomNo"));
                    int Capasity = dr.GetInt32(dr.GetOrdinal("BenchCapasity"));
                    roomdrp.AddItem("Room No: "+RoomNo.ToString() +"  |  "+"Seats: "+ Capasity.ToString());
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            con.Close();
        }
    }
}
