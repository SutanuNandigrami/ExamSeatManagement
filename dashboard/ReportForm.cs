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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();

            crrpt.Visible = true;
            //ReportDocument crrptd = new ReportDocument();
            es1.Load(Application.StartupPath + "\\ExamSchedule.rpt");
            crrpt.ReportSource = es1;
            crrpt.Refresh();
        }
    }
}
