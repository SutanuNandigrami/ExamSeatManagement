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
    public partial class Dash : UserControl
    {
        private static Dash _instance;

        public static Dash Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Dash();
                return _instance;
            }
        }
        public Dash()
        {
            InitializeComponent();
        }
    }
}
