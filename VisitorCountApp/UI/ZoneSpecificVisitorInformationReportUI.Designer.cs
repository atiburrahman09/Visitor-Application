namespace VisitorCountApp.UI
{
    partial class ZoneSpecificVisitorInformationReportUI
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
            this.totalZoneSpecificTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.zoneSpecificVisitorInformationListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showButton = new System.Windows.Forms.Button();
            this.selectZoneComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totalZoneSpecificTextBox
            // 
            this.totalZoneSpecificTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalZoneSpecificTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.totalZoneSpecificTextBox.Location = new System.Drawing.Point(487, 421);
            this.totalZoneSpecificTextBox.Multiline = true;
            this.totalZoneSpecificTextBox.Name = "totalZoneSpecificTextBox";
            this.totalZoneSpecificTextBox.Size = new System.Drawing.Size(100, 30);
            this.totalZoneSpecificTextBox.TabIndex = 5;
            this.totalZoneSpecificTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Visitor(s)";
            // 
            // zoneSpecificVisitorInformationListView
            // 
            this.zoneSpecificVisitorInformationListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.zoneSpecificVisitorInformationListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoneSpecificVisitorInformationListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.zoneSpecificVisitorInformationListView.GridLines = true;
            this.zoneSpecificVisitorInformationListView.Location = new System.Drawing.Point(22, 109);
            this.zoneSpecificVisitorInformationListView.Name = "zoneSpecificVisitorInformationListView";
            this.zoneSpecificVisitorInformationListView.Size = new System.Drawing.Size(646, 290);
            this.zoneSpecificVisitorInformationListView.TabIndex = 3;
            this.zoneSpecificVisitorInformationListView.UseCompatibleStateImageBehavior = false;
            this.zoneSpecificVisitorInformationListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 39;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 199;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            this.columnHeader3.Width = 232;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Contact Number";
            this.columnHeader4.Width = 173;
            // 
            // showButton
            // 
            this.showButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.Location = new System.Drawing.Point(465, 35);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(83, 38);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // selectZoneComboBox
            // 
            this.selectZoneComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectZoneComboBox.ForeColor = System.Drawing.Color.Maroon;
            this.selectZoneComboBox.FormattingEnabled = true;
            this.selectZoneComboBox.Location = new System.Drawing.Point(192, 35);
            this.selectZoneComboBox.Name = "selectZoneComboBox";
            this.selectZoneComboBox.Size = new System.Drawing.Size(227, 26);
            this.selectZoneComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Zone";
            // 
            // ZoneSpecificVisitorInformationReportUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(691, 486);
            this.Controls.Add(this.totalZoneSpecificTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zoneSpecificVisitorInformationListView);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.selectZoneComboBox);
            this.Controls.Add(this.label1);
            this.Name = "ZoneSpecificVisitorInformationReportUI";
            this.Text = "ZoneSpecificVisitorInformationReportUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox totalZoneSpecificTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView zoneSpecificVisitorInformationListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.ComboBox selectZoneComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}