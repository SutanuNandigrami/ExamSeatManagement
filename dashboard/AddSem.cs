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
    public partial class AddSem : UserControl
    {
        private static AddSem _instance;

        public static AddSem Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddSem();
                return _instance;
            }
        }
        public AddSem()
        {
            InitializeComponent();
        }
    }
}
