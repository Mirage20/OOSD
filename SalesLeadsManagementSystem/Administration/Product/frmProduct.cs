using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesLeadsManagementSystem.Administration.Product
{
    public partial class frmProduct : Form
    {

        private bool isAddMode = false;
        private int selectedProductID = 0;

        private ProductHandler productHandler;
       
        internal ProductHandler ProductHandler
        {
            set { productHandler = value; }
        }

        public int SelectedProductID
        {
            get { return selectedProductID; }
            set { selectedProductID = value; }
        }

        public TextBox ProductSalesName
        {
            get { return txtProductName; }
        }

        public ComboBox ProductCategory
        {
            get { return cmbCategory; }
        }

        public TextBox InitialPrice
        {
            get { return txtInitialPrice; }
        }

        public TextBox ProductDetails
        {
            get { return txtProductDetails; }
        }

        public frmProduct()
        {
            InitializeComponent();
        }

       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void validateData()
        {
            bool isValid = true;
            if (txtProductName.Text.Trim().Equals(""))
            {
                isValid = false;
            }

            if (cmbCategory.Text.Trim().Equals(""))
            {
                isValid = false;
            }

            if (txtInitialPrice.Text.Trim().Equals("") || !General.Rules.isDecimalNumber(txtInitialPrice.Text))
            {
                isValid = false;
            }

            if (txtProductDetails.Text.Trim().Equals(""))
            {
                isValid = false;
            }

            btnAddUpdate.Enabled = isValid;

        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            if (this.isAddMode == true)
            {
                productHandler.newProduct();
            }
            else
            {
                productHandler.updateProduct();
            }

            this.updateControls();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            isAddMode = chkAddMode.Checked;
            this.updateControls();

            if (General.frmMain.AppUser.getPermissionLevel() == Security.Permissions.AccountManager)
            {
                btnAddUpdate.Enabled = false;
                chkAddMode.Enabled = false;
            }
            else if (General.frmMain.AppUser.getPermissionLevel() == Security.Permissions.Manager)
            {
                chkAddMode.Enabled = false;
                chkAddMode.Enabled = false;
            }
            else if (General.frmMain.AppUser.getPermissionLevel() == Security.Permissions.Engineer)
            {
                btnAddUpdate.Enabled = false;
                chkAddMode.Enabled = false;
            }
            else if (General.frmMain.AppUser.getPermissionLevel() == Security.Permissions.DeputyGeneralManager)
            {

            }
        }

        private void dataGridViewProduct_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProduct.SelectedRows.Count != 0 && !this.isAddMode)
            {
                this.selectedProductID = (int)dataGridViewProduct.SelectedRows[0].Cells[0].Value;
                productHandler.viewProductData(this.selectedProductID);
            }
        }

        private void chkAddMode_CheckedChanged(object sender, EventArgs e)
        {
            isAddMode = chkAddMode.Checked;
            this.updateControls();
        }

        private void updateControls()
        {
            dataGridViewProduct.DataSource = productHandler.getAllProducts();

            if (isAddMode == false)
            {
                btnAddUpdate.Text = "&Update";
                this.Text = "Update Product";
            }
            else
            {
                btnAddUpdate.Text = "&Add";
                this.Text = "Add New Product";
                txtProductName.Clear();
                cmbCategory.SelectedIndex=0;
                txtInitialPrice.Clear();
                txtProductDetails.Clear();
                
            }
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            validateData();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            validateData();
        }

        private void txtInitialPrice_TextChanged(object sender, EventArgs e)
        {
            validateData();
        }

        private void txtProductDetails_TextChanged(object sender, EventArgs e)
        {
            validateData();
        }

        
    }
}
