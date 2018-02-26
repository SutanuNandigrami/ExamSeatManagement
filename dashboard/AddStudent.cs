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
    public partial class AddStudent : UserControl
    {
        private static AddStudent _instance;

        public static AddStudent Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddStudent();
                return _instance;
            }
        }
        public AddStudent()
        {
            InitializeComponent();
        }
    }
}
