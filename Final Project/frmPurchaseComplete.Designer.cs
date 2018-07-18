namespace Final_Project
{
    partial class frmPurchaseComplete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseComplete));
            this.picSolarSysFlag = new System.Windows.Forms.PictureBox();
            this.picFlagBanner = new System.Windows.Forms.PictureBox();
            this.lblThanks = new System.Windows.Forms.Label();
            this.lblBye = new System.Windows.Forms.Label();
            this.picShip = new System.Windows.Forms.PictureBox();
            this.picDestination = new System.Windows.Forms.PictureBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.lblSafe = new System.Windows.Forms.Label();
            this.lblShipName = new System.Windows.Forms.Label();
            this.lblEnjoy = new System.Windows.Forms.Label();
            this.lblDestinationSpace = new System.Windows.Forms.Label();
            this.lsbReceipt = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSolarSysFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlagBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDestination)).BeginInit();
            this.SuspendLayout();
            // 
            // picSolarSysFlag
            // 
            this.picSolarSysFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSolarSysFlag.Image = global::Final_Project.Properties.Resources.solar_system_flag;
            this.picSolarSysFlag.Location = new System.Drawing.Point(105, -2);
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
            this.picFlagBanner.Location = new System.Drawing.Point(-2, -2);
            this.picFlagBanner.Name = "picFlagBanner";
            this.picFlagBanner.Size = new System.Drawing.Size(107, 108);
            this.picFlagBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFlagBanner.TabIndex = 2;
            this.picFlagBanner.TabStop = false;
            // 
            // lblThanks
            // 
            this.lblThanks.AutoSize = true;
            this.lblThanks.Location = new System.Drawing.Point(17, 121);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Size = new System.Drawing.Size(192, 26);
            this.lblThanks.TabIndex = 4;
            this.lblThanks.Text = "Thank you for your purchase!\r\nPlease review the following information:";
            // 
            // lblBye
            // 
            this.lblBye.AutoSize = true;
            this.lblBye.Location = new System.Drawing.Point(17, 537);
            this.lblBye.Name = "lblBye";
            this.lblBye.Size = new System.Drawing.Size(226, 26);
            this.lblBye.TabIndex = 6;
            this.lblBye.Text = "You will receive your purchased ticket(s) in the\r\nprovided email address shortly." +
    "";
            // 
            // picShip
            // 
            this.picShip.Location = new System.Drawing.Point(20, 375);
            this.picShip.Name = "picShip";
            this.picShip.Size = new System.Drawing.Size(241, 149);
            this.picShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShip.TabIndex = 7;
            this.picShip.TabStop = false;
            // 
            // picDestination
            // 
            this.picDestination.Location = new System.Drawing.Point(327, 375);
            this.picDestination.Name = "picDestination";
            this.picDestination.Size = new System.Drawing.Size(241, 149);
            this.picDestination.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDestination.TabIndex = 8;
            this.picDestination.TabStop = false;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(501, 550);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(67, 25);
            this.btnFinish.TabIndex = 9;
            this.btnFinish.Text = "Finished";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lblSafe
            // 
            this.lblSafe.AutoSize = true;
            this.lblSafe.Location = new System.Drawing.Point(17, 346);
            this.lblSafe.Name = "lblSafe";
            this.lblSafe.Size = new System.Drawing.Size(136, 13);
            this.lblSafe.TabIndex = 10;
            this.lblSafe.Text = "Have a safe trip aboard the";
            // 
            // lblShipName
            // 
            this.lblShipName.AutoSize = true;
            this.lblShipName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipName.Location = new System.Drawing.Point(17, 359);
            this.lblShipName.Name = "lblShipName";
            this.lblShipName.Size = new System.Drawing.Size(68, 13);
            this.lblShipName.TabIndex = 11;
            this.lblShipName.Text = "#shipname";
            // 
            // lblEnjoy
            // 
            this.lblEnjoy.AutoSize = true;
            this.lblEnjoy.Location = new System.Drawing.Point(324, 346);
            this.lblEnjoy.Name = "lblEnjoy";
            this.lblEnjoy.Size = new System.Drawing.Size(110, 13);
            this.lblEnjoy.TabIndex = 12;
            this.lblEnjoy.Text = "And enjoy your time in\r\n";
            // 
            // lblDestinationSpace
            // 
            this.lblDestinationSpace.AutoSize = true;
            this.lblDestinationSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationSpace.Location = new System.Drawing.Point(324, 359);
            this.lblDestinationSpace.Name = "lblDestinationSpace";
            this.lblDestinationSpace.Size = new System.Drawing.Size(77, 13);
            this.lblDestinationSpace.TabIndex = 13;
            this.lblDestinationSpace.Text = "#destination";
            // 
            // lsbReceipt
            // 
            this.lsbReceipt.FormattingEnabled = true;
            this.lsbReceipt.Location = new System.Drawing.Point(20, 159);
            this.lsbReceipt.Name = "lsbReceipt";
            this.lsbReceipt.Size = new System.Drawing.Size(447, 173);
            this.lsbReceipt.TabIndex = 14;
            // 
            // frmPurchaseComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 591);
            this.Controls.Add(this.lsbReceipt);
            this.Controls.Add(this.lblDestinationSpace);
            this.Controls.Add(this.lblEnjoy);
            this.Controls.Add(this.lblShipName);
            this.Controls.Add(this.lblSafe);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.picDestination);
            this.Controls.Add(this.picShip);
            this.Controls.Add(this.lblBye);
            this.Controls.Add(this.lblThanks);
            this.Controls.Add(this.picSolarSysFlag);
            this.Controls.Add(this.picFlagBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPurchaseComplete";
            this.Text = "Purchase Completed - Receipt";
            this.Load += new System.EventHandler(this.frmPurchaseComplete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSolarSysFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlagBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDestination)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSolarSysFlag;
        private System.Windows.Forms.PictureBox picFlagBanner;
        private System.Windows.Forms.Label lblThanks;
        private System.Windows.Forms.Label lblBye;
        private System.Windows.Forms.PictureBox picShip;
        private System.Windows.Forms.PictureBox picDestination;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label lblSafe;
        private System.Windows.Forms.Label lblShipName;
        private System.Windows.Forms.Label lblEnjoy;
        private System.Windows.Forms.Label lblDestinationSpace;
        private System.Windows.Forms.ListBox lsbReceipt;
    }
}