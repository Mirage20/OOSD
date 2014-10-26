namespace SalesLeadsManagementSystem.Sales
{
    partial class frmSelectCustomer
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
            this.dataGridViewselectcus = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCusSearch = new System.Windows.Forms.ComboBox();
            this.txtSerchCus = new System.Windows.Forms.TextBox();
            this.btnSelectCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewselectcus)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewselectcus
            // 
            this.dataGridViewselectcus.AllowUserToAddRows = false;
            this.dataGridViewselectcus.AllowUserToDeleteRows = false;
            this.dataGridViewselectcus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewselectcus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewselectcus.Location = new System.Drawing.Point(12, 105);
            this.dataGridViewselectcus.MultiSelect = false;
            this.dataGridViewselectcus.Name = "dataGridViewselectcus";
            this.dataGridViewselectcus.ReadOnly = true;
            this.dataGridViewselectcus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewselectcus.Size = new System.Drawing.Size(674, 191);
            this.dataGridViewselectcus.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(341, 48);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search by";
            // 
            // cmbCusSearch
            // 
            this.cmbCusSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCusSearch.FormattingEnabled = true;
            this.cmbCusSearch.Items.AddRange(new object[] {
            "Name",
            "Short Name",
            "Address",
            "Email",
            "Phone Number",
            "Account Manager"});
            this.cmbCusSearch.Location = new System.Drawing.Point(109, 50);
            this.cmbCusSearch.Name = "cmbCusSearch";
            this.cmbCusSearch.Size = new System.Drawing.Size(226, 21);
            this.cmbCusSearch.TabIndex = 35;
            this.cmbCusSearch.TextChanged += new System.EventHandler(this.cmbCusSearch_TextChanged);
            // 
            // txtSerchCus
            // 
            this.txtSerchCus.Location = new System.Drawing.Point(109, 24);
            this.txtSerchCus.Name = "txtSerchCus";
            this.txtSerchCus.Size = new System.Drawing.Size(226, 20);
            this.txtSerchCus.TabIndex = 36;
            this.txtSerchCus.TextChanged += new System.EventHandler(this.txtSerchCus_TextChanged);
            // 
            // btnSelectCustomer
            // 
            this.btnSelectCustomer.Location = new System.Drawing.Point(341, 22);
            this.btnSelectCustomer.Name = "btnSelectCustomer";
            this.btnSelectCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnSelectCustomer.TabIndex = 38;
            this.btnSelectCustomer.Text = "Select";
            this.btnSelectCustomer.UseVisualStyleBackColor = true;
            this.btnSelectCustomer.Click += new System.EventHandler(this.btnSelectCustomer_Click);
            // 
            // frmSelectCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 308);
            this.Controls.Add(this.btnSelectCustomer);
            this.Controls.Add(this.txtSerchCus);
            this.Controls.Add(this.cmbCusSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGridViewselectcus);
            this.Name = "frmSelectCustomer";
            this.Text = "frmSelectCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewselectcus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewselectcus;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCusSearch;
        private System.Windows.Forms.TextBox txtSerchCus;
        private System.Windows.Forms.Button btnSelectCustomer;
    }
}