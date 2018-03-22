namespace dashboard
{
    partial class RoomArrangement
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crrptt = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.arrangement1 = new dashboard.Arrangement();
            this.SuspendLayout();
            // 
            // crrptt
            // 
            this.crrptt.ActiveViewIndex = -1;
            this.crrptt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crrptt.Cursor = System.Windows.Forms.Cursors.Default;
            this.crrptt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crrptt.Location = new System.Drawing.Point(0, 0);
            this.crrptt.Name = "crrptt";
            this.crrptt.Size = new System.Drawing.Size(1051, 678);
            this.crrptt.TabIndex = 0;
            this.crrptt.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // RoomArrangement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 678);
            this.Controls.Add(this.crrptt);
            this.Name = "RoomArrangement";
            this.Text = "RoomArrangement";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crrptt;
        private Arrangement arrangement1;
    }
}