using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesLeadsManagementSystem.General;
namespace SalesLeadsManagementSystem.Sales
{
    public partial class frmAddUpdateSalesLead : Form
    {
        private bool isAdd = false;
        private int selectedSalesLeadID = 0;
              
        private frmViewSalesLeads baseSalesLeadForm = null;
        private SalesleadsHandler addUpdateSalesleadsHandler = null;

        

        #region Properties
        public frmViewSalesLeads BaseSalesLeadForm
        {
            get { return baseSalesLeadForm; }
            set { baseSalesLeadForm = value; }
        }

        internal SalesleadsHandler AddUpdateSalesleadsHandler
        {
            set { addUpdateSalesleadsHandler = value; }
        }

        

        public bool IsAdd
        {
            get { return isAdd; }
            set { isAdd = value; }
        }
        public int SelectedSalesLeadID
        {
            get { return selectedSalesLeadID; }
            set { selectedSalesLeadID = value; }
        }

        public TextBox TextCustomerID
        {
            get { return txtCustomerID; }
        }

        public TextBox TextProductID
        {
            get { return txtProductID; }
        }

        public ComboBox ComboRevType
        {
            get { return cmbRevType; }
        }

        public TextBox TextMonthlyRev
        {
            get { return txtMonthlyRev; }
        }

        public ComboBox ComboHadTest
        {
            get { return cmbHadTest; }
        }

        public TextBox TextProjectRev
        {
            get { return txtProjectRev; }
        }

        public TextBox TextProjectPaid
        {
            get { return txtProjectPaid; }
        }

        public ComboBox ComboFirstBill
        {
            get { return cmbFirstBill; }
        }

        public TextBox TextCloseReason
        {
            get { return txtCloseReason; }
        }

        public TextBox TextDisconReason
        {
            get { return txtDisconReason; }
        }

        public TextBox TextCustomerFeedback
        {
            get { return txtCustomerFeedback; }
        }

        public TextBox TextDiscount
        {
            get { return txtDiscount; }
        }

        public TextBox TextNotes
        {
            get { return txtNotes; }
        }

        public DateTimePicker DateIssue
        {
            get { return dateTimePickerIssueDate; }
        }

        public DateTimePicker DateCustomerConfirm
        {
            get { return dateTimePickerCustomerConfirm; }
        }

        public DateTimePicker DateAgreementSign
        {
            get { return dateTimePickerAgreementSign; }
        }

        public DateTimePicker DSP
        {
            get { return dateTimePickerDSP; }
        }

        public DateTimePicker DateBillIssue
        {
            get { return dateTimePickerBillIssue; }
        }

        public DateTimePicker DateClosed
        {
            get { return dateTimePickerClosed; }
        }

        public DateTimePicker DateDiscon
        {
            get { return dateTimePickerDiscon; }
        }

        #endregion


        public frmAddUpdateSalesLead()
        {
            InitializeComponent();
        }

        private void frmSalesLead_Load(object sender, EventArgs e)
        {
            if(this.isAdd)
            {
                this.Text = "Create New SalesLead";
                btnAddUpdate.Text = "&Add";
                resetControls();
            }
            else
            {
                this.Text = "Update ID= "+ selectedSalesLeadID;
                btnAddUpdate.Text = "&Update";
                this.updateControls();
            }
        }

        private void resetControls()
        {
            cmbRevType.SelectedIndex = 0;
            dateTimePickerAgreementSign.Checked = false;
            dateTimePickerAgreementSign.CustomFormat = "N/A";
            
            dateTimePickerBillIssue.Checked = false;
            dateTimePickerBillIssue.CustomFormat = "N/A";

            dateTimePickerClosed.Checked = false;
            dateTimePickerClosed.CustomFormat = "N/A";

            dateTimePickerCustomerConfirm.Checked = false;
            dateTimePickerCustomerConfirm.CustomFormat = "N/A";

            dateTimePickerDiscon.Checked = false;
            dateTimePickerDiscon.CustomFormat = "N/A";

            dateTimePickerDSP.Checked = false;
            dateTimePickerDSP.CustomFormat = "N/A";

            cmbFirstBill.Enabled = false;
            cmbFirstBill.SelectedIndex = -1;

            txtCloseReason.Enabled = false;
            txtCloseReason.Clear();

            txtDisconReason.Enabled = false;
            txtDisconReason.Clear();
        }

        private void updateControls()
        {
            addUpdateSalesleadsHandler.viewSalesleadData(this.selectedSalesLeadID);
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {

            if (this.isAdd)
            {  
                addUpdateSalesleadsHandler.newSaleslead();
            }
            else
            {                
                             
                addUpdateSalesleadsHandler.updateSaleslead();
            }
            if (this.baseSalesLeadForm != null)
                baseSalesLeadForm.refreshControls();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbRevType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbRevType.SelectedIndex==0)
            {
                txtMonthlyRev.Enabled = true;
                cmbHadTest.Enabled = true;
                cmbHadTest.SelectedIndex = 0;
                txtProjectPaid.Enabled = false;
                txtProjectRev.Enabled = false;

            }
            else
            {
                txtMonthlyRev.Enabled = false;
                cmbHadTest.SelectedIndex = -1;
                cmbHadTest.Enabled = false;
                txtProjectPaid.Enabled = true;
                txtProjectRev.Enabled = true;
            }
        }

        #region DateTimePickCheckControl
        private void dateTimePickerBillIssue_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePickerBillIssue.Checked==true)
            {
                cmbFirstBill.Enabled = true;
                cmbFirstBill.SelectedIndex = 0;
                dateTimePickerBillIssue.CustomFormat = "yyyy-MM-dd";
            }
            else
            {
                dateTimePickerBillIssue.CustomFormat = "N/A";
                cmbFirstBill.Enabled = false;
                cmbFirstBill.SelectedIndex = -1;
            }
        }

        private void dateTimePickerClosed_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerClosed.Checked == true)
            {
                txtCloseReason.Enabled = true;
                dateTimePickerClosed.CustomFormat = "yyyy-MM-dd";
            }
            else
            {
                dateTimePickerClosed.CustomFormat = "N/A";
                txtCloseReason.Enabled = false;
                txtCloseReason.Clear();
            }
        }

        private void dateTimePickerDiscon_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerDiscon.Checked == true)
            {
                txtDisconReason.Enabled = true;
                dateTimePickerDiscon.CustomFormat = "yyyy-MM-dd";
            }
            else
            {
                dateTimePickerDiscon.CustomFormat = "N/A";
                txtDisconReason.Enabled = false;
                txtDisconReason.Clear();
            }
        }

       

        private void dateTimePickerDSP_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerDSP.Checked == true)
                dateTimePickerDSP.CustomFormat = "yyyy-MM-dd";
            else
                dateTimePickerDSP.CustomFormat = "N/A";
        }

        private void dateTimePickerAgreementSign_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerAgreementSign.Checked == true)
                dateTimePickerAgreementSign.CustomFormat = "yyyy-MM-dd";
            else
                dateTimePickerAgreementSign.CustomFormat = "N/A";
        }

        private void dateTimePickerCustomerConfirm_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerCustomerConfirm.Checked == true)
                dateTimePickerCustomerConfirm.CustomFormat = "yyyy-MM-dd";
            else
                dateTimePickerCustomerConfirm.CustomFormat = "N/A";
        }

        #endregion

        private void btnPurchaseFileAdd_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                btnPurchaseFileAdd.BackColor=Color.Gray;
                addUpdateSalesleadsHandler.PurchaseOrderFilePath = openFileDialog1.FileName;
            }
        }

        private void btnPurchaseFileView_Click(object sender, EventArgs e)
        {
            addUpdateSalesleadsHandler.showPurchaseOrderFile();
        }

        public void updateCustomerID(int CustomerID)
        {
            txtCustomerID.Text = CustomerID.ToString();
        }
        public void updateProductID(int ProductID)
        {
            txtProductID.Text = ProductID.ToString();
        }

        private void btnPickCustomer_Click(object sender, EventArgs e)
        {
            frmSelectCustomer pickCustomer = new frmSelectCustomer();
            pickCustomer.BaseSalesLeadForm = this;
            pickCustomer.Show();
        }

        private void btnPickProduct_Click(object sender, EventArgs e)
        {
            frmSelectProduct pickProduct = new frmSelectProduct();
            pickProduct.BaseSalesLeadForm = this;
            pickProduct.Show();
        }

        private void btnQutationFilesView_Click(object sender, EventArgs e)
        {
            Quotation.QuotationHandler thisQuotationHandler = new Quotation.QuotationHandler();
            Quotation.frmQuotation frmaddViewQuotationData = new Quotation.frmQuotation();

            thisQuotationHandler.FrmQuotation = frmaddViewQuotationData;
            frmaddViewQuotationData.QuotationHandler = thisQuotationHandler;
            frmaddViewQuotationData.SalesID = this.selectedSalesLeadID;
            frmaddViewQuotationData.Show();
        }

        

        private void btnPurchaseFileAdd_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==System.Windows.Forms.MouseButtons.Right)
            {
                btnPurchaseFileAdd.BackColor = SystemColors.Control;
                addUpdateSalesleadsHandler.PurchaseOrderFilePath = "";
            }
        }

        

      

        
    }
}
