using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DoubleButton
{
    public partial class UserControl1:UserControl 
    {
       

        public UserControl1()
        {
            InitializeComponent();
           /* this.pbEdit = new PictureBox();
            this.Controls.Add(this.pbEdit);

            this.pbDelete = new PictureBox();
            this.Controls.Add(this.pbDelete);*/

           // this.renderControl();
            this.pbDelete.Click += new EventHandler(pbDelete_Click);
            this.pbEdit.Click += new EventHandler(pbEdit_Click);
        }

       void pbDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit");
        }
        void pbEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete" );
        }

        
        public void renderControl()
        {
            this.pbEdit.Location = new Point(0, 0);
            this.pbEdit.Width = this.Width / 3;
            this.pbEdit.Height = this.Height;

            this.pbDelete.Location = new Point(2 * this.Width / 3, 0);
            this.pbDelete.Width = this.Width / 3;
            this.pbDelete.Height = this.Height;
        }
    }
}
