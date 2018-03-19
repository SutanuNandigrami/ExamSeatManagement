namespace dashboard
{
    partial class ViewBatch
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
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tESToneDataSet = new dashboard.TESToneDataSet();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.paperCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tESToneDataSet4 = new dashboard.TESToneDataSet4();
            this.tESToneDataSet1 = new dashboard.TESToneDataSet1();
            this.roomTableAdapter = new dashboard.TESToneDataSetTableAdapters.RoomTableAdapter();
            this.editpnl = new System.Windows.Forms.Panel();
            this.Textbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Textbox4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Textbox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Textbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.searchbtn = new MyImageButton.CustomImageButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.viewallbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.batchTableAdapter = new dashboard.TESToneDataSet1TableAdapters.BatchTableAdapter();
            this.tESToneDataSet3 = new dashboard.TESToneDataSet3();
            this.studentTableAdapter = new dashboard.TESToneDataSet3TableAdapters.StudentTableAdapter();
            this.subjectTableAdapter = new dashboard.TESToneDataSet4TableAdapters.SubjectTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet1)).BeginInit();
            this.editpnl.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchbtn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet3)).BeginInit();
            this.SuspendLayout();
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(369, 306);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(126, 306);
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
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(643, 0);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(28, 30);
            this.bunifuCustomLabel5.TabIndex = 13;
            this.bunifuCustomLabel5.Text = "X";
            this.bunifuCustomLabel5.Click += new System.EventHandler(this.bunifuCustomLabel5_Click);
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
            this.paperCodeDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.deptDataGridViewTextBoxColumn,
            this.semDataGridViewTextBoxColumn});
            this.DataGrid.DataSource = this.subjectBindingSource;
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
            this.DataGrid.Size = new System.Drawing.Size(1246, 617);
            this.DataGrid.TabIndex = 0;
            this.DataGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DataGrid_MouseDoubleClick);
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
            // deptDataGridViewTextBoxColumn
            // 
            this.deptDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deptDataGridViewTextBoxColumn.DataPropertyName = "Dept";
            this.deptDataGridViewTextBoxColumn.HeaderText = "Dept";
            this.deptDataGridViewTextBoxColumn.Name = "deptDataGridViewTextBoxColumn";
            this.deptDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // semDataGridViewTextBoxColumn
            // 
            this.semDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.semDataGridViewTextBoxColumn.DataPropertyName = "Sem";
            this.semDataGridViewTextBoxColumn.HeaderText = "Sem";
            this.semDataGridViewTextBoxColumn.Name = "semDataGridViewTextBoxColumn";
            this.semDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "Subject";
            this.subjectBindingSource.DataSource = this.tESToneDataSet4;
            // 
            // tESToneDataSet4
            // 
            this.tESToneDataSet4.DataSetName = "TESToneDataSet4";
            this.tESToneDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tESToneDataSet1
            // 
            this.tESToneDataSet1.DataSetName = "TESToneDataSet1";
            this.tESToneDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // editpnl
            // 
            this.editpnl.BackColor = System.Drawing.Color.White;
            this.editpnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editpnl.Controls.Add(this.Textbox2);
            this.editpnl.Controls.Add(this.bunifuCustomLabel4);
            this.editpnl.Controls.Add(this.Textbox4);
            this.editpnl.Controls.Add(this.bunifuCustomLabel1);
            this.editpnl.Controls.Add(this.bunifuCustomLabel3);
            this.editpnl.Controls.Add(this.Textbox3);
            this.editpnl.Controls.Add(this.Textbox1);
            this.editpnl.Controls.Add(this.lbl1);
            this.editpnl.Controls.Add(this.bunifuFlatButton2);
            this.editpnl.Controls.Add(this.bunifuFlatButton1);
            this.editpnl.Controls.Add(this.bunifuCustomLabel5);
            this.editpnl.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.editpnl.ForeColor = System.Drawing.Color.White;
            this.editpnl.Location = new System.Drawing.Point(329, 142);
            this.editpnl.Name = "editpnl";
            this.editpnl.Size = new System.Drawing.Size(674, 416);
            this.editpnl.TabIndex = 1;
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
            this.Textbox2.Location = new System.Drawing.Point(286, 102);
            this.Textbox2.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox2.Name = "Textbox2";
            this.Textbox2.Size = new System.Drawing.Size(312, 45);
            this.Textbox2.TabIndex = 24;
            this.Textbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(139, 113);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(118, 34);
            this.bunifuCustomLabel4.TabIndex = 23;
            this.bunifuCustomLabel4.Text = "Subject";
            // 
            // Textbox4
            // 
            this.Textbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Textbox4.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox4.HintText = "";
            this.Textbox4.isPassword = false;
            this.Textbox4.LineFocusedColor = System.Drawing.Color.Blue;
            this.Textbox4.LineIdleColor = System.Drawing.Color.Gray;
            this.Textbox4.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Textbox4.LineThickness = 3;
            this.Textbox4.Location = new System.Drawing.Point(286, 217);
            this.Textbox4.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox4.Name = "Textbox4";
            this.Textbox4.Size = new System.Drawing.Size(312, 45);
            this.Textbox4.TabIndex = 22;
            this.Textbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(119, 228);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(138, 34);
            this.bunifuCustomLabel1.TabIndex = 21;
            this.bunifuCustomLabel1.Text = "Semester";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(76, 175);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(181, 34);
            this.bunifuCustomLabel3.TabIndex = 20;
            this.bunifuCustomLabel3.Text = "Department";
            // 
            // Textbox3
            // 
            this.Textbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Textbox3.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox3.HintText = "";
            this.Textbox3.isPassword = false;
            this.Textbox3.LineFocusedColor = System.Drawing.Color.Blue;
            this.Textbox3.LineIdleColor = System.Drawing.Color.Gray;
            this.Textbox3.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Textbox3.LineThickness = 3;
            this.Textbox3.Location = new System.Drawing.Point(286, 164);
            this.Textbox3.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox3.Name = "Textbox3";
            this.Textbox3.Size = new System.Drawing.Size(312, 45);
            this.Textbox3.TabIndex = 17;
            this.Textbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.Textbox1.Location = new System.Drawing.Point(286, 39);
            this.Textbox1.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox1.Name = "Textbox1";
            this.Textbox1.Size = new System.Drawing.Size(312, 45);
            this.Textbox1.TabIndex = 17;
            this.Textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.lbl1.Location = new System.Drawing.Point(75, 50);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(182, 34);
            this.lbl1.TabIndex = 16;
            this.lbl1.Text = "Paper Code";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.editpnl);
            this.panel2.Controls.Add(this.DataGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1285, 657);
            this.panel2.TabIndex = 3;
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
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(45, 36);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(174, 34);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "View Paper";
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
            this.panel1.Size = new System.Drawing.Size(1285, 100);
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
            this.viewallbtn.Location = new System.Drawing.Point(782, 36);
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
            // batchTableAdapter
            // 
            this.batchTableAdapter.ClearBeforeFill = true;
            // 
            // tESToneDataSet3
            // 
            this.tESToneDataSet3.DataSetName = "TESToneDataSet3";
            this.tESToneDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // ViewBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewBatch";
            this.Size = new System.Drawing.Size(1285, 757);
            this.Load += new System.EventHandler(this.ViewBatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet1)).EndInit();
            this.editpnl.ResumeLayout(false);
            this.editpnl.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchbtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tESToneDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private TESToneDataSet tESToneDataSet;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid;
        private TESToneDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.Panel editpnl;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox searchbox;
        private MyImageButton.CustomImageButton searchbtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl1;
        private TESToneDataSet1 tESToneDataSet1;
        private TESToneDataSet1TableAdapters.BatchTableAdapter batchTableAdapter;
        private Bunifu.Framework.UI.BunifuFlatButton viewallbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paperCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private TESToneDataSet4 tESToneDataSet4;
        private TESToneDataSet3 tESToneDataSet3;
        private TESToneDataSet3TableAdapters.StudentTableAdapter studentTableAdapter;
        private TESToneDataSet4TableAdapters.SubjectTableAdapter subjectTableAdapter;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox3;
    }
}
