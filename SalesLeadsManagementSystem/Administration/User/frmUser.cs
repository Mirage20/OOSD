using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesLeadsManagementSystem.Administration.User
{
    public partial class frmUser : Form
    {
        private bool isAddMode = false;
        private string selectedUserName = "";

        private UserHandler userHandler;

        internal UserHandler UserHandler
        {
            set { userHandler = value; }
        }

        public string SelectedUserName
        {
            get { return selectedUserName; }
            set { selectedUserName = value; }
        }

        public TextBox UserName
        {
            get { return txtUserName; }
        }

        public TextBox RealName
        {
            get { return txtName; }
        }

        public ComboBox UserPermissions
        {
            get { return cmbUserPermissions; }
        }

        public TextBox UserRating
        {
            get { return txtRating; }
        }

        public TextBox UserMonthlyRevenue
        {
            get { return txtMonthlyRevenue; }
        }

        public ComboBox UserPredecessor
        {
            get { return cmbPredecessor; }
        }

        public TextBox UserNotes
        {
            get { return txtNotes; }
        }

        public frmUser()
        {
            InitializeComponent();
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            
            if (this.isAddMode == true)
            {
                userHandler.newUser();
            }
            else
            {
                userHandler.updateUser();
            }

            this.UpdateControls();
        }

        private void validateData()
        {
            bool isValid = true;
            if (txtUserName.Text.Trim().Equals(""))
            {
                isValid = false;
            }

            if (txtName.Text.Trim().Equals(""))
            {
                isValid = false;
            }
            if (cmbPredecessor.Text.Trim().Equals("") && cmbUserPermissions.SelectedIndex != 5)
            {
                isValid = false;
            }

            if (cmbUserPermissions.Text.Trim().Equals(""))
            {
                isValid = false;
            }

            if (!txtMonthlyRevenue.Text.Trim().Equals("") && !General.Rules.isDecimalNumber(txtMonthlyRevenue.Text))
            {
                isValid = false;
            }

            btnAddUpdate.Enabled = isValid;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
      
       
     
        private void chkAddMode_CheckedChanged(object sender, EventArgs e)
        {
            isAddMode = chkAddMode.Checked;
            this.UpdateControls();
        }

        private void UpdateControls()
        {
            dataGridViewUser.DataSource = userHandler.getAllUsers();

            if (isAddMode == false)
            {
                btnAddUpdate.Text = "&Update";
                this.Text = "Update User";
            }
            else
            {
                btnAddUpdate.Text = "&Add";
                this.Text = "Add New User";
                txtUserName.Clear();
                txtName.Clear();
                txtMonthlyRevenue.Clear();
                txtRating.Clear();
                txtNotes.Clear();
                cmbUserPermissions.SelectedIndex=0;
                cmbPredecessor.DataSource=null ;
            }
        }

        

        private void dataGridViewUser_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewUser.SelectedRows.Count != 0 && !this.isAddMode)
            {
                this.selectedUserName = (string)dataGridViewUser.SelectedRows[0].Cells[0].Value;
                userHandler.viewUserData(this.selectedUserName);               
            }
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            isAddMode = chkAddMode.Checked;
            this.UpdateControls();

            if (General.frmMain.AppUser.getPermissionLevel() == Security.Permissions.AccountManager)
            {
                btnAddUpdate.Enabled = false;
                chkAddMode.Enabled = false;
            }
            else if (General.frmMain.AppUser.getPermissionLevel() == Security.Permissions.Manager)
            {
                btnAddUpdate.Enabled = false;
                chkAddMode.Enabled = false;
            }
            else if (General.frmMain.AppUser.getPermissionLevel() == Security.Permissions.Engineer)
            {
                btnAddUpdate.Enabled = false;
                chkAddMode.Enabled = false;
            }
            else if (General.frmMain.AppUser.getPermissionLevel() == Security.Permissions.DeputyGeneralManager)
            {
                btnAddUpdate.Enabled = false;
                chkAddMode.Enabled = false;
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            validateData();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            validateData();
        }

        private void cmbPredecessor_SelectedIndexChanged(object sender, EventArgs e)
        {
            validateData();
        }
        
        //chamil
        private void cmbUserPermissions_SelectedIndexChanged(object sender, EventArgs e)
        {           
            cmbPredecessor.DataSource = userHandler.getPredecessors();
            validateData();
        }

        private void txtMonthlyRevenue_TextChanged(object sender, EventArgs e)
        {
            validateData();
        }

       

       

        

        

        //chamil

       

        

       

    }
}
