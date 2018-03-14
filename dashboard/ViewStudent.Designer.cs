namespace dashboard
{
    partial class ViewStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.deptDrp1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.refreshbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.viewallbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchbtn2 = new MyImageButton.CustomImageButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.editpnl = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textbox5 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textbox4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textbox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.roomTableAdapter = new dashboard.TESToneDataSetTableAdapters.RoomTableAdapter();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tESToneDataSet = new dashboard.TESToneDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.regNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.univRollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tESToneDataSet1 = new dashboard.TESToneDataSet1();
            this.studentTableAdapter = new dashboard.TESToneDataSet1TableAdapters.StudentTableAdapter();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchbtn2)).BeginInit();
            this.editpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.searchbox1);
            this.panel1.Controls.Add(this.deptDrp1);
            this.panel1.Controls.Add(this.refreshbtn);
            this.panel1.Controls.Add(this.viewallbtn);
            this.panel1.Controls.Add(this.searchbtn2);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1348, 100);
            this.panel1.TabIndex = 4;
            // 
            // searchbox1
            // 
            this.searchbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchbox1.ForeColor = System.Drawing.Color.White;
            this.searchbox1.HintForeColor = System.Drawing.Color.White;
            this.searchbox1.HintText = "Reg No/ Name/ Sem";
            this.searchbox1.isPassword = false;
            this.searchbox1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.searchbox1.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.searchbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.searchbox1.LineThickness = 3;
            this.searchbox1.Location = new System.Drawing.Point(573, 48);
            this.searchbox1.Margin = new System.Windows.Forms.Padding(4);
            this.searchbox1.Name = "searchbox1";
            this.searchbox1.Size = new System.Drawing.Size(337, 36);
            this.searchbox1.TabIndex = 4;
            this.searchbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // deptDrp1
            // 
            this.deptDrp1.BackColor = System.Drawing.Color.Transparent;
            this.deptDrp1.BorderRadius = 3;
            this.deptDrp1.DisabledColor = System.Drawing.Color.Gray;
            this.deptDrp1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptDrp1.ForeColor = System.Drawing.Color.White;
            this.deptDrp1.Items = new string[0];
            this.deptDrp1.Location = new System.Drawing.Point(258, 36);
            this.deptDrp1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.deptDrp1.Name = "deptDrp1";
            this.deptDrp1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.deptDrp1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(11)))), ((int)(((byte)(14)))));
            this.deptDrp1.selectedIndex = -1;
            this.deptDrp1.Size = new System.Drawing.Size(290, 48);
            this.deptDrp1.TabIndex = 18;
            this.deptDrp1.onItemSelected += new System.EventHandler(this.deptDrp1_onItemSelected);
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
            this.refreshbtn.Location = new System.Drawing.Point(1171, 33);
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
            // viewallbtn
            // 
            this.viewallbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.viewallbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.viewallbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viewallbtn.BorderRadius = 0;
            this.viewallbtn.ButtonText = "View All";
            this.viewallbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewallbtn.DisabledColor = System.Drawing.Color.Gray;
            this.viewallbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.viewallbtn.Iconimage = global::dashboard.Properties.Resources.Eye_96px;
            this.viewallbtn.Iconimage_right = null;
            this.viewallbtn.Iconimage_right_Selected = null;
            this.viewallbtn.Iconimage_Selected = null;
            this.viewallbtn.IconMarginLeft = 0;
            this.viewallbtn.IconMarginRight = 0;
            this.viewallbtn.IconRightVisible = true;
            this.viewallbtn.IconRightZoom = 0D;
            this.viewallbtn.IconVisible = true;
            this.viewallbtn.IconZoom = 50D;
            this.viewallbtn.IsTab = true;
            this.viewallbtn.Location = new System.Drawing.Point(988, 33);
            this.viewallbtn.Margin = new System.Windows.Forms.Padding(6);
            this.viewallbtn.Name = "viewallbtn";
            this.viewallbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.viewallbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(11)))), ((int)(((byte)(14)))));
            this.viewallbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.viewallbtn.selected = false;
            this.viewallbtn.Size = new System.Drawing.Size(171, 51);
            this.viewallbtn.TabIndex = 16;
            this.viewallbtn.Text = "View All";
            this.viewallbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewallbtn.Textcolor = System.Drawing.Color.White;
            this.viewallbtn.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewallbtn.Click += new System.EventHandler(this.viewallbtn_Click);
            // 
            // searchbtn2
            // 
            this.searchbtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.searchbtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchbtn2.Image = global::dashboard.Properties.Resources.Search_100px;
            this.searchbtn2.ImageHover = global::dashboard.Properties.Resources.Detective_96px;
            this.searchbtn2.ImageNormal = global::dashboard.Properties.Resources.Search_100px;
            this.searchbtn2.Location = new System.Drawing.Point(933, 16);
            this.searchbtn2.Name = "searchbtn2";
            this.searchbtn2.Size = new System.Drawing.Size(46, 81);
            this.searchbtn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchbtn2.TabIndex = 7;
            this.searchbtn2.TabStop = false;
            this.searchbtn2.Click += new System.EventHandler(this.searchbtn2_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(11, 26);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(198, 34);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "View Student";
            // 
            // editpnl
            // 
            this.editpnl.BackColor = System.Drawing.Color.White;
            this.editpnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editpnl.Controls.Add(this.bunifuCustomLabel4);
            this.editpnl.Controls.Add(this.bunifuCustomLabel3);
            this.editpnl.Controls.Add(this.textbox2);
            this.editpnl.Controls.Add(this.textbox1);
            this.editpnl.Controls.Add(this.textbox5);
            this.editpnl.Controls.Add(this.textbox4);
            this.editpnl.Controls.Add(this.textbox3);
            this.editpnl.Controls.Add(this.bunifuCustomLabel7);
            this.editpnl.Controls.Add(this.bunifuCustomLabel8);
            this.editpnl.Controls.Add(this.lbl1);
            this.editpnl.Controls.Add(this.bunifuFlatButton2);
            this.editpnl.Controls.Add(this.bunifuFlatButton1);
            this.editpnl.Controls.Add(this.bunifuCustomLabel5);
            this.editpnl.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.editpnl.ForeColor = System.Drawing.Color.White;
            this.editpnl.Location = new System.Drawing.Point(286, 231);
            this.editpnl.Name = "editpnl";
            this.editpnl.Size = new System.Drawing.Size(840, 532);
            this.editpnl.TabIndex = 1;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(225, 109);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(82, 30);
            this.bunifuCustomLabel4.TabIndex = 29;
            this.bunifuCustomLabel4.Text = "Batch";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(150, 47);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(157, 30);
            this.bunifuCustomLabel3.TabIndex = 30;
            this.bunifuCustomLabel3.Text = "Department";
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
            this.textbox2.Location = new System.Drawing.Point(355, 218);
            this.textbox2.Margin = new System.Windows.Forms.Padding(4);
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(365, 45);
            this.textbox2.TabIndex = 24;
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
            this.textbox1.Location = new System.Drawing.Point(355, 288);
            this.textbox1.Margin = new System.Windows.Forms.Padding(4);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(365, 45);
            this.textbox1.TabIndex = 25;
            this.textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textbox5
            // 
            this.textbox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textbox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox5.HintForeColor = System.Drawing.Color.Empty;
            this.textbox5.HintText = "";
            this.textbox5.isPassword = false;
            this.textbox5.LineFocusedColor = System.Drawing.Color.Blue;
            this.textbox5.LineIdleColor = System.Drawing.Color.Gray;
            this.textbox5.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textbox5.LineThickness = 3;
            this.textbox5.Location = new System.Drawing.Point(355, 94);
            this.textbox5.Margin = new System.Windows.Forms.Padding(4);
            this.textbox5.Name = "textbox5";
            this.textbox5.Size = new System.Drawing.Size(365, 45);
            this.textbox5.TabIndex = 26;
            this.textbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textbox4
            // 
            this.textbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textbox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textbox4.HintForeColor = System.Drawing.Color.Empty;
            this.textbox4.HintText = "";
            this.textbox4.isPassword = false;
            this.textbox4.LineFocusedColor = System.Drawing.Color.Blue;
            this.textbox4.LineIdleColor = System.Drawing.Color.Gray;
            this.textbox4.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textbox4.LineThickness = 3;
            this.textbox4.Location = new System.Drawing.Point(355, 32);
            this.textbox4.Margin = new System.Windows.Forms.Padding(4);
            this.textbox4.Name = "textbox4";
            this.textbox4.Size = new System.Drawing.Size(365, 45);
            this.textbox4.TabIndex = 26;
            this.textbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.textbox3.Location = new System.Drawing.Point(355, 154);
            this.textbox3.Margin = new System.Windows.Forms.Padding(4);
            this.textbox3.Name = "textbox3";
            this.textbox3.Size = new System.Drawing.Size(365, 45);
            this.textbox3.TabIndex = 26;
            this.textbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(148, 233);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(159, 30);
            this.bunifuCustomLabel7.TabIndex = 21;
            this.bunifuCustomLabel7.Text = "Roll Number";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(52, 303);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(255, 30);
            this.bunifuCustomLabel8.TabIndex = 22;
            this.bunifuCustomLabel8.Text = "Registration Number";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.lbl1.Location = new System.Drawing.Point(123, 169);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(184, 30);
            this.lbl1.TabIndex = 23;
            this.lbl1.Text = "Student Name";
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Delete";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::dashboard.Properties.Resources.Trash_96px;
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(459, 418);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(9);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(164, 64);
            this.bunifuFlatButton2.TabIndex = 14;
            this.bunifuFlatButton2.Text = "Delete";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Edit";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::dashboard.Properties.Resources.Edit_100px;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(216, 418);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(161, 64);
            this.bunifuFlatButton1.TabIndex = 14;
            this.bunifuFlatButton1.Text = "Edit";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(810, 0);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(28, 30);
            this.bunifuCustomLabel5.TabIndex = 13;
            this.bunifuCustomLabel5.Text = "X";
            this.bunifuCustomLabel5.Click += new System.EventHandler(this.bunifuCustomLabel5_Click);
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.tESToneDataSet;
            // 
            // tESToneDataSet
            // 
            this.tESToneDataSet.DataSetName = "TESToneDataSet";
            this.tESToneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.editpnl);
            this.panel2.Controls.Add(this.DataGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1348, 782);
            this.panel2.TabIndex = 5;
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(63)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid.AutoGenerateColumns = false;
            this.DataGrid.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid.ColumnHeadersHeight = 50;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regNoDataGridViewTextBoxColumn,
            this.univRollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.streamDataGridViewTextBoxColumn,
            this.semDataGridViewTextBoxColumn});
            this.DataGrid.DataSource = this.studentBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid.DoubleBuffered = true;
            this.DataGrid.EnableHeadersVisualStyles = false;
            this.DataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.DataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.DataGrid.Location = new System.Drawing.Point(17, 121);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.RowHeadersWidth = 5;
            this.DataGrid.RowTemplate.Height = 36;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(1309, 642);
            this.DataGrid.TabIndex = 0;
            this.DataGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DataGrid_MouseDoubleClick);
            // 
            // regNoDataGridViewTextBoxColumn
            // 
            this.regNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.regNoDataGridViewTextBoxColumn.DataPropertyName = "RegNo";
            this.regNoDataGridViewTextBoxColumn.HeaderText = "RegNo";
            this.regNoDataGridViewTextBoxColumn.Name = "regNoDataGridViewTextBoxColumn";
            this.regNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // univRollNoDataGridViewTextBoxColumn
            // 
            this.univRollNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.univRollNoDataGridViewTextBoxColumn.DataPropertyName = "UnivRollNo";
            this.univRollNoDataGridViewTextBoxColumn.HeaderText = "UnivRollNo";
            this.univRollNoDataGridViewTextBoxColumn.Name = "univRollNoDataGridViewTextBoxColumn";
            this.univRollNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // streamDataGridViewTextBoxColumn
            // 
            this.streamDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.streamDataGridViewTextBoxColumn.DataPropertyName = "Stream";
            this.streamDataGridViewTextBoxColumn.HeaderText = "Stream";
            this.streamDataGridViewTextBoxColumn.Name = "streamDataGridViewTextBoxColumn";
            this.streamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // semDataGridViewTextBoxColumn
            // 
            this.semDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.semDataGridViewTextBoxColumn.DataPropertyName = "Sem";
            this.semDataGridViewTextBoxColumn.HeaderText = "Sem";
            this.semDataGridViewTextBoxColumn.Name = "semDataGridViewTextBoxColumn";
            this.semDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.tESToneDataSet1;
            // 
            // tESToneDataSet1
            // 
            this.tESToneDataSet1.DataSetName = "TESToneDataSet1";
            this.tESToneDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.HeaderText = "Action";
            this.dataGridViewImageColumn1.Image = global::dashboard.Properties.Resources.Edit_100px;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ViewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ViewStudent";
            this.Size = new System.Drawing.Size(1348, 782);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DataGrid_MouseDoubleClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchbtn2)).EndInit();
            this.editpnl.ResumeLayout(false);
            this.editpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Panel editpnl;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private TESToneDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private TESToneDataSet tESToneDataSet;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textbox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textbox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textbox3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textbox5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textbox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn regNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn univRollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private TESToneDataSet1 tESToneDataSet1;
        private TESToneDataSet1TableAdapters.StudentTableAdapter studentTableAdapter;
        private Bunifu.Framework.UI.BunifuFlatButton viewallbtn;
        private Bunifu.Framework.UI.BunifuFlatButton refreshbtn;
        private Bunifu.Framework.UI.BunifuDropdown deptDrp1;
        private MyImageButton.CustomImageButton searchbtn2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchbox1;
    }
}
