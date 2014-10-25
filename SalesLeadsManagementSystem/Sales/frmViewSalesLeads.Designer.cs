namespace SalesLeadsManagementSystem.Sales
{
    partial class frmViewSalesLeads
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
            this.dataGridViewSalesLeads = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkShowUnclosed = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSelectColumns = new System.Windows.Forms.Panel();
            this.chkCustomerShortName = new System.Windows.Forms.CheckBox();
            this.chkAccManager = new System.Windows.Forms.CheckBox();
            this.chkNotes = new System.Windows.Forms.CheckBox();
            this.chkDiscount = new System.Windows.Forms.CheckBox();
            this.chkCoustomerFeedBack = new System.Windows.Forms.CheckBox();
            this.chkDisconnectReason = new System.Windows.Forms.CheckBox();
            this.chkDisconnectedDate = new System.Windows.Forms.CheckBox();
            this.chkClosedDate = new System.Windows.Forms.CheckBox();
            this.chkBillIssueDate = new System.Windows.Forms.CheckBox();
            this.chkFirstBillIssued = new System.Windows.Forms.CheckBox();
            this.chkCustomerConfirmDate = new System.Windows.Forms.CheckBox();
            this.chkProjectRevenue = new System.Windows.Forms.CheckBox();
            this.chkHadTest = new System.Windows.Forms.CheckBox();
            this.chkRevenueType = new System.Windows.Forms.CheckBox();
            this.chkProductName = new System.Windows.Forms.CheckBox();
            this.chkCustomerID = new System.Windows.Forms.CheckBox();
            this.chkCloseReason = new System.Windows.Forms.CheckBox();
            this.chkDSP = new System.Windows.Forms.CheckBox();
            this.chkAgreementSignDate = new System.Windows.Forms.CheckBox();
            this.chkProjectPaid = new System.Windows.Forms.CheckBox();
            this.chkMonthlyRevenue = new System.Windows.Forms.CheckBox();
            this.chkIssueDate = new System.Windows.Forms.CheckBox();
            this.chkProductID = new System.Windows.Forms.CheckBox();
            this.chkCustomerName = new System.Windows.Forms.CheckBox();
            this.chkSalesID = new System.Windows.Forms.CheckBox();
            this.groupBoxColumnSelect = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesLeads)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelSelectColumns.SuspendLayout();
            this.groupBoxColumnSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSalesLeads
            // 
            this.dataGridViewSalesLeads.AllowUserToAddRows = false;
            this.dataGridViewSalesLeads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSalesLeads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalesLeads.Location = new System.Drawing.Point(12, 136);
            this.dataGridViewSalesLeads.MultiSelect = false;
            this.dataGridViewSalesLeads.Name = "dataGridViewSalesLeads";
            this.dataGridViewSalesLeads.ReadOnly = true;
            this.dataGridViewSalesLeads.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSalesLeads.Size = new System.Drawing.Size(645, 246);
            this.dataGridViewSalesLeads.TabIndex = 0;
            this.dataGridViewSalesLeads.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSalesLeads_CellDoubleClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(191, 49);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(111, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(155, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkShowUnclosed);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 118);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // chkShowUnclosed
            // 
            this.chkShowUnclosed.AutoSize = true;
            this.chkShowUnclosed.Location = new System.Drawing.Point(9, 49);
            this.chkShowUnclosed.Name = "chkShowUnclosed";
            this.chkShowUnclosed.Size = new System.Drawing.Size(125, 17);
            this.chkShowUnclosed.TabIndex = 4;
            this.chkShowUnclosed.Text = "Show Unclosed Only";
            this.chkShowUnclosed.UseVisualStyleBackColor = true;
            this.chkShowUnclosed.CheckedChanged += new System.EventHandler(this.chkShowUnclosed_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search SalesLeads";
            // 
            // panelSelectColumns
            // 
            this.panelSelectColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSelectColumns.AutoScroll = true;
            this.panelSelectColumns.Controls.Add(this.chkCustomerShortName);
            this.panelSelectColumns.Controls.Add(this.chkAccManager);
            this.panelSelectColumns.Controls.Add(this.chkNotes);
            this.panelSelectColumns.Controls.Add(this.chkDiscount);
            this.panelSelectColumns.Controls.Add(this.chkCoustomerFeedBack);
            this.panelSelectColumns.Controls.Add(this.chkDisconnectReason);
            this.panelSelectColumns.Controls.Add(this.chkDisconnectedDate);
            this.panelSelectColumns.Controls.Add(this.chkClosedDate);
            this.panelSelectColumns.Controls.Add(this.chkBillIssueDate);
            this.panelSelectColumns.Controls.Add(this.chkFirstBillIssued);
            this.panelSelectColumns.Controls.Add(this.chkCustomerConfirmDate);
            this.panelSelectColumns.Controls.Add(this.chkProjectRevenue);
            this.panelSelectColumns.Controls.Add(this.chkHadTest);
            this.panelSelectColumns.Controls.Add(this.chkRevenueType);
            this.panelSelectColumns.Controls.Add(this.chkProductName);
            this.panelSelectColumns.Controls.Add(this.chkCustomerID);
            this.panelSelectColumns.Controls.Add(this.chkCloseReason);
            this.panelSelectColumns.Controls.Add(this.chkDSP);
            this.panelSelectColumns.Controls.Add(this.chkAgreementSignDate);
            this.panelSelectColumns.Controls.Add(this.chkProjectPaid);
            this.panelSelectColumns.Controls.Add(this.chkMonthlyRevenue);
            this.panelSelectColumns.Controls.Add(this.chkIssueDate);
            this.panelSelectColumns.Controls.Add(this.chkProductID);
            this.panelSelectColumns.Controls.Add(this.chkCustomerName);
            this.panelSelectColumns.Controls.Add(this.chkSalesID);
            this.panelSelectColumns.Location = new System.Drawing.Point(6, 19);
            this.panelSelectColumns.Name = "panelSelectColumns";
            this.panelSelectColumns.Size = new System.Drawing.Size(288, 93);
            this.panelSelectColumns.TabIndex = 5;
            // 
            // chkCustomerShortName
            // 
            this.chkCustomerShortName.AutoSize = true;
            this.chkCustomerShortName.Checked = true;
            this.chkCustomerShortName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCustomerShortName.Location = new System.Drawing.Point(13, 58);
            this.chkCustomerShortName.Name = "chkCustomerShortName";
            this.chkCustomerShortName.Size = new System.Drawing.Size(123, 17);
            this.chkCustomerShortName.TabIndex = 24;
            this.chkCustomerShortName.Text = "CustomerShortName";
            this.chkCustomerShortName.UseVisualStyleBackColor = true;
            this.chkCustomerShortName.CheckedChanged += new System.EventHandler(this.chkCustomerShortName_CheckedChanged);
            // 
            // chkAccManager
            // 
            this.chkAccManager.AutoSize = true;
            this.chkAccManager.Checked = true;
            this.chkAccManager.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAccManager.Location = new System.Drawing.Point(13, 415);
            this.chkAccManager.Name = "chkAccManager";
            this.chkAccManager.Size = new System.Drawing.Size(87, 17);
            this.chkAccManager.TabIndex = 23;
            this.chkAccManager.Text = "AccManager";
            this.chkAccManager.UseVisualStyleBackColor = true;
            this.chkAccManager.CheckedChanged += new System.EventHandler(this.chkAccManager_CheckedChanged);
            // 
            // chkNotes
            // 
            this.chkNotes.AutoSize = true;
            this.chkNotes.Checked = true;
            this.chkNotes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNotes.Location = new System.Drawing.Point(13, 398);
            this.chkNotes.Name = "chkNotes";
            this.chkNotes.Size = new System.Drawing.Size(54, 17);
            this.chkNotes.TabIndex = 22;
            this.chkNotes.Text = "Notes";
            this.chkNotes.UseVisualStyleBackColor = true;
            this.chkNotes.CheckedChanged += new System.EventHandler(this.chkNotes_CheckedChanged);
            // 
            // chkDiscount
            // 
            this.chkDiscount.AutoSize = true;
            this.chkDiscount.Checked = true;
            this.chkDiscount.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDiscount.Location = new System.Drawing.Point(13, 381);
            this.chkDiscount.Name = "chkDiscount";
            this.chkDiscount.Size = new System.Drawing.Size(68, 17);
            this.chkDiscount.TabIndex = 21;
            this.chkDiscount.Text = "Discount";
            this.chkDiscount.UseVisualStyleBackColor = true;
            this.chkDiscount.CheckedChanged += new System.EventHandler(this.chkDiscount_CheckedChanged);
            // 
            // chkCoustomerFeedBack
            // 
            this.chkCoustomerFeedBack.AutoSize = true;
            this.chkCoustomerFeedBack.Checked = true;
            this.chkCoustomerFeedBack.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCoustomerFeedBack.Location = new System.Drawing.Point(13, 364);
            this.chkCoustomerFeedBack.Name = "chkCoustomerFeedBack";
            this.chkCoustomerFeedBack.Size = new System.Drawing.Size(125, 17);
            this.chkCoustomerFeedBack.TabIndex = 20;
            this.chkCoustomerFeedBack.Text = "CoustomerFeedBack";
            this.chkCoustomerFeedBack.UseVisualStyleBackColor = true;
            this.chkCoustomerFeedBack.CheckedChanged += new System.EventHandler(this.chkCoustomerFeedBack_CheckedChanged);
            // 
            // chkDisconnectReason
            // 
            this.chkDisconnectReason.AutoSize = true;
            this.chkDisconnectReason.Checked = true;
            this.chkDisconnectReason.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDisconnectReason.Location = new System.Drawing.Point(13, 347);
            this.chkDisconnectReason.Name = "chkDisconnectReason";
            this.chkDisconnectReason.Size = new System.Drawing.Size(117, 17);
            this.chkDisconnectReason.TabIndex = 19;
            this.chkDisconnectReason.Text = "DisconnectReason";
            this.chkDisconnectReason.UseVisualStyleBackColor = true;
            this.chkDisconnectReason.CheckedChanged += new System.EventHandler(this.chkDisconnectReason_CheckedChanged);
            // 
            // chkDisconnectedDate
            // 
            this.chkDisconnectedDate.AutoSize = true;
            this.chkDisconnectedDate.Checked = true;
            this.chkDisconnectedDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDisconnectedDate.Location = new System.Drawing.Point(13, 330);
            this.chkDisconnectedDate.Name = "chkDisconnectedDate";
            this.chkDisconnectedDate.Size = new System.Drawing.Size(115, 17);
            this.chkDisconnectedDate.TabIndex = 18;
            this.chkDisconnectedDate.Text = "DisconnectedDate";
            this.chkDisconnectedDate.UseVisualStyleBackColor = true;
            this.chkDisconnectedDate.CheckedChanged += new System.EventHandler(this.chkDisconnectedDate_CheckedChanged);
            // 
            // chkClosedDate
            // 
            this.chkClosedDate.AutoSize = true;
            this.chkClosedDate.Checked = true;
            this.chkClosedDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkClosedDate.Location = new System.Drawing.Point(13, 313);
            this.chkClosedDate.Name = "chkClosedDate";
            this.chkClosedDate.Size = new System.Drawing.Size(81, 17);
            this.chkClosedDate.TabIndex = 17;
            this.chkClosedDate.Text = "ClosedDate";
            this.chkClosedDate.UseVisualStyleBackColor = true;
            this.chkClosedDate.CheckedChanged += new System.EventHandler(this.chkClosedDate_CheckedChanged);
            // 
            // chkBillIssueDate
            // 
            this.chkBillIssueDate.AutoSize = true;
            this.chkBillIssueDate.Checked = true;
            this.chkBillIssueDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBillIssueDate.Location = new System.Drawing.Point(13, 279);
            this.chkBillIssueDate.Name = "chkBillIssueDate";
            this.chkBillIssueDate.Size = new System.Drawing.Size(87, 17);
            this.chkBillIssueDate.TabIndex = 16;
            this.chkBillIssueDate.Text = "BillIssueDate";
            this.chkBillIssueDate.UseVisualStyleBackColor = true;
            this.chkBillIssueDate.CheckedChanged += new System.EventHandler(this.chkBillIssueDate_CheckedChanged);
            // 
            // chkFirstBillIssued
            // 
            this.chkFirstBillIssued.AutoSize = true;
            this.chkFirstBillIssued.Checked = true;
            this.chkFirstBillIssued.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFirstBillIssued.Location = new System.Drawing.Point(13, 262);
            this.chkFirstBillIssued.Name = "chkFirstBillIssued";
            this.chkFirstBillIssued.Size = new System.Drawing.Size(89, 17);
            this.chkFirstBillIssued.TabIndex = 15;
            this.chkFirstBillIssued.Text = "FirstBillIssued";
            this.chkFirstBillIssued.UseVisualStyleBackColor = true;
            this.chkFirstBillIssued.CheckedChanged += new System.EventHandler(this.chkFirstBillIssued_CheckedChanged);
            // 
            // chkCustomerConfirmDate
            // 
            this.chkCustomerConfirmDate.AutoSize = true;
            this.chkCustomerConfirmDate.Checked = true;
            this.chkCustomerConfirmDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCustomerConfirmDate.Location = new System.Drawing.Point(13, 211);
            this.chkCustomerConfirmDate.Name = "chkCustomerConfirmDate";
            this.chkCustomerConfirmDate.Size = new System.Drawing.Size(128, 17);
            this.chkCustomerConfirmDate.TabIndex = 14;
            this.chkCustomerConfirmDate.Text = "CustomerConfirmDate";
            this.chkCustomerConfirmDate.UseVisualStyleBackColor = true;
            this.chkCustomerConfirmDate.CheckedChanged += new System.EventHandler(this.chkCustomerConfirmDate_CheckedChanged);
            // 
            // chkProjectRevenue
            // 
            this.chkProjectRevenue.AutoSize = true;
            this.chkProjectRevenue.Checked = true;
            this.chkProjectRevenue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkProjectRevenue.Location = new System.Drawing.Point(13, 177);
            this.chkProjectRevenue.Name = "chkProjectRevenue";
            this.chkProjectRevenue.Size = new System.Drawing.Size(103, 17);
            this.chkProjectRevenue.TabIndex = 13;
            this.chkProjectRevenue.Text = "ProjectRevenue";
            this.chkProjectRevenue.UseVisualStyleBackColor = true;
            this.chkProjectRevenue.CheckedChanged += new System.EventHandler(this.chkProjectRevenue_CheckedChanged);
            // 
            // chkHadTest
            // 
            this.chkHadTest.AutoSize = true;
            this.chkHadTest.Checked = true;
            this.chkHadTest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHadTest.Location = new System.Drawing.Point(13, 160);
            this.chkHadTest.Name = "chkHadTest";
            this.chkHadTest.Size = new System.Drawing.Size(67, 17);
            this.chkHadTest.TabIndex = 12;
            this.chkHadTest.Text = "HadTest";
            this.chkHadTest.UseVisualStyleBackColor = true;
            this.chkHadTest.CheckedChanged += new System.EventHandler(this.chkHadTest_CheckedChanged);
            // 
            // chkRevenueType
            // 
            this.chkRevenueType.AutoSize = true;
            this.chkRevenueType.Checked = true;
            this.chkRevenueType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRevenueType.Location = new System.Drawing.Point(13, 126);
            this.chkRevenueType.Name = "chkRevenueType";
            this.chkRevenueType.Size = new System.Drawing.Size(94, 17);
            this.chkRevenueType.TabIndex = 11;
            this.chkRevenueType.Text = "RevenueType";
            this.chkRevenueType.UseVisualStyleBackColor = true;
            this.chkRevenueType.CheckedChanged += new System.EventHandler(this.chkRevenueType_CheckedChanged);
            // 
            // chkProductName
            // 
            this.chkProductName.AutoSize = true;
            this.chkProductName.Checked = true;
            this.chkProductName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkProductName.Location = new System.Drawing.Point(13, 92);
            this.chkProductName.Name = "chkProductName";
            this.chkProductName.Size = new System.Drawing.Size(91, 17);
            this.chkProductName.TabIndex = 10;
            this.chkProductName.Text = "ProductName";
            this.chkProductName.UseVisualStyleBackColor = true;
            this.chkProductName.CheckedChanged += new System.EventHandler(this.chkProductName_CheckedChanged);
            // 
            // chkCustomerID
            // 
            this.chkCustomerID.AutoSize = true;
            this.chkCustomerID.Checked = true;
            this.chkCustomerID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCustomerID.Location = new System.Drawing.Point(13, 24);
            this.chkCustomerID.Name = "chkCustomerID";
            this.chkCustomerID.Size = new System.Drawing.Size(81, 17);
            this.chkCustomerID.TabIndex = 9;
            this.chkCustomerID.Text = "CustomerID";
            this.chkCustomerID.UseVisualStyleBackColor = true;
            this.chkCustomerID.CheckedChanged += new System.EventHandler(this.chkCustomerID_CheckedChanged);
            // 
            // chkCloseReason
            // 
            this.chkCloseReason.AutoSize = true;
            this.chkCloseReason.Checked = true;
            this.chkCloseReason.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCloseReason.Location = new System.Drawing.Point(13, 296);
            this.chkCloseReason.Name = "chkCloseReason";
            this.chkCloseReason.Size = new System.Drawing.Size(89, 17);
            this.chkCloseReason.TabIndex = 8;
            this.chkCloseReason.Text = "CloseReason";
            this.chkCloseReason.UseVisualStyleBackColor = true;
            this.chkCloseReason.CheckedChanged += new System.EventHandler(this.chkCloseReason_CheckedChanged);
            // 
            // chkDSP
            // 
            this.chkDSP.AutoSize = true;
            this.chkDSP.Checked = true;
            this.chkDSP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDSP.Location = new System.Drawing.Point(13, 245);
            this.chkDSP.Name = "chkDSP";
            this.chkDSP.Size = new System.Drawing.Size(48, 17);
            this.chkDSP.TabIndex = 7;
            this.chkDSP.Text = "DSP";
            this.chkDSP.UseVisualStyleBackColor = true;
            this.chkDSP.CheckedChanged += new System.EventHandler(this.chkDSP_CheckedChanged);
            // 
            // chkAgreementSignDate
            // 
            this.chkAgreementSignDate.AutoSize = true;
            this.chkAgreementSignDate.Checked = true;
            this.chkAgreementSignDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAgreementSignDate.Location = new System.Drawing.Point(13, 228);
            this.chkAgreementSignDate.Name = "chkAgreementSignDate";
            this.chkAgreementSignDate.Size = new System.Drawing.Size(121, 17);
            this.chkAgreementSignDate.TabIndex = 6;
            this.chkAgreementSignDate.Text = "AgreementSignDate";
            this.chkAgreementSignDate.UseVisualStyleBackColor = true;
            this.chkAgreementSignDate.CheckedChanged += new System.EventHandler(this.chkAgreementSignDate_CheckedChanged);
            // 
            // chkProjectPaid
            // 
            this.chkProjectPaid.AutoSize = true;
            this.chkProjectPaid.Checked = true;
            this.chkProjectPaid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkProjectPaid.Location = new System.Drawing.Point(13, 194);
            this.chkProjectPaid.Name = "chkProjectPaid";
            this.chkProjectPaid.Size = new System.Drawing.Size(80, 17);
            this.chkProjectPaid.TabIndex = 5;
            this.chkProjectPaid.Text = "ProjectPaid";
            this.chkProjectPaid.UseVisualStyleBackColor = true;
            this.chkProjectPaid.CheckedChanged += new System.EventHandler(this.chkProjectPaid_CheckedChanged);
            // 
            // chkMonthlyRevenue
            // 
            this.chkMonthlyRevenue.AutoSize = true;
            this.chkMonthlyRevenue.Checked = true;
            this.chkMonthlyRevenue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMonthlyRevenue.Location = new System.Drawing.Point(13, 143);
            this.chkMonthlyRevenue.Name = "chkMonthlyRevenue";
            this.chkMonthlyRevenue.Size = new System.Drawing.Size(107, 17);
            this.chkMonthlyRevenue.TabIndex = 4;
            this.chkMonthlyRevenue.Text = "MonthlyRevenue";
            this.chkMonthlyRevenue.UseVisualStyleBackColor = true;
            this.chkMonthlyRevenue.CheckedChanged += new System.EventHandler(this.chkMonthlyRevenue_CheckedChanged);
            // 
            // chkIssueDate
            // 
            this.chkIssueDate.AutoSize = true;
            this.chkIssueDate.Checked = true;
            this.chkIssueDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIssueDate.Location = new System.Drawing.Point(13, 109);
            this.chkIssueDate.Name = "chkIssueDate";
            this.chkIssueDate.Size = new System.Drawing.Size(74, 17);
            this.chkIssueDate.TabIndex = 3;
            this.chkIssueDate.Text = "IssueDate";
            this.chkIssueDate.UseVisualStyleBackColor = true;
            this.chkIssueDate.CheckedChanged += new System.EventHandler(this.chkIssueDate_CheckedChanged);
            // 
            // chkProductID
            // 
            this.chkProductID.AutoSize = true;
            this.chkProductID.Checked = true;
            this.chkProductID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkProductID.Location = new System.Drawing.Point(13, 75);
            this.chkProductID.Name = "chkProductID";
            this.chkProductID.Size = new System.Drawing.Size(74, 17);
            this.chkProductID.TabIndex = 2;
            this.chkProductID.Text = "ProductID";
            this.chkProductID.UseVisualStyleBackColor = true;
            this.chkProductID.CheckedChanged += new System.EventHandler(this.chkProductID_CheckedChanged);
            // 
            // chkCustomerName
            // 
            this.chkCustomerName.AutoSize = true;
            this.chkCustomerName.Checked = true;
            this.chkCustomerName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCustomerName.Location = new System.Drawing.Point(13, 41);
            this.chkCustomerName.Name = "chkCustomerName";
            this.chkCustomerName.Size = new System.Drawing.Size(98, 17);
            this.chkCustomerName.TabIndex = 1;
            this.chkCustomerName.Text = "CustomerName";
            this.chkCustomerName.UseVisualStyleBackColor = true;
            this.chkCustomerName.CheckedChanged += new System.EventHandler(this.chkCustomerName_CheckedChanged);
            // 
            // chkSalesID
            // 
            this.chkSalesID.AutoSize = true;
            this.chkSalesID.Checked = true;
            this.chkSalesID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSalesID.Location = new System.Drawing.Point(13, 7);
            this.chkSalesID.Name = "chkSalesID";
            this.chkSalesID.Size = new System.Drawing.Size(63, 17);
            this.chkSalesID.TabIndex = 0;
            this.chkSalesID.Text = "SalesID";
            this.chkSalesID.UseVisualStyleBackColor = true;
            this.chkSalesID.CheckedChanged += new System.EventHandler(this.chkSalesID_CheckedChanged);
            // 
            // groupBoxColumnSelect
            // 
            this.groupBoxColumnSelect.Controls.Add(this.panelSelectColumns);
            this.groupBoxColumnSelect.Location = new System.Drawing.Point(357, 12);
            this.groupBoxColumnSelect.Name = "groupBoxColumnSelect";
            this.groupBoxColumnSelect.Size = new System.Drawing.Size(300, 118);
            this.groupBoxColumnSelect.TabIndex = 6;
            this.groupBoxColumnSelect.TabStop = false;
            this.groupBoxColumnSelect.Text = "Select Columns";
            // 
            // frmViewSalesLeads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 394);
            this.Controls.Add(this.groupBoxColumnSelect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewSalesLeads);
            this.Name = "frmViewSalesLeads";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmViewSalesLeads";
            this.Load += new System.EventHandler(this.frmViewSalesLeads_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesLeads)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelSelectColumns.ResumeLayout(false);
            this.panelSelectColumns.PerformLayout();
            this.groupBoxColumnSelect.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSalesLeads;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkShowUnclosed;
        private System.Windows.Forms.Panel panelSelectColumns;
        private System.Windows.Forms.GroupBox groupBoxColumnSelect;
        private System.Windows.Forms.CheckBox chkAccManager;
        private System.Windows.Forms.CheckBox chkNotes;
        private System.Windows.Forms.CheckBox chkDiscount;
        private System.Windows.Forms.CheckBox chkCoustomerFeedBack;
        private System.Windows.Forms.CheckBox chkDisconnectReason;
        private System.Windows.Forms.CheckBox chkDisconnectedDate;
        private System.Windows.Forms.CheckBox chkClosedDate;
        private System.Windows.Forms.CheckBox chkBillIssueDate;
        private System.Windows.Forms.CheckBox chkFirstBillIssued;
        private System.Windows.Forms.CheckBox chkCustomerConfirmDate;
        private System.Windows.Forms.CheckBox chkProjectRevenue;
        private System.Windows.Forms.CheckBox chkHadTest;
        private System.Windows.Forms.CheckBox chkRevenueType;
        private System.Windows.Forms.CheckBox chkProductName;
        private System.Windows.Forms.CheckBox chkCustomerID;
        private System.Windows.Forms.CheckBox chkCloseReason;
        private System.Windows.Forms.CheckBox chkDSP;
        private System.Windows.Forms.CheckBox chkAgreementSignDate;
        private System.Windows.Forms.CheckBox chkProjectPaid;
        private System.Windows.Forms.CheckBox chkMonthlyRevenue;
        private System.Windows.Forms.CheckBox chkIssueDate;
        private System.Windows.Forms.CheckBox chkProductID;
        private System.Windows.Forms.CheckBox chkCustomerName;
        private System.Windows.Forms.CheckBox chkSalesID;
        private System.Windows.Forms.CheckBox chkCustomerShortName;
    }
}