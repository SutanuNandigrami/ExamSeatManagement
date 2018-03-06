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
            fillBatch();
            
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
                    batchDrp.AddItem(BatchName);
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
            string UnivRollNo, Name, Stream, Sem;

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

                    try
                    {
                        savedata(RegNo, UnivRollNo, Name, Stream, Sem);
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



        private void savedata(string RegNo, string UnivRollNo, string Name, string Stream, string Sem)
        {
            String query = "insert into Student values('" + RegNo + "','" + UnivRollNo + "','" + Name + "','" + Stream + "','" + Sem + "')";
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con.Open();
            SqlDataAdapter dAdop = new SqlDataAdapter(query, con);
            dAdop.SelectCommand.ExecuteNonQuery();
            con.Close();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            deptDrp1.Clear();
            batchDrp.Clear();
            fillDept();
            fillBatch();
        }
    }
}

