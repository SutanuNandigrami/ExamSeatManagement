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
        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Student", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGrid.DataSource = dt;
            con.Close();
            editpnl.Visible = false;
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            editpnl.Visible = true;

            textbox1.Text = DataGrid.SelectedRows[0].Cells[0].Value.ToString();
            textbox2.Text = DataGrid.SelectedRows[0].Cells[1].Value.ToString();
            textbox3.Text = DataGrid.SelectedRows[0].Cells[2].Value.ToString();
            textbox4.Text = DataGrid.SelectedRows[0].Cells[3].Value.ToString();
            textbox5.Text = DataGrid.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {
            editpnl.Visible = false;
        }
    }
}
