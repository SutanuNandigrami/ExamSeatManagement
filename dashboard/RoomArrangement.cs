using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashboard
{
    public partial class RoomArrangement : Form
    {
        public RoomArrangement()
        {
            InitializeComponent();
            crrptt.Visible = true;
            
            arrangement1.Load(Application.StartupPath + "\\Arrangement.rpt");
            crrptt.ReportSource = arrangement1;
            crrptt.Refresh();
        }
    }
}
