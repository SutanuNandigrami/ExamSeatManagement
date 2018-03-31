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
        int ColNo, ColNo2, cap, BenchCapasity, Sitting, BenchCapasity2;
        string PaperCode = "", RoomNo = "", P = "";
        string Loc = "", Loc2 = "", capasity = "", Sem = "", Dept = "", Subject = "", RollS = "", RollE = "", Sem2 = "", Dept2 = "", Subject2 = "", RollS2 = "", RollE2 = "", PaperCode2 = "", RoomNo2 = "", Duration = "";
        int[] a = new int[200];
        int[] b = new int[200];

        private void button1_Click(object sender, EventArgs e)
        {
            eraseDesign();
            label4.Visible = false;
            a = new int[200];
            b = new int[200];
            getData();
            RoomFunc();
        }

        string Date;


        public SeatingArrangementcs()
        {
            InitializeComponent();
            this.AutoScroll = true;
            panel.Visible = true;
            label4.Visible = false;
            getData();
            RoomFunc();
            a = new int[200];
            b = new int[200];
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

        void RoomFunc()
        {
            if (RoomNo != null && RoomNo2 != "0")  //DOUBLE ROOM CASE
            {
                if (Dept != null && Dept2 != "0")  //DOUBLE DEPT CASE
                {
                    if (Sitting == 0)  // SINGLE SITTING
                    {
                        getOtherRows_R2(RoomNo, RoomNo2);

                        DesignMatrix_S1R1(BenchCapasity);
                        DesignMatrix_S1R2(BenchCapasity2);

                        Arrange_D2S1();
                    }
                    else if (Sitting == 1) // DOUBLE SITTING
                    {
                        MessageBox.Show("DDD");
                        getOtherRows_R2(RoomNo, RoomNo2);
                        DesignMatrix_S2R1(BenchCapasity);
                        DesignMatrix_S2R2(BenchCapasity2);
                        Arrange_D2S2();

                    }
                }
                else if (Dept != null && Dept2 == "0") //SINGLE DEPT CASE
                {
                    if (Sitting == 0)  // SINGLE SITTING
                    {
                        MessageBox.Show("hello;");
                        getOtherRows_R2(RoomNo, RoomNo2);

                        DesignMatrix_S1R1(BenchCapasity);
                        DesignMatrix_S1R2(BenchCapasity2);

                        Arrange_D1();

                    }
                    else if (Sitting == 1) // DOUBLE SITTING
                    {
                        getOtherRows_R2(RoomNo, RoomNo2);
                        DesignMatrix_S2R1(BenchCapasity);
                        DesignMatrix_S2R2(BenchCapasity2);
                        Arrange_D1();
                    }
                }
            }
            else if (RoomNo != null && RoomNo2 == "0") //SINGLE ROOM CASE
            {
                if (Dept != null && Dept2 != "0")  //DOUBLE DEPT CASE
                {
                    if (Sitting == 0)  // SINGLE SITTING
                    {
                        label2.Text = RoomNo;
                        getOtherRows_R1(rmn: RoomNo);
                        DesignMatrix_S1R1(BenchCapasity);
                        Arrange_D2S1();
                    }
                    else if (Sitting == 1) // DOUBLE SITTING
                    {
                        label2.Text = RoomNo;
                        getOtherRows_R1(rmn: RoomNo);
                        DesignMatrix_S2R1(BenchCapasity);
                        Arrange_D2S2();
                    }
                }
                else if (Dept != null && Dept2 == "0") //SINGLE DEPT CASE
                {
                    if (Sitting == 0)  // SINGLE SITTING
                    {

                        label2.Text = RoomNo;
                        getOtherRows_R1(rmn: RoomNo);
                        DesignMatrix_S1R1(BenchCapasity);
                        Arrange_D1();
                    }
                    else if (Sitting == 1) // DOUBLE SITTING
                    {
                        label2.Text = RoomNo;
                        getOtherRows_R1(rmn: RoomNo);
                        DesignMatrix_S2R1(BenchCapasity);
                        Arrange_D1();
                    }
                }
            }
        }

        void Arrange_D1()
        {


            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con.Open();
            string query = "select RegNo,UnivRollNo,Name,Stream from Student where Sem='" + Sem + "' and Stream='" + Dept + "' and (HonsPaper='" + Subject + "' or Pass1='" + Subject + "' or Pass2='" + Subject + "') ORDER BY RegNo ASC";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            int pointer = 1;

            try
            {
                while (dr.Read())
                {
                    NewTextBox(pointer).Text = (dr[0].ToString());
                    pointer++;
                }

                //for any blank box
                while (pointer <= BenchCapasity)
                {
                    NewTextBox(pointer);
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

        void Arrange_D2S1()
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con.Open();
            string query = "select RegNo,UnivRollNo,Name,Stream from Student where Sem='" + Sem + "' and Stream='" + Dept + "' and (HonsPaper='" + Subject + "' or Pass1='" + Subject + "' or Pass2='" + Subject + "') ORDER BY RegNo ASC";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            int pointer = 1;

            try
            {
                while (dr.Read())
                {
                    NewTextBox(pointer).Text = (dr[0].ToString());
                    pointer++;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            con.Close();
            //-----------------------------------------------------------//

            con.Open();
            string query2 = "select RegNo,UnivRollNo,Name,Stream from Student where Sem='" + Sem2 + "' and Stream='" + Dept2 + "' and (HonsPaper='" + Subject2 + "' or Pass1='" + Subject2 + "' or Pass2='" + Subject2 + "') ORDER BY RegNo ASC";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            //int pointer = 1;

            try
            {
                while (dr2.Read())
                {
                    NewTextBox(pointer).Text = (dr2[0].ToString());
                    pointer++;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            con.Close();

            //for any blank box
            while (pointer <= BenchCapasity)
            {
                NewTextBox(pointer);
                pointer++;
            }

        }

        void Arrange_D2S2()
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con.Open();
            string query = "select RegNo,UnivRollNo,Name,Stream from Student where Sem='" + Sem + "' and Stream='" + Dept + "' and (HonsPaper='" + Subject + "' or Pass1='" + Subject + "' or Pass2='" + Subject + "') ORDER BY RegNo ASC";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            //ROOM 1

            int pointer = 1;
            int c = BenchCapasity * 2;
            int n = BenchCapasity / ColNo;
            int flag = 1;
            int k = 1;
           

            while (pointer <= c)
            {
               
                if (pointer > n * flag)
                {
                    pointer = pointer + n;
                    flag = flag + 2;
                    continue;
                }
                a[k] = pointer;
               // MessageBox.Show("1st"+pointer.ToString());
                pointer++;
                k++;
                
                
            }
            //ROOM 2
            int pointer2 = c+1;
            int c2 = BenchCapasity2 * 2;
            int n2 = BenchCapasity2 / ColNo2;
            int flag2 = 1;
            int k2 = BenchCapasity+1;


            while (pointer2 <= c+c2)
            {

                if (pointer2 > c+(n2 * flag2))
                {
                    pointer2 = pointer2 + n2;
                    flag2 = flag2 + 2;
                    continue;
                }
                a[k2] = pointer2;
               // MessageBox.Show(pointer2.ToString());
                pointer2++;
                k2++;
            }

            //GETTING DATA
            try
            {
                k = 1;
               // k2 = 1;
                while (dr.Read())
                {
                    NewTextBox(a[k]).Text = (dr[0].ToString());
                    //NewTextBox(a[k]);

                    k++;

                   // NewTextBox(b[k2]).Text = (dr[0].ToString());
                    //NewTextBox(b[k]);

                   // k2++;
                }

                for (int i = 1; i <= (BenchCapasity ) + (BenchCapasity2 ); i++)
                {
                    if(a[i].Equals(null))
                       NewTextBox(i);
                }




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            con.Close();
            //-----------------------------------------------------------//

            con.Open();
            string query2 = "select RegNo,UnivRollNo,Name,Stream from Student where Sem='" + Sem2 + "' and Stream='" + Dept2 + "' and (HonsPaper='" + Subject2 + "' or Pass1='" + Subject2 + "' or Pass2='" + Subject2 + "') ORDER BY RegNo ASC";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            SqlDataReader dr2 = cmd2.ExecuteReader();


            //ROOM 1
             pointer  = 1;
            c = BenchCapasity * 2;
            n = BenchCapasity / ColNo;
            flag = 2;
            pointer = n + 1;
             k = 1;

            while (pointer <= c)
            {
               
                if (pointer > n * flag)
                {
                    pointer = pointer + n;
                    flag = flag + 2;
                    continue;
                }
                b[k] = pointer;
               // MessageBox.Show("3rd" + pointer.ToString());
                pointer++;
                k++;
            }

            //RoomNo2

            c2 = BenchCapasity2 * 2;
            n2 = BenchCapasity2 / ColNo2;
            flag2 = 2;
            pointer2 =c+ n2 + 1;
             k2 = BenchCapasity + 1;
            while (pointer2 <= c+c2)
            {

                if (pointer2 >c+ (n2 * flag2))
                {
                    pointer2 = pointer2 + n2;
                    flag2 = flag2 + 2;
                    continue;
                }
                b[k2] = pointer2;
               // MessageBox.Show("4th" + pointer2.ToString());
                pointer2++;
                k2++;
            }
            try
            {
                 k = 1;
                while (dr2.Read())
                {
                    NewTextBox(b[k]).Text = (dr2[0].ToString());
                    //NewTextBox(a[k]);

                    k++;
                }

                
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
            string query = "select * from AddPlan where A='" + 1.ToString()+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr1 = cmd.ExecuteReader();
            
            try
            {
                while (dr1.Read())
                {
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
                    //string Duration = dr1.GetString(dr1.GetOrdinal("Duration"));
                    Date = dr1.GetDateTime(dr1.GetOrdinal("Date")).ToShortDateString();
                    Sitting = dr1.GetInt32(dr1.GetOrdinal("Sitting"));
                }

                //label2.Text = RoomNo;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

           
            con.Close();
        }

        void getOtherRows_R1(string rmn)
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

        }   //SINGLE ROOM 

        void getOtherRows_R2(string rmn1, string rmn2)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True;MultipleActiveResultSets=True");
            string query = "select Location,ColumnNo,BenchCapasity from Room where RoomNo='" + int.Parse(rmn1) + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {

                ColNo = dr.GetInt32(dr.GetOrdinal("ColumnNo"));
                Loc = dr.GetString(dr.GetOrdinal("Location"));
                BenchCapasity = dr.GetInt32(dr.GetOrdinal("BenchCapasity"));

            }
            con.Close();

            string query2 = "select Location,ColumnNo,BenchCapasity from Room where RoomNo='" + int.Parse(rmn2) + "'";
            con.Open();
            SqlCommand cmd2 = new SqlCommand(query2, con);
            SqlDataReader dr2 = cmd2.ExecuteReader();


            while (dr2.Read())
            {

                ColNo2 = dr2.GetInt32(dr2.GetOrdinal("ColumnNo"));
                Loc2 = dr2.GetString(dr2.GetOrdinal("Location"));
                BenchCapasity2 = dr2.GetInt32(dr2.GetOrdinal("BenchCapasity"));

            }

            con.Close();
        }   //DOUBLE ROOM

        public void DesignMatrix_S1R1(int Lim)// room capasity
        {
            int R = 37, C = 87, n = 0, col = 0, flag = 1, a = 64, b = 34;

            n = Lim / ColNo;
            col = Cola(Lim, n, col);
            for (int i = 1; i <= col; i++)
            {

                Lab(a, b, i);
                for (int j = 1; j <= n; j++)
                {

                    SaveD(R, C);
                    C = C + 40;
                    if (Lim == flag)
                    {
                        break;
                    }
                    flag++;

                }
                C = 87;
                R = R + 135;
                a += 135;
            }




        }

        public void DesignMatrix_S1R2(int Lim)// room capasity
        {
            int R = 37+760, C = 87, n = 0, col = 0, flag = 1, a = 64, b = 34;

            n = Lim / ColNo;
            col = Cola(Lim, n, col);
            for (int i = 1; i <= col; i++)
            {

                Lab(a, b, i);
                for (int j = 1; j <= n; j++)
                {

                    SaveD(R, C);
                    C = C + 40;
                    if (Lim == flag)
                    {
                        break;
                    }
                    flag++;

                }
                C = 87;
                R = R + 135;
                a += 135;
            }




        }

        private static int Cola(int Lim, int n, int col)
        {
            if (Lim % n < n && Lim % n != 0)
            {
                col = (Lim / n) + 1;
                
            }
            else
            {
                
                col = Lim / n;
            }

            return col;
        }

        public void DesignMatrix_S2R1(int Lim)// room capasity
        {
            int R = 33, C = 83, n = 0, col = 0,  flag = 1, a = 122, b = 27;

            n = Lim / ColNo;
            col = Cola(Lim, n, col);


            MessageBox.Show("design s2r1");
            for (int i = 1; i <= col; i++)
            {
                Lab(a, b, i);
                for (int k = 1; k <= 2; k++) 
                {
                    for (int j = 1; j <= n; j++)
                    {
                        SaveD(R, C);
                        C = C + 40;
                        if (flag == Lim*2)
                        {
                            break;
                        }
                        flag++;

                    }
                    R += 90;
                    C = 83;

                }
                C = 83;
                R = R + 125;
                a += 300;
            }


        }

        public void DesignMatrix_S2R2(int Lim)// room capasity
        {
            int R = 820, C = 83, n = 0, col = 0, flag = 1, a = 900, b = 27;

            n = Lim / ColNo2;
            col = Cola(Lim, n, ColNo2);
            

            MessageBox.Show("design s2r2");
            for (int i = 1; i <= col; i++)
            {
                Lab(a, b, i);
                for (int k = 1; k <= 2; k++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        SaveD(R, C);
                        C = C + 40;
                        if (flag == Lim * 2)
                        {
                            break;
                        }
                        flag++;

                    }
                    R += 90;
                    C = 83;

                }
                C = 83;
                R = R + 125;
                a += 300;
            }


        }

        private void SeatingArrangementcs_Load(object sender, EventArgs e)
        {

        }

        private void print_Click(object sender, EventArgs e)
        {
            this.Refresh();
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

            txt.Size = new System.Drawing.Size(86, 26);
            txt.Multiline = true;
            txt.ReadOnly = true;
            return txt;

        }

        public System.Windows.Forms.Label Lab(int r, int c, int t)
        {
            System.Windows.Forms.Label l = new Label();
            panel.Controls.Add(l);
            l.Location = new Point(r, c);
            l.Text = t.ToString();
            l.Size = new System.Drawing.Size(26, 30);
            return l;
        }



    }

}
