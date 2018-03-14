namespace dashboard
{
    partial class AddSem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSem));
            this.addBatchbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deptdrp = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Textbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statuslbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refreshbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBatchbtn
            // 
            this.addBatchbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addBatchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addBatchbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addBatchbtn.BorderRadius = 0;
            this.addBatchbtn.ButtonText = "Add Batch";
            this.addBatchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBatchbtn.DisabledColor = System.Drawing.Color.Gray;
            this.addBatchbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addBatchbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("addBatchbtn.Iconimage")));
            this.addBatchbtn.Iconimage_right = null;
            this.addBatchbtn.Iconimage_right_Selected = null;
            this.addBatchbtn.Iconimage_Selected = null;
            this.addBatchbtn.IconMarginLeft = 0;
            this.addBatchbtn.IconMarginRight = 0;
            this.addBatchbtn.IconRightVisible = true;
            this.addBatchbtn.IconRightZoom = 0D;
            this.addBatchbtn.IconVisible = true;
            this.addBatchbtn.IconZoom = 50D;
            this.addBatchbtn.IsTab = true;
            this.addBatchbtn.Location = new System.Drawing.Point(372, 409);
            this.addBatchbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addBatchbtn.Name = "addBatchbtn";
            this.addBatchbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addBatchbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.addBatchbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addBatchbtn.selected = false;
            this.addBatchbtn.Size = new System.Drawing.Size(293, 64);
            this.addBatchbtn.TabIndex = 5;
            this.addBatchbtn.Text = "Add Batch";
            this.addBatchbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addBatchbtn.Textcolor = System.Drawing.Color.White;
            this.addBatchbtn.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBatchbtn.Click += new System.EventHandler(this.addBatchbtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.deptdrp);
            this.panel2.Controls.Add(this.bunifuCustomLabel3);
            this.panel2.Controls.Add(this.addBatchbtn);
            this.panel2.Controls.Add(this.Textbox1);
            this.panel2.Controls.Add(this.lbl1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1065, 642);
            this.panel2.TabIndex = 5;
            // 
            // deptdrp
            // 
            this.deptdrp.BackColor = System.Drawing.Color.Transparent;
            this.deptdrp.BorderRadius = 3;
            this.deptdrp.DisabledColor = System.Drawing.Color.Gray;
            this.deptdrp.ForeColor = System.Drawing.Color.White;
            this.deptdrp.Items = new string[0];
            this.deptdrp.Location = new System.Drawing.Point(501, 276);
            this.deptdrp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deptdrp.Name = "deptdrp";
            this.deptdrp.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.deptdrp.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.deptdrp.selectedIndex = -1;
            this.deptdrp.Size = new System.Drawing.Size(312, 43);
            this.deptdrp.TabIndex = 8;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(274, 276);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(181, 34);
            this.bunifuCustomLabel3.TabIndex = 7;
            this.bunifuCustomLabel3.Text = "Department";
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
            this.Textbox1.Location = new System.Drawing.Point(501, 151);
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
            this.lbl1.Location = new System.Drawing.Point(317, 162);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(138, 34);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Semester";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(166)))), ((int)(((byte)(91)))));
            this.panel3.Controls.Add(this.statuslbl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1065, 64);
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
            this.panel1.Controls.Add(this.refreshbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 100);
            this.panel1.TabIndex = 4;
            // 
            // refreshbtn
            // 
            this.refreshbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.refreshbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.refreshbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshbtn.BorderRadius = 0;
            this.refreshbtn.ButtonText = "Refresh";
            this.refreshbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshbtn.DisabledColor = System.Drawing.Color.Gray;
            this.refreshbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.refreshbtn.Iconimage = global::dashboard.Properties.Resources.Refresh_80px;
            this.refreshbtn.Iconimage_right = null;
            this.refreshbtn.Iconimage_right_Selected = null;
            this.refreshbtn.Iconimage_Selected = null;
            this.refreshbtn.IconMarginLeft = 0;
            this.refreshbtn.IconMarginRight = 0;
            this.refreshbtn.IconRightVisible = true;
            this.refreshbtn.IconRightZoom = 0D;
            this.refreshbtn.IconVisible = true;
            this.refreshbtn.IconZoom = 50D;
            this.refreshbtn.IsTab = true;
            this.refreshbtn.Location = new System.Drawing.Point(425, 23);
            this.refreshbtn.Margin = new System.Windows.Forms.Padding(6);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.refreshbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(11)))), ((int)(((byte)(14)))));
            this.refreshbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.refreshbtn.selected = false;
            this.refreshbtn.Size = new System.Drawing.Size(171, 51);
            this.refreshbtn.TabIndex = 18;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.refreshbtn.Textcolor = System.Drawing.Color.White;
            this.refreshbtn.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // AddSem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddSem";
            this.Size = new System.Drawing.Size(1065, 742);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton addBatchbtn;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel statuslbl;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuDropdown deptdrp;
        private Bunifu.Framework.UI.BunifuFlatButton refreshbtn;
    }
}
