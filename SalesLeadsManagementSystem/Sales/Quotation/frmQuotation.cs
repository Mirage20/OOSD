using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesLeadsManagementSystem.Sales.Quotation
{
    public partial class frmQuotation : Form
    {
        private int salesID;
        private int selectedQuotationID;

        public int SelectedQuotationID
        {
            get { return selectedQuotationID; }
            set { selectedQuotationID = value; }
        }
        public DateTimePicker PickerQuoatationDate
        {
            get
            {
                return this.dateTimePickerQuotationDate;
            }
        }
        public TextBox QuoatationStatus
        {
            get
            {
                return this.txtQuotationStatus;
            }
        }
        public int SalesID
        {
            get { return salesID; }
            set { salesID = value; }
        }

        private QuotationHandler quotationHandler = new QuotationHandler();

        internal QuotationHandler QuotationHandler
        {
            get { return quotationHandler; }
            set { quotationHandler = value; }
        }
        public frmQuotation()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.quotationHandler.showQuotationFile(selectedQuotationID);
        }

        private void frmQuotation_Load(object sender, EventArgs e)
        {
            refresh();

            if (General.frmMain.AppUser.getPermissionLevel() == Security.Permissions.AccountManager)
            {
                
            }
            else if (General.frmMain.AppUser.getPermissionLevel() == Security.Permissions.Manager)
            {
                
            }
            else if (General.frmMain.AppUser.getPermissionLevel() == Security.Permissions.Engineer)
            {
                btnAdd.Enabled = false;
                btnBrowse.Enabled = false;
                chkAddMode.Enabled = false;
            }
            else if (General.frmMain.AppUser.getPermissionLevel() == Security.Permissions.DeputyGeneralManager)
            {
                
            }
        }

        private void refresh()
        {
            this.dataGridViewQuotations.DataSource = this.QuotationHandler.viewQuotationData(salesID);
        }

        private void dataGridViewQuotations_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewQuotations.SelectedRows.Count != 0 && !this.chkAddMode.Checked)
            {
                this.selectedQuotationID = (int)dataGridViewQuotations.SelectedRows[0].Cells[0].Value;
                quotationHandler.viewQuotation(this.selectedQuotationID);
            }
        }

        private void chkAddMode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAddMode.Checked)
            {
                lblQPath.Text = "";
                txtQuotationStatus.Text = "";
                dateTimePickerQuotationDate.Value = DateTime.Today;
                btnAdd.Text = "Add";
            }
            else
            {
                btnAdd.Text = "Update";
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if(openFileDialogQuotation.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                FileInfo f = new FileInfo(openFileDialogQuotation.FileName);
                long fileSize = f.Length;
                int filesizeinMB = (int)(fileSize / (1024 * 1024));
                if (filesizeinMB > 16)
                {
                    System.Windows.Forms.MessageBox.Show("Select a file samller than 16 MB", "WARNING", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
                    return;
                }
                quotationHandler.QuotationPath = openFileDialogQuotation.FileName;
                lblQPath.Text = quotationHandler.QuotationPath;
                quotationHandler.IsQpathChanged = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if add mode is selected
            if (chkAddMode.Checked)
            {
                quotationHandler.newQuotation();
            }
            else
            {
                quotationHandler.updateQuotation();
            }

            refresh();
        }
    }
}
