using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesLeadsManagementSystem.Administration.Customer
{
    public partial class frmCustomer : Form
    {
        private bool isAddMode = false;
        private int selectedCustomerID = 0;
        private string[] accManagers;

        private CustomerHandler customerHandler;

        internal CustomerHandler CustomerHandler
        {
            set { customerHandler = value; }
        }

        public int SelectedCustomerID
        {
            get { return selectedCustomerID; }
            set { selectedCustomerID = value; }
        }

        public TextBox CustomerName
        {
            get { return txtName; }
        }
        public TextBox CustomerShortName
        {
            get { return txtShortName; }
        }
        public TextBox CustomerAddress
        {
            get { return txtAddress; }
        }
        public TextBox CustomerEmail
        {
            get { return txtEmail; }
        }
        public TextBox CustomerPhone
        {
            get { return txtPhone; }
        }
        public TextBox CustomerAccManager
        {
            get { return txtAccManager; }
        }

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
                   
            if (this.isAddMode == true)
            {
                customerHandler.newCustomer();
            }
            else
            {
                customerHandler.updateCustomer();
            }

            this.updateControls();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
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
            }
            else if (General.frmMain.AppUser.getPermissionLevel() == Security.Permissions.Engineer)
            {
                btnAddUpdate.Enabled = false;
                chkAddMode.Enabled = false;
            }
            else if (General.frmMain.AppUser.getPermissionLevel() == Security.Permissions.DeputyGeneralManager)
            {

            }

            txtAccManager.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtAccManager.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection autoCustomerList = new AutoCompleteStringCollection();
            accManagers = User.UserDA.getInstance().getAccmanagers();
            for (int i = 0; i < accManagers.Length; i++)
                autoCustomerList.Add(accManagers[i]);

            txtAccManager.AutoCompleteCustomSource = autoCustomerList;
        }

        private void dataGridViewCustomer_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCustomer.SelectedRows.Count != 0 && !this.isAddMode)
            {
                this.selectedCustomerID = (int)dataGridViewCustomer.SelectedRows[0].Cells[0].Value;
                customerHandler.viewCustomerData(this.selectedCustomerID);
            }
        }

        private void chkAddMode_CheckedChanged(object sender, EventArgs e)
        {
            isAddMode = chkAddMode.Checked;
            this.updateControls();
        }

        private void updateControls()
        {
            dataGridViewCustomer.DataSource = customerHandler.getAllCustomers();

            if (isAddMode == false)
            {
                btnAddUpdate.Text = "&Update";
                this.Text = "Update Customer";
            }
            else
            {
                btnAddUpdate.Text = "&Add";
                this.Text = "Add New Customer";
                txtName.Clear();
                txtShortName.Clear();
                txtAddress.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
                txtAccManager.Clear();
            }
        }


        private void validateData()
        {
            bool isValid = true;
            if(txtName.Text.Trim().Equals(""))
            {
                isValid = false;
            }
            if (txtShortName.Text.Trim().Equals(""))
            {
                isValid = false;
            }

            if (txtAddress.Text.Trim().Equals(""))
            {
                isValid = false;
            }

            if (!General.Rules.isEmail(txtEmail.Text.Trim()))
            {
                isValid = false;
            }

            if(!General.Rules.isPhonenumber(txtPhone.Text.Trim()))
            {
                isValid = false;
            }

            if (txtAccManager.Text.Trim().Equals("") || !isValidAccManager(txtAccManager.Text.Trim()))
            {
                isValid = false;
            }

            btnAddUpdate.Enabled = isValid;

        }

        private bool isValidAccManager(string userName)
        {
            if (accManagers == null)
                return false;

            for (int i = 0; i < accManagers.Length; i++)
            {
                if (accManagers[i].Equals(userName))
                    return true;
            }

            return false;

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            validateData();
        }

        private void txtShortName_TextChanged(object sender, EventArgs e)
        {
            validateData();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            validateData();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            validateData();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            validateData();
        }

        private void txtAccManager_TextChanged(object sender, EventArgs e)
        {
            validateData();
        }
        
    }
}
