using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashboard
{
    public partial class ViewDept : UserControl
    {
        private static ViewDept _instance;

        

        public static ViewDept Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ViewDept();
                return _instance;
            }
        }
        public ViewDept()
        {
            InitializeComponent();
            editpnl.Visible = false;
            
        }
        

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {
            editpnl.Visible = false;
        }

        private void DataGrid_MouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            editpnl.Visible = true;

            Textbox1.Text = DataGrid.SelectedRows[0].Cells[0].Value.ToString();
            Textbox2.Text = DataGrid.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
