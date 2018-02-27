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
    public partial class ViewBatch : UserControl
    {
        private static ViewBatch _instance;


        public static ViewBatch Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ViewBatch();
                return _instance;
            }
        }
        public ViewBatch()
        {
            InitializeComponent();
        }

        private void ViewBatch_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RHFMINC\SQLEXPRESS;Initial Catalog=TESTone;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Batch", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGrid.DataSource = dt;
            con.Close();
            editpnl.Visible = false;
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            editpnl.Visible = true;

            Textbox1.Text = DataGrid.SelectedRows[0].Cells[0].Value.ToString();
            Dropdown1.Text = DataGrid.SelectedRows[0].Cells[1].Value.ToString();
            if (DataGrid.SelectedRows[0].Cells[3].Value.ToString() == "Active")
                radioButton1.Select();
            else
                radioButton2.Select();

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {
            editpnl.Visible = false;
        }
    }
}
