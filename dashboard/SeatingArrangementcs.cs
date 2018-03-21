using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace dashboard
{
    public partial class SeatingArrangementcs : Form
    {
        int ColNo,cap, BenchCapasity;
        string PaperCode="",RoomNo="",P="";
        string Loc="", capasity="",Sem="",Dept="",Subject="",RollS="",RollE="";


      
        public SeatingArrangementcs()
        {
            InitializeComponent();
            this.AutoScroll = true;
            panel.Visible = true;
            
            arrange();

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

        void arrange()
        {
            getData();
            getOtherRows(RoomNo);
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con.Open();
            string query = "select RegNo,UnivRollNo,Name,Stream from Student where Sem='" + Sem + "' and Stream='" + Dept + "' and (HonsPaper='" + Subject + "' or Pass1='" + Subject + "' or Pass2='" + Subject + "') ORDER BY RegNo ASC";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            int pointer = 1;
            DesignMatrix(BenchCapasity);
            try
            {
                while (dr.Read())
                {
                    NewTextBox(pointer).Text = (dr[0].ToString()) + Environment.NewLine + (dr[1].ToString()) + Environment.NewLine + (dr[2].ToString()) + Environment.NewLine + (dr[3].ToString()) + Environment.NewLine + (Subject) + Environment.NewLine + (Sem);
                    pointer++;
                }

                MessageBox.Show("Arrangement Completed!!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


            con.Close();
        }

        void getData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con.Open();
            string query = "select PaperCode,Sem,Subject,Dept,RoomNo,RollS,RollE from AddPlan where A='" + 1.ToString()+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            
            try
            {
                while (dr.Read())
                {
                    PaperCode= dr.GetString(dr.GetOrdinal("PaperCode"));
                    Sem= dr.GetString(dr.GetOrdinal("Sem"));
                    Subject= dr.GetString(dr.GetOrdinal("Subject"));
                    Dept= dr.GetString(dr.GetOrdinal("Dept"));
                    RoomNo= dr.GetString(dr.GetOrdinal("RoomNo"));

                    RollS= dr.GetString(dr.GetOrdinal("RollS"));
                    RollE= dr.GetString(dr.GetOrdinal("RollE"));
                }

                P = PaperCode;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


            con.Close();
        }

        public System.Windows.Forms.TextBox NewTextBox(int i)
        {

            System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
            panel.Controls.Add(txt);
            //SetPadding(txt, new Padding(5, 5, 5, 5));

            String query = "select R,C from Design where Id='" + i + "'";
            SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");

            con2.Open();
            SqlCommand cmd = new SqlCommand(query, con2);
            SqlDataReader dr = cmd.ExecuteReader();
            int row = 0, col = 0;

            while (dr.Read())
            {
                row = int.Parse(dr[0].ToString());
                col = int.Parse(dr[1].ToString());
            }


            con2.Close();

            txt.Location = new Point(row, col);

            txt.Size = new System.Drawing.Size(285, 69);
            txt.Multiline = true;
            txt.ReadOnly = true;
            return txt;

        }

        public void DesignMatrix(int Lim)// room capasity
        {
            int R = 100, C = 130, n = 0, col = 0, lim = Lim, flag = 1;

            n = lim / ColNo;
            if (lim % n < n)
            {
                col = (lim / n) + 1;
            }

            for (int i = 1; i <= col; i++)
            {
                for (int j = 1; j <= n; j++)
                {

                    SaveD(R, C);
                    C = C + 100;
                    if (flag == lim)
                    {
                        break;
                    }
                    flag++;

                }
                C = 130;
                R = R + 400;
            }


        }

        private void SeatingArrangementcs_Load(object sender, EventArgs e)
        {

        }

        private void print_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        void getOtherRows(string rmn)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True;MultipleActiveResultSets=True");
            string query = "select Location,ColumnNo,BenchCapasity from Room where RoomNo='" + int.Parse(rmn) + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                
                ColNo = dr.GetInt32(dr.GetOrdinal("ColumnNo"));
                Loc = dr.GetString(dr.GetOrdinal("Location"));
                BenchCapasity = dr.GetInt32(dr.GetOrdinal("BenchCapasity"));

            }
            
        }

        public void SaveD(int R, int C)
        {
            SqlConnection con4 = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");

            String query = "insert into Design values('" + R + "','" + C + "')";
            con4.Open();
            SqlDataAdapter dAdop = new SqlDataAdapter(query, con4);
            dAdop.SelectCommand.ExecuteNonQuery();
            con4.Close();
        }

        private void clr_Click(object sender, EventArgs e)
        {
            eraseDesign();

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True;MultipleActiveResultSets=True");
            string query = "update AddPlan set A='" + 0.ToString() + "' where (PaperCode='" + P + "' )";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            this.Close();
        }

        
       
    }

}
