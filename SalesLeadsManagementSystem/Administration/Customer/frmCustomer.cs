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

        
    }
}
