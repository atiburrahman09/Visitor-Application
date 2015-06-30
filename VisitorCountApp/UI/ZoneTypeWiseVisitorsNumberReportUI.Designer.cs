namespace VisitorCountApp.UI
{
    partial class ZoneTypeWiseVisitorsNumberReportUI
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
            this.totalVisitorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zoneTypeWiseVisitorNumberListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // totalVisitorTextBox
            // 
            this.totalVisitorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalVisitorTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.totalVisitorTextBox.Location = new System.Drawing.Point(287, 432);
            this.totalVisitorTextBox.Multiline = true;
            this.totalVisitorTextBox.Name = "totalVisitorTextBox";
            this.totalVisitorTextBox.Size = new System.Drawing.Size(139, 33);
            this.totalVisitorTextBox.TabIndex = 2;
            this.totalVisitorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Visitor(s)";
            // 
            // zoneTypeWiseVisitorNumberListView
            // 
            this.zoneTypeWiseVisitorNumberListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.zoneTypeWiseVisitorNumberListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoneTypeWiseVisitorNumberListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.zoneTypeWiseVisitorNumberListView.GridLines = true;
            this.zoneTypeWiseVisitorNumberListView.Location = new System.Drawing.Point(34, 35);
            this.zoneTypeWiseVisitorNumberListView.Name = "zoneTypeWiseVisitorNumberListView";
            this.zoneTypeWiseVisitorNumberListView.Size = new System.Drawing.Size(392, 351);
            this.zoneTypeWiseVisitorNumberListView.TabIndex = 0;
            this.zoneTypeWiseVisitorNumberListView.UseCompatibleStateImageBehavior = false;
            this.zoneTypeWiseVisitorNumberListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Zone Type";
            this.columnHeader2.Width = 234;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Total Visitors";
            this.columnHeader3.Width = 78;
            // 
            // ZoneTypeWiseVisitorsNumberReportUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(461, 498);
            this.Controls.Add(this.zoneTypeWiseVisitorNumberListView);
            this.Controls.Add(this.totalVisitorTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ZoneTypeWiseVisitorsNumberReportUI";
            this.Text = "ZoneTypeWiseVisitorsNumberReportUI";
            this.Load += new System.EventHandler(this.ZoneTypeWiseVisitorsNumberReportUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox totalVisitorTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView zoneTypeWiseVisitorNumberListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}