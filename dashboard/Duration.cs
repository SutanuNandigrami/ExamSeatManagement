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
    public partial class Duration : UserControl
    {
        private static Duration _instance;

        public static Duration Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Duration();
                return _instance;
            }
        }
        public Duration()
        {
            InitializeComponent();
        }
    }
}
