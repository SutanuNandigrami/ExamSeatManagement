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
    public partial class AddDept : UserControl
    {

        private static AddDept _instance;

        public static AddDept Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddDept();
                return _instance;
            }
        }
        public AddDept()
        {
            InitializeComponent();
        }
    }
}
