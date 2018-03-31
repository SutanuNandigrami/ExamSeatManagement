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
            this.panel3 = new System.Windows.Forms.Panel();
            this.ViewRoomArgBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PrntScheduleBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.planNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paperCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paperCode2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tESToneDataSet10 = new dashboard.TESToneDataSet10();
            this.tESToneDataSet9 = new dashboard.TESToneDataSet9();
            this.tESToneDataSet8 = new dashboard.TESToneDataSet8();
            this.tESToneDataSet6 = new dashboard.TESToneDataSet6();
            this.searchBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datepkr = new System.Windows.Forms.DateTimePicker();
            this.viewallbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchbtn = new MyImageButton.CustomImageButton();
            this.addPlanTableAdapter = new dashboard.TESToneDataSet6TableAdapters.AddPlanTableAdapter();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tESToneDataSet7 = new dashboard.TESToneDataSet7();
            this.addPlanTableAdapter1 = new dashboard.TESToneDataSet7TableAdapters.AddPlanTableAdapter();
            this.addPlanTableAdapter2 = new dashboard.TESToneDataSet8TableAdapters.AddPlanTableAdapter();
            this.addPlanTableAdapter3 = new dashboard.TESToneDataSet9TableAdapters.AddPlanTableAdapter();
            this.addPlanTableAdapter4 = new dashboard.TESToneDataSet10TableAdapters.AddPlanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet6)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet7)).BeginInit();
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
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.DataGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1303, 651);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ViewRoomArgBtn);
            this.panel3.Controls.Add(this.PrntScheduleBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 545);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1303, 100);
            this.panel3.TabIndex = 18;
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
            this.ViewRoomArgBtn.Location = new System.Drawing.Point(599, 25);
            this.ViewRoomArgBtn.Margin = new System.Windows.Forms.Padding(6);
            this.ViewRoomArgBtn.Name = "ViewRoomArgBtn";
            this.ViewRoomArgBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ViewRoomArgBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(11)))), ((int)(((byte)(14)))));
            this.ViewRoomArgBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.ViewRoomArgBtn.selected = false;
            this.ViewRoomArgBtn.Size = new System.Drawing.Size(386, 51);
            this.ViewRoomArgBtn.TabIndex = 18;
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
            this.PrntScheduleBtn.Location = new System.Drawing.Point(115, 25);
            this.PrntScheduleBtn.Margin = new System.Windows.Forms.Padding(6);
            this.PrntScheduleBtn.Name = "PrntScheduleBtn";
            this.PrntScheduleBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.PrntScheduleBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(11)))), ((int)(((byte)(14)))));
            this.PrntScheduleBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.PrntScheduleBtn.selected = false;
            this.PrntScheduleBtn.Size = new System.Drawing.Size(320, 51);
            this.PrntScheduleBtn.TabIndex = 19;
            this.PrntScheduleBtn.Text = "Print Exam Schedule";
            this.PrntScheduleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PrntScheduleBtn.Textcolor = System.Drawing.Color.White;
            this.PrntScheduleBtn.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrntScheduleBtn.Click += new System.EventHandler(this.PrntScheduleBtn_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(63)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.planNoDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.paperCodeDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.paperCode2DataGridViewTextBoxColumn,
            this.subject2DataGridViewTextBoxColumn});
            this.DataGrid.DataSource = this.addPlanBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataGrid.DoubleBuffered = true;
            this.DataGrid.EnableHeadersVisualStyles = false;
            this.DataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.DataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.DataGrid.Location = new System.Drawing.Point(0, 0);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.RowHeadersWidth = 5;
            this.DataGrid.RowTemplate.Height = 36;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(1303, 545);
            this.DataGrid.TabIndex = 17;
            this.DataGrid.VirtualMode = true;
            this.DataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGrid_CellMouseClick);
            // 
            // planNoDataGridViewTextBoxColumn
            // 
            this.planNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.planNoDataGridViewTextBoxColumn.DataPropertyName = "PlanNo";
            this.planNoDataGridViewTextBoxColumn.HeaderText = "PlanNo";
            this.planNoDataGridViewTextBoxColumn.Name = "planNoDataGridViewTextBoxColumn";
            this.planNoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // paperCodeDataGridViewTextBoxColumn
            // 
            this.paperCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.paperCodeDataGridViewTextBoxColumn.DataPropertyName = "PaperCode";
            this.paperCodeDataGridViewTextBoxColumn.HeaderText = "PaperCode";
            this.paperCodeDataGridViewTextBoxColumn.Name = "paperCodeDataGridViewTextBoxColumn";
            this.paperCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paperCode2DataGridViewTextBoxColumn
            // 
            this.paperCode2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.paperCode2DataGridViewTextBoxColumn.DataPropertyName = "PaperCode2";
            this.paperCode2DataGridViewTextBoxColumn.HeaderText = "PaperCode2";
            this.paperCode2DataGridViewTextBoxColumn.Name = "paperCode2DataGridViewTextBoxColumn";
            this.paperCode2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subject2DataGridViewTextBoxColumn
            // 
            this.subject2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subject2DataGridViewTextBoxColumn.DataPropertyName = "Subject2";
            this.subject2DataGridViewTextBoxColumn.HeaderText = "Subject2";
            this.subject2DataGridViewTextBoxColumn.Name = "subject2DataGridViewTextBoxColumn";
            this.subject2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addPlanBindingSource
            // 
            this.addPlanBindingSource.DataMember = "AddPlan";
            this.addPlanBindingSource.DataSource = this.tESToneDataSet10;
            // 
            // tESToneDataSet10
            // 
            this.tESToneDataSet10.DataSetName = "TESToneDataSet10";
            this.tESToneDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tESToneDataSet9
            // 
            this.tESToneDataSet9.DataSetName = "TESToneDataSet9";
            this.tESToneDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tESToneDataSet8
            // 
            this.tESToneDataSet8.DataSetName = "TESToneDataSet8";
            this.tESToneDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tESToneDataSet6
            // 
            this.tESToneDataSet6.DataSetName = "TESToneDataSet6";
            this.tESToneDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.panel1.Controls.Add(this.datepkr);
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
            // datepkr
            // 
            this.datepkr.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepkr.Location = new System.Drawing.Point(190, 43);
            this.datepkr.Name = "datepkr";
            this.datepkr.Size = new System.Drawing.Size(312, 26);
            this.datepkr.TabIndex = 20;
            this.datepkr.ValueChanged += new System.EventHandler(this.datepkr_ValueChanged);
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
            // addPlanTableAdapter1
            // 
            this.addPlanTableAdapter1.ClearBeforeFill = true;
            // 
            // addPlanTableAdapter2
            // 
            this.addPlanTableAdapter2.ClearBeforeFill = true;
            // 
            // addPlanTableAdapter3
            // 
            this.addPlanTableAdapter3.ClearBeforeFill = true;
            // 
            // addPlanTableAdapter4
            // 
            this.addPlanTableAdapter4.ClearBeforeFill = true;
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
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet6)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet7)).EndInit();
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
        private TESToneDataSet6 tESToneDataSet6;
        private TESToneDataSet6TableAdapters.AddPlanTableAdapter addPlanTableAdapter;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid;
        private TESToneDataSet7 tESToneDataSet7;
        private TESToneDataSet7TableAdapters.AddPlanTableAdapter addPlanTableAdapter1;
        private TESToneDataSet8 tESToneDataSet8;
        private TESToneDataSet8TableAdapters.AddPlanTableAdapter addPlanTableAdapter2;
        private System.Windows.Forms.DateTimePicker datepkr;
        private TESToneDataSet9 tESToneDataSet9;
        private TESToneDataSet9TableAdapters.AddPlanTableAdapter addPlanTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn planNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paperCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paperCode2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject2DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource addPlanBindingSource;
        private TESToneDataSet10 tESToneDataSet10;
        private TESToneDataSet10TableAdapters.AddPlanTableAdapter addPlanTableAdapter4;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton ViewRoomArgBtn;
        private Bunifu.Framework.UI.BunifuFlatButton PrntScheduleBtn;
    }
}
