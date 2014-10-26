namespace SalesLeadsManagementSystem.General
{
    partial class frmSettings
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
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tabChangePW = new System.Windows.Forms.TabPage();
            this.lblNotify = new System.Windows.Forms.Label();
            this.txtNew2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirmPW = new System.Windows.Forms.Button();
            this.txtNew1 = new System.Windows.Forms.TextBox();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageChangeSQ = new System.Windows.Forms.TabPage();
            this.btnConfirmSQ = new System.Windows.Forms.Button();
            this.txtSecurityAns = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSecurityQ = new System.Windows.Forms.TextBox();
            this.txtCurrentPWsq = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClose1 = new System.Windows.Forms.Button();
            this.tabSettings.SuspendLayout();
            this.tabChangePW.SuspendLayout();
            this.tabPageChangeSQ.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSettings
            // 
            this.tabSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSettings.Controls.Add(this.tabChangePW);
            this.tabSettings.Controls.Add(this.tabPageChangeSQ);
            this.tabSettings.Location = new System.Drawing.Point(12, 12);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(375, 236);
            this.tabSettings.TabIndex = 0;
            // 
            // tabChangePW
            // 
            this.tabChangePW.BackColor = System.Drawing.SystemColors.Control;
            this.tabChangePW.Controls.Add(this.btnClose);
            this.tabChangePW.Controls.Add(this.lblNotify);
            this.tabChangePW.Controls.Add(this.txtNew2);
            this.tabChangePW.Controls.Add(this.label3);
            this.tabChangePW.Controls.Add(this.btnConfirmPW);
            this.tabChangePW.Controls.Add(this.txtNew1);
            this.tabChangePW.Controls.Add(this.txtCurrent);
            this.tabChangePW.Controls.Add(this.label2);
            this.tabChangePW.Controls.Add(this.label1);
            this.tabChangePW.Location = new System.Drawing.Point(4, 22);
            this.tabChangePW.Name = "tabChangePW";
            this.tabChangePW.Padding = new System.Windows.Forms.Padding(3);
            this.tabChangePW.Size = new System.Drawing.Size(367, 210);
            this.tabChangePW.TabIndex = 0;
            this.tabChangePW.Text = "Change Password";
            // 
            // lblNotify
            // 
            this.lblNotify.AutoSize = true;
            this.lblNotify.Location = new System.Drawing.Point(36, 147);
            this.lblNotify.Name = "lblNotify";
            this.lblNotify.Size = new System.Drawing.Size(0, 13);
            this.lblNotify.TabIndex = 7;
            // 
            // txtNew2
            // 
            this.txtNew2.Location = new System.Drawing.Point(152, 112);
            this.txtNew2.Name = "txtNew2";
            this.txtNew2.Size = new System.Drawing.Size(100, 20);
            this.txtNew2.TabIndex = 6;
            this.txtNew2.TextChanged += new System.EventHandler(this.txtNew2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Re-Enter Password";
            // 
            // btnConfirmPW
            // 
            this.btnConfirmPW.Location = new System.Drawing.Point(177, 169);
            this.btnConfirmPW.Name = "btnConfirmPW";
            this.btnConfirmPW.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmPW.TabIndex = 4;
            this.btnConfirmPW.Text = "Confirm";
            this.btnConfirmPW.UseVisualStyleBackColor = true;
            this.btnConfirmPW.Click += new System.EventHandler(this.btnConfirmPW_Click);
            // 
            // txtNew1
            // 
            this.txtNew1.Location = new System.Drawing.Point(152, 80);
            this.txtNew1.Name = "txtNew1";
            this.txtNew1.Size = new System.Drawing.Size(100, 20);
            this.txtNew1.TabIndex = 3;
            this.txtNew1.TextChanged += new System.EventHandler(this.txtNew1_TextChanged);
            // 
            // txtCurrent
            // 
            this.txtCurrent.Location = new System.Drawing.Point(152, 40);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(100, 20);
            this.txtCurrent.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Password";
            // 
            // tabPageChangeSQ
            // 
            this.tabPageChangeSQ.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageChangeSQ.Controls.Add(this.btnClose1);
            this.tabPageChangeSQ.Controls.Add(this.btnConfirmSQ);
            this.tabPageChangeSQ.Controls.Add(this.txtSecurityAns);
            this.tabPageChangeSQ.Controls.Add(this.label4);
            this.tabPageChangeSQ.Controls.Add(this.txtSecurityQ);
            this.tabPageChangeSQ.Controls.Add(this.txtCurrentPWsq);
            this.tabPageChangeSQ.Controls.Add(this.label5);
            this.tabPageChangeSQ.Controls.Add(this.label6);
            this.tabPageChangeSQ.Location = new System.Drawing.Point(4, 22);
            this.tabPageChangeSQ.Name = "tabPageChangeSQ";
            this.tabPageChangeSQ.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChangeSQ.Size = new System.Drawing.Size(367, 210);
            this.tabPageChangeSQ.TabIndex = 1;
            this.tabPageChangeSQ.Text = "Change Secuirity Qestion";
            // 
            // btnConfirmSQ
            // 
            this.btnConfirmSQ.Location = new System.Drawing.Point(185, 171);
            this.btnConfirmSQ.Name = "btnConfirmSQ";
            this.btnConfirmSQ.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmSQ.TabIndex = 13;
            this.btnConfirmSQ.Text = "Confirm";
            this.btnConfirmSQ.UseVisualStyleBackColor = true;
            this.btnConfirmSQ.Click += new System.EventHandler(this.btnConfirmSQ_Click);
            // 
            // txtSecurityAns
            // 
            this.txtSecurityAns.Location = new System.Drawing.Point(160, 124);
            this.txtSecurityAns.Name = "txtSecurityAns";
            this.txtSecurityAns.Size = new System.Drawing.Size(100, 20);
            this.txtSecurityAns.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Answer";
            // 
            // txtSecurityQ
            // 
            this.txtSecurityQ.Location = new System.Drawing.Point(160, 92);
            this.txtSecurityQ.Name = "txtSecurityQ";
            this.txtSecurityQ.Size = new System.Drawing.Size(100, 20);
            this.txtSecurityQ.TabIndex = 10;
            // 
            // txtCurrentPWsq
            // 
            this.txtCurrentPWsq.Location = new System.Drawing.Point(160, 52);
            this.txtCurrentPWsq.Name = "txtCurrentPWsq";
            this.txtCurrentPWsq.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentPWsq.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "New Security Qestion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Current Password";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(275, 169);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClose1
            // 
            this.btnClose1.Location = new System.Drawing.Point(277, 171);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(75, 23);
            this.btnClose1.TabIndex = 14;
            this.btnClose1.Text = "Close";
            this.btnClose1.UseVisualStyleBackColor = true;
            this.btnClose1.Click += new System.EventHandler(this.btnClose1_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 260);
            this.Controls.Add(this.tabSettings);
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.tabSettings.ResumeLayout(false);
            this.tabChangePW.ResumeLayout(false);
            this.tabChangePW.PerformLayout();
            this.tabPageChangeSQ.ResumeLayout(false);
            this.tabPageChangeSQ.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage tabChangePW;
        private System.Windows.Forms.TabPage tabPageChangeSQ;
        private System.Windows.Forms.Button btnConfirmPW;
        private System.Windows.Forms.TextBox txtNew1;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNew2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSecurityAns;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSecurityQ;
        private System.Windows.Forms.TextBox txtCurrentPWsq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConfirmSQ;
        private System.Windows.Forms.Label lblNotify;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClose1;
    }
}