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
    public partial class ViewPlan : UserControl
    {
        private static ViewPlan _instance;


        public static ViewPlan Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ViewPlan();
                return _instance;
            }
        }
        public ViewPlan()
        {
            InitializeComponent();
        }
        
    }
}
