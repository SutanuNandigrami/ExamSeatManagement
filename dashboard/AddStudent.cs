using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Important NameSpaces Used
using System.Data.SqlClient;
using System.IO;
using System.Data.OleDb;

//Excel Imports
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;
using ExcelLibrary.BinaryDrawingFormat;
using ExcelLibrary.BinaryFileFormat;


namespace dashboard
{
    public partial class AddStudent : UserControl
    {
        private static AddStudent _instance;

        public static AddStudent Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddStudent();
                return _instance;
            }
        }
        public AddStudent()
        {
            InitializeComponent();
            browsetxt.Text = "";
            fillDept();
            fillHon();
            fillgen();
            
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
                    deptDrp1.AddItem(DeptName);
                    }

                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            con.Close();
        }
        void fillHon()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con.Open();
            string query = "select * from SubList where SubType='HON'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            try
            {
                while (dr.Read())
                {
                    string Subject = dr.GetString(dr.GetOrdinal("SubName"));
                    hnsdrp.AddItem(Subject);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            con.Close();
        }
    

        void fillgen()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con.Open();
            string query = "select * from SubList where SubType='GEN'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            try
            {
                while (dr.Read())
                {
                    string Subject = dr.GetString(dr.GetOrdinal("SubName"));
                    pass1drp.AddItem(Subject);
                    pass2drp.AddItem(Subject);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            con.Close();
        }
        
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select An Excel File";
            openFileDialog1.InitialDirectory = @"C:\Users\sutan\Desktop";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.DefaultExt = "xlsx";
            openFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) // Test result.
            {
                try
                {
                    browsetxt.Text = openFileDialog1.FileName;
                }
                catch (IOException)
                {
                    excellbl.Text = "**File Didn't Match!!!";
                }

            }
        }

        /*Upload / Save To SQL Server Button Click Event Coding
         ------------------------------------------------------ -*/

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

            string RegNo;
            string UnivRollNo, Name, Stream, Sem,UG,HonsPaper,Pass1,Pass2;

            //CODE TO BUILD CONNECTION WITH EXCEL SHEET
            string pathcon = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + browsetxt.Text + "; Extended Properties=Excel 8.0; Persist Security Info = False";
            OleDbConnection mycon = new OleDbConnection(pathcon);

            mycon.Open();

            

            //PREPARING DATA TO SEND THEM TO DATABASE

            OleDbCommand cmd = new OleDbCommand("select * from [Sheet1$] ", mycon);
            OleDbDataReader dr = cmd.ExecuteReader();
            try
            {
                while (dr.Read())
                {
                    // Response.Write("<br/>"+dr[0].ToString());
                    RegNo = dr[0].ToString();
                    UnivRollNo = dr[1].ToString();
                    Name = dr[2].ToString();
                    Stream = dr[3].ToString();
                    Sem = dr[4].ToString();
                    UG = dr[5].ToString();
                    HonsPaper= dr[6].ToString();
                    Pass1= dr[7].ToString();
                    Pass2= dr[8].ToString();

                    try
                    {
                        savedata(RegNo, UnivRollNo, Name, Stream, Sem,UG,HonsPaper,Pass1,Pass2);
                    }
                    catch (Exception)
                    {

                        //MessageBox.Show("Duplicate Entry");
                        continue;
                    }




                }
                MessageBox.Show("Data Has Been Saved Successfully");
            }
            catch (Exception)
            {

                MessageBox.Show("Databse Didn't match!!!");
            }

            mycon.Close();

        }

        //CODE TO SAVE DATA IN DATABASE



        private void savedata(string RegNo, string UnivRollNo, string Name, string Stream, string Sem,string UG,string HonsPaper,string Pass1, string Pass2)
        {
            String query = "insert into Student values('" + RegNo + "','" + UnivRollNo + "','" + Name + "','" + Stream + "','" + Sem + "','" + UG + "','" + HonsPaper + "','" + Pass1 + "','" + Pass2 + "')";
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con.Open();
            SqlDataAdapter dAdop = new SqlDataAdapter(query, con);
            dAdop.SelectCommand.ExecuteNonQuery();
            con.Close();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            deptDrp1.Clear();
            batchDrp.selectedIndex = -1;
            fillDept();
            hnsdrp.Clear();
            pass1drp.Clear();
            pass2drp.Clear();
            fillHon();
            fillgen();
           
            
        }

        private void studentbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");

            if (deptDrp1.selectedIndex != -1 && batchDrp.selectedIndex != -1 && hnsdrp.selectedIndex != -1 && pass1drp.selectedIndex != -1 && pass2drp.selectedIndex != -1 && textbox1.Text!="" && textbox2.Text!="" && textbox3.Text!="")
            {
                try
                {
                    con.Open();
                    string query = "insert into Student values('" + textbox1.Text + "','" + textbox2.Text + "','" + textbox3.Text + "','" + deptDrp1.selectedValue + "','" + batchDrp.selectedValue + "','" + ugpgdrp.selectedValue + "','" + hnsdrp.selectedValue + "','" + pass1drp.selectedValue + "','" + pass2drp.selectedValue + "')";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    statuslbl.ForeColor = System.Drawing.Color.White;
                    statuslbl.Text = "INSERTION SUCCESSFULL";
                }
                catch
                {
                    statuslbl.ForeColor = System.Drawing.Color.Red;
                    statuslbl.Text = "Duplicate Entry!!";
                }

                finally
                {

                    con.Close();
                }
            }
        }
    }
}

