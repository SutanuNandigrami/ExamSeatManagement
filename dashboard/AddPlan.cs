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
        
        string RegNo="",RegNo2="";
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
            addPlanbtn.Enabled = false;
            batchdrp.Enabled = false;
            subdrp.Enabled = false;
            paperdrp.Enabled = false;
            batchdrp2.Enabled = false;
            subdrp2.Enabled = false;
            paperdrp2.Enabled = false;
            //roomdrp.Enabled = false;
            studentnolbl.Visible = false;
            studentnolbl2.Visible = false;
            cleantempRoom();
            //filltempRoom();
            roomdrp.Clear();
            roomdrp2.Clear();
            //FillRoom();
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                deptdrp.Clear();
                subdrp.Clear();
                
                durdrp.Clear();
            }
            catch (Exception )
            {
                throw;
            }
            
            FillDept();
            FillDur();
            statuslbl.Text = "";
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
                    deptdrp2.AddItem(DeptName);
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
                        int BenchCapasity= dr.GetInt32(dr.GetOrdinal("BenchCapasity")); 
                        String query2 = "insert into TempRoom (RoomNo,BenchCapasity,Date,Duration) values('"+RoomNo+"','"+BenchCapasity+ "','" + datepkr.Value.Date + "','" + durdrp.selectedValue + "') ";
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

        void fillsub2()
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con.Open();
            string query = "select DISTINCT Subject from Subject where Dept='" + deptdrp2.selectedValue + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            try
            {
                while (dr.Read())
                {

                    string Sub = dr.GetString(dr.GetOrdinal("Subject"));

                    subdrp2.AddItem(Sub);

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
            string query3 = "select DISTINCT Pass1 from Student where Stream='" + deptdrp2.selectedValue + "' and Sem='" + batchdrp2.selectedValue + "'";
            SqlCommand cmd3 = new SqlCommand(query3, con2);
            SqlDataReader dr3 = cmd3.ExecuteReader();

            try
            {
                while (dr3.Read())
                {
                    string Pass1 = dr3.GetString(dr3.GetOrdinal("Pass1"));
                    subdrp2.AddItem(Pass1);

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
            string queryp = "select DISTINCT Pass2 from Student where Stream='" + deptdrp2.selectedValue + "' and Sem='" + batchdrp2.selectedValue + "'";
            SqlCommand cmdp = new SqlCommand(queryp, conp);
            SqlDataReader drp = cmdp.ExecuteReader();

            try
            {
                while (drp.Read())
                {

                    string Pass2 = drp.GetString(drp.GetOrdinal("Pass2"));

                    subdrp2.AddItem(Pass2);
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
            string query9 = "select DISTINCT RoomNo,BenchCapasity from TempRoom where  Date='" + datepkr.Value.Date + "'and  Duration='" + durdrp.selectedValue+ "' ORDER BY BenchCapasity DESC";
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

        void FillRoom2()
        {
            SqlConnection con9 = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con9.Open();
            string query9 = "select DISTINCT RoomNo,BenchCapasity from TempRoom where  Date='" + datepkr.Value.Date + "'and  Duration='" + durdrp.selectedValue + "' ORDER BY BenchCapasity DESC";
            SqlCommand cmd9 = new SqlCommand(query9, con9);
            SqlDataReader dr9 = cmd9.ExecuteReader();

            try
            {
                while (dr9.Read())
                {
                    int RoomNo = dr9.GetInt32(dr9.GetOrdinal("RoomNo"));
                    capasity = dr9.GetInt32(dr9.GetOrdinal("BenchCapasity"));
                    
                    roomdrp2.AddItem(RoomNo.ToString());

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
            string query = "select * from Subject where Subject='" + subdrp.selectedValue + "'and Sem='" + batchdrp.selectedValue + "'";
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

          /*  SqlConnection con3 = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
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
            con3.Close();*/

            //Student Count
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");

                conn.Open();
                string query2 = "select * from Student where Sem='" + batchdrp.selectedValue + "' and (HonsPaper='" + subdrp.selectedValue + "' or Pass1='" + subdrp.selectedValue + "' or Pass2='" + subdrp.selectedValue + "') ORDER BY RegNo ASC";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                int i = 0;

                try
                {
                    while (dr2.Read())
                    {
                        i++;
                        if (i == 1)
                        {
                            RegNo = dr2.GetString(dr2.GetOrdinal("RegNo"));
                            Textbox1.Text = RegNo;
                            
                        }
                        RegNo = dr2.GetString(dr2.GetOrdinal("RegNo"));
                        

                    }
                    Textbox2.Text = RegNo;
                    Textbox3.Text = subdrp.selectedValue;
                    studentnolbl.Visible = true;
                    studentnolbl.Text =  i.ToString();
                    TotalSlbl.Text = studentnolbl.Text;
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

        void fillpaper2()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con.Open();
            string query = "select * from Subject where  Subject='" + subdrp2.selectedValue + "'and Sem='" + batchdrp2.selectedValue + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            try
            {
                while (dr.Read())
                {
                    string papercode = dr.GetString(dr.GetOrdinal("PaperCode"));
                    //string Sub = dr.GetString(dr.GetOrdinal("Subject"));
                    //string paper = papercode + " | " + Sub;
                    paperdrp2.AddItem(papercode);
                }


            }
            catch (Exception)
            {
                throw;
            }
            con.Close();

            //Adding Extra papers

          /*  SqlConnection con3 = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con3.Open();
            string query3 = "select PaperCode from Subject where  Subject='" + subdrp2.selectedValue + "'and Sem='" + batchdrp2.selectedValue + "'";
            SqlCommand cmd3 = new SqlCommand(query3, con3);
            SqlDataReader dr3 = cmd3.ExecuteReader();

            try
            {
                while (dr3.Read())
                {

                    string papercode = dr3.GetString(dr3.GetOrdinal("PaperCode"));

                    if (paperdrp2.Items.Contains(papercode))
                        continue;
                    else
                        paperdrp2.AddItem(papercode);
                }


            }
            catch (Exception)
            {
                throw;
            }
            con3.Close();*/

            //Student Count
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");

                conn.Open();
                string query2 = "select * from Student where Sem='" + batchdrp2.selectedValue + "' and (HonsPaper='" + subdrp2.selectedValue + "' or Pass1='" + subdrp2.selectedValue + "' or Pass2='" + subdrp2.selectedValue + "') ORDER BY RegNo ASC";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                int i = 0;

                try
                {
                    while (dr2.Read())
                    {
                        i++;
                        if (i == 1)
                        {
                            RegNo2 = dr2.GetString(dr2.GetOrdinal("RegNo"));
                            Textbox4.Text = RegNo2;

                        }
                        RegNo2 = dr2.GetString(dr2.GetOrdinal("RegNo"));


                    }
                    Textbox5.Text = RegNo2;
                    Textbox6.Text = subdrp2.selectedValue;
                    studentnolbl2.Visible = true;
                    studentnolbl2.Text =  i.ToString();
                    TotalSlbl.Text = (int.Parse(studentnolbl.Text) + int.Parse(studentnolbl2.Text)).ToString();
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

            // cleantempRoom();
            filltempRoom();
            
            roomdrp.Clear();
            FillRoom();

        }

        private void addPlanbtn_Click(object sender, EventArgs e)
        {
            int b=0;
            
            if (int.Parse(tcap.Text) < int.Parse(TotalSlbl.Text))
            {
                label2.Text = "Insufficient Space!! Please Add More Room.";
                addPlanbtn.Enabled = false;

            }
            else    //four cases of dept and room
            {

                if (durdrp.selectedIndex != -1 && deptdrp.selectedIndex != -1 && batchdrp.selectedIndex != -1 && subdrp.selectedIndex != -1 && paperdrp.selectedIndex != -1 && roomdrp.selectedIndex != -1)
              {

                    //double room case with single dept

                    if (roomdrp2.selectedIndex != -1 && paperdrp2.selectedIndex==-1)    
                    {
                        if (radioButton1.Checked == true)
                            b = 0;
                        else if (radioButton2.Checked == true)
                            b = 1;

                        //adding plan to database

                        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
                        try
                        {
                            con.Open();
                            string query = $"INSERT INTO AddPlan(PaperCode,Sem,Subject,Dept,RoomNo,RollS,RollE,RoomNo2,Duration,Date,A,Sitting) VALUES('{paperdrp.selectedValue.ToString()}','{batchdrp.selectedValue.ToString()}','{subdrp.selectedValue.ToString()}','{deptdrp.selectedValue.ToString()}','{roomdrp.selectedValue.ToString()}','{Textbox1.Text}','{Textbox2.Text}','{roomdrp2.selectedValue.ToString()}','{durdrp.selectedValue.ToString()}','{datepkr.Value}','{0.ToString()}','{b}')";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.ExecuteNonQuery();

                            statuslbl.ForeColor = System.Drawing.Color.White;
                            statuslbl.Text = "INSERTION SUCCESSFULL";
                        }
                        catch (Exception)
                        {
                            //MessageBox.Show(l.ToString());
                            statuslbl.ForeColor = System.Drawing.Color.Red;
                            statuslbl.Text = "Duplicate Entry!!";
                        }

                        finally
                        {
                            CapasityUpdate(roomdrp2.selectedValue);
                            con.Close();
                        }
                    }

                    //single room single dept

                    else if (roomdrp2.selectedIndex==-1 && paperdrp2.selectedIndex==-1)  
                {
                    if (radioButton1.Checked == true)
                        b = 0;
                    else if (radioButton2.Checked == true)
                        b = 1;
                   
                        //adding plan to database

                        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
                        try
                        {
                            MessageBox.Show("in ss try");
                            con.Open();
                            string query = $"INSERT INTO AddPlan(PaperCode,Sem,Subject,Dept,RoomNo,RollS,RollE,Duration,Date,A,Sitting) VALUES('{paperdrp.selectedValue.ToString()}','{batchdrp.selectedValue.ToString()}','{subdrp.selectedValue.ToString()}','{deptdrp.selectedValue.ToString()}','{roomdrp.selectedValue.ToString()}','{Textbox1.Text}','{Textbox2.Text}','{durdrp.selectedValue.ToString()}','{datepkr.Value}','{0.ToString()}','{b}')";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.ExecuteNonQuery();

                            statuslbl.ForeColor = System.Drawing.Color.White;
                            statuslbl.Text = "INSERTION SUCCESSFULL";
                        }
                        catch (Exception l)
                        {
                            MessageBox.Show(l.ToString());
                            statuslbl.ForeColor = System.Drawing.Color.Red;
                            statuslbl.Text = "Duplicate Entry!!";
                        }

                        finally
                        {
                            CapasityUpdate(roomdrp.selectedValue);
                            con.Close();
                        }
                   
                }

                    //double dept double room
                    else if (roomdrp2.selectedIndex != -1 && paperdrp2.selectedIndex!=-1)  
                {
                        if (radioButton1.Checked == true)
                            b = 0;
                        else if (radioButton2.Checked == true)
                            b = 1;

                        //adding first paper

                        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
                        try
                        {
                            
                            con.Open();
                            string query = $"INSERT INTO AddPlan(PaperCode,Sem,Subject,Dept,RoomNo,RollS,RollE,PaperCode2,Sem2,Subject2,Dept2,RollS2,RollE2,RoomNo2,Duration,Date,A,Sitting) VALUES('{paperdrp.selectedValue.ToString()}','{batchdrp.selectedValue.ToString()}','{subdrp.selectedValue.ToString()}','{deptdrp.selectedValue.ToString()}','{roomdrp.selectedValue.ToString()}','{Textbox1.Text}','{Textbox2.Text}','{paperdrp2.selectedValue.ToString()}','{batchdrp2.selectedValue.ToString()}','{subdrp2.selectedValue.ToString()}','{deptdrp2.selectedValue.ToString()}','{Textbox4.Text}','{Textbox5.Text}','{roomdrp2.selectedValue.ToString()}','{durdrp.selectedValue.ToString()}','{datepkr.Value}','{0.ToString()}','{b}')";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.ExecuteNonQuery();

                            
                            statuslbl.ForeColor = System.Drawing.Color.White;
                            statuslbl.Text = "INSERTION SUCCESSFULL";
                        }
                        catch (Exception l)
                        {
                            MessageBox.Show(l.ToString());
                            statuslbl.ForeColor = System.Drawing.Color.Red;
                            statuslbl.Text = "Duplicate Entry!!";
                        }

                        finally
                        {
                            CapasityUpdate(roomdrp2.selectedValue);
                            con.Close();
                        }
                    }

                    //double dept single room
                    else if (roomdrp2.selectedIndex==-1 && paperdrp2.selectedIndex != -1)  
                {
                        if (radioButton1.Checked == true)
                            b = 0;
                        else if (radioButton2.Checked == true)
                            b = 1;

                        //adding first paper

                        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
                        try
                        {
                            con.Open();
                            string query = $"INSERT INTO AddPlan(PaperCode,Sem,Subject,Dept,RoomNo,RollS,RollE,PaperCode2,Sem2,Subject2,Dept2,RollS2,RollE2,Duration,Date,A,Sitting) VALUES('{paperdrp.selectedValue.ToString()}','{batchdrp.selectedValue.ToString()}','{subdrp.selectedValue.ToString()}','{deptdrp.selectedValue.ToString()}','{roomdrp.selectedValue.ToString()}','{Textbox1.Text}','{Textbox2.Text}','{paperdrp2.selectedValue.ToString()}','{batchdrp2.selectedValue.ToString()}','{subdrp2.selectedValue.ToString()}','{deptdrp2.selectedValue.ToString()}','{Textbox4.Text}','{Textbox5.Text}','{durdrp.selectedValue.ToString()}','{datepkr.Value}','{0.ToString()}','{b}')";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.ExecuteNonQuery();

                            

                            statuslbl.ForeColor = System.Drawing.Color.White;
                            statuslbl.Text = "INSERTION SUCCESSFULL";
                        }
                        catch (Exception o)
                        {
                            MessageBox.Show(o.ToString());
                            statuslbl.ForeColor = System.Drawing.Color.Red;
                            statuslbl.Text = "Duplicate Entry!!";
                        }

                        finally
                        {
                            CapasityUpdate(roomdrp.selectedValue);
                            con.Close();
                        }
                    }
              }
              else
                    MessageBox.Show("Fill All Fields Properly!!");

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
        public void CapasityUpdate(string roomno)
        {
            int cap=0;
            int trm = int.Parse(tcap.Text);
            int ts = int.Parse(TotalSlbl.Text);
            if (trm >= ts)
            {
                if (radioButton1.Checked == true)
                {
                        cap = trm - ts;
                  
                }
                else if (radioButton2.Checked == true)
                {
                   
                        cap = (trm - ts) /2;
                   
                }
            }

            SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True;MultipleActiveResultSets=True");
            string query3 = $"update TempRoom set BenchCapasity='{cap}' where (RoomNo='{int.Parse(roomno)}') ";
            con2.Open();
            SqlCommand cmd2 = new SqlCommand(query3, con2);
            cmd2.ExecuteNonQuery();
            con2.Close();
            
        }

        private void subdrp_onItemSelected(object sender, EventArgs e)
        {
            
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
            int k = 0;
            try
            {
                while (dr.Read())
                {
                    
                   k = dr.GetInt32(dr.GetOrdinal("BenchCapasity"));
                   

                }
                if (radioButton2.Checked == true)
                {
                    int m = k * 2;
                    lblrmcap.Text =  m.ToString();
                }
                else if (radioButton1.Checked == true)
                {
                    lblrmcap.Text =  k.ToString();
                }

                tcap.Text = lblrmcap.Text;

                if (int.Parse(lblrmcap.Text) < int.Parse(TotalSlbl.Text))
                {
                    label2.Text = "Insufficient Space!! Please Add More Room.";
                }
                else
                {
                    label2.Text = "Sufficient Space!!";
                    addPlanbtn.Enabled = true;
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
            cleantempRoom();
            filltempRoom();
            roomdrp.Clear();
            roomdrp2.Clear();
            FillRoom();
            FillRoom2();
        }

        private void Dual1_Click(object sender, EventArgs e)
        {
            deptdrp2.Enabled = true;
            
        }

        private void deptdrp2_onItemSelected(object sender, EventArgs e)
        {
            batchdrp2.Enabled = true;
        }

        private void batchdrp2_onItemSelected(object sender, EventArgs e)
        {
            subdrp2.Enabled = true;
            subdrp2.Clear();
            fillsub2();
        }

        private void subdrp2_onItemSelected(object sender, EventArgs e)
        {
           
            paperdrp2.Enabled = true;
            paperdrp2.Clear();
            fillpaper2();
        }

        private void paperdrp2_onItemSelected(object sender, EventArgs e)
        {
            //roomdrp.Enabled = true;

            //cleantempRoom();
            filltempRoom();
            roomdrp2.Clear();
            FillRoom2();
        }

        private void durdrp_onItemSelected(object sender, EventArgs e)
        {
            
        }

        private void Dual2_Click(object sender, EventArgs e)
        {
            if (Dual2.Text == "Dual")
            {
                roomdrp2.Enabled = true;
                Dual2.Text = "Single";
            }
            else
            {
                roomdrp2.Enabled = false;
                Dual2.Text = "Dual";
                label1.Text = "";
                tcap.Text = lblrmcap.Text;
            }

        }

        private void roomdrp2_onItemSelected(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con.Open();
            string query = "select BenchCapasity from TempRoom where RoomNo='" + roomdrp2.selectedValue + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            int c = 0;
            try
            {
                while (dr.Read())
                {

                    c = dr.GetInt32(dr.GetOrdinal("BenchCapasity"));
                    

                }
                if(radioButton2.Checked==true)
                {
                    int l = c * 2;
                    label1.Text =  l.ToString();
                }
                else if(radioButton1.Checked==true)
                {
                    label1.Text =  c.ToString();
                }
                tcap.Text = (int.Parse(lblrmcap.Text) + int.Parse(label1.Text)).ToString();

                int x = int.Parse(tcap.Text);
                if (x < int.Parse(TotalSlbl.Text))
                {
                    label2.Text = "Insufficient Space!! Please Add More Room.";
                }
                else
                {
                    label2.Text = "Sufficient Space!!";
                    addPlanbtn.Enabled = true;
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
