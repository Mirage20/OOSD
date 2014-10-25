namespace SalesLeadsManagementSystem.Sales
{
    partial class frmAddUpdateSalesLead
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.btnPickCustomer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPickProduct = new System.Windows.Forms.Button();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.dateTimePickerIssueDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCustomerConfirm = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAgreementSign = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDSP = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBillIssue = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerClosed = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDiscon = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxDates = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbFirstBill = new System.Windows.Forms.ComboBox();
            this.groupBoxFiles = new System.Windows.Forms.GroupBox();
            this.btnPurchaseFileAdd = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnQutationFilesView = new System.Windows.Forms.Button();
            this.btnPurchaseFileView = new System.Windows.Forms.Button();
            this.txtDisconReason = new System.Windows.Forms.TextBox();
            this.txtCloseReason = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbRevType = new System.Windows.Forms.ComboBox();
            this.txtMonthlyRev = new System.Windows.Forms.TextBox();
            this.cmbHadTest = new System.Windows.Forms.ComboBox();
            this.txtProjectPaid = new System.Windows.Forms.TextBox();
            this.txtProjectRev = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.groupBoxExtraDetails = new System.Windows.Forms.GroupBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCustomerFeedback = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxDates.SuspendLayout();
            this.groupBoxFiles.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            this.groupBoxExtraDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(100, 27);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(72, 20);
            this.txtCustomerID.TabIndex = 0;
            // 
            // btnPickCustomer
            // 
            this.btnPickCustomer.Location = new System.Drawing.Point(178, 25);
            this.btnPickCustomer.Name = "btnPickCustomer";
            this.btnPickCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnPickCustomer.TabIndex = 24;
            this.btnPickCustomer.Text = "Select";
            this.btnPickCustomer.UseVisualStyleBackColor = true;
            this.btnPickCustomer.Click += new System.EventHandler(this.btnPickCustomer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product ID";
            // 
            // btnPickProduct
            // 
            this.btnPickProduct.Location = new System.Drawing.Point(178, 51);
            this.btnPickProduct.Name = "btnPickProduct";
            this.btnPickProduct.Size = new System.Drawing.Size(75, 23);
            this.btnPickProduct.TabIndex = 25;
            this.btnPickProduct.Text = "Select";
            this.btnPickProduct.UseVisualStyleBackColor = true;
            this.btnPickProduct.Click += new System.EventHandler(this.btnPickProduct_Click);
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(100, 53);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(72, 20);
            this.txtProductID.TabIndex = 1;
            // 
            // dateTimePickerIssueDate
            // 
            this.dateTimePickerIssueDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerIssueDate.Location = new System.Drawing.Point(100, 212);
            this.dateTimePickerIssueDate.Name = "dateTimePickerIssueDate";
            this.dateTimePickerIssueDate.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerIssueDate.TabIndex = 7;
            // 
            // dateTimePickerCustomerConfirm
            // 
            this.dateTimePickerCustomerConfirm.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerCustomerConfirm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerCustomerConfirm.Location = new System.Drawing.Point(156, 25);
            this.dateTimePickerCustomerConfirm.Name = "dateTimePickerCustomerConfirm";
            this.dateTimePickerCustomerConfirm.ShowCheckBox = true;
            this.dateTimePickerCustomerConfirm.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerCustomerConfirm.TabIndex = 8;
            this.dateTimePickerCustomerConfirm.ValueChanged += new System.EventHandler(this.dateTimePickerCustomerConfirm_ValueChanged);
            // 
            // dateTimePickerAgreementSign
            // 
            this.dateTimePickerAgreementSign.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerAgreementSign.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAgreementSign.Location = new System.Drawing.Point(156, 51);
            this.dateTimePickerAgreementSign.Name = "dateTimePickerAgreementSign";
            this.dateTimePickerAgreementSign.ShowCheckBox = true;
            this.dateTimePickerAgreementSign.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerAgreementSign.TabIndex = 9;
            this.dateTimePickerAgreementSign.ValueChanged += new System.EventHandler(this.dateTimePickerAgreementSign_ValueChanged);
            // 
            // dateTimePickerDSP
            // 
            this.dateTimePickerDSP.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerDSP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDSP.Location = new System.Drawing.Point(156, 79);
            this.dateTimePickerDSP.Name = "dateTimePickerDSP";
            this.dateTimePickerDSP.ShowCheckBox = true;
            this.dateTimePickerDSP.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerDSP.TabIndex = 10;
            this.dateTimePickerDSP.ValueChanged += new System.EventHandler(this.dateTimePickerDSP_ValueChanged);
            // 
            // dateTimePickerBillIssue
            // 
            this.dateTimePickerBillIssue.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerBillIssue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBillIssue.Location = new System.Drawing.Point(156, 107);
            this.dateTimePickerBillIssue.Name = "dateTimePickerBillIssue";
            this.dateTimePickerBillIssue.ShowCheckBox = true;
            this.dateTimePickerBillIssue.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerBillIssue.TabIndex = 11;
            this.dateTimePickerBillIssue.ValueChanged += new System.EventHandler(this.dateTimePickerBillIssue_ValueChanged);
            // 
            // dateTimePickerClosed
            // 
            this.dateTimePickerClosed.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerClosed.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerClosed.Location = new System.Drawing.Point(156, 135);
            this.dateTimePickerClosed.Name = "dateTimePickerClosed";
            this.dateTimePickerClosed.ShowCheckBox = true;
            this.dateTimePickerClosed.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerClosed.TabIndex = 13;
            this.dateTimePickerClosed.ValueChanged += new System.EventHandler(this.dateTimePickerClosed_ValueChanged);
            // 
            // dateTimePickerDiscon
            // 
            this.dateTimePickerDiscon.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerDiscon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDiscon.Location = new System.Drawing.Point(156, 163);
            this.dateTimePickerDiscon.Name = "dateTimePickerDiscon";
            this.dateTimePickerDiscon.ShowCheckBox = true;
            this.dateTimePickerDiscon.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerDiscon.TabIndex = 15;
            this.dateTimePickerDiscon.ValueChanged += new System.EventHandler(this.dateTimePickerDiscon_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Issue Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "CustomerConfirmDate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "AgreementSignDate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Date of Service Provisioning";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Bill Issue Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Closed Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Disconnected Date";
            // 
            // groupBoxDates
            // 
            this.groupBoxDates.Controls.Add(this.label22);
            this.groupBoxDates.Controls.Add(this.cmbFirstBill);
            this.groupBoxDates.Controls.Add(this.groupBoxFiles);
            this.groupBoxDates.Controls.Add(this.txtDisconReason);
            this.groupBoxDates.Controls.Add(this.txtCloseReason);
            this.groupBoxDates.Controls.Add(this.label21);
            this.groupBoxDates.Controls.Add(this.label20);
            this.groupBoxDates.Controls.Add(this.dateTimePickerAgreementSign);
            this.groupBoxDates.Controls.Add(this.label9);
            this.groupBoxDates.Controls.Add(this.label8);
            this.groupBoxDates.Controls.Add(this.dateTimePickerCustomerConfirm);
            this.groupBoxDates.Controls.Add(this.label7);
            this.groupBoxDates.Controls.Add(this.dateTimePickerDSP);
            this.groupBoxDates.Controls.Add(this.label6);
            this.groupBoxDates.Controls.Add(this.dateTimePickerBillIssue);
            this.groupBoxDates.Controls.Add(this.label5);
            this.groupBoxDates.Controls.Add(this.dateTimePickerClosed);
            this.groupBoxDates.Controls.Add(this.label4);
            this.groupBoxDates.Controls.Add(this.dateTimePickerDiscon);
            this.groupBoxDates.Location = new System.Drawing.Point(12, 260);
            this.groupBoxDates.Name = "groupBoxDates";
            this.groupBoxDates.Size = new System.Drawing.Size(517, 195);
            this.groupBoxDates.TabIndex = 8;
            this.groupBoxDates.TabStop = false;
            this.groupBoxDates.Text = "Status";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(300, 111);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(76, 13);
            this.label22.TabIndex = 34;
            this.label22.Text = "First Bill Issued";
            // 
            // cmbFirstBill
            // 
            this.cmbFirstBill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFirstBill.FormattingEnabled = true;
            this.cmbFirstBill.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cmbFirstBill.Location = new System.Drawing.Point(411, 110);
            this.cmbFirstBill.Name = "cmbFirstBill";
            this.cmbFirstBill.Size = new System.Drawing.Size(100, 21);
            this.cmbFirstBill.TabIndex = 12;
            // 
            // groupBoxFiles
            // 
            this.groupBoxFiles.Controls.Add(this.btnPurchaseFileAdd);
            this.groupBoxFiles.Controls.Add(this.label19);
            this.groupBoxFiles.Controls.Add(this.label18);
            this.groupBoxFiles.Controls.Add(this.btnQutationFilesView);
            this.groupBoxFiles.Controls.Add(this.btnPurchaseFileView);
            this.groupBoxFiles.Location = new System.Drawing.Point(303, 18);
            this.groupBoxFiles.Name = "groupBoxFiles";
            this.groupBoxFiles.Size = new System.Drawing.Size(208, 86);
            this.groupBoxFiles.TabIndex = 3;
            this.groupBoxFiles.TabStop = false;
            this.groupBoxFiles.Text = "Files";
            // 
            // btnPurchaseFileAdd
            // 
            this.btnPurchaseFileAdd.Location = new System.Drawing.Point(148, 23);
            this.btnPurchaseFileAdd.Name = "btnPurchaseFileAdd";
            this.btnPurchaseFileAdd.Size = new System.Drawing.Size(54, 23);
            this.btnPurchaseFileAdd.TabIndex = 24;
            this.btnPurchaseFileAdd.Text = "Change";
            this.btnPurchaseFileAdd.UseVisualStyleBackColor = true;
            this.btnPurchaseFileAdd.Click += new System.EventHandler(this.btnPurchaseFileAdd_Click);
            this.btnPurchaseFileAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPurchaseFileAdd_MouseDown);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 57);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 3;
            this.label19.Text = "Quatations";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Purchase Order";
            // 
            // btnQutationFilesView
            // 
            this.btnQutationFilesView.Location = new System.Drawing.Point(93, 52);
            this.btnQutationFilesView.Name = "btnQutationFilesView";
            this.btnQutationFilesView.Size = new System.Drawing.Size(109, 23);
            this.btnQutationFilesView.TabIndex = 23;
            this.btnQutationFilesView.Text = "View";
            this.btnQutationFilesView.UseVisualStyleBackColor = true;
            this.btnQutationFilesView.Click += new System.EventHandler(this.btnQutationFilesView_Click);
            // 
            // btnPurchaseFileView
            // 
            this.btnPurchaseFileView.Location = new System.Drawing.Point(93, 23);
            this.btnPurchaseFileView.Name = "btnPurchaseFileView";
            this.btnPurchaseFileView.Size = new System.Drawing.Size(54, 23);
            this.btnPurchaseFileView.TabIndex = 22;
            this.btnPurchaseFileView.Text = "View";
            this.btnPurchaseFileView.UseVisualStyleBackColor = true;
            this.btnPurchaseFileView.Click += new System.EventHandler(this.btnPurchaseFileView_Click);
            // 
            // txtDisconReason
            // 
            this.txtDisconReason.Location = new System.Drawing.Point(411, 162);
            this.txtDisconReason.Name = "txtDisconReason";
            this.txtDisconReason.Size = new System.Drawing.Size(100, 20);
            this.txtDisconReason.TabIndex = 16;
            // 
            // txtCloseReason
            // 
            this.txtCloseReason.Location = new System.Drawing.Point(411, 136);
            this.txtCloseReason.Name = "txtCloseReason";
            this.txtCloseReason.Size = new System.Drawing.Size(100, 20);
            this.txtCloseReason.TabIndex = 14;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(300, 165);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(101, 13);
            this.label21.TabIndex = 30;
            this.label21.Text = "Disconnect Reason";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(300, 138);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 13);
            this.label20.TabIndex = 29;
            this.label20.Text = "Close Reason";
            // 
            // cmbRevType
            // 
            this.cmbRevType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRevType.FormattingEnabled = true;
            this.cmbRevType.Items.AddRange(new object[] {
            "Monthly",
            "Project"});
            this.cmbRevType.Location = new System.Drawing.Point(100, 80);
            this.cmbRevType.Name = "cmbRevType";
            this.cmbRevType.Size = new System.Drawing.Size(121, 21);
            this.cmbRevType.TabIndex = 2;
            this.cmbRevType.SelectedIndexChanged += new System.EventHandler(this.cmbRevType_SelectedIndexChanged);
            // 
            // txtMonthlyRev
            // 
            this.txtMonthlyRev.Location = new System.Drawing.Point(100, 107);
            this.txtMonthlyRev.Name = "txtMonthlyRev";
            this.txtMonthlyRev.Size = new System.Drawing.Size(121, 20);
            this.txtMonthlyRev.TabIndex = 3;
            // 
            // cmbHadTest
            // 
            this.cmbHadTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHadTest.FormattingEnabled = true;
            this.cmbHadTest.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cmbHadTest.Location = new System.Drawing.Point(100, 133);
            this.cmbHadTest.Name = "cmbHadTest";
            this.cmbHadTest.Size = new System.Drawing.Size(121, 21);
            this.cmbHadTest.TabIndex = 4;
            // 
            // txtProjectPaid
            // 
            this.txtProjectPaid.Location = new System.Drawing.Point(100, 186);
            this.txtProjectPaid.Name = "txtProjectPaid";
            this.txtProjectPaid.Size = new System.Drawing.Size(121, 20);
            this.txtProjectPaid.TabIndex = 6;
            // 
            // txtProjectRev
            // 
            this.txtProjectRev.Location = new System.Drawing.Point(100, 160);
            this.txtProjectRev.Name = "txtProjectRev";
            this.txtProjectRev.Size = new System.Drawing.Size(121, 20);
            this.txtProjectRev.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Revenue Type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Monthly Revenue";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "HadTest";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Project Revenue";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Project Paid";
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.groupBoxExtraDetails);
            this.groupBoxDetails.Controls.Add(this.label14);
            this.groupBoxDetails.Controls.Add(this.txtCustomerID);
            this.groupBoxDetails.Controls.Add(this.dateTimePickerIssueDate);
            this.groupBoxDetails.Controls.Add(this.txtProjectRev);
            this.groupBoxDetails.Controls.Add(this.label1);
            this.groupBoxDetails.Controls.Add(this.label13);
            this.groupBoxDetails.Controls.Add(this.btnPickCustomer);
            this.groupBoxDetails.Controls.Add(this.txtProjectPaid);
            this.groupBoxDetails.Controls.Add(this.txtProductID);
            this.groupBoxDetails.Controls.Add(this.label12);
            this.groupBoxDetails.Controls.Add(this.label2);
            this.groupBoxDetails.Controls.Add(this.cmbHadTest);
            this.groupBoxDetails.Controls.Add(this.btnPickProduct);
            this.groupBoxDetails.Controls.Add(this.label11);
            this.groupBoxDetails.Controls.Add(this.label3);
            this.groupBoxDetails.Controls.Add(this.cmbRevType);
            this.groupBoxDetails.Controls.Add(this.txtMonthlyRev);
            this.groupBoxDetails.Controls.Add(this.label10);
            this.groupBoxDetails.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(608, 242);
            this.groupBoxDetails.TabIndex = 0;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "SalesLead Details";
            // 
            // groupBoxExtraDetails
            // 
            this.groupBoxExtraDetails.Controls.Add(this.txtDiscount);
            this.groupBoxExtraDetails.Controls.Add(this.label17);
            this.groupBoxExtraDetails.Controls.Add(this.txtNotes);
            this.groupBoxExtraDetails.Controls.Add(this.label16);
            this.groupBoxExtraDetails.Controls.Add(this.txtCustomerFeedback);
            this.groupBoxExtraDetails.Controls.Add(this.label15);
            this.groupBoxExtraDetails.Location = new System.Drawing.Point(259, 25);
            this.groupBoxExtraDetails.Name = "groupBoxExtraDetails";
            this.groupBoxExtraDetails.Size = new System.Drawing.Size(343, 207);
            this.groupBoxExtraDetails.TabIndex = 17;
            this.groupBoxExtraDetails.TabStop = false;
            this.groupBoxExtraDetails.Text = "Extra Details";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(120, 19);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(217, 20);
            this.txtDiscount.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(47, 71);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(290, 130);
            this.txtNotes.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Coustomer Feedback";
            // 
            // txtCustomerFeedback
            // 
            this.txtCustomerFeedback.Location = new System.Drawing.Point(120, 45);
            this.txtCustomerFeedback.Name = "txtCustomerFeedback";
            this.txtCustomerFeedback.Size = new System.Drawing.Size(217, 20);
            this.txtCustomerFeedback.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Discount";
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Location = new System.Drawing.Point(545, 395);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnAddUpdate.TabIndex = 20;
            this.btnAddUpdate.Text = "Add";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(545, 424);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "PDF Files|*.pdf";
            // 
            // frmAddUpdateSalesLead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 464);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.groupBoxDates);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddUpdateSalesLead";
            this.Text = "frmNewSalesLead";
            this.Load += new System.EventHandler(this.frmSalesLead_Load);
            this.groupBoxDates.ResumeLayout(false);
            this.groupBoxDates.PerformLayout();
            this.groupBoxFiles.ResumeLayout(false);
            this.groupBoxFiles.PerformLayout();
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.groupBoxExtraDetails.ResumeLayout(false);
            this.groupBoxExtraDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Button btnPickCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPickProduct;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.DateTimePicker dateTimePickerIssueDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerCustomerConfirm;
        private System.Windows.Forms.DateTimePicker dateTimePickerAgreementSign;
        private System.Windows.Forms.DateTimePicker dateTimePickerDSP;
        private System.Windows.Forms.DateTimePicker dateTimePickerBillIssue;
        private System.Windows.Forms.DateTimePicker dateTimePickerClosed;
        private System.Windows.Forms.DateTimePicker dateTimePickerDiscon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBoxDates;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmbFirstBill;
        private System.Windows.Forms.TextBox txtDisconReason;
        private System.Windows.Forms.TextBox txtCloseReason;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBoxFiles;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnQutationFilesView;
        private System.Windows.Forms.Button btnPurchaseFileView;
        private System.Windows.Forms.ComboBox cmbRevType;
        private System.Windows.Forms.TextBox txtMonthlyRev;
        private System.Windows.Forms.ComboBox cmbHadTest;
        private System.Windows.Forms.TextBox txtProjectPaid;
        private System.Windows.Forms.TextBox txtProjectRev;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtCustomerFeedback;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.GroupBox groupBoxExtraDetails;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnPurchaseFileAdd;
    }
}