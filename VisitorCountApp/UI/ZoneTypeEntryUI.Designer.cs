namespace VisitorCountApp.UI
{
    partial class ZoneTypeEntryUI
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
            this.zoneTypeListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.zoneTypeSaveButton = new System.Windows.Forms.Button();
            this.typeNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zoneTypeListView
            // 
            this.zoneTypeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.zoneTypeListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoneTypeListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.zoneTypeListView.GridLines = true;
            this.zoneTypeListView.Location = new System.Drawing.Point(38, 199);
            this.zoneTypeListView.Name = "zoneTypeListView";
            this.zoneTypeListView.Size = new System.Drawing.Size(408, 255);
            this.zoneTypeListView.TabIndex = 6;
            this.zoneTypeListView.UseCompatibleStateImageBehavior = false;
            this.zoneTypeListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Zone Type";
            this.columnHeader2.Width = 342;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.zoneTypeSaveButton);
            this.groupBox1.Controls.Add(this.typeNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 150);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zone Type";
            // 
            // zoneTypeSaveButton
            // 
            this.zoneTypeSaveButton.Location = new System.Drawing.Point(291, 91);
            this.zoneTypeSaveButton.Name = "zoneTypeSaveButton";
            this.zoneTypeSaveButton.Size = new System.Drawing.Size(87, 39);
            this.zoneTypeSaveButton.TabIndex = 2;
            this.zoneTypeSaveButton.Text = "Save";
            this.zoneTypeSaveButton.UseVisualStyleBackColor = true;
            this.zoneTypeSaveButton.Click += new System.EventHandler(this.zoneTypeSaveButton_Click);
            // 
            // typeNameTextBox
            // 
            this.typeNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeNameTextBox.Location = new System.Drawing.Point(122, 36);
            this.typeNameTextBox.Multiline = true;
            this.typeNameTextBox.Name = "typeNameTextBox";
            this.typeNameTextBox.Size = new System.Drawing.Size(256, 36);
            this.typeNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type Name";
            // 
            // ZoneTypeEntryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(490, 484);
            this.Controls.Add(this.zoneTypeListView);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ZoneTypeEntryUI";
            this.Text = "ZoneTypeEntryUI";
            this.Load += new System.EventHandler(this.ZoneTypeEntryUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView zoneTypeListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button zoneTypeSaveButton;
        private System.Windows.Forms.TextBox typeNameTextBox;
        private System.Windows.Forms.Label label1;
    }
}