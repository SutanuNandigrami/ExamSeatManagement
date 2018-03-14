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
    public partial class ViewStudent : UserControl
    {

        private static ViewStudent _instance;

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");

        public static ViewStudent Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ViewStudent();
                return _instance;
            }
        }

        public ViewStudent()
        {
            InitializeComponent();

            deptDrp1.selectedIndex = -1;
            showall();
            fillDept();
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            editpnl.Visible = true;

            textbox1.Text = DataGrid.SelectedRows[0].Cells[0].Value.ToString();
            textbox2.Text = DataGrid.SelectedRows[0].Cells[1].Value.ToString();
            textbox3.Text = DataGrid.SelectedRows[0].Cells[2].Value.ToString();
            textbox4.Text = DataGrid.SelectedRows[0].Cells[3].Value.ToString();
            textbox5.Text = DataGrid.SelectedRows[0].Cells[4].Value.ToString();
            textbox1.Enabled = false;

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {
            editpnl.Visible = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update Student set UnivRollNo='" + textbox2.Text + "',Name='" + textbox3.Text + "',Stream='" + textbox4.Text + "',Sem='" + textbox5.Text + "' where RegNo='" + textbox1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            showall();
        }

        public void showall()
        {
            SqlConnection mcon = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            mcon.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Student", mcon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGrid.DataSource = dt;
            mcon.Close();
            editpnl.Visible = false;
        }
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            SqlConnection mycon = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            mycon.Open();
            string query = "delete from Student where RegNo='" + textbox1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, mycon);
            sda.SelectCommand.ExecuteNonQuery();
            mycon.Close();
            showall();
        }

        private void viewallbtn_Click(object sender, EventArgs e)
        {
            showall();
        }

         private void erasebtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con.Open();
            string query = "truncate table Student ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            DataGrid.DataSource = null;

            MessageBox.Show("Deletion SUCCESSFULL!!!!");
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

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            deptDrp1.Clear();
            fillDept();
            showall();
        }

        private void searchbtn2_Click(object sender, EventArgs e)
        {
            if (deptDrp1.selectedIndex != -1 && searchbox1.Text != "Reg No/ Name/ Sem")
            {
                try
                {
                    con.Open();
                    string query = "select * from Student where (RegNo='" + searchbox1.Text + "' or Name='" + searchbox1.Text + "' or Sem='" + searchbox1.Text + "' ) and Stream='" + deptDrp1.selectedValue + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    DataGrid.DataSource = dt;
                    searchbox1.Text = "";
                    con.Close();
                }
                catch (Exception k)
                {

                    MessageBox.Show(k.ToString());
                }
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "select * from Student where (RegNo='" + searchbox1.Text + "' or Name='" + searchbox1.Text + "' or Sem='" + searchbox1.Text + "') ";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    DataGrid.DataSource = dt;
                    searchbox1.Text = "";
                    con.Close();
                }
                catch (Exception )
                {

                    MessageBox.Show("Wrong Search Entry!!");
                }
            }
            
        }

        private void deptDrp1_onItemSelected(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "select * from Student where Stream='" + deptDrp1.selectedValue + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGrid.DataSource = dt;

                //To Clear The Dropdown Menu after Search click
                deptDrp1.Clear();
                fillDept();

                con.Close();
            }
            catch (Exception k)
            {

                MessageBox.Show(k.ToString());
            }
        }
    }
}
