namespace dashboard
{
    partial class AddStudent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.deptDrp1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.studentbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.excellbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.batchDrp = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.browsetxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textbox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statuslbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.deptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tESToneDataSet1 = new dashboard.TESToneDataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refreshbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.deptTableAdapter = new dashboard.TESToneDataSet1TableAdapters.DeptTableAdapter();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deptDrp1
            // 
            this.deptDrp1.BackColor = System.Drawing.Color.Transparent;
            this.deptDrp1.BorderRadius = 3;
            this.deptDrp1.DisabledColor = System.Drawing.Color.Gray;
            this.deptDrp1.ForeColor = System.Drawing.Color.White;
            this.deptDrp1.Items = new string[0];
            this.deptDrp1.Location = new System.Drawing.Point(285, 90);
            this.deptDrp1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deptDrp1.Name = "deptDrp1";
            this.deptDrp1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.deptDrp1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.deptDrp1.selectedIndex = -1;
            this.deptDrp1.Size = new System.Drawing.Size(376, 42);
            this.deptDrp1.TabIndex = 8;
            // 
            // studentbtn
            // 
            this.studentbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.studentbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.studentbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.studentbtn.BorderRadius = 0;
            this.studentbtn.ButtonText = "Add Student";
            this.studentbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentbtn.DisabledColor = System.Drawing.Color.Gray;
            this.studentbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.studentbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("studentbtn.Iconimage")));
            this.studentbtn.Iconimage_right = null;
            this.studentbtn.Iconimage_right_Selected = null;
            this.studentbtn.Iconimage_Selected = null;
            this.studentbtn.IconMarginLeft = 0;
            this.studentbtn.IconMarginRight = 0;
            this.studentbtn.IconRightVisible = true;
            this.studentbtn.IconRightZoom = 0D;
            this.studentbtn.IconVisible = true;
            this.studentbtn.IconZoom = 50D;
            this.studentbtn.IsTab = true;
            this.studentbtn.Location = new System.Drawing.Point(216, 447);
            this.studentbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentbtn.Name = "studentbtn";
            this.studentbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.studentbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.studentbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.studentbtn.selected = false;
            this.studentbtn.Size = new System.Drawing.Size(290, 63);
            this.studentbtn.TabIndex = 5;
            this.studentbtn.Text = "Add Student";
            this.studentbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.studentbtn.Textcolor = System.Drawing.Color.White;
            this.studentbtn.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentbtn.Click += new System.EventHandler(this.studentbtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.excellbl);
            this.panel2.Controls.Add(this.bunifuFlatButton3);
            this.panel2.Controls.Add(this.bunifuFlatButton2);
            this.panel2.Controls.Add(this.bunifuCustomLabel7);
            this.panel2.Controls.Add(this.bunifuSeparator2);
            this.panel2.Controls.Add(this.bunifuSeparator1);
            this.panel2.Controls.Add(this.batchDrp);
            this.panel2.Controls.Add(this.bunifuCustomLabel4);
            this.panel2.Controls.Add(this.deptDrp1);
            this.panel2.Controls.Add(this.bunifuCustomLabel3);
            this.panel2.Controls.Add(this.bunifuFlatButton4);
            this.panel2.Controls.Add(this.studentbtn);
            this.panel2.Controls.Add(this.textbox2);
            this.panel2.Controls.Add(this.textbox1);
            this.panel2.Controls.Add(this.browsetxt);
            this.panel2.Controls.Add(this.textbox3);
            this.panel2.Controls.Add(this.bunifuCustomLabel6);
            this.panel2.Controls.Add(this.bunifuCustomLabel8);
            this.panel2.Controls.Add(this.bunifuCustomLabel5);
            this.panel2.Controls.Add(this.lbl1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1428, 677);
            this.panel2.TabIndex = 7;
            // 
            // excellbl
            // 
            this.excellbl.AutoSize = true;
            this.excellbl.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excellbl.ForeColor = System.Drawing.Color.Red;
            this.excellbl.Location = new System.Drawing.Point(920, 251);
            this.excellbl.Name = "excellbl";
            this.excellbl.Size = new System.Drawing.Size(0, 17);
            this.excellbl.TabIndex = 12;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Add Department";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 50D;
            this.bunifuFlatButton3.IsTab = true;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(1793, 86);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(207, 64);
            this.bunifuFlatButton3.TabIndex = 11;
            this.bunifuFlatButton3.Text = "Add Department";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Browse Excel File";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 50D;
            this.bunifuFlatButton2.IsTab = true;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(908, 97);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(314, 64);
            this.bunifuFlatButton2.TabIndex = 11;
            this.bunifuFlatButton2.Text = "Browse Excel File";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(680, 310);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(49, 30);
            this.bunifuCustomLabel7.TabIndex = 10;
            this.bunifuCustomLabel7.Text = "OR";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(685, 366);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(38, 185);
            this.bunifuSeparator2.TabIndex = 9;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(685, 90);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(38, 185);
            this.bunifuSeparator1.TabIndex = 9;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // batchDrp
            // 
            this.batchDrp.BackColor = System.Drawing.Color.Transparent;
            this.batchDrp.BorderRadius = 3;
            this.batchDrp.DisabledColor = System.Drawing.Color.Gray;
            this.batchDrp.ForeColor = System.Drawing.Color.White;
            this.batchDrp.Items = new string[0];
            this.batchDrp.Location = new System.Drawing.Point(285, 140);
            this.batchDrp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.batchDrp.Name = "batchDrp";
            this.batchDrp.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.batchDrp.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.batchDrp.selectedIndex = -1;
            this.batchDrp.Size = new System.Drawing.Size(376, 42);
            this.batchDrp.TabIndex = 8;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(12, 152);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(82, 30);
            this.bunifuCustomLabel4.TabIndex = 7;
            this.bunifuCustomLabel4.Text = "Batch";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(12, 102);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(157, 30);
            this.bunifuCustomLabel3.TabIndex = 7;
            this.bunifuCustomLabel3.Text = "Department";
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Upload";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 50D;
            this.bunifuFlatButton4.IsTab = true;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(908, 306);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(314, 64);
            this.bunifuFlatButton4.TabIndex = 5;
            this.bunifuFlatButton4.Text = "Upload";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // textbox2
            // 
            this.textbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox2.HintForeColor = System.Drawing.Color.Empty;
            this.textbox2.HintText = "";
            this.textbox2.isPassword = false;
            this.textbox2.LineFocusedColor = System.Drawing.Color.Blue;
            this.textbox2.LineIdleColor = System.Drawing.Color.Gray;
            this.textbox2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textbox2.LineThickness = 3;
            this.textbox2.Location = new System.Drawing.Point(285, 273);
            this.textbox2.Margin = new System.Windows.Forms.Padding(4);
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(376, 44);
            this.textbox2.TabIndex = 4;
            this.textbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textbox1
            // 
            this.textbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox1.HintForeColor = System.Drawing.Color.Empty;
            this.textbox1.HintText = "";
            this.textbox1.isPassword = false;
            this.textbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.textbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.textbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textbox1.LineThickness = 3;
            this.textbox1.Location = new System.Drawing.Point(285, 348);
            this.textbox1.Margin = new System.Windows.Forms.Padding(4);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(376, 35);
            this.textbox1.TabIndex = 4;
            this.textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // browsetxt
            // 
            this.browsetxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.browsetxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.browsetxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.browsetxt.HintForeColor = System.Drawing.Color.Empty;
            this.browsetxt.HintText = "";
            this.browsetxt.isPassword = false;
            this.browsetxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.browsetxt.LineIdleColor = System.Drawing.Color.Gray;
            this.browsetxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.browsetxt.LineThickness = 3;
            this.browsetxt.Location = new System.Drawing.Point(881, 183);
            this.browsetxt.Margin = new System.Windows.Forms.Padding(4);
            this.browsetxt.Name = "browsetxt";
            this.browsetxt.Size = new System.Drawing.Size(341, 45);
            this.browsetxt.TabIndex = 4;
            this.browsetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textbox3
            // 
            this.textbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox3.HintForeColor = System.Drawing.Color.Empty;
            this.textbox3.HintText = "";
            this.textbox3.isPassword = false;
            this.textbox3.LineFocusedColor = System.Drawing.Color.Blue;
            this.textbox3.LineIdleColor = System.Drawing.Color.Gray;
            this.textbox3.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textbox3.LineThickness = 3;
            this.textbox3.Location = new System.Drawing.Point(285, 207);
            this.textbox3.Margin = new System.Windows.Forms.Padding(4);
            this.textbox3.Name = "textbox3";
            this.textbox3.Size = new System.Drawing.Size(376, 44);
            this.textbox3.TabIndex = 4;
            this.textbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(12, 287);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(159, 30);
            this.bunifuCustomLabel6.TabIndex = 2;
            this.bunifuCustomLabel6.Text = "Roll Number";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(730, 198);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(134, 30);
            this.bunifuCustomLabel8.TabIndex = 2;
            this.bunifuCustomLabel8.Text = "File Name";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(12, 348);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(255, 30);
            this.bunifuCustomLabel5.TabIndex = 2;
            this.bunifuCustomLabel5.Text = "Registration Number";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.lbl1.Location = new System.Drawing.Point(12, 221);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(184, 30);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Student Name";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(166)))), ((int)(((byte)(91)))));
            this.panel3.Controls.Add(this.statuslbl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1428, 64);
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
            // deptBindingSource
            // 
            this.deptBindingSource.DataMember = "Dept";
            this.deptBindingSource.DataSource = this.tESToneDataSet1;
            // 
            // tESToneDataSet1
            // 
            this.tESToneDataSet1.DataSetName = "TESToneDataSet1";
            this.tESToneDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.refreshbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1428, 100);
            this.panel1.TabIndex = 6;
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
            this.refreshbtn.Location = new System.Drawing.Point(573, 15);
            this.refreshbtn.Margin = new System.Windows.Forms.Padding(6);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.refreshbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(11)))), ((int)(((byte)(14)))));
            this.refreshbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.refreshbtn.selected = false;
            this.refreshbtn.Size = new System.Drawing.Size(171, 51);
            this.refreshbtn.TabIndex = 17;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.refreshbtn.Textcolor = System.Drawing.Color.White;
            this.refreshbtn.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // deptTableAdapter
            // 
            this.deptTableAdapter.ClearBeforeFill = true;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddStudent";
            this.Size = new System.Drawing.Size(1428, 777);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDropdown deptDrp1;
        private Bunifu.Framework.UI.BunifuFlatButton studentbtn;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textbox3;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel statuslbl;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDropdown batchDrp;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textbox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textbox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox browsetxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel excellbl;
        private TESToneDataSet1 tESToneDataSet1;
        private TESToneDataSet1TableAdapters.DeptTableAdapter deptTableAdapter;
        private System.Windows.Forms.BindingSource deptBindingSource;
        private Bunifu.Framework.UI.BunifuFlatButton refreshbtn;
    }
}
