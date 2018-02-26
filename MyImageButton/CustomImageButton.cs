using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyImageButton
{
    public partial class CustomImageButton: PictureBox
    {
        public CustomImageButton()
        {
            InitializeComponent();
        }

        private Image normalImage;
        private Image hovarImage;

        public Image ImageNormal
        {
            get{ return normalImage; }
            set { normalImage = value; }

        }

        public Image ImageHover
        {
            get { return hovarImage; }
            set { hovarImage = value; }
        }

        private void CustomImageButton_MouseHover(object sender, EventArgs e)
        {
            this.Image = hovarImage;
        }

        private void CustomImageButton_MouseLeave(object sender, EventArgs e)
        {
            this.Image = normalImage;
        }
    }
}
