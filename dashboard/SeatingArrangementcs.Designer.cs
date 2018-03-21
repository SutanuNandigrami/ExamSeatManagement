namespace dashboard
{
    partial class SeatingArrangementcs
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
            this.panel = new System.Windows.Forms.Panel();
            this.print = new System.Windows.Forms.Button();
            this.clr = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.AutoSize = true;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 100);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1060, 600);
            this.panel.TabIndex = 0;
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(492, 33);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(75, 23);
            this.print.TabIndex = 2;
            this.print.Text = "Refresh";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // clr
            // 
            this.clr.Location = new System.Drawing.Point(719, 33);
            this.clr.Name = "clr";
            this.clr.Size = new System.Drawing.Size(75, 23);
            this.clr.TabIndex = 0;
            this.clr.Text = "close";
            this.clr.UseVisualStyleBackColor = true;
            this.clr.Click += new System.EventHandler(this.clr_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clr);
            this.panel1.Controls.Add(this.print);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 100);
            this.panel1.TabIndex = 1;
            // 
            // SeatingArrangementcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1060, 700);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.Name = "SeatingArrangementcs";
            this.Text = "SeatingArrangementcs";
            this.Load += new System.EventHandler(this.SeatingArrangementcs_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button clr;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Panel panel1;
    }
}