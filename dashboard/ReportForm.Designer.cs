namespace dashboard
{
    partial class ReportForm
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
            this.crrpt = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.es1 = new dashboard.ExamSchedule();
            this.SuspendLayout();
            // 
            // crrpt
            // 
            this.crrpt.ActiveViewIndex = -1;
            this.crrpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crrpt.Cursor = System.Windows.Forms.Cursors.Default;
            this.crrpt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crrpt.Location = new System.Drawing.Point(0, 0);
            this.crrpt.Name = "crrpt";
            this.crrpt.Size = new System.Drawing.Size(1010, 734);
            this.crrpt.TabIndex = 19;
            this.crrpt.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 734);
            this.Controls.Add(this.crrpt);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crrpt;
        private ExamSchedule es1;
    }
}