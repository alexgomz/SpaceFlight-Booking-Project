namespace Final_Project
{
    partial class frmTicketInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTicketInfo));
            this.picSolarSysFlag = new System.Windows.Forms.PictureBox();
            this.picFlagBanner = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSearchPersonal = new System.Windows.Forms.Panel();
            this.btnSearchPer = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.pnlSearchNum = new System.Windows.Forms.Panel();
            this.btnSearchNum = new System.Windows.Forms.Button();
            this.lblONum = new System.Windows.Forms.Label();
            this.txtOrderNum = new System.Windows.Forms.TextBox();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSolarSysFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlagBanner)).BeginInit();
            this.pnlSearchPersonal.SuspendLayout();
            this.pnlSearchNum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // picSolarSysFlag
            // 
            this.picSolarSysFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSolarSysFlag.Image = global::Final_Project.Properties.Resources.solar_system_flag;
            this.picSolarSysFlag.Location = new System.Drawing.Point(105, -1);
            this.picSolarSysFlag.Name = "picSolarSysFlag";
            this.picSolarSysFlag.Size = new System.Drawing.Size(497, 108);
            this.picSolarSysFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSolarSysFlag.TabIndex = 5;
            this.picSolarSysFlag.TabStop = false;
            // 
            // picFlagBanner
            // 
            this.picFlagBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFlagBanner.Image = global::Final_Project.Properties.Resources.Un_flag_square;
            this.picFlagBanner.Location = new System.Drawing.Point(-1, -1);
            this.picFlagBanner.Name = "picFlagBanner";
            this.picFlagBanner.Size = new System.Drawing.Size(107, 108);
            this.picFlagBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFlagBanner.TabIndex = 4;
            this.picFlagBanner.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Need information on your purchased flight? Or maybe want to cancel your ticket?\r\n" +
    "Find it using your personal information or order number!";
            // 
            // pnlSearchPersonal
            // 
            this.pnlSearchPersonal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearchPersonal.Controls.Add(this.btnSearchPer);
            this.pnlSearchPersonal.Controls.Add(this.lblEmail);
            this.pnlSearchPersonal.Controls.Add(this.lblLName);
            this.pnlSearchPersonal.Controls.Add(this.lblFName);
            this.pnlSearchPersonal.Controls.Add(this.txtEmail);
            this.pnlSearchPersonal.Controls.Add(this.txtLName);
            this.pnlSearchPersonal.Controls.Add(this.txtFName);
            this.pnlSearchPersonal.Location = new System.Drawing.Point(8, 156);
            this.pnlSearchPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSearchPersonal.Name = "pnlSearchPersonal";
            this.pnlSearchPersonal.Size = new System.Drawing.Size(289, 85);
            this.pnlSearchPersonal.TabIndex = 7;
            // 
            // btnSearchPer
            // 
            this.btnSearchPer.Location = new System.Drawing.Point(185, 49);
            this.btnSearchPer.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchPer.Name = "btnSearchPer";
            this.btnSearchPer.Size = new System.Drawing.Size(82, 25);
            this.btnSearchPer.TabIndex = 13;
            this.btnSearchPer.Text = "Search";
            this.btnSearchPer.UseVisualStyleBackColor = true;
            this.btnSearchPer.Click += new System.EventHandler(this.btnSearchPer_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 42);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(153, 3);
            this.lblLName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(61, 13);
            this.lblLName.TabIndex = 11;
            this.lblLName.Text = "Last Name:";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(15, 3);
            this.lblFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(60, 13);
            this.lblFName.TabIndex = 10;
            this.lblFName.Text = "First Name:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(18, 57);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(119, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(156, 18);
            this.txtLName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(119, 20);
            this.txtLName.TabIndex = 1;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(18, 18);
            this.txtFName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(119, 20);
            this.txtFName.TabIndex = 0;
            // 
            // pnlSearchNum
            // 
            this.pnlSearchNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearchNum.Controls.Add(this.btnSearchNum);
            this.pnlSearchNum.Controls.Add(this.lblONum);
            this.pnlSearchNum.Controls.Add(this.txtOrderNum);
            this.pnlSearchNum.Location = new System.Drawing.Point(301, 156);
            this.pnlSearchNum.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSearchNum.Name = "pnlSearchNum";
            this.pnlSearchNum.Size = new System.Drawing.Size(289, 85);
            this.pnlSearchNum.TabIndex = 8;
            // 
            // btnSearchNum
            // 
            this.btnSearchNum.Location = new System.Drawing.Point(185, 49);
            this.btnSearchNum.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchNum.Name = "btnSearchNum";
            this.btnSearchNum.Size = new System.Drawing.Size(82, 25);
            this.btnSearchNum.TabIndex = 14;
            this.btnSearchNum.Text = "Search";
            this.btnSearchNum.UseVisualStyleBackColor = true;
            this.btnSearchNum.Click += new System.EventHandler(this.btnSearchNum_Click);
            // 
            // lblONum
            // 
            this.lblONum.AutoSize = true;
            this.lblONum.Location = new System.Drawing.Point(62, 3);
            this.lblONum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblONum.Name = "lblONum";
            this.lblONum.Size = new System.Drawing.Size(76, 13);
            this.lblONum.TabIndex = 13;
            this.lblONum.Text = "Order Number:";
            // 
            // txtOrderNum
            // 
            this.txtOrderNum.Location = new System.Drawing.Point(84, 18);
            this.txtOrderNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderNum.Name = "txtOrderNum";
            this.txtOrderNum.Size = new System.Drawing.Size(119, 20);
            this.txtOrderNum.TabIndex = 10;
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AllowUserToDeleteRows = false;
            this.dgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSearch.BackgroundColor = System.Drawing.Color.White;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(18, 252);
            this.dgvSearch.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSearch.MultiSelect = false;
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.RowHeadersVisible = false;
            this.dgvSearch.RowTemplate.Height = 28;
            this.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearch.Size = new System.Drawing.Size(565, 107);
            this.dgvSearch.TabIndex = 9;
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Location = new System.Drawing.Point(18, 368);
            this.btnDeleteRecord.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(97, 25);
            this.btnDeleteRecord.TabIndex = 14;
            this.btnDeleteRecord.Text = "Delete Order";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(501, 368);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 25);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmTicketInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 400);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteRecord);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.pnlSearchNum);
            this.Controls.Add(this.pnlSearchPersonal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picSolarSysFlag);
            this.Controls.Add(this.picFlagBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTicketInfo";
            this.Text = "Ticket Information";
            ((System.ComponentModel.ISupportInitialize)(this.picSolarSysFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlagBanner)).EndInit();
            this.pnlSearchPersonal.ResumeLayout(false);
            this.pnlSearchPersonal.PerformLayout();
            this.pnlSearchNum.ResumeLayout(false);
            this.pnlSearchNum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSolarSysFlag;
        private System.Windows.Forms.PictureBox picFlagBanner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSearchPersonal;
        private System.Windows.Forms.Panel pnlSearchNum;
        private System.Windows.Forms.Button btnSearchPer;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Button btnSearchNum;
        private System.Windows.Forms.Label lblONum;
        private System.Windows.Forms.TextBox txtOrderNum;
        public System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.Button btnCancel;
    }
}