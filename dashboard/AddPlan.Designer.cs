namespace dashboard
{
    partial class AddPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPlan));
            this.lbl1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.roomdrp = new Bunifu.Framework.UI.BunifuDropdown();
            this.batchdrp = new Bunifu.Framework.UI.BunifuDropdown();
            this.deptdrp = new Bunifu.Framework.UI.BunifuDropdown();
            this.durdrp = new Bunifu.Framework.UI.BunifuDropdown();
            this.addRoombtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Textbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Textbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statuslbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refreshbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.lbl1.Location = new System.Drawing.Point(263, 157);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(83, 34);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Date";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.bunifuDatepicker1);
            this.panel2.Controls.Add(this.roomdrp);
            this.panel2.Controls.Add(this.batchdrp);
            this.panel2.Controls.Add(this.deptdrp);
            this.panel2.Controls.Add(this.durdrp);
            this.panel2.Controls.Add(this.addRoombtn);
            this.panel2.Controls.Add(this.Textbox2);
            this.panel2.Controls.Add(this.Textbox1);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Controls.Add(this.bunifuCustomLabel6);
            this.panel2.Controls.Add(this.bunifuCustomLabel5);
            this.panel2.Controls.Add(this.bunifuCustomLabel4);
            this.panel2.Controls.Add(this.bunifuCustomLabel3);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Controls.Add(this.lbl1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1140, 683);
            this.panel2.TabIndex = 3;
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(398, 147);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(312, 44);
            this.bunifuDatepicker1.TabIndex = 7;
            this.bunifuDatepicker1.Value = new System.DateTime(2018, 3, 12, 0, 6, 44, 890);
            // 
            // roomdrp
            // 
            this.roomdrp.BackColor = System.Drawing.Color.Transparent;
            this.roomdrp.BorderRadius = 3;
            this.roomdrp.DisabledColor = System.Drawing.Color.Gray;
            this.roomdrp.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.roomdrp.ForeColor = System.Drawing.Color.White;
            this.roomdrp.Items = new string[0];
            this.roomdrp.Location = new System.Drawing.Point(398, 403);
            this.roomdrp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roomdrp.Name = "roomdrp";
            this.roomdrp.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.roomdrp.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.roomdrp.selectedIndex = -1;
            this.roomdrp.Size = new System.Drawing.Size(312, 44);
            this.roomdrp.TabIndex = 6;
            // 
            // batchdrp
            // 
            this.batchdrp.BackColor = System.Drawing.Color.Transparent;
            this.batchdrp.BorderRadius = 3;
            this.batchdrp.DisabledColor = System.Drawing.Color.Gray;
            this.batchdrp.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.batchdrp.ForeColor = System.Drawing.Color.White;
            this.batchdrp.Items = new string[0];
            this.batchdrp.Location = new System.Drawing.Point(398, 342);
            this.batchdrp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.batchdrp.Name = "batchdrp";
            this.batchdrp.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.batchdrp.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.batchdrp.selectedIndex = -1;
            this.batchdrp.Size = new System.Drawing.Size(312, 44);
            this.batchdrp.TabIndex = 6;
            // 
            // deptdrp
            // 
            this.deptdrp.BackColor = System.Drawing.Color.Transparent;
            this.deptdrp.BorderRadius = 3;
            this.deptdrp.DisabledColor = System.Drawing.Color.Gray;
            this.deptdrp.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.deptdrp.ForeColor = System.Drawing.Color.White;
            this.deptdrp.Items = new string[0];
            this.deptdrp.Location = new System.Drawing.Point(398, 284);
            this.deptdrp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deptdrp.Name = "deptdrp";
            this.deptdrp.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.deptdrp.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.deptdrp.selectedIndex = -1;
            this.deptdrp.Size = new System.Drawing.Size(312, 44);
            this.deptdrp.TabIndex = 6;
            // 
            // durdrp
            // 
            this.durdrp.BackColor = System.Drawing.Color.Transparent;
            this.durdrp.BorderRadius = 3;
            this.durdrp.DisabledColor = System.Drawing.Color.Gray;
            this.durdrp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durdrp.ForeColor = System.Drawing.Color.White;
            this.durdrp.Items = new string[0];
            this.durdrp.Location = new System.Drawing.Point(398, 226);
            this.durdrp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.durdrp.Name = "durdrp";
            this.durdrp.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.durdrp.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.durdrp.selectedIndex = -1;
            this.durdrp.Size = new System.Drawing.Size(312, 44);
            this.durdrp.TabIndex = 6;
            // 
            // addRoombtn
            // 
            this.addRoombtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addRoombtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addRoombtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addRoombtn.BorderRadius = 0;
            this.addRoombtn.ButtonText = "Add Plan";
            this.addRoombtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addRoombtn.DisabledColor = System.Drawing.Color.Gray;
            this.addRoombtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addRoombtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("addRoombtn.Iconimage")));
            this.addRoombtn.Iconimage_right = null;
            this.addRoombtn.Iconimage_right_Selected = null;
            this.addRoombtn.Iconimage_Selected = null;
            this.addRoombtn.IconMarginLeft = 0;
            this.addRoombtn.IconMarginRight = 0;
            this.addRoombtn.IconRightVisible = true;
            this.addRoombtn.IconRightZoom = 0D;
            this.addRoombtn.IconVisible = true;
            this.addRoombtn.IconZoom = 50D;
            this.addRoombtn.IsTab = true;
            this.addRoombtn.Location = new System.Drawing.Point(379, 596);
            this.addRoombtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addRoombtn.Name = "addRoombtn";
            this.addRoombtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addRoombtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.addRoombtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addRoombtn.selected = false;
            this.addRoombtn.Size = new System.Drawing.Size(228, 64);
            this.addRoombtn.TabIndex = 5;
            this.addRoombtn.Text = "Add Plan";
            this.addRoombtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addRoombtn.Textcolor = System.Drawing.Color.White;
            this.addRoombtn.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Textbox2
            // 
            this.Textbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Textbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Textbox2.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox2.HintText = "";
            this.Textbox2.isPassword = false;
            this.Textbox2.LineFocusedColor = System.Drawing.Color.Blue;
            this.Textbox2.LineIdleColor = System.Drawing.Color.Gray;
            this.Textbox2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Textbox2.LineThickness = 3;
            this.Textbox2.Location = new System.Drawing.Point(675, 478);
            this.Textbox2.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox2.Name = "Textbox2";
            this.Textbox2.Size = new System.Drawing.Size(177, 45);
            this.Textbox2.TabIndex = 4;
            this.Textbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Textbox1
            // 
            this.Textbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Textbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Textbox1.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox1.HintText = "";
            this.Textbox1.isPassword = false;
            this.Textbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.Textbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.Textbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Textbox1.LineThickness = 3;
            this.Textbox1.Location = new System.Drawing.Point(398, 478);
            this.Textbox1.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox1.Name = "Textbox1";
            this.Textbox1.Size = new System.Drawing.Size(177, 45);
            this.Textbox1.TabIndex = 4;
            this.Textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(214, 489);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(160, 34);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Roll Range";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(609, 489);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(44, 34);
            this.bunifuCustomLabel6.TabIndex = 2;
            this.bunifuCustomLabel6.Text = "To";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(214, 413);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(148, 34);
            this.bunifuCustomLabel5.TabIndex = 2;
            this.bunifuCustomLabel5.Text = "Room No.";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(213, 352);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(149, 34);
            this.bunifuCustomLabel4.TabIndex = 2;
            this.bunifuCustomLabel4.Text = "Batch No.";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(181, 294);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(181, 34);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = "Department";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(230, 236);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(132, 34);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Duration";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(166)))), ((int)(((byte)(91)))));
            this.panel3.Controls.Add(this.statuslbl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1140, 64);
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
            this.panel1.Size = new System.Drawing.Size(1140, 100);
            this.panel1.TabIndex = 2;
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
            this.refreshbtn.Location = new System.Drawing.Point(460, 22);
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
            // AddPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddPlan";
            this.Size = new System.Drawing.Size(1140, 783);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lbl1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton addRoombtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel statuslbl;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDropdown roomdrp;
        private Bunifu.Framework.UI.BunifuDropdown batchdrp;
        private Bunifu.Framework.UI.BunifuDropdown deptdrp;
        private Bunifu.Framework.UI.BunifuDropdown durdrp;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuFlatButton refreshbtn;
    }
}
