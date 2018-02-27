using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using System.Data.SqlClient;

namespace dashboard
{
    public partial class Dashboard : Form
    {
         
        
        //Form Load Event
          public Dashboard()
        {
            
             InitializeComponent();
            //to hide menu bar initially
            leftpanel.Visible = false;
            leftsubpnl.Visible = false;
            //to position Main Container Panel
           // Mainpnl.Dock = DockStyle.Fill;

            //Load dashBoard User Control At Form Load
            if (!Mainpnl.Controls.Contains(Dash.Instance))
            {
                Mainpnl.Controls.Add(Dash.Instance);
                Dash.Instance.Dock = DockStyle.Fill;
                Dash.Instance.BringToFront();
            }
            else
                Dash.Instance.BringToFront();

        }

        

        //Hamburger Button Function
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (leftpanel.Visible == false)
            {
                
                leftpanel.Visible = true;
                //Mainpnl.Dock = DockStyle.None;
                leftsubpnl.Visible = false;
            }
            else
            {
                leftpanel.Visible = false;
                //Mainpnl.Dock = DockStyle.Fill;
                leftsubpnl.Visible = false;
            }
           
          }

        //Dashboard button control
        private void btnDash_Click(object sender, EventArgs e)
        {
            clean();
            panel2.Visible = false;
            //Load dashBoard User Control when clicked
            if (!Mainpnl.Controls.Contains(Dash.Instance))
            {
                Mainpnl.Controls.Add(Dash.Instance);
                Dash.Instance.Dock = DockStyle.Fill;
                Dash.Instance.BringToFront();
            }
            else
                Dash.Instance.BringToFront();

        }

        //Setting button control
        private void btnSetting_Click(object sender, EventArgs e)
        {
            clean();
            if (panel2.Visible == false)
            {
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;
            }
            
        }

        //fuction to clean all panels
        private void clean()
        {
           
            spnlRoom.Visible = false;
            spnlDept.Visible = false;
            spnlBatch.Visible = false;
            spnlStudent.Visible = false;
            spnlDur.Visible = false;
            pnlOperation.Visible = false;
            leftsubpnl.Visible = false;
        }

       
        //sub menu Showing Codes
        private void btnDept_Click(object sender, EventArgs e)
        {
            if ((spnlRoom.Visible = true) || (spnlBatch.Visible = true) || (spnlStudent.Visible = true) || (spnlDur.Visible = true) || (pnlOperation.Visible = true))
            {
                
                spnlRoom.Visible = false;
                //spnlDept.Visible = false;
                spnlBatch.Visible = false;
                spnlStudent.Visible = false;
                spnlDur.Visible = false;
                pnlOperation.Visible = false;
            }

            if (spnlDept.Visible == false)
            {
                spnlDept.Show();
                leftsubpnl.Visible = true;

            }
            else
            {
                spnlDept.Hide();
                leftsubpnl.Visible = false;
            }

            }

        private void btnDur_Click(object sender, EventArgs e)
        {

            if ((spnlRoom.Visible = true) || (spnlBatch.Visible = true) || (spnlStudent.Visible = true) || (spnlBatch.Visible = true) || (pnlOperation.Visible = true))
            {
                
                spnlRoom.Visible = false;
                spnlDept.Visible = false;
                spnlBatch.Visible = false;
                spnlStudent.Visible = false;
                // spnlDur.Visible = false;
                pnlOperation.Visible = false;
            }

            if (spnlDur.Visible == false)
            {
                leftsubpnl.Visible = true;
                spnlDur.Show();
            }
            else
            {
                spnlDur.Hide();
                leftsubpnl.Visible = false;
            }
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {

            if ((spnlRoom.Visible = true) || (spnlBatch.Visible = true) || (spnlDept.Visible = true) || (spnlDur.Visible = true) || (pnlOperation.Visible = true))
            {
                
                spnlRoom.Visible = false;
                spnlDept.Visible = false;
                spnlBatch.Visible = false;
               // spnlStudent.Visible = false;
                spnlDur.Visible = false;
                pnlOperation.Visible = false;
            }

            if (spnlStudent.Visible == false)
            {
                leftsubpnl.Visible = true;
                spnlStudent.Show();

            }
            else
            {
                spnlStudent.Hide();
                leftsubpnl.Visible = false;
            }
            }

        private void btnBatch_Click(object sender, EventArgs e)
        {
            if ((spnlRoom.Visible = true) || (spnlDept.Visible = true) || (spnlStudent.Visible = true) || (spnlDur.Visible = true) || (pnlOperation.Visible = true))
            {
                spnlRoom.Visible = false;
                spnlDept.Visible = false;
                //spnlBatch.Visible = false;
                spnlStudent.Visible = false;
                spnlDur.Visible = false;
                pnlOperation.Visible = false;
            }

            if (spnlBatch.Visible == false)
            {
                spnlBatch.Show();
                leftsubpnl.Visible = true;
            }
            else
            {
                spnlBatch.Hide();
                leftsubpnl.Visible = false;
            }
            }
        private void btnOperation_Click(object sender, EventArgs e)
        {
            if ((spnlRoom.Visible = true) || (spnlDept.Visible = true) || (spnlBatch.Visible = true) || (spnlStudent.Visible = true) || (spnlDur.Visible = true))
            {
                spnlRoom.Visible = false;
                spnlDept.Visible = false;
                spnlBatch.Visible = false;
                spnlStudent.Visible = false;
                spnlDur.Visible = false;
                //pnlOperation.Visible = false;
            }
            if (pnlOperation.Visible == false)
            {
                pnlOperation.Show();
                leftsubpnl.Visible = true;
            }
            else
            {
                pnlOperation.Hide();
                leftsubpnl.Visible = false;
            }
            }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            if ((pnlOperation.Visible = true) || (spnlDept.Visible = true) || (spnlBatch.Visible = true) || (spnlStudent.Visible = true) || (spnlDur.Visible = true))

                //spnlRoom.Visible = false;
                spnlDept.Visible = false;
            spnlBatch.Visible = false;
            spnlStudent.Visible = false;
            spnlDur.Visible = false;
            pnlOperation.Visible = false;
            if (spnlRoom.Visible == false)
            {
                spnlRoom.Show();
                leftsubpnl.Visible = true;
            }
            else
            {
                spnlRoom.Hide();
                leftsubpnl.Visible = false;
            }
        }

        //Head Panel Click Auto Hide
        public void hide()
        {
            leftpanel.Hide();
            leftsubpnl.Hide();
            //Mainpnl.Dock = DockStyle.Fill;

        }
        private void headpanel_Click(object sender, EventArgs e)
        {
            hide();
        }


        //close, Maximize,minimize,restore buttons
        private void Closebtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maxminbtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                maxminbtn.Image = dashboard.Properties.Resources.icons8_Maximize_Window_64;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                maxminbtn.Image = dashboard.Properties.Resources.icons8_Restore_Window_641;
            }
        }

        // User Control Fetching Area

        private void AddRoombtn_Click(object sender, EventArgs e)
        {
            //Load Add Room User Control 
            if (!Mainpnl.Controls.Contains(tab1.Instance))
            {
                Mainpnl.Controls.Add(tab1.Instance);
                tab1.Instance.Dock = DockStyle.Fill;
                tab1.Instance.BringToFront();
                clean();
                
            }
            else
                tab1.Instance.BringToFront();
        }

        private void AddDeptbtn_Click(object sender, EventArgs e)
        {
            //Load Add Dept User Control 
            if (!Mainpnl.Controls.Contains(AddDept.Instance))
            {
                Mainpnl.Controls.Add(AddDept.Instance);
                AddDept.Instance.Dock = DockStyle.Fill;
                AddDept.Instance.BringToFront();
                clean();

            }
            else
                AddDept.Instance.BringToFront();
        }

        private void AddBatchbtn_Click(object sender, EventArgs e)
        {
            //Load Add Room User Control 
            if (!Mainpnl.Controls.Contains(AddSem.Instance))
            {
                Mainpnl.Controls.Add(AddSem.Instance);
                AddSem.Instance.Dock = DockStyle.Fill;
                AddSem.Instance.BringToFront();
                clean();

            }
            else
                AddSem.Instance.BringToFront();
        }

        private void AddStudentbtn_Click(object sender, EventArgs e)
        {
            //Load Add Room User Control 
            if (!Mainpnl.Controls.Contains(AddStudent.Instance))
            {
                Mainpnl.Controls.Add(AddStudent.Instance);
                AddStudent.Instance.Dock = DockStyle.Fill;
                AddStudent.Instance.BringToFront();
                clean();

            }
            else
                AddStudent.Instance.BringToFront();
        }

        private void AddDurbtn_Click(object sender, EventArgs e)
        {
            //Load Add Room User Control 
            if (!Mainpnl.Controls.Contains(Duration.Instance))
            {
                Mainpnl.Controls.Add(Duration.Instance);
                Duration.Instance.Dock = DockStyle.Fill;
                Duration.Instance.BringToFront();
                clean();

            }
            else
                Duration.Instance.BringToFront();
        }

        private void AddPlanbtn_Click(object sender, EventArgs e)
        {
            //Load Add Room User Control 
            if (!Mainpnl.Controls.Contains(AddPlan.Instance))
            {
                Mainpnl.Controls.Add(AddPlan.Instance);
                AddPlan.Instance.Dock = DockStyle.Fill;
                AddPlan.Instance.BringToFront();
                clean();

            }
            else
                AddPlan.Instance.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewRoombtn_Click(object sender, EventArgs e)
        {
            //Load View Room User Control 
            if (!Mainpnl.Controls.Contains(ViewRoom.Instance))
            {
                Mainpnl.Controls.Add(ViewRoom.Instance);
                ViewRoom.Instance.Dock = DockStyle.Fill;
                ViewRoom.Instance.BringToFront();
                clean();

            }
            else
                ViewRoom.Instance.BringToFront();
            

        }

        private void ViewDeptbtn_Click(object sender, EventArgs e)
        {
            //Load View Department User Control 
            if (!Mainpnl.Controls.Contains(ViewDept.Instance))
            {
                Mainpnl.Controls.Add(ViewDept.Instance);
                ViewDept.Instance.Dock = DockStyle.Fill;
                ViewDept.Instance.BringToFront();
                clean();

            }
            else
                ViewDept.Instance.BringToFront();
        }
    }
}
