namespace Final_Project
{
    partial class frmPurchasing
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
            this.dgvReview = new System.Windows.Forms.DataGridView();
            this.lblReview = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.pnlCustomerInfo = new System.Windows.Forms.Panel();
            this.rdoEconomy = new System.Windows.Forms.RadioButton();
            this.lblEconomy = new System.Windows.Forms.Label();
            this.lblFirstClass = new System.Windows.Forms.Label();
            this.rdoFirstClass = new System.Windows.Forms.RadioButton();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.lblSeats = new System.Windows.Forms.Label();
            this.txtCreditCard = new System.Windows.Forms.TextBox();
            this.lblCC = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.cmbSeats = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSolarSysFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlagBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReview)).BeginInit();
            this.pnlCustomerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // picSolarSysFlag
            // 
            this.picSolarSysFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSolarSysFlag.Image = global::Final_Project.Properties.Resources.solar_system_flag;
            this.picSolarSysFlag.Location = new System.Drawing.Point(107, 0);
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
            this.picFlagBanner.Location = new System.Drawing.Point(0, 0);
            this.picFlagBanner.Name = "picFlagBanner";
            this.picFlagBanner.Size = new System.Drawing.Size(107, 108);
            this.picFlagBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFlagBanner.TabIndex = 2;
            this.picFlagBanner.TabStop = false;
            // 
            // dgvReview
            // 
            this.dgvReview.AllowUserToAddRows = false;
            this.dgvReview.AllowUserToDeleteRows = false;
            this.dgvReview.AllowUserToResizeColumns = false;
            this.dgvReview.AllowUserToResizeRows = false;
            this.dgvReview.BackgroundColor = System.Drawing.Color.White;
            this.dgvReview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReview.Location = new System.Drawing.Point(17, 137);
            this.dgvReview.Margin = new System.Windows.Forms.Padding(2);
            this.dgvReview.MultiSelect = false;
            this.dgvReview.Name = "dgvReview";
            this.dgvReview.ReadOnly = true;
            this.dgvReview.RowHeadersVisible = false;
            this.dgvReview.RowTemplate.Height = 28;
            this.dgvReview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReview.Size = new System.Drawing.Size(569, 84);
            this.dgvReview.TabIndex = 8;
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Location = new System.Drawing.Point(14, 122);
            this.lblReview.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(221, 13);
            this.lblReview.TabIndex = 9;
            this.lblReview.Text = "Please review your selected flight information:";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(15, 223);
            this.lblInstructions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(350, 26);
            this.lblInstructions.TabIndex = 10;
            this.lblInstructions.Text = "If you\'d like to make a purchase, please fill in the purchasing information. \r\nOt" +
    "herwise, you can click CANCEL to return to the previous page.";
            // 
            // pnlCustomerInfo
            // 
            this.pnlCustomerInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCustomerInfo.Controls.Add(this.rdoEconomy);
            this.pnlCustomerInfo.Controls.Add(this.lblEconomy);
            this.pnlCustomerInfo.Controls.Add(this.lblFirstClass);
            this.pnlCustomerInfo.Controls.Add(this.rdoFirstClass);
            this.pnlCustomerInfo.Controls.Add(this.btnPurchase);
            this.pnlCustomerInfo.Controls.Add(this.lblSeats);
            this.pnlCustomerInfo.Controls.Add(this.txtCreditCard);
            this.pnlCustomerInfo.Controls.Add(this.lblCC);
            this.pnlCustomerInfo.Controls.Add(this.lblEmail);
            this.pnlCustomerInfo.Controls.Add(this.lblLName);
            this.pnlCustomerInfo.Controls.Add(this.lblFName);
            this.pnlCustomerInfo.Controls.Add(this.cmbSeats);
            this.pnlCustomerInfo.Controls.Add(this.txtEmail);
            this.pnlCustomerInfo.Controls.Add(this.txtLastName);
            this.pnlCustomerInfo.Controls.Add(this.txtFirstName);
            this.pnlCustomerInfo.Location = new System.Drawing.Point(17, 262);
            this.pnlCustomerInfo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCustomerInfo.Name = "pnlCustomerInfo";
            this.pnlCustomerInfo.Size = new System.Drawing.Size(480, 122);
            this.pnlCustomerInfo.TabIndex = 11;
            // 
            // rdoEconomy
            // 
            this.rdoEconomy.AutoSize = true;
            this.rdoEconomy.Checked = true;
            this.rdoEconomy.Location = new System.Drawing.Point(329, 92);
            this.rdoEconomy.Margin = new System.Windows.Forms.Padding(2);
            this.rdoEconomy.Name = "rdoEconomy";
            this.rdoEconomy.Size = new System.Drawing.Size(14, 13);
            this.rdoEconomy.TabIndex = 15;
            this.rdoEconomy.TabStop = true;
            this.rdoEconomy.UseVisualStyleBackColor = true;
            // 
            // lblEconomy
            // 
            this.lblEconomy.AutoSize = true;
            this.lblEconomy.Location = new System.Drawing.Point(309, 75);
            this.lblEconomy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEconomy.Name = "lblEconomy";
            this.lblEconomy.Size = new System.Drawing.Size(51, 13);
            this.lblEconomy.TabIndex = 14;
            this.lblEconomy.Text = "Economy";
            // 
            // lblFirstClass
            // 
            this.lblFirstClass.AutoSize = true;
            this.lblFirstClass.Location = new System.Drawing.Point(242, 75);
            this.lblFirstClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstClass.Name = "lblFirstClass";
            this.lblFirstClass.Size = new System.Drawing.Size(54, 13);
            this.lblFirstClass.TabIndex = 13;
            this.lblFirstClass.Text = "First Class";
            // 
            // rdoFirstClass
            // 
            this.rdoFirstClass.AutoSize = true;
            this.rdoFirstClass.Location = new System.Drawing.Point(267, 92);
            this.rdoFirstClass.Margin = new System.Windows.Forms.Padding(2);
            this.rdoFirstClass.Name = "rdoFirstClass";
            this.rdoFirstClass.Size = new System.Drawing.Size(14, 13);
            this.rdoFirstClass.TabIndex = 12;
            this.rdoFirstClass.UseVisualStyleBackColor = true;
            this.rdoFirstClass.Click += new System.EventHandler(this.rdoFirstClass_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(377, 81);
            this.btnPurchase.Margin = new System.Windows.Forms.Padding(2);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(87, 24);
            this.btnPurchase.TabIndex = 11;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.Location = new System.Drawing.Point(242, 49);
            this.lblSeats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(146, 13);
            this.lblSeats.TabIndex = 10;
            this.lblSeats.Text = "Number of seats to purchase:";
            // 
            // txtCreditCard
            // 
            this.txtCreditCard.Location = new System.Drawing.Point(347, 15);
            this.txtCreditCard.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreditCard.Name = "txtCreditCard";
            this.txtCreditCard.Size = new System.Drawing.Size(119, 20);
            this.txtCreditCard.TabIndex = 9;
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Location = new System.Drawing.Point(242, 19);
            this.lblCC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(102, 13);
            this.lblCC.TabIndex = 8;
            this.lblCC.Text = "Credit Card Number:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(13, 79);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(76, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email Address:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(13, 49);
            this.lblLName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(61, 13);
            this.lblLName.TabIndex = 6;
            this.lblLName.Text = "Last Name:";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(13, 19);
            this.lblFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(60, 13);
            this.lblFName.TabIndex = 5;
            this.lblFName.Text = "First Name:";
            // 
            // cmbSeats
            // 
            this.cmbSeats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeats.FormattingEnabled = true;
            this.cmbSeats.Location = new System.Drawing.Point(391, 47);
            this.cmbSeats.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSeats.Name = "cmbSeats";
            this.cmbSeats.Size = new System.Drawing.Size(35, 21);
            this.cmbSeats.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(107, 75);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(119, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(107, 47);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(119, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(107, 17);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(119, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(505, 345);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 24);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmPurchasing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 394);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlCustomerInfo);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblReview);
            this.Controls.Add(this.dgvReview);
            this.Controls.Add(this.picSolarSysFlag);
            this.Controls.Add(this.picFlagBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPurchasing";
            this.Text = "Ticket Purchasing";
            this.Load += new System.EventHandler(this.frmPurchasing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSolarSysFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlagBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReview)).EndInit();
            this.pnlCustomerInfo.ResumeLayout(false);
            this.pnlCustomerInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSolarSysFlag;
        private System.Windows.Forms.PictureBox picFlagBanner;
        private System.Windows.Forms.DataGridView dgvReview;
        private System.Windows.Forms.Label lblReview;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Panel pnlCustomerInfo;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.TextBox txtCreditCard;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.ComboBox cmbSeats;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rdoEconomy;
        private System.Windows.Forms.Label lblEconomy;
        private System.Windows.Forms.Label lblFirstClass;
        private System.Windows.Forms.RadioButton rdoFirstClass;
    }
}