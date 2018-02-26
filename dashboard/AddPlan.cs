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
    public partial class AddPlan : UserControl
    {
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
        }
    }
}
