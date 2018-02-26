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
    public partial class tab1 : UserControl
    {
        //Size last = new Size(0, 0);
        

        private static tab1 _instance;

        public static tab1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new tab1();
                return _instance;
            }
        }
        public tab1()
        {
            InitializeComponent();
        }

       /* private void tab1_Resize(object sender, EventArgs e)
        {
            if (last != new Size(0, 0))
            {
                this.Parent.Size = Size.Add(this.Parent.Size, Size.Subtract(this.Size, last));
            }
            last = this.Size;

            
        }*/
    }
}
