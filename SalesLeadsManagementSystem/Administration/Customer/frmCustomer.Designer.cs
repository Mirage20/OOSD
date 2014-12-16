namespace SalesLeadsManagementSystem.Administration.Customer
{
    partial class frmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtShortName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAccManager = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.chkAddMode = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(156, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(226, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtShortName
            // 
            this.txtShortName.Location = new System.Drawing.Point(156, 56);
            this.txtShortName.Name = "txtShortName";
            this.txtShortName.Size = new System.Drawing.Size(226, 20);
            this.txtShortName.TabIndex = 1;
            this.txtShortName.TextChanged += new System.EventHandler(this.txtShortName_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(156, 82);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(226, 20);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(156, 108);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(226, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(156, 134);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(226, 20);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // txtAccManager
            // 
            this.txtAccManager.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAccManager.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAccManager.Location = new System.Drawing.Point(156, 160);
            this.txtAccManager.Name = "txtAccManager";
            this.txtAccManager.Size = new System.Drawing.Size(226, 20);
            this.txtAccManager.TabIndex = 5;
            this.txtAccManager.TextChanged += new System.EventHandler(this.txtAccManager_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ShortName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Assigned Account Manager";
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Location = new System.Drawing.Point(490, 188);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnAddUpdate.TabIndex = 12;
            this.btnAddUpdate.Text = "&Add";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(571, 188);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AllowUserToAddRows = false;
            this.dataGridViewCustomer.AllowUserToDeleteRows = false;
            this.dataGridViewCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(12, 217);
            this.dataGridViewCustomer.MultiSelect = false;
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.ReadOnly = true;
            this.dataGridViewCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(634, 195);
            this.dataGridViewCustomer.TabIndex = 14;
            this.dataGridViewCustomer.SelectionChanged += new System.EventHandler(this.dataGridViewCustomer_SelectionChanged);
            // 
            // chkAddMode
            // 
            this.chkAddMode.AutoSize = true;
            this.chkAddMode.Location = new System.Drawing.Point(15, 194);
            this.chkAddMode.Name = "chkAddMode";
            this.chkAddMode.Size = new System.Drawing.Size(75, 17);
            this.chkAddMode.TabIndex = 15;
            this.chkAddMode.Text = "Add Mode";
            this.chkAddMode.UseVisualStyleBackColor = true;
            this.chkAddMode.CheckedChanged += new System.EventHandler(this.chkAddMode_CheckedChanged);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 424);
            this.Controls.Add(this.chkAddMode);
            this.Controls.Add(this.dataGridViewCustomer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAccManager);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtShortName);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCustomer";
            this.Text = "frmNewCustomer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtShortName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAccManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.CheckBox chkAddMode;
    }
}