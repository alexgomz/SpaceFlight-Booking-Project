namespace Final_Project
{
    partial class frmAdvSearch
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
            this.picSolarSysFlag = new System.Windows.Forms.PictureBox();
            this.picFlagBanner = new System.Windows.Forms.PictureBox();
            this.pnlSearchDest = new System.Windows.Forms.Panel();
            this.btnSearchByDestination = new System.Windows.Forms.Button();
            this.txtSearchByDestination = new System.Windows.Forms.TextBox();
            this.rdoSearchByDestination = new System.Windows.Forms.RadioButton();
            this.pnlSearchDepLoc = new System.Windows.Forms.Panel();
            this.btnSearchByDepartureLocation = new System.Windows.Forms.Button();
            this.txtSearchByDepartureLocation = new System.Windows.Forms.TextBox();
            this.rdoSearchByDepartureLocation = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSolarSysFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlagBanner)).BeginInit();
            this.pnlSearchDest.SuspendLayout();
            this.pnlSearchDepLoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // picSolarSysFlag
            // 
            this.picSolarSysFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSolarSysFlag.Image = global::Final_Project.Properties.Resources.solar_system_flag;
            this.picSolarSysFlag.Location = new System.Drawing.Point(105, 1);
            this.picSolarSysFlag.Name = "picSolarSysFlag";
            this.picSolarSysFlag.Size = new System.Drawing.Size(497, 108);
            this.picSolarSysFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSolarSysFlag.TabIndex = 3;
            this.picSolarSysFlag.TabStop = false;
            // 
            // picFlagBanner
            // 
            this.picFlagBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFlagBanner.Image = global::Final_Project.Properties.Resources.Un_flag_square;
            this.picFlagBanner.Location = new System.Drawing.Point(-2, 1);
            this.picFlagBanner.Name = "picFlagBanner";
            this.picFlagBanner.Size = new System.Drawing.Size(107, 108);
            this.picFlagBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFlagBanner.TabIndex = 2;
            this.picFlagBanner.TabStop = false;
            // 
            // pnlSearchDest
            // 
            this.pnlSearchDest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearchDest.Controls.Add(this.btnSearchByDestination);
            this.pnlSearchDest.Controls.Add(this.txtSearchByDestination);
            this.pnlSearchDest.Controls.Add(this.rdoSearchByDestination);
            this.pnlSearchDest.Location = new System.Drawing.Point(18, 126);
            this.pnlSearchDest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlSearchDest.Name = "pnlSearchDest";
            this.pnlSearchDest.Size = new System.Drawing.Size(463, 40);
            this.pnlSearchDest.TabIndex = 8;
            // 
            // btnSearchByDestination
            // 
            this.btnSearchByDestination.Enabled = false;
            this.btnSearchByDestination.Location = new System.Drawing.Point(379, 8);
            this.btnSearchByDestination.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchByDestination.Name = "btnSearchByDestination";
            this.btnSearchByDestination.Size = new System.Drawing.Size(75, 25);
            this.btnSearchByDestination.TabIndex = 2;
            this.btnSearchByDestination.Text = "Search";
            this.btnSearchByDestination.UseVisualStyleBackColor = true;
            this.btnSearchByDestination.Click += new System.EventHandler(this.btnSearchByDestination_Click);
            // 
            // txtSearchByDestination
            // 
            this.txtSearchByDestination.Enabled = false;
            this.txtSearchByDestination.Location = new System.Drawing.Point(179, 12);
            this.txtSearchByDestination.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchByDestination.Name = "txtSearchByDestination";
            this.txtSearchByDestination.Size = new System.Drawing.Size(183, 20);
            this.txtSearchByDestination.TabIndex = 1;
            // 
            // rdoSearchByDestination
            // 
            this.rdoSearchByDestination.AutoSize = true;
            this.rdoSearchByDestination.Location = new System.Drawing.Point(13, 13);
            this.rdoSearchByDestination.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoSearchByDestination.Name = "rdoSearchByDestination";
            this.rdoSearchByDestination.Size = new System.Drawing.Size(129, 17);
            this.rdoSearchByDestination.TabIndex = 0;
            this.rdoSearchByDestination.TabStop = true;
            this.rdoSearchByDestination.Text = "Search by Destination";
            this.rdoSearchByDestination.UseVisualStyleBackColor = true;
            this.rdoSearchByDestination.Click += new System.EventHandler(this.rdoSearchByDestination_Click);
            // 
            // pnlSearchDepLoc
            // 
            this.pnlSearchDepLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearchDepLoc.Controls.Add(this.btnSearchByDepartureLocation);
            this.pnlSearchDepLoc.Controls.Add(this.txtSearchByDepartureLocation);
            this.pnlSearchDepLoc.Controls.Add(this.rdoSearchByDepartureLocation);
            this.pnlSearchDepLoc.Location = new System.Drawing.Point(18, 179);
            this.pnlSearchDepLoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlSearchDepLoc.Name = "pnlSearchDepLoc";
            this.pnlSearchDepLoc.Size = new System.Drawing.Size(463, 40);
            this.pnlSearchDepLoc.TabIndex = 10;
            // 
            // btnSearchByDepartureLocation
            // 
            this.btnSearchByDepartureLocation.Enabled = false;
            this.btnSearchByDepartureLocation.Location = new System.Drawing.Point(379, 6);
            this.btnSearchByDepartureLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchByDepartureLocation.Name = "btnSearchByDepartureLocation";
            this.btnSearchByDepartureLocation.Size = new System.Drawing.Size(75, 25);
            this.btnSearchByDepartureLocation.TabIndex = 12;
            this.btnSearchByDepartureLocation.Text = "Search";
            this.btnSearchByDepartureLocation.UseVisualStyleBackColor = true;
            this.btnSearchByDepartureLocation.Click += new System.EventHandler(this.btnSearchByDepartureLocation_Click);
            // 
            // txtSearchByDepartureLocation
            // 
            this.txtSearchByDepartureLocation.Enabled = false;
            this.txtSearchByDepartureLocation.Location = new System.Drawing.Point(179, 10);
            this.txtSearchByDepartureLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchByDepartureLocation.Name = "txtSearchByDepartureLocation";
            this.txtSearchByDepartureLocation.Size = new System.Drawing.Size(183, 20);
            this.txtSearchByDepartureLocation.TabIndex = 3;
            // 
            // rdoSearchByDepartureLocation
            // 
            this.rdoSearchByDepartureLocation.AutoSize = true;
            this.rdoSearchByDepartureLocation.Location = new System.Drawing.Point(13, 12);
            this.rdoSearchByDepartureLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoSearchByDepartureLocation.Name = "rdoSearchByDepartureLocation";
            this.rdoSearchByDepartureLocation.Size = new System.Drawing.Size(167, 17);
            this.rdoSearchByDepartureLocation.TabIndex = 2;
            this.rdoSearchByDepartureLocation.TabStop = true;
            this.rdoSearchByDepartureLocation.Text = "Search by Departure Location";
            this.rdoSearchByDepartureLocation.UseVisualStyleBackColor = true;
            this.rdoSearchByDepartureLocation.Click += new System.EventHandler(this.rdoSearchByDepartureLocation_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(503, 194);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(503, 126);
            this.btnViewAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(75, 40);
            this.btnViewAll.TabIndex = 12;
            this.btnViewAll.Text = "View ALL Flights";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // frmAdvSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 233);
            this.ControlBox = false;
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlSearchDepLoc);
            this.Controls.Add(this.pnlSearchDest);
            this.Controls.Add(this.picSolarSysFlag);
            this.Controls.Add(this.picFlagBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAdvSearch";
            this.Text = "Advanced Search";
            this.Load += new System.EventHandler(this.frmAdvSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSolarSysFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlagBanner)).EndInit();
            this.pnlSearchDest.ResumeLayout(false);
            this.pnlSearchDest.PerformLayout();
            this.pnlSearchDepLoc.ResumeLayout(false);
            this.pnlSearchDepLoc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSolarSysFlag;
        private System.Windows.Forms.PictureBox picFlagBanner;
        private System.Windows.Forms.Panel pnlSearchDest;
        private System.Windows.Forms.Button btnSearchByDestination;
        private System.Windows.Forms.TextBox txtSearchByDestination;
        private System.Windows.Forms.RadioButton rdoSearchByDestination;
        private System.Windows.Forms.Panel pnlSearchDepLoc;
        private System.Windows.Forms.Button btnSearchByDepartureLocation;
        private System.Windows.Forms.TextBox txtSearchByDepartureLocation;
        private System.Windows.Forms.RadioButton rdoSearchByDepartureLocation;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnViewAll;
    }
}