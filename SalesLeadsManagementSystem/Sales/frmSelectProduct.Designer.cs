namespace SalesLeadsManagementSystem.Sales
{
    partial class frmSelectProduct
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
            this.txtSerchProduct = new System.Windows.Forms.TextBox();
            this.cmbProSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridViewselectpro = new System.Windows.Forms.DataGridView();
            this.btnSelectProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewselectpro)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSerchProduct
            // 
            this.txtSerchProduct.Location = new System.Drawing.Point(110, 25);
            this.txtSerchProduct.Name = "txtSerchProduct";
            this.txtSerchProduct.Size = new System.Drawing.Size(226, 20);
            this.txtSerchProduct.TabIndex = 43;
            this.txtSerchProduct.TextChanged += new System.EventHandler(this.txtSerchProduct_TextChanged);
            // 
            // cmbProSearch
            // 
            this.cmbProSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProSearch.FormattingEnabled = true;
            this.cmbProSearch.Items.AddRange(new object[] {
            "Product Name",
            "Category",
            "Initial Price",
            "Product Details"});
            this.cmbProSearch.Location = new System.Drawing.Point(110, 51);
            this.cmbProSearch.Name = "cmbProSearch";
            this.cmbProSearch.Size = new System.Drawing.Size(226, 21);
            this.cmbProSearch.TabIndex = 42;
            this.cmbProSearch.TextChanged += new System.EventHandler(this.cmbProSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Search by";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Search Product";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(360, 49);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataGridViewselectpro
            // 
            this.dataGridViewselectpro.AllowUserToAddRows = false;
            this.dataGridViewselectpro.AllowUserToDeleteRows = false;
            this.dataGridViewselectpro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewselectpro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewselectpro.Location = new System.Drawing.Point(12, 104);
            this.dataGridViewselectpro.MultiSelect = false;
            this.dataGridViewselectpro.Name = "dataGridViewselectpro";
            this.dataGridViewselectpro.ReadOnly = true;
            this.dataGridViewselectpro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewselectpro.Size = new System.Drawing.Size(493, 198);
            this.dataGridViewselectpro.TabIndex = 38;
            // 
            // btnSelectProduct
            // 
            this.btnSelectProduct.Location = new System.Drawing.Point(360, 23);
            this.btnSelectProduct.Name = "btnSelectProduct";
            this.btnSelectProduct.Size = new System.Drawing.Size(75, 23);
            this.btnSelectProduct.TabIndex = 44;
            this.btnSelectProduct.Text = "Select";
            this.btnSelectProduct.UseVisualStyleBackColor = true;
            this.btnSelectProduct.Click += new System.EventHandler(this.btnSelectProduct_Click);
            // 
            // frmSelectProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 314);
            this.Controls.Add(this.btnSelectProduct);
            this.Controls.Add(this.txtSerchProduct);
            this.Controls.Add(this.cmbProSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGridViewselectpro);
            this.Name = "frmSelectProduct";
            this.Text = "Select Product";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewselectpro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSerchProduct;
        private System.Windows.Forms.ComboBox cmbProSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridViewselectpro;
        private System.Windows.Forms.Button btnSelectProduct;
    }
}