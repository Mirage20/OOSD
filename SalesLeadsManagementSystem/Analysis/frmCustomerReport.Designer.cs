namespace SalesLeadsManagementSystem.Analysis
{
    partial class frmCustomerReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerReport));
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.btnSearRevenue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewRevenue = new System.Windows.Forms.DataGridView();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.checkBoxAllRev = new System.Windows.Forms.CheckBox();
            this.labelSart = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(126, 28);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(279, 21);
            this.cmbCustomer.TabIndex = 0;
            this.cmbCustomer.TextChanged += new System.EventHandler(this.cmbCustomer_TextChanged);
            // 
            // btnSearRevenue
            // 
            this.btnSearRevenue.Location = new System.Drawing.Point(438, 31);
            this.btnSearRevenue.Name = "btnSearRevenue";
            this.btnSearRevenue.Size = new System.Drawing.Size(75, 23);
            this.btnSearRevenue.TabIndex = 1;
            this.btnSearRevenue.Text = "Search";
            this.btnSearRevenue.UseVisualStyleBackColor = true;
            this.btnSearRevenue.Click += new System.EventHandler(this.btnSearRevenue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Name";
            // 
            // dataGridViewRevenue
            // 
            this.dataGridViewRevenue.AllowUserToAddRows = false;
            this.dataGridViewRevenue.AllowUserToDeleteRows = false;
            this.dataGridViewRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRevenue.Location = new System.Drawing.Point(12, 114);
            this.dataGridViewRevenue.Name = "dataGridViewRevenue";
            this.dataGridViewRevenue.ReadOnly = true;
            this.dataGridViewRevenue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRevenue.Size = new System.Drawing.Size(635, 208);
            this.dataGridViewRevenue.TabIndex = 3;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(390, 85);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(127, 23);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(523, 85);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(124, 23);
            this.btnChart.TabIndex = 5;
            this.btnChart.Text = "Draw Chart";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // checkBoxAllRev
            // 
            this.checkBoxAllRev.AutoSize = true;
            this.checkBoxAllRev.Location = new System.Drawing.Point(563, 32);
            this.checkBoxAllRev.Name = "checkBoxAllRev";
            this.checkBoxAllRev.Size = new System.Drawing.Size(84, 17);
            this.checkBoxAllRev.TabIndex = 6;
            this.checkBoxAllRev.Text = "All Revenue";
            this.checkBoxAllRev.UseVisualStyleBackColor = true;
            this.checkBoxAllRev.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelSart
            // 
            this.labelSart.AutoSize = true;
            this.labelSart.Location = new System.Drawing.Point(12, 72);
            this.labelSart.Name = "labelSart";
            this.labelSart.Size = new System.Drawing.Size(55, 13);
            this.labelSart.TabIndex = 7;
            this.labelSart.Text = "Start Date";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(165, 72);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(52, 13);
            this.labelEnd.TabIndex = 8;
            this.labelEnd.Text = "End Date";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(15, 88);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(147, 20);
            this.dateTimePickerStart.TabIndex = 9;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(168, 88);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(147, 20);
            this.dateTimePickerEnd.TabIndex = 10;
            // 
            // frmCustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 334);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.labelSart);
            this.Controls.Add(this.checkBoxAllRev);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.dataGridViewRevenue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearRevenue);
            this.Controls.Add(this.cmbCustomer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCustomerReport";
            this.Text = "Revenue Analysis";
            this.Load += new System.EventHandler(this.frmCustomerReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Button btnSearRevenue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewRevenue;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.CheckBox checkBoxAllRev;
        private System.Windows.Forms.Label labelSart;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
    }
}