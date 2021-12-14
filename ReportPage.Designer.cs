
namespace MuskSoftwareProject
{
    partial class ReportPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPage));
            this.cmbIncidentLevel = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rtxtReportDescription = new System.Windows.Forms.RichTextBox();
            this.rtxtComments = new System.Windows.Forms.RichTextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblIncidentLevel = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblReportDescription = new System.Windows.Forms.Label();
            this.lblComments = new System.Windows.Forms.Label();
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbIncidentLevel
            // 
            this.cmbIncidentLevel.FormattingEnabled = true;
            this.cmbIncidentLevel.Items.AddRange(new object[] {
            "Very High",
            "High",
            "Medium",
            "Low",
            "Very Low"});
            this.cmbIncidentLevel.Location = new System.Drawing.Point(125, 207);
            this.cmbIncidentLevel.Name = "cmbIncidentLevel";
            this.cmbIncidentLevel.Size = new System.Drawing.Size(121, 28);
            this.cmbIncidentLevel.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(83, 134);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 93);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // rtxtReportDescription
            // 
            this.rtxtReportDescription.Location = new System.Drawing.Point(560, 65);
            this.rtxtReportDescription.Name = "rtxtReportDescription";
            this.rtxtReportDescription.Size = new System.Drawing.Size(228, 136);
            this.rtxtReportDescription.TabIndex = 3;
            this.rtxtReportDescription.Text = "";
            // 
            // rtxtComments
            // 
            this.rtxtComments.Location = new System.Drawing.Point(560, 221);
            this.rtxtComments.Name = "rtxtComments";
            this.rtxtComments.Size = new System.Drawing.Size(228, 145);
            this.rtxtComments.TabIndex = 4;
            this.rtxtComments.Text = "";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 139);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // lblIncidentLevel
            // 
            this.lblIncidentLevel.AutoSize = true;
            this.lblIncidentLevel.Location = new System.Drawing.Point(3, 210);
            this.lblIncidentLevel.Name = "lblIncidentLevel";
            this.lblIncidentLevel.Size = new System.Drawing.Size(107, 20);
            this.lblIncidentLevel.TabIndex = 6;
            this.lblIncidentLevel.Text = "Incident Level";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(125, 388);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(100, 50);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(396, 388);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 50);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblReportDescription
            // 
            this.lblReportDescription.AutoSize = true;
            this.lblReportDescription.Location = new System.Drawing.Point(392, 134);
            this.lblReportDescription.Name = "lblReportDescription";
            this.lblReportDescription.Size = new System.Drawing.Size(142, 20);
            this.lblReportDescription.TabIndex = 9;
            this.lblReportDescription.Text = "Report Description";
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(432, 287);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(86, 20);
            this.lblComments.TabIndex = 10;
            this.lblComments.Text = "Comments";
            // 
            // doubleBitmapControl1
            // 
            this.doubleBitmapControl1.Location = new System.Drawing.Point(283, 0);
            this.doubleBitmapControl1.Name = "doubleBitmapControl1";
            this.doubleBitmapControl1.Size = new System.Drawing.Size(75, 23);
            this.doubleBitmapControl1.TabIndex = 11;
            this.doubleBitmapControl1.Text = "doubleBitmapControl1";
            this.doubleBitmapControl1.Visible = false;
            // 
            // ReportPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.doubleBitmapControl1);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.lblReportDescription);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblIncidentLevel);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.rtxtComments);
            this.Controls.Add(this.rtxtReportDescription);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbIncidentLevel);
            this.Name = "ReportPage";
            this.Text = "ReportPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIncidentLevel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox rtxtReportDescription;
        private System.Windows.Forms.RichTextBox rtxtComments;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblIncidentLevel;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblReportDescription;
        private System.Windows.Forms.Label lblComments;
        private BunifuAnimatorNS.DoubleBitmapControl doubleBitmapControl1;
    }
}