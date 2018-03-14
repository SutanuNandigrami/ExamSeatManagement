namespace dashboard
{
    partial class ViewDept
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
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.roomTableAdapter = new dashboard.TESToneDataSetTableAdapters.RoomTableAdapter();
            this.tESToneDataSet = new dashboard.TESToneDataSet();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.deptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tESToneDataSet1 = new dashboard.TESToneDataSet1();
            this.panel2 = new System.Windows.Forms.Panel();
            this.editpnl = new System.Windows.Forms.Panel();
            this.Textbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Textbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.deletebtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.editbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.viewallbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchbtn = new MyImageButton.CustomImageButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.deptTableAdapter = new dashboard.TESToneDataSet1TableAdapters.DeptTableAdapter();
            this.deptIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            this.editpnl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(643, 0);
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
            // tESToneDataSet
            // 
            this.tESToneDataSet.DataSetName = "TESToneDataSet";
            this.tESToneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.tESToneDataSet;
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
            this.deptIdDataGridViewTextBoxColumn,
            this.deptNameDataGridViewTextBoxColumn});
            this.DataGrid.DataSource = this.deptBindingSource;
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
            this.DataGrid.Location = new System.Drawing.Point(17, 21);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.RowHeadersWidth = 5;
            this.DataGrid.RowTemplate.Height = 36;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(1282, 793);
            this.DataGrid.TabIndex = 0;
            this.DataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGrid_MouseDoubleClick);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.editpnl);
            this.panel2.Controls.Add(this.DataGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1321, 833);
            this.panel2.TabIndex = 3;
            // 
            // editpnl
            // 
            this.editpnl.BackColor = System.Drawing.Color.White;
            this.editpnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editpnl.Controls.Add(this.Textbox1);
            this.editpnl.Controls.Add(this.Textbox2);
            this.editpnl.Controls.Add(this.bunifuCustomLabel3);
            this.editpnl.Controls.Add(this.lbl1);
            this.editpnl.Controls.Add(this.deletebtn);
            this.editpnl.Controls.Add(this.editbtn);
            this.editpnl.Controls.Add(this.bunifuCustomLabel5);
            this.editpnl.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.editpnl.ForeColor = System.Drawing.Color.White;
            this.editpnl.Location = new System.Drawing.Point(329, 142);
            this.editpnl.Name = "editpnl";
            this.editpnl.Size = new System.Drawing.Size(674, 416);
            this.editpnl.TabIndex = 1;
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
            this.Textbox1.Location = new System.Drawing.Point(346, 66);
            this.Textbox1.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox1.Name = "Textbox1";
            this.Textbox1.Size = new System.Drawing.Size(253, 45);
            this.Textbox1.TabIndex = 17;
            this.Textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Textbox2
            // 
            this.Textbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Textbox2.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox2.HintText = "";
            this.Textbox2.isPassword = false;
            this.Textbox2.LineFocusedColor = System.Drawing.Color.Blue;
            this.Textbox2.LineIdleColor = System.Drawing.Color.Gray;
            this.Textbox2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Textbox2.LineThickness = 3;
            this.Textbox2.Location = new System.Drawing.Point(346, 164);
            this.Textbox2.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox2.Name = "Textbox2";
            this.Textbox2.Size = new System.Drawing.Size(253, 45);
            this.Textbox2.TabIndex = 17;
            this.Textbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(55, 81);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(188, 30);
            this.bunifuCustomLabel3.TabIndex = 16;
            this.bunifuCustomLabel3.Text = "Department ID";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.lbl1.Location = new System.Drawing.Point(55, 179);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(238, 30);
            this.lbl1.TabIndex = 16;
            this.lbl1.Text = "Department Name";
            // 
            // deletebtn
            // 
            this.deletebtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.deletebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deletebtn.BorderRadius = 0;
            this.deletebtn.ButtonText = "Delete";
            this.deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebtn.DisabledColor = System.Drawing.Color.Gray;
            this.deletebtn.Iconcolor = System.Drawing.Color.Transparent;
            this.deletebtn.Iconimage = global::dashboard.Properties.Resources.Trash_96px;
            this.deletebtn.Iconimage_right = null;
            this.deletebtn.Iconimage_right_Selected = null;
            this.deletebtn.Iconimage_Selected = null;
            this.deletebtn.IconMarginLeft = 0;
            this.deletebtn.IconMarginRight = 0;
            this.deletebtn.IconRightVisible = true;
            this.deletebtn.IconRightZoom = 0D;
            this.deletebtn.IconVisible = true;
            this.deletebtn.IconZoom = 50D;
            this.deletebtn.IsTab = true;
            this.deletebtn.Location = new System.Drawing.Point(369, 306);
            this.deletebtn.Margin = new System.Windows.Forms.Padding(9);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.deletebtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.deletebtn.OnHoverTextColor = System.Drawing.Color.White;
            this.deletebtn.selected = false;
            this.deletebtn.Size = new System.Drawing.Size(164, 64);
            this.deletebtn.TabIndex = 14;
            this.deletebtn.Text = "Delete";
            this.deletebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deletebtn.Textcolor = System.Drawing.Color.White;
            this.deletebtn.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // editbtn
            // 
            this.editbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.editbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.editbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editbtn.BorderRadius = 0;
            this.editbtn.ButtonText = "Edit";
            this.editbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editbtn.DisabledColor = System.Drawing.Color.Gray;
            this.editbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.editbtn.Iconimage = global::dashboard.Properties.Resources.Edit_100px;
            this.editbtn.Iconimage_right = null;
            this.editbtn.Iconimage_right_Selected = null;
            this.editbtn.Iconimage_Selected = null;
            this.editbtn.IconMarginLeft = 0;
            this.editbtn.IconMarginRight = 0;
            this.editbtn.IconRightVisible = true;
            this.editbtn.IconRightZoom = 0D;
            this.editbtn.IconVisible = true;
            this.editbtn.IconZoom = 50D;
            this.editbtn.IsTab = true;
            this.editbtn.Location = new System.Drawing.Point(126, 306);
            this.editbtn.Margin = new System.Windows.Forms.Padding(6);
            this.editbtn.Name = "editbtn";
            this.editbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.editbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.editbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.editbtn.selected = false;
            this.editbtn.Size = new System.Drawing.Size(161, 64);
            this.editbtn.TabIndex = 14;
            this.editbtn.Text = "Edit";
            this.editbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.editbtn.Textcolor = System.Drawing.Color.White;
            this.editbtn.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // searchbox
            // 
            this.searchbox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(43)))), ((int)(((byte)(24)))));
            this.searchbox.BorderColorIdle = System.Drawing.Color.White;
            this.searchbox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(43)))), ((int)(((byte)(24)))));
            this.searchbox.BorderThickness = 3;
            this.searchbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.ForeColor = System.Drawing.Color.White;
            this.searchbox.isPassword = false;
            this.searchbox.Location = new System.Drawing.Point(365, 39);
            this.searchbox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(312, 48);
            this.searchbox.TabIndex = 8;
            this.searchbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(45, 36);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(259, 34);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "View Department";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.viewallbtn);
            this.panel1.Controls.Add(this.searchbox);
            this.panel1.Controls.Add(this.searchbtn);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1321, 100);
            this.panel1.TabIndex = 2;
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
            this.viewallbtn.Location = new System.Drawing.Point(791, 36);
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
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.searchbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchbtn.Image = global::dashboard.Properties.Resources.Search_100px;
            this.searchbtn.ImageHover = global::dashboard.Properties.Resources.Detective_96px;
            this.searchbtn.ImageNormal = global::dashboard.Properties.Resources.Search_100px;
            this.searchbtn.Location = new System.Drawing.Point(685, 16);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(46, 81);
            this.searchbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchbtn.TabIndex = 7;
            this.searchbtn.TabStop = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
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
            // deptTableAdapter
            // 
            this.deptTableAdapter.ClearBeforeFill = true;
            // 
            // deptIdDataGridViewTextBoxColumn
            // 
            this.deptIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deptIdDataGridViewTextBoxColumn.DataPropertyName = "DeptId";
            this.deptIdDataGridViewTextBoxColumn.HeaderText = "DeptId";
            this.deptIdDataGridViewTextBoxColumn.Name = "deptIdDataGridViewTextBoxColumn";
            this.deptIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deptNameDataGridViewTextBoxColumn
            // 
            this.deptNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deptNameDataGridViewTextBoxColumn.DataPropertyName = "DeptName";
            this.deptNameDataGridViewTextBoxColumn.HeaderText = "DeptName";
            this.deptNameDataGridViewTextBoxColumn.Name = "deptNameDataGridViewTextBoxColumn";
            this.deptNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ViewDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewDept";
            this.Size = new System.Drawing.Size(1321, 933);
            this.Load += new System.EventHandler(this.ViewDept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.editpnl.ResumeLayout(false);
            this.editpnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchbtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton deletebtn;
        private Bunifu.Framework.UI.BunifuFlatButton editbtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private MyImageButton.CustomImageButton searchbtn;
        private TESToneDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private TESToneDataSet tESToneDataSet;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel editpnl;
        private Bunifu.Framework.UI.BunifuMetroTextbox searchbox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox2;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuFlatButton viewallbtn;
        private TESToneDataSet1 tESToneDataSet1;
        private TESToneDataSet1TableAdapters.DeptTableAdapter deptTableAdapter;
        private System.Windows.Forms.BindingSource deptBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptNameDataGridViewTextBoxColumn;
    }
}
