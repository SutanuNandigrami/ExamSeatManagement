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
//Important NameSpaces Used

using System.IO;
using System.Data.OleDb;

//Excel Imports
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;
using ExcelLibrary.BinaryDrawingFormat;
using ExcelLibrary.BinaryFileFormat;


namespace dashboard
{
    public partial class AddSem : UserControl
    {
        
        private static AddSem _instance;

        public static AddSem Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddSem();
                return _instance;
            }
        }
        public AddSem()
        {
            InitializeComponent();
            fillDept();
            fillSub();
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

        void fillSub()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con.Open();
            string query = "select Distinct SubName from SubList ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            try
            {
                while (dr.Read())
                {
                    string Subject = dr.GetString(dr.GetOrdinal("SubName"));
                    subdrp.AddItem(Subject);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            con.Close();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            deptdrp.Clear();
            fillDept();
            subdrp.Clear();
            fillSub();
            statuslbl.Text = "";
            Textbox1.Text = "";
            semdrp.selectedIndex = -1;
        }

        private void addBatchbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            
            try
            {
                con.Open();
                string query = "insert into Subject values('" + Textbox1.Text + "','" + subdrp.selectedValue + "','"+deptdrp.selectedValue+"','"+semdrp.selectedValue+"')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                //con.Close();
                statuslbl.ForeColor = System.Drawing.Color.White;
                statuslbl.Text = "Batch Added Successfully!!";
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

        private void browsebtn_Click(object sender, EventArgs e)
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

        private void uploadbtn_Click(object sender, EventArgs e)
        {
            
            string PaperCode,Subject,Dept,Sem;

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
                    PaperCode = dr[0].ToString();
                    Subject = dr[1].ToString();
                    Dept = dr[2].ToString();
                    Sem = dr[3].ToString();
                    

                    try
                    {
                        savedata(PaperCode, Subject, Dept, Sem);
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

        private void savedata(string PaperCode,string Subject,string Dept, string Sem)
        {
            String query = "insert into Subject values('" + PaperCode + "','" + Subject + "','" + Dept + "','" + Sem + "')";
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con.Open();
            SqlDataAdapter dAdop = new SqlDataAdapter(query, con);
            dAdop.SelectCommand.ExecuteNonQuery();
            con.Close();
        }

        
    }
}
