namespace SalesLeadsManagementSystem.Sales.Quotation
{
    partial class frmQuotation
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
            this.dateTimePickerQuotationDate = new System.Windows.Forms.DateTimePicker();
            this.txtQuotationStatus = new System.Windows.Forms.TextBox();
            this.dataGridViewQuotations = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.openFileDialogQuotation = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.chkAddMode = new System.Windows.Forms.CheckBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblQPath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuotations)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerQuotationDate
            // 
            this.dateTimePickerQuotationDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerQuotationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerQuotationDate.Location = new System.Drawing.Point(100, 48);
            this.dateTimePickerQuotationDate.Name = "dateTimePickerQuotationDate";
            this.dateTimePickerQuotationDate.Size = new System.Drawing.Size(137, 20);
            this.dateTimePickerQuotationDate.TabIndex = 0;
            // 
            // txtQuotationStatus
            // 
            this.txtQuotationStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuotationStatus.Location = new System.Drawing.Point(12, 108);
            this.txtQuotationStatus.Multiline = true;
            this.txtQuotationStatus.Name = "txtQuotationStatus";
            this.txtQuotationStatus.Size = new System.Drawing.Size(646, 69);
            this.txtQuotationStatus.TabIndex = 1;
            // 
            // dataGridViewQuotations
            // 
            this.dataGridViewQuotations.AllowUserToAddRows = false;
            this.dataGridViewQuotations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewQuotations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuotations.Location = new System.Drawing.Point(12, 183);
            this.dataGridViewQuotations.MultiSelect = false;
            this.dataGridViewQuotations.Name = "dataGridViewQuotations";
            this.dataGridViewQuotations.ReadOnly = true;
            this.dataGridViewQuotations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQuotations.Size = new System.Drawing.Size(646, 167);
            this.dataGridViewQuotations.TabIndex = 2;
            this.dataGridViewQuotations.SelectionChanged += new System.EventHandler(this.dataGridViewQuotations_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quotation Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(511, 79);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "&Update";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(430, 79);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "&View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // openFileDialogQuotation
            // 
            this.openFileDialogQuotation.Filter = "PDF Files|*.pdf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quotation Data ??";
            // 
            // chkAddMode
            // 
            this.chkAddMode.AutoSize = true;
            this.chkAddMode.Location = new System.Drawing.Point(505, 32);
            this.chkAddMode.Name = "chkAddMode";
            this.chkAddMode.Size = new System.Drawing.Size(75, 17);
            this.chkAddMode.TabIndex = 8;
            this.chkAddMode.Text = "&Add Mode";
            this.chkAddMode.UseVisualStyleBackColor = true;
            this.chkAddMode.CheckedChanged += new System.EventHandler(this.chkAddMode_CheckedChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(409, 8);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "&Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblQPath
            // 
            this.lblQPath.AutoSize = true;
            this.lblQPath.Location = new System.Drawing.Point(17, 33);
            this.lblQPath.Name = "lblQPath";
            this.lblQPath.Size = new System.Drawing.Size(0, 13);
            this.lblQPath.TabIndex = 10;
            // 
            // frmQuotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 362);
            this.Controls.Add(this.lblQPath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.chkAddMode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewQuotations);
            this.Controls.Add(this.txtQuotationStatus);
            this.Controls.Add(this.dateTimePickerQuotationDate);
            this.Name = "frmQuotation";
            this.Text = "frmQuotation";
            this.Load += new System.EventHandler(this.frmQuotation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuotations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerQuotationDate;
        private System.Windows.Forms.TextBox txtQuotationStatus;
        private System.Windows.Forms.DataGridView dataGridViewQuotations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.OpenFileDialog openFileDialogQuotation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkAddMode;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblQPath;
    }
}