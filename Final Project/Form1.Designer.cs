namespace Final_Project
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlFlightInfo = new System.Windows.Forms.Panel();
            this.lblCCSAvailShow = new System.Windows.Forms.Label();
            this.lblFCSAvailShow = new System.Windows.Forms.Label();
            this.lblTravelTimeShow = new System.Windows.Forms.Label();
            this.lblCCPShow = new System.Windows.Forms.Label();
            this.lblFCPShow = new System.Windows.Forms.Label();
            this.lblCCSeats = new System.Windows.Forms.Label();
            this.lblFCSeats = new System.Windows.Forms.Label();
            this.lblTravelTime = new System.Windows.Forms.Label();
            this.lblCCPrice = new System.Windows.Forms.Label();
            this.lblFCPrice = new System.Windows.Forms.Label();
            this.btnSelectFlight = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvFlights = new System.Windows.Forms.DataGridView();
            this.pnlDestinations = new System.Windows.Forms.Panel();
            this.btnSelectDestination = new System.Windows.Forms.Button();
            this.rdoVenus = new System.Windows.Forms.RadioButton();
            this.rdoPluto = new System.Windows.Forms.RadioButton();
            this.rdoNeptune = new System.Windows.Forms.RadioButton();
            this.rdoMoon = new System.Windows.Forms.RadioButton();
            this.rdoMercury = new System.Windows.Forms.RadioButton();
            this.rdoMars = new System.Windows.Forms.RadioButton();
            this.rdoJupiter = new System.Windows.Forms.RadioButton();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.lblTimeDisplay = new System.Windows.Forms.Label();
            this.picSelection = new System.Windows.Forms.PictureBox();
            this.picSolarSysFlag = new System.Windows.Forms.PictureBox();
            this.picFlagBanner = new System.Windows.Forms.PictureBox();
            this.lblAdvSearch = new System.Windows.Forms.Button();
            this.btnTicketInfo = new System.Windows.Forms.Button();
            this.pnlFlightInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).BeginInit();
            this.pnlDestinations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSolarSysFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlagBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(27, 120);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(301, 26);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome to the intergalactic space travel booking program!\r\nTo see available flig" +
    "hts, please select your general destination:";
            // 
            // pnlFlightInfo
            // 
            this.pnlFlightInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFlightInfo.Controls.Add(this.lblCCSAvailShow);
            this.pnlFlightInfo.Controls.Add(this.lblFCSAvailShow);
            this.pnlFlightInfo.Controls.Add(this.lblTravelTimeShow);
            this.pnlFlightInfo.Controls.Add(this.lblCCPShow);
            this.pnlFlightInfo.Controls.Add(this.lblFCPShow);
            this.pnlFlightInfo.Controls.Add(this.lblCCSeats);
            this.pnlFlightInfo.Controls.Add(this.lblFCSeats);
            this.pnlFlightInfo.Controls.Add(this.lblTravelTime);
            this.pnlFlightInfo.Controls.Add(this.lblCCPrice);
            this.pnlFlightInfo.Controls.Add(this.lblFCPrice);
            this.pnlFlightInfo.Controls.Add(this.btnSelectFlight);
            this.pnlFlightInfo.Location = new System.Drawing.Point(26, 460);
            this.pnlFlightInfo.Name = "pnlFlightInfo";
            this.pnlFlightInfo.Size = new System.Drawing.Size(477, 127);
            this.pnlFlightInfo.TabIndex = 6;
            // 
            // lblCCSAvailShow
            // 
            this.lblCCSAvailShow.AutoSize = true;
            this.lblCCSAvailShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCSAvailShow.Location = new System.Drawing.Point(389, 34);
            this.lblCCSAvailShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCCSAvailShow.Name = "lblCCSAvailShow";
            this.lblCCSAvailShow.Size = new System.Drawing.Size(41, 13);
            this.lblCCSAvailShow.TabIndex = 18;
            this.lblCCSAvailShow.Text = "label6";
            this.lblCCSAvailShow.Visible = false;
            // 
            // lblFCSAvailShow
            // 
            this.lblFCSAvailShow.AutoSize = true;
            this.lblFCSAvailShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFCSAvailShow.Location = new System.Drawing.Point(389, 12);
            this.lblFCSAvailShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFCSAvailShow.Name = "lblFCSAvailShow";
            this.lblFCSAvailShow.Size = new System.Drawing.Size(41, 13);
            this.lblFCSAvailShow.TabIndex = 17;
            this.lblFCSAvailShow.Text = "label5";
            this.lblFCSAvailShow.Visible = false;
            // 
            // lblTravelTimeShow
            // 
            this.lblTravelTimeShow.AutoSize = true;
            this.lblTravelTimeShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTravelTimeShow.Location = new System.Drawing.Point(131, 57);
            this.lblTravelTimeShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTravelTimeShow.Name = "lblTravelTimeShow";
            this.lblTravelTimeShow.Size = new System.Drawing.Size(41, 13);
            this.lblTravelTimeShow.TabIndex = 16;
            this.lblTravelTimeShow.Text = "label4";
            this.lblTravelTimeShow.Visible = false;
            // 
            // lblCCPShow
            // 
            this.lblCCPShow.AutoSize = true;
            this.lblCCPShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCPShow.Location = new System.Drawing.Point(131, 34);
            this.lblCCPShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCCPShow.Name = "lblCCPShow";
            this.lblCCPShow.Size = new System.Drawing.Size(41, 13);
            this.lblCCPShow.TabIndex = 15;
            this.lblCCPShow.Text = "label3";
            this.lblCCPShow.Visible = false;
            // 
            // lblFCPShow
            // 
            this.lblFCPShow.AutoSize = true;
            this.lblFCPShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFCPShow.Location = new System.Drawing.Point(131, 12);
            this.lblFCPShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFCPShow.Name = "lblFCPShow";
            this.lblFCPShow.Size = new System.Drawing.Size(41, 13);
            this.lblFCPShow.TabIndex = 14;
            this.lblFCPShow.Text = "label2";
            this.lblFCPShow.Visible = false;
            // 
            // lblCCSeats
            // 
            this.lblCCSeats.AutoSize = true;
            this.lblCCSeats.Location = new System.Drawing.Point(233, 34);
            this.lblCCSeats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCCSeats.Name = "lblCCSeats";
            this.lblCCSeats.Size = new System.Drawing.Size(145, 13);
            this.lblCCSeats.TabIndex = 13;
            this.lblCCSeats.Text = "Coach Class Seats Available:";
            // 
            // lblFCSeats
            // 
            this.lblFCSeats.AutoSize = true;
            this.lblFCSeats.Location = new System.Drawing.Point(233, 12);
            this.lblFCSeats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFCSeats.Name = "lblFCSeats";
            this.lblFCSeats.Size = new System.Drawing.Size(133, 13);
            this.lblFCSeats.TabIndex = 12;
            this.lblFCSeats.Text = "First Class Seats Available:";
            // 
            // lblTravelTime
            // 
            this.lblTravelTime.AutoSize = true;
            this.lblTravelTime.Location = new System.Drawing.Point(12, 57);
            this.lblTravelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTravelTime.Name = "lblTravelTime";
            this.lblTravelTime.Size = new System.Drawing.Size(115, 13);
            this.lblTravelTime.TabIndex = 11;
            this.lblTravelTime.Text = "Estimated Travel Time:";
            // 
            // lblCCPrice
            // 
            this.lblCCPrice.AutoSize = true;
            this.lblCCPrice.Location = new System.Drawing.Point(12, 34);
            this.lblCCPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCCPrice.Name = "lblCCPrice";
            this.lblCCPrice.Size = new System.Drawing.Size(96, 13);
            this.lblCCPrice.TabIndex = 10;
            this.lblCCPrice.Text = "Coach Class Price:";
            // 
            // lblFCPrice
            // 
            this.lblFCPrice.AutoSize = true;
            this.lblFCPrice.Location = new System.Drawing.Point(12, 12);
            this.lblFCPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFCPrice.Name = "lblFCPrice";
            this.lblFCPrice.Size = new System.Drawing.Size(84, 13);
            this.lblFCPrice.TabIndex = 9;
            this.lblFCPrice.Text = "First Class Price:";
            // 
            // btnSelectFlight
            // 
            this.btnSelectFlight.Location = new System.Drawing.Point(391, 92);
            this.btnSelectFlight.Name = "btnSelectFlight";
            this.btnSelectFlight.Size = new System.Drawing.Size(79, 25);
            this.btnSelectFlight.TabIndex = 8;
            this.btnSelectFlight.Text = "Select Flight";
            this.btnSelectFlight.UseVisualStyleBackColor = true;
            this.btnSelectFlight.Click += new System.EventHandler(this.btnSelectFlight_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightGray;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Location = new System.Drawing.Point(513, 554);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 25);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvFlights
            // 
            this.dgvFlights.AllowUserToAddRows = false;
            this.dgvFlights.AllowUserToDeleteRows = false;
            this.dgvFlights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFlights.BackgroundColor = System.Drawing.Color.White;
            this.dgvFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlights.Location = new System.Drawing.Point(26, 285);
            this.dgvFlights.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvFlights.MultiSelect = false;
            this.dgvFlights.Name = "dgvFlights";
            this.dgvFlights.ReadOnly = true;
            this.dgvFlights.RowHeadersVisible = false;
            this.dgvFlights.RowTemplate.Height = 28;
            this.dgvFlights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFlights.Size = new System.Drawing.Size(565, 170);
            this.dgvFlights.TabIndex = 8;
            this.dgvFlights.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFlights_CellClick);
            // 
            // pnlDestinations
            // 
            this.pnlDestinations.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDestinations.Controls.Add(this.btnSelectDestination);
            this.pnlDestinations.Controls.Add(this.rdoVenus);
            this.pnlDestinations.Controls.Add(this.rdoPluto);
            this.pnlDestinations.Controls.Add(this.rdoNeptune);
            this.pnlDestinations.Controls.Add(this.rdoMoon);
            this.pnlDestinations.Controls.Add(this.rdoMercury);
            this.pnlDestinations.Controls.Add(this.rdoMars);
            this.pnlDestinations.Controls.Add(this.rdoJupiter);
            this.pnlDestinations.Location = new System.Drawing.Point(26, 148);
            this.pnlDestinations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlDestinations.Name = "pnlDestinations";
            this.pnlDestinations.Size = new System.Drawing.Size(319, 99);
            this.pnlDestinations.TabIndex = 9;
            // 
            // btnSelectDestination
            // 
            this.btnSelectDestination.Location = new System.Drawing.Point(227, 61);
            this.btnSelectDestination.Name = "btnSelectDestination";
            this.btnSelectDestination.Size = new System.Drawing.Size(79, 25);
            this.btnSelectDestination.TabIndex = 9;
            this.btnSelectDestination.Text = "Select";
            this.btnSelectDestination.UseVisualStyleBackColor = true;
            this.btnSelectDestination.Click += new System.EventHandler(this.btnSelectDestination_Click);
            // 
            // rdoVenus
            // 
            this.rdoVenus.AutoSize = true;
            this.rdoVenus.Location = new System.Drawing.Point(210, 8);
            this.rdoVenus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoVenus.Name = "rdoVenus";
            this.rdoVenus.Size = new System.Drawing.Size(55, 17);
            this.rdoVenus.TabIndex = 6;
            this.rdoVenus.TabStop = true;
            this.rdoVenus.Text = "Venus";
            this.rdoVenus.UseVisualStyleBackColor = true;
            this.rdoVenus.Click += new System.EventHandler(this.rdoVenus_Click);
            // 
            // rdoPluto
            // 
            this.rdoPluto.AutoSize = true;
            this.rdoPluto.Location = new System.Drawing.Point(109, 61);
            this.rdoPluto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoPluto.Name = "rdoPluto";
            this.rdoPluto.Size = new System.Drawing.Size(49, 17);
            this.rdoPluto.TabIndex = 5;
            this.rdoPluto.TabStop = true;
            this.rdoPluto.Text = "Pluto";
            this.rdoPluto.UseVisualStyleBackColor = true;
            this.rdoPluto.Click += new System.EventHandler(this.rdoPluto_Click);
            // 
            // rdoNeptune
            // 
            this.rdoNeptune.AutoSize = true;
            this.rdoNeptune.Location = new System.Drawing.Point(109, 35);
            this.rdoNeptune.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoNeptune.Name = "rdoNeptune";
            this.rdoNeptune.Size = new System.Drawing.Size(66, 17);
            this.rdoNeptune.TabIndex = 4;
            this.rdoNeptune.TabStop = true;
            this.rdoNeptune.Text = "Neptune";
            this.rdoNeptune.UseVisualStyleBackColor = true;
            this.rdoNeptune.Click += new System.EventHandler(this.rdoNeptune_Click);
            // 
            // rdoMoon
            // 
            this.rdoMoon.AutoSize = true;
            this.rdoMoon.Location = new System.Drawing.Point(109, 8);
            this.rdoMoon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoMoon.Name = "rdoMoon";
            this.rdoMoon.Size = new System.Drawing.Size(52, 17);
            this.rdoMoon.TabIndex = 3;
            this.rdoMoon.TabStop = true;
            this.rdoMoon.Text = "Moon";
            this.rdoMoon.UseVisualStyleBackColor = true;
            this.rdoMoon.Click += new System.EventHandler(this.rdoMoon_Click);
            // 
            // rdoMercury
            // 
            this.rdoMercury.AutoSize = true;
            this.rdoMercury.Location = new System.Drawing.Point(10, 61);
            this.rdoMercury.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoMercury.Name = "rdoMercury";
            this.rdoMercury.Size = new System.Drawing.Size(63, 17);
            this.rdoMercury.TabIndex = 2;
            this.rdoMercury.TabStop = true;
            this.rdoMercury.Text = "Mercury";
            this.rdoMercury.UseVisualStyleBackColor = true;
            this.rdoMercury.Click += new System.EventHandler(this.rdoMercury_Click);
            // 
            // rdoMars
            // 
            this.rdoMars.AutoSize = true;
            this.rdoMars.Location = new System.Drawing.Point(10, 35);
            this.rdoMars.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoMars.Name = "rdoMars";
            this.rdoMars.Size = new System.Drawing.Size(48, 17);
            this.rdoMars.TabIndex = 1;
            this.rdoMars.TabStop = true;
            this.rdoMars.Text = "Mars";
            this.rdoMars.UseVisualStyleBackColor = true;
            this.rdoMars.Click += new System.EventHandler(this.rdoMars_Click);
            // 
            // rdoJupiter
            // 
            this.rdoJupiter.AutoSize = true;
            this.rdoJupiter.Location = new System.Drawing.Point(10, 8);
            this.rdoJupiter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoJupiter.Name = "rdoJupiter";
            this.rdoJupiter.Size = new System.Drawing.Size(56, 17);
            this.rdoJupiter.TabIndex = 0;
            this.rdoJupiter.TabStop = true;
            this.rdoJupiter.Text = "Jupiter";
            this.rdoJupiter.UseVisualStyleBackColor = true;
            this.rdoJupiter.Click += new System.EventHandler(this.rdoJupiter_Click);
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // lblTimeDisplay
            // 
            this.lblTimeDisplay.AutoSize = true;
            this.lblTimeDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(146)))), ((int)(((byte)(219)))));
            this.lblTimeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeDisplay.Location = new System.Drawing.Point(495, 6);
            this.lblTimeDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimeDisplay.Name = "lblTimeDisplay";
            this.lblTimeDisplay.Size = new System.Drawing.Size(42, 13);
            this.lblTimeDisplay.TabIndex = 10;
            this.lblTimeDisplay.Text = "holder";
            // 
            // picSelection
            // 
            this.picSelection.Image = global::Final_Project.Properties.Resources.Flag_of_the_United_Federation_of_Planets;
            this.picSelection.Location = new System.Drawing.Point(357, 120);
            this.picSelection.Name = "picSelection";
            this.picSelection.Size = new System.Drawing.Size(234, 126);
            this.picSelection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSelection.TabIndex = 5;
            this.picSelection.TabStop = false;
            // 
            // picSolarSysFlag
            // 
            this.picSolarSysFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSolarSysFlag.Image = global::Final_Project.Properties.Resources.solar_system_flag;
            this.picSolarSysFlag.Location = new System.Drawing.Point(106, 0);
            this.picSolarSysFlag.Name = "picSolarSysFlag";
            this.picSolarSysFlag.Size = new System.Drawing.Size(497, 108);
            this.picSolarSysFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSolarSysFlag.TabIndex = 1;
            this.picSolarSysFlag.TabStop = false;
            // 
            // picFlagBanner
            // 
            this.picFlagBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFlagBanner.Image = global::Final_Project.Properties.Resources.Un_flag_square;
            this.picFlagBanner.Location = new System.Drawing.Point(-1, 0);
            this.picFlagBanner.Name = "picFlagBanner";
            this.picFlagBanner.Size = new System.Drawing.Size(107, 108);
            this.picFlagBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFlagBanner.TabIndex = 0;
            this.picFlagBanner.TabStop = false;
            // 
            // lblAdvSearch
            // 
            this.lblAdvSearch.Location = new System.Drawing.Point(26, 251);
            this.lblAdvSearch.Name = "lblAdvSearch";
            this.lblAdvSearch.Size = new System.Drawing.Size(110, 25);
            this.lblAdvSearch.TabIndex = 12;
            this.lblAdvSearch.Text = "Advanced Search";
            this.lblAdvSearch.UseVisualStyleBackColor = true;
            this.lblAdvSearch.Click += new System.EventHandler(this.lblAdvSearch_Click);
            // 
            // btnTicketInfo
            // 
            this.btnTicketInfo.Location = new System.Drawing.Point(182, 251);
            this.btnTicketInfo.Name = "btnTicketInfo";
            this.btnTicketInfo.Size = new System.Drawing.Size(162, 25);
            this.btnTicketInfo.TabIndex = 13;
            this.btnTicketInfo.Text = "Purchased Ticket Information";
            this.btnTicketInfo.UseVisualStyleBackColor = true;
            this.btnTicketInfo.Click += new System.EventHandler(this.btnTicketInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(601, 602);
            this.Controls.Add(this.btnTicketInfo);
            this.Controls.Add(this.lblTimeDisplay);
            this.Controls.Add(this.lblAdvSearch);
            this.Controls.Add(this.pnlDestinations);
            this.Controls.Add(this.dgvFlights);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlFlightInfo);
            this.Controls.Add(this.picSelection);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.picSolarSysFlag);
            this.Controls.Add(this.picFlagBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "UNITED FEDERATION  of PLANETS Flight Booking";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlFlightInfo.ResumeLayout(false);
            this.pnlFlightInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).EndInit();
            this.pnlDestinations.ResumeLayout(false);
            this.pnlDestinations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSolarSysFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlagBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFlagBanner;
        private System.Windows.Forms.PictureBox picSolarSysFlag;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox picSelection;
        private System.Windows.Forms.Panel pnlFlightInfo;
        private System.Windows.Forms.Button btnSelectFlight;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCCSeats;
        private System.Windows.Forms.Label lblFCSeats;
        private System.Windows.Forms.Label lblTravelTime;
        private System.Windows.Forms.Label lblCCPrice;
        private System.Windows.Forms.Label lblFCPrice;
        private System.Windows.Forms.Panel pnlDestinations;
        private System.Windows.Forms.RadioButton rdoVenus;
        private System.Windows.Forms.RadioButton rdoPluto;
        private System.Windows.Forms.RadioButton rdoNeptune;
        private System.Windows.Forms.RadioButton rdoMoon;
        private System.Windows.Forms.RadioButton rdoMercury;
        private System.Windows.Forms.RadioButton rdoMars;
        private System.Windows.Forms.RadioButton rdoJupiter;
        private System.Windows.Forms.Button btnSelectDestination;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label lblTimeDisplay;
        private System.Windows.Forms.Label lblCCSAvailShow;
        private System.Windows.Forms.Label lblFCSAvailShow;
        private System.Windows.Forms.Label lblTravelTimeShow;
        private System.Windows.Forms.Label lblCCPShow;
        private System.Windows.Forms.Label lblFCPShow;
        private System.Windows.Forms.Button lblAdvSearch;
        private System.Windows.Forms.Button btnTicketInfo;
        public System.Windows.Forms.DataGridView dgvFlights;
    }
}

