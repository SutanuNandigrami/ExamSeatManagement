namespace dashboard
{
    partial class Duration
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Duration));
            this.addDurbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Textbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statuslbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // addDurbtn
            // 
            this.addDurbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addDurbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addDurbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addDurbtn.BorderRadius = 0;
            this.addDurbtn.ButtonText = "Add Duration";
            this.addDurbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addDurbtn.DisabledColor = System.Drawing.Color.Gray;
            this.addDurbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addDurbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("addDurbtn.Iconimage")));
            this.addDurbtn.Iconimage_right = null;
            this.addDurbtn.Iconimage_right_Selected = null;
            this.addDurbtn.Iconimage_Selected = null;
            this.addDurbtn.IconMarginLeft = 0;
            this.addDurbtn.IconMarginRight = 0;
            this.addDurbtn.IconRightVisible = true;
            this.addDurbtn.IconRightZoom = 0D;
            this.addDurbtn.IconVisible = true;
            this.addDurbtn.IconZoom = 50D;
            this.addDurbtn.IsTab = true;
            this.addDurbtn.Location = new System.Drawing.Point(370, 337);
            this.addDurbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addDurbtn.Name = "addDurbtn";
            this.addDurbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addDurbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.addDurbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addDurbtn.selected = false;
            this.addDurbtn.Size = new System.Drawing.Size(293, 64);
            this.addDurbtn.TabIndex = 5;
            this.addDurbtn.Text = "Add Duration";
            this.addDurbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addDurbtn.Textcolor = System.Drawing.Color.White;
            this.addDurbtn.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDurbtn.Click += new System.EventHandler(this.addDurbtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.addDurbtn);
            this.panel2.Controls.Add(this.Textbox1);
            this.panel2.Controls.Add(this.lbl1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 661);
            this.panel2.TabIndex = 5;
            // 
            // Textbox1
            // 
            this.Textbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Textbox1.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox1.HintText = "";
            this.Textbox1.isPassword = false;
            this.Textbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.Textbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.Textbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Textbox1.LineThickness = 3;
            this.Textbox1.Location = new System.Drawing.Point(501, 187);
            this.Textbox1.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox1.Name = "Textbox1";
            this.Textbox1.Size = new System.Drawing.Size(312, 45);
            this.Textbox1.TabIndex = 4;
            this.Textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.lbl1.Location = new System.Drawing.Point(203, 198);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(213, 34);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Exam Duration";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(166)))), ((int)(((byte)(91)))));
            this.panel3.Controls.Add(this.statuslbl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1080, 64);
            this.panel3.TabIndex = 1;
            // 
            // statuslbl
            // 
            this.statuslbl.AutoSize = true;
            this.statuslbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.statuslbl.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslbl.ForeColor = System.Drawing.Color.White;
            this.statuslbl.Location = new System.Drawing.Point(51, 13);
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(0, 34);
            this.statuslbl.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 100);
            this.panel1.TabIndex = 4;
            // 
            // Duration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Duration";
            this.Size = new System.Drawing.Size(1080, 761);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton addDurbtn;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel statuslbl;
        private System.Windows.Forms.Panel panel1;
    }
}
