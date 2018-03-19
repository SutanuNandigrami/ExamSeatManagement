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
        int capasity, cap=0;
        
        string RegNo="";
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
            FillDur();
            FillDept();
            batchdrp.Enabled = false;
            subdrp.Enabled = false;
            paperdrp.Enabled = false;
            //roomdrp.Enabled = false;
            studentnolbl.Visible = false;
            //cleantempRoom();
            filltempRoom();
            FillRoom();
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            batchdrp.Enabled = false;
            subdrp.Enabled = false;
            paperdrp.Enabled = false;
            
            try
            {
                deptdrp.Clear();
                subdrp.Clear();
                
                durdrp.Clear();
            }
            catch (Exception k)
            {

                MessageBox.Show(k.ToString());
            }
            
            FillDept();
            FillDur();
           
           fillsub();
            
        }

        void FillDept()
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

       

        void FillDur()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con.Open();
            string query = "select * from Duration";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            
                while (dr.Read())
                {
                    try
                    {
                        string Duration = dr.GetString(dr.GetOrdinal("Duration"));
                        durdrp.AddItem(Duration);
                    }

                    catch (Exception )
                    {
                       continue;
                        //MessageBox.Show(ex.ToString());
                    }
                    

                }

            con.Close();


        }

        void filltempRoom()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True;MultipleActiveResultSets=True");
            string query = "select RoomNo,BenchCapasity from Room ORDER BY BenchCapasity DESC";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            try
            {
                while (dr.Read())
                {
                    try
                    {
                        int RoomNo= dr.GetInt32(dr.GetOrdinal("RoomNo"));
                        int BenchCapasity= dr.GetInt32(dr.GetOrdinal("BenchCapasity")); ;
                        String query2 = "insert into TempRoom (RoomNo,BenchCapasity) values('"+RoomNo+"','"+BenchCapasity+"') ";
                        SqlDataAdapter dAdop = new SqlDataAdapter(query2, con);
                        dAdop.SelectCommand.ExecuteNonQuery();
                    }
                    catch(Exception x)
                    {
                        //MessageBox.Show("Error from room to temp"+x.ToString());
                        continue;
                    }
                }
            }
            catch (Exception k)
            {
                //throw;
                MessageBox.Show("outer catch loop" + k.ToString());

            }
            con.Close();
        }

        void cleantempRoom()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");

            try
            {
                con.Open();

                String query = "truncate table TempRoom";
                SqlDataAdapter dAdop = new SqlDataAdapter(query, con);
                dAdop.SelectCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;


            }
            con.Close();
        }

        void fillsub()
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con.Open();
            string query = "select DISTINCT Subject from Subject where Dept='" + deptdrp.selectedValue + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            try
            {
                while (dr.Read())
                {

                    string Sub = dr.GetString(dr.GetOrdinal("Subject"));

                    subdrp.AddItem(Sub);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            con.Close();
            
           
            //Adding  Pass1

            SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con2.Open();
            string query3 = "select DISTINCT Pass1 from Student where Stream='" + deptdrp.selectedValue + "' and Sem='" + batchdrp.selectedValue + "'";
            SqlCommand cmd3 = new SqlCommand(query3, con2);
            SqlDataReader dr3 = cmd3.ExecuteReader();

            try
            {
                while (dr3.Read())
                {
                    string Pass1 = dr3.GetString(dr3.GetOrdinal("Pass1"));
                    subdrp.AddItem(Pass1);
                    
                }

            }
            catch (Exception ext)
            {

                MessageBox.Show(ext.ToString());
            }
            con2.Close();

            //Adding pass2

            SqlConnection conp = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            conp.Open();
            string queryp = "select DISTINCT Pass2 from Student where Stream='" + deptdrp.selectedValue + "' and Sem='" + batchdrp.selectedValue + "'";
            SqlCommand cmdp = new SqlCommand(queryp, conp);
            SqlDataReader drp = cmdp.ExecuteReader();

            try
            {
                while (drp.Read())
                {
                   
                    string Pass2 = drp.GetString(drp.GetOrdinal("Pass2"));
                    
                    subdrp.AddItem(Pass2);
                }

            }
            catch (Exception ext)
            {

                MessageBox.Show(ext.ToString());
            }
            conp.Close();

        }

        void FillRoom()
        {
            SqlConnection con9 = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con9.Open();
            string query9 = "select * from TempRoom ORDER BY BenchCapasity DESC";
            SqlCommand cmd9 = new SqlCommand(query9, con9);
            SqlDataReader dr9 = cmd9.ExecuteReader();

            try
            {
                while (dr9.Read())
                {
                    int RoomNo = dr9.GetInt32(dr9.GetOrdinal("RoomNo"));
                    capasity = dr9.GetInt32(dr9.GetOrdinal("BenchCapasity"));
                    roomdrp.AddItem(RoomNo.ToString());
                    
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            con9.Close();
        }

        void fillpaper()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con.Open();
            string query = "select * from Subject where Dept='" + deptdrp.selectedValue + "' and Subject='" + subdrp.selectedValue + "'and Sem='" + batchdrp.selectedValue + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            try
            {
                while (dr.Read())
                {
                    string papercode = dr.GetString(dr.GetOrdinal("PaperCode"));
                    //string Sub = dr.GetString(dr.GetOrdinal("Subject"));
                    //string paper = papercode + " | " + Sub;
                    paperdrp.AddItem(papercode);
                }

               
            }
            catch(Exception)
            {
                throw;
            }
            con.Close();

            //Adding Extra papers

            SqlConnection con3 = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con3.Open();
            string query3 = "select PaperCode from Subject where  Subject='" + subdrp.selectedValue + "'and Sem='" + batchdrp.selectedValue + "'";
            SqlCommand cmd3 = new SqlCommand(query3, con3);
            SqlDataReader dr3 = cmd3.ExecuteReader();

            try
            {
                while (dr3.Read())
                {
                    
                    string papercode = dr3.GetString(dr3.GetOrdinal("PaperCode"));
                    
                    if (paperdrp.Items.Contains(subdrp.Items.ToString()))
                        continue;
                    else
                      paperdrp.AddItem(papercode);
                }


            }
            catch (Exception)
            {
                throw;
            }
            con3.Close();

            //Student Count
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");

                conn.Open();
                string query2 = "select * from Student where Sem='" + batchdrp.selectedValue + "' and (HonsPaper='" + subdrp.selectedValue + "' or Pass1='" + subdrp.selectedValue + "' or Pass2='" + subdrp.selectedValue + "') ORDER BY RegNo ASC";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                int i = 1;

                try
                {
                    while (dr2.Read())
                    {
                        if (i == 1)
                        {
                            RegNo = dr2.GetString(dr2.GetOrdinal("RegNo"));
                            Textbox1.Text = RegNo;
                        }
                        RegNo = dr2.GetString(dr2.GetOrdinal("RegNo"));
                        i++;

                    }
                    Textbox2.Text = RegNo;
                    studentnolbl.Visible = true;
                    studentnolbl.Text = "Number Of Students:: " + i.ToString();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

                conn.Close();
            }
            catch (Exception k)
            {

                MessageBox.Show(k.ToString());
            }
        }
       
        private void deptdrp_onItemSelected(object sender, EventArgs e)
        {
           
            batchdrp.Enabled = true;
            
        }

        private void paperdrp_onItemSelected(object sender, EventArgs e)
        {
            roomdrp.Enabled = true;

            //cleantempRoom();
            //filltempRoom();
            roomdrp.Clear();
            FillRoom();

        }

        private void addPlanbtn_Click(object sender, EventArgs e)
        {

            //adding plan to database

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            try
            {
                con.Open();
                string query = $"INSERT INTO AddPlan VALUES('{paperdrp.selectedValue}','{batchdrp.selectedValue}','{subdrp.selectedValue}','{deptdrp.selectedValue}','{roomdrp.selectedValue.ToString()}','{durdrp.selectedValue}','{datepkr.Value.Date}','{Textbox1.Text}','{Textbox2.Text}')";
                SqlCommand cmd=new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                
                statuslbl.ForeColor = System.Drawing.Color.White;
                statuslbl.Text = "INSERTION SUCCESSFULL";
            }
            catch(Exception l)
            {
                //MessageBox.Show(l.ToString());
                statuslbl.ForeColor = System.Drawing.Color.Red;
                statuslbl.Text = "Duplicate Entry!!";
            }

            finally
            {

                con.Close();
            }

            //deleting room from database temproom

         /*   SqlConnection con5 = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");

            try
            {
                con5.Open();
                string s = RoomNo.ToString(); ;
                string query5 = "delete from TempRoom where RoomNo = '" + s + "'";
                SqlDataAdapter sda5 = new SqlDataAdapter(query5, con5);
                sda5.SelectCommand.ExecuteNonQuery();


            }
            catch
            {
                throw;
            }

            finally
            {

                con5.Close();
            }   */
        }

        private void subdrp_onItemSelected(object sender, EventArgs e)
        {
            paperdrp.Enabled = true;
            paperdrp.Enabled = true;
            paperdrp.Clear();
            fillpaper();

            
        }

        private void batchdrp_onItemSelected_1(object sender, EventArgs e)
        {
            subdrp.Enabled = true;
            subdrp.Clear();
            fillsub();
        }

        private void roomdrp_onItemSelected(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con.Open();
            string query = "select BenchCapasity from TempRoom where RoomNo='"+ roomdrp.selectedValue +"' ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            try
            {
                while (dr.Read())
                {
                    
                    int c = dr.GetInt32(dr.GetOrdinal("BenchCapasity"));
                    lblrmcap.Text = "Capasity= " +c.ToString();

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            con.Close();
            
        }

        private void refroombtn_Click(object sender, EventArgs e)
        {
            //cleantempRoom();
            filltempRoom();
            roomdrp.Clear();
            FillRoom();
        }

        private void addRoombtn_Click(object sender, EventArgs e)
        {
            roomlstbx.Items.Add(roomdrp.selectedValue);
            cap = cap + capasity;
            lblcap.Text = "Total Capasity is:: " + cap.ToString();
        }
    }
}
