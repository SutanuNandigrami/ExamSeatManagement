namespace dashboard
{
    partial class ViewPlan
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
            this.tESToneDataSet = new dashboard.TESToneDataSet();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTableAdapter = new dashboard.TESToneDataSetTableAdapters.RoomTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.tESToneDataSet6 = new dashboard.TESToneDataSet6();
            this.Stickerbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ViewRoomArgBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PrntScheduleBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpkr = new Bunifu.Framework.UI.BunifuDatepicker();
            this.viewallbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchbtn = new MyImageButton.CustomImageButton();
            this.addPlanTableAdapter = new dashboard.TESToneDataSet6TableAdapters.AddPlanTableAdapter();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tESToneDataSet7 = new dashboard.TESToneDataSet7();
            this.addPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addPlanTableAdapter1 = new dashboard.TESToneDataSet7TableAdapters.AddPlanTableAdapter();
            this.paperCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rollSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rollEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet6)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPlanBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.DataGrid);
            this.panel2.Controls.Add(this.Stickerbtn);
            this.panel2.Controls.Add(this.ViewRoomArgBtn);
            this.panel2.Controls.Add(this.PrntScheduleBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1303, 651);
            this.panel2.TabIndex = 3;
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
            this.DataGrid.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.paperCodeDataGridViewTextBoxColumn,
            this.semDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.deptDataGridViewTextBoxColumn,
            this.roomNoDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.rollSDataGridViewTextBoxColumn,
            this.rollEDataGridViewTextBoxColumn});
            this.DataGrid.DataSource = this.addPlanBindingSource;
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
            this.DataGrid.Location = new System.Drawing.Point(16, 6);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.RowHeadersWidth = 5;
            this.DataGrid.RowTemplate.Height = 36;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(1259, 537);
            this.DataGrid.TabIndex = 17;
            this.DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellContentClick);
            this.DataGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DataGrid_MouseDoubleClick);
            // 
            // tESToneDataSet6
            // 
            this.tESToneDataSet6.DataSetName = "TESToneDataSet6";
            this.tESToneDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Stickerbtn
            // 
            this.Stickerbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Stickerbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Stickerbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Stickerbtn.BorderRadius = 0;
            this.Stickerbtn.ButtonText = "Stickers";
            this.Stickerbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Stickerbtn.DisabledColor = System.Drawing.Color.Gray;
            this.Stickerbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.Stickerbtn.Iconimage = global::dashboard.Properties.Resources.Eye_96px;
            this.Stickerbtn.Iconimage_right = null;
            this.Stickerbtn.Iconimage_right_Selected = null;
            this.Stickerbtn.Iconimage_Selected = null;
            this.Stickerbtn.IconMarginLeft = 0;
            this.Stickerbtn.IconMarginRight = 0;
            this.Stickerbtn.IconRightVisible = true;
            this.Stickerbtn.IconRightZoom = 0D;
            this.Stickerbtn.IconVisible = true;
            this.Stickerbtn.IconZoom = 50D;
            this.Stickerbtn.IsTab = true;
            this.Stickerbtn.Location = new System.Drawing.Point(746, 566);
            this.Stickerbtn.Margin = new System.Windows.Forms.Padding(6);
            this.Stickerbtn.Name = "Stickerbtn";
            this.Stickerbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Stickerbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(11)))), ((int)(((byte)(14)))));
            this.Stickerbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.Stickerbtn.selected = false;
            this.Stickerbtn.Size = new System.Drawing.Size(171, 51);
            this.Stickerbtn.TabIndex = 16;
            this.Stickerbtn.Text = "Stickers";
            this.Stickerbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Stickerbtn.Textcolor = System.Drawing.Color.White;
            this.Stickerbtn.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ViewRoomArgBtn
            // 
            this.ViewRoomArgBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ViewRoomArgBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ViewRoomArgBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ViewRoomArgBtn.BorderRadius = 0;
            this.ViewRoomArgBtn.ButtonText = "View Room Arrangement";
            this.ViewRoomArgBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewRoomArgBtn.DisabledColor = System.Drawing.Color.Gray;
            this.ViewRoomArgBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.ViewRoomArgBtn.Iconimage = global::dashboard.Properties.Resources.Eye_96px;
            this.ViewRoomArgBtn.Iconimage_right = null;
            this.ViewRoomArgBtn.Iconimage_right_Selected = null;
            this.ViewRoomArgBtn.Iconimage_Selected = null;
            this.ViewRoomArgBtn.IconMarginLeft = 0;
            this.ViewRoomArgBtn.IconMarginRight = 0;
            this.ViewRoomArgBtn.IconRightVisible = true;
            this.ViewRoomArgBtn.IconRightZoom = 0D;
            this.ViewRoomArgBtn.IconVisible = true;
            this.ViewRoomArgBtn.IconZoom = 50D;
            this.ViewRoomArgBtn.IsTab = true;
            this.ViewRoomArgBtn.Location = new System.Drawing.Point(348, 566);
            this.ViewRoomArgBtn.Margin = new System.Windows.Forms.Padding(6);
            this.ViewRoomArgBtn.Name = "ViewRoomArgBtn";
            this.ViewRoomArgBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ViewRoomArgBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(11)))), ((int)(((byte)(14)))));
            this.ViewRoomArgBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.ViewRoomArgBtn.selected = false;
            this.ViewRoomArgBtn.Size = new System.Drawing.Size(386, 51);
            this.ViewRoomArgBtn.TabIndex = 16;
            this.ViewRoomArgBtn.Text = "View Room Arrangement";
            this.ViewRoomArgBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ViewRoomArgBtn.Textcolor = System.Drawing.Color.White;
            this.ViewRoomArgBtn.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewRoomArgBtn.Click += new System.EventHandler(this.ViewRoomArgBtn_Click);
            // 
            // PrntScheduleBtn
            // 
            this.PrntScheduleBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.PrntScheduleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.PrntScheduleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PrntScheduleBtn.BorderRadius = 0;
            this.PrntScheduleBtn.ButtonText = "Print Exam Schedule";
            this.PrntScheduleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrntScheduleBtn.DisabledColor = System.Drawing.Color.Gray;
            this.PrntScheduleBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.PrntScheduleBtn.Iconimage = global::dashboard.Properties.Resources.Eye_96px;
            this.PrntScheduleBtn.Iconimage_right = null;
            this.PrntScheduleBtn.Iconimage_right_Selected = null;
            this.PrntScheduleBtn.Iconimage_Selected = null;
            this.PrntScheduleBtn.IconMarginLeft = 0;
            this.PrntScheduleBtn.IconMarginRight = 0;
            this.PrntScheduleBtn.IconRightVisible = true;
            this.PrntScheduleBtn.IconRightZoom = 0D;
            this.PrntScheduleBtn.IconVisible = true;
            this.PrntScheduleBtn.IconZoom = 50D;
            this.PrntScheduleBtn.IsTab = true;
            this.PrntScheduleBtn.Location = new System.Drawing.Point(16, 566);
            this.PrntScheduleBtn.Margin = new System.Windows.Forms.Padding(6);
            this.PrntScheduleBtn.Name = "PrntScheduleBtn";
            this.PrntScheduleBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.PrntScheduleBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(11)))), ((int)(((byte)(14)))));
            this.PrntScheduleBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.PrntScheduleBtn.selected = false;
            this.PrntScheduleBtn.Size = new System.Drawing.Size(320, 51);
            this.PrntScheduleBtn.TabIndex = 16;
            this.PrntScheduleBtn.Text = "Print Exam Schedule";
            this.PrntScheduleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PrntScheduleBtn.Textcolor = System.Drawing.Color.White;
            this.PrntScheduleBtn.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrntScheduleBtn.Click += new System.EventHandler(this.PrntScheduleBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(43)))), ((int)(((byte)(24)))));
            this.searchBox.BorderColorIdle = System.Drawing.Color.White;
            this.searchBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(43)))), ((int)(((byte)(24)))));
            this.searchBox.BorderThickness = 3;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.White;
            this.searchBox.isPassword = false;
            this.searchBox.Location = new System.Drawing.Point(542, 35);
            this.searchBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(312, 48);
            this.searchBox.TabIndex = 8;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(21, 35);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(152, 34);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "View Plan";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.dtpkr);
            this.panel1.Controls.Add(this.viewallbtn);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.searchbtn);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1303, 100);
            this.panel1.TabIndex = 2;
            // 
            // dtpkr
            // 
            this.dtpkr.BackColor = System.Drawing.Color.SeaGreen;
            this.dtpkr.BorderRadius = 0;
            this.dtpkr.ForeColor = System.Drawing.Color.White;
            this.dtpkr.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpkr.FormatCustom = null;
            this.dtpkr.Location = new System.Drawing.Point(204, 35);
            this.dtpkr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpkr.Name = "dtpkr";
            this.dtpkr.Size = new System.Drawing.Size(309, 44);
            this.dtpkr.TabIndex = 16;
            this.dtpkr.Value = new System.DateTime(2018, 3, 20, 2, 56, 36, 67);
            this.dtpkr.onValueChanged += new System.EventHandler(this.dtpkr_onValueChanged);
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
            this.viewallbtn.Location = new System.Drawing.Point(926, 35);
            this.viewallbtn.Margin = new System.Windows.Forms.Padding(6);
            this.viewallbtn.Name = "viewallbtn";
            this.viewallbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.viewallbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(11)))), ((int)(((byte)(14)))));
            this.viewallbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.viewallbtn.selected = false;
            this.viewallbtn.Size = new System.Drawing.Size(171, 51);
            this.viewallbtn.TabIndex = 15;
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
            this.searchbtn.Location = new System.Drawing.Point(862, 16);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(46, 81);
            this.searchbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchbtn.TabIndex = 7;
            this.searchbtn.TabStop = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // addPlanTableAdapter
            // 
            this.addPlanTableAdapter.ClearBeforeFill = true;
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
            // tESToneDataSet7
            // 
            this.tESToneDataSet7.DataSetName = "TESToneDataSet7";
            this.tESToneDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addPlanBindingSource
            // 
            this.addPlanBindingSource.DataMember = "AddPlan";
            this.addPlanBindingSource.DataSource = this.tESToneDataSet7;
            // 
            // addPlanTableAdapter1
            // 
            this.addPlanTableAdapter1.ClearBeforeFill = true;
            // 
            // paperCodeDataGridViewTextBoxColumn
            // 
            this.paperCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.paperCodeDataGridViewTextBoxColumn.DataPropertyName = "PaperCode";
            this.paperCodeDataGridViewTextBoxColumn.HeaderText = "PaperCode";
            this.paperCodeDataGridViewTextBoxColumn.Name = "paperCodeDataGridViewTextBoxColumn";
            this.paperCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // semDataGridViewTextBoxColumn
            // 
            this.semDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.semDataGridViewTextBoxColumn.DataPropertyName = "Sem";
            this.semDataGridViewTextBoxColumn.HeaderText = "Sem";
            this.semDataGridViewTextBoxColumn.Name = "semDataGridViewTextBoxColumn";
            this.semDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deptDataGridViewTextBoxColumn
            // 
            this.deptDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deptDataGridViewTextBoxColumn.DataPropertyName = "Dept";
            this.deptDataGridViewTextBoxColumn.HeaderText = "Dept";
            this.deptDataGridViewTextBoxColumn.Name = "deptDataGridViewTextBoxColumn";
            this.deptDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomNoDataGridViewTextBoxColumn
            // 
            this.roomNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.roomNoDataGridViewTextBoxColumn.DataPropertyName = "RoomNo";
            this.roomNoDataGridViewTextBoxColumn.HeaderText = "RoomNo";
            this.roomNoDataGridViewTextBoxColumn.Name = "roomNoDataGridViewTextBoxColumn";
            this.roomNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration ";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration ";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rollSDataGridViewTextBoxColumn
            // 
            this.rollSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rollSDataGridViewTextBoxColumn.DataPropertyName = "RollS";
            this.rollSDataGridViewTextBoxColumn.HeaderText = "RollS";
            this.rollSDataGridViewTextBoxColumn.Name = "rollSDataGridViewTextBoxColumn";
            this.rollSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rollEDataGridViewTextBoxColumn
            // 
            this.rollEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rollEDataGridViewTextBoxColumn.DataPropertyName = "RollE";
            this.rollEDataGridViewTextBoxColumn.HeaderText = "RollE";
            this.rollEDataGridViewTextBoxColumn.Name = "rollEDataGridViewTextBoxColumn";
            this.rollEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(961, 607);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1048, 607);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "label2";
            // 
            // ViewPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewPlan";
            this.Size = new System.Drawing.Size(1303, 751);
            this.Load += new System.EventHandler(this.ViewPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet6)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPlanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private TESToneDataSet tESToneDataSet;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private TESToneDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton viewallbtn;
        private Bunifu.Framework.UI.BunifuMetroTextbox searchBox;
        private MyImageButton.CustomImageButton searchbtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton Stickerbtn;
        private Bunifu.Framework.UI.BunifuFlatButton ViewRoomArgBtn;
        private Bunifu.Framework.UI.BunifuFlatButton PrntScheduleBtn;
        private TESToneDataSet6 tESToneDataSet6;
        private TESToneDataSet6TableAdapters.AddPlanTableAdapter addPlanTableAdapter;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid;
        private Bunifu.Framework.UI.BunifuDatepicker dtpkr;
        private System.Windows.Forms.DataGridViewTextBoxColumn paperCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource addPlanBindingSource;
        private TESToneDataSet7 tESToneDataSet7;
        private TESToneDataSet7TableAdapters.AddPlanTableAdapter addPlanTableAdapter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
