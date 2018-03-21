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
        int ColNo;
        string Loc;


        public PlanVar plan;
        public SeatingArrangementcs()
        {
            InitializeComponent();
           
            arrange();

        }

        public SeatingArrangementcs(PlanVar pv)
        {
            InitializeComponent();
            plan = pv;
           
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
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con.Open();
            string query = "select RegNo,UnivRollNo,Name,Stream from Student where Sem='" + plan.Sem + "' and Stream='" + plan.Dept + "' and (HonsPaper='" + plan.Subject + "' or Pass1='" + plan.Subject + "' or Pass2='" + plan.Subject + "') ORDER BY RegNo ASC";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            int pointer = 1;

            int m = plan.capasity;
            getOtherRows(plan.RoomNo);
            DesignMatrix(m);
            try
            {
                while (dr.Read())
                {
                    NewTextBox(pointer).Text = (dr[0].ToString()) + Environment.NewLine + (dr[1].ToString()) + Environment.NewLine + (dr[2].ToString()) + Environment.NewLine + (dr[3].ToString()) + Environment.NewLine + (plan.Subject);
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
        }
    }

}
