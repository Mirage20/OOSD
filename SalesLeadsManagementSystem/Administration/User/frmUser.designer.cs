namespace SalesLeadsManagementSystem.Administration.User
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.chkAddMode = new System.Windows.Forms.CheckBox();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMonthlyRevenue = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.cmbUserPermissions = new System.Windows.Forms.ComboBox();
            this.cmbPredecessor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // chkAddMode
            // 
            this.chkAddMode.AutoSize = true;
            this.chkAddMode.Location = new System.Drawing.Point(15, 221);
            this.chkAddMode.Name = "chkAddMode";
            this.chkAddMode.Size = new System.Drawing.Size(75, 17);
            this.chkAddMode.TabIndex = 31;
            this.chkAddMode.Text = "Add Mode";
            this.chkAddMode.UseVisualStyleBackColor = true;
            this.chkAddMode.CheckedChanged += new System.EventHandler(this.chkAddMode_CheckedChanged);
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AllowUserToAddRows = false;
            this.dataGridViewUser.AllowUserToDeleteRows = false;
            this.dataGridViewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Location = new System.Drawing.Point(12, 244);
            this.dataGridViewUser.MultiSelect = false;
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.ReadOnly = true;
            this.dataGridViewUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUser.Size = new System.Drawing.Size(496, 227);
            this.dataGridViewUser.TabIndex = 30;
            this.dataGridViewUser.SelectionChanged += new System.EventHandler(this.dataGridViewUser_SelectionChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(428, 180);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Location = new System.Drawing.Point(428, 150);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnAddUpdate.TabIndex = 28;
            this.btnAddUpdate.Text = "&Update";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Predecessor Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Monthly Revenue Generated";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Permissions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "User Rating";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "User Name";
            // 
            // txtMonthlyRevenue
            // 
            this.txtMonthlyRevenue.Location = new System.Drawing.Point(163, 133);
            this.txtMonthlyRevenue.Name = "txtMonthlyRevenue";
            this.txtMonthlyRevenue.Size = new System.Drawing.Size(226, 20);
            this.txtMonthlyRevenue.TabIndex = 20;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(163, 159);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(226, 20);
            this.txtRating.TabIndex = 18;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(163, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(226, 20);
            this.txtName.TabIndex = 17;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(163, 29);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(226, 20);
            this.txtUserName.TabIndex = 16;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(163, 185);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(226, 20);
            this.txtNotes.TabIndex = 33;
            // 
            // cmbUserPermissions
            // 
            this.cmbUserPermissions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserPermissions.FormattingEnabled = true;
            this.cmbUserPermissions.Items.AddRange(new object[] {
            "No Permissions",
            "Engineer",
            "Account Manager",
            "Manager",
            "Deputy General Manager",
            "General Manager"});
            this.cmbUserPermissions.Location = new System.Drawing.Point(163, 81);
            this.cmbUserPermissions.Name = "cmbUserPermissions";
            this.cmbUserPermissions.Size = new System.Drawing.Size(226, 21);
            this.cmbUserPermissions.TabIndex = 34;
            this.cmbUserPermissions.SelectedIndexChanged += new System.EventHandler(this.cmbUserPermissions_SelectedIndexChanged);
            // 
            // cmbPredecessor
            // 
            this.cmbPredecessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPredecessor.FormattingEnabled = true;
            this.cmbPredecessor.Location = new System.Drawing.Point(163, 107);
            this.cmbPredecessor.Name = "cmbPredecessor";
            this.cmbPredecessor.Size = new System.Drawing.Size(226, 21);
            this.cmbPredecessor.TabIndex = 35;
            this.cmbPredecessor.SelectedIndexChanged += new System.EventHandler(this.cmbPredecessor_SelectedIndexChanged);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(520, 483);
            this.Controls.Add(this.cmbPredecessor);
            this.Controls.Add(this.cmbUserPermissions);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkAddMode);
            this.Controls.Add(this.dataGridViewUser);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMonthlyRevenue);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtUserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUser";
            this.Text = "frmnewUser";
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAddMode;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMonthlyRevenue;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.ComboBox cmbUserPermissions;
        private System.Windows.Forms.ComboBox cmbPredecessor;

    }
}