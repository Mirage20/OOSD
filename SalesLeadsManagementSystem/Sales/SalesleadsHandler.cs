using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesLeadsManagementSystem.General;
namespace SalesLeadsManagementSystem.Sales
{
    class SalesleadsHandler
    {

        private frmAddUpdateSalesLead viewSaleslead;
        private SalesLead modelSaleslead;
        private string purchaseOrderFilePath = "";

        public string PurchaseOrderFilePath
        {
            get { return purchaseOrderFilePath; }
            set { purchaseOrderFilePath = value; }
        }

        public SalesleadsHandler(frmAddUpdateSalesLead view)
        {
            this.viewSaleslead = view;
            this.viewSaleslead.AddUpdateSalesleadsHandler = this;
            this.modelSaleslead = new Sales.SalesLead(new Administration.Customer.Customer(), new Administration.Product.Product(), new Administration.User.User());
        }

        public void viewSalesleadData(int salesID)
        {
            modelSaleslead = SalesLeadDA.getInstance().readFromDatabase(salesID);

            if (modelSaleslead != null)
            {
                viewSaleslead.TextCustomerID.Text = Convert.ToString(modelSaleslead.Customer.CustomerID);
                viewSaleslead.TextProductID.Text = Convert.ToString(modelSaleslead.Product.ProductID);
                viewSaleslead.ComboRevType.Text = modelSaleslead.RevenueType;
                viewSaleslead.TextMonthlyRev.Text = Convert.ToString(modelSaleslead.MonthlyRevenue);
                viewSaleslead.ComboHadTest.SelectedIndex = Convert.ToInt32(modelSaleslead.HadTest);
                viewSaleslead.TextProjectRev.Text = Convert.ToString(modelSaleslead.ProjectRevenue);
                viewSaleslead.TextProjectPaid.Text = Convert.ToString(modelSaleslead.ProjectPaid);
                ;
                viewSaleslead.ComboFirstBill.SelectedIndex = modelSaleslead.getSalesActivity(ActivityType.BillIssue).ActivityDetails.ToUpper().Equals("YES") ? 1:0;
                viewSaleslead.TextCloseReason.Text = modelSaleslead.getSalesActivity(ActivityType.SalesClose).ActivityDetails;
                viewSaleslead.TextDisconReason.Text = modelSaleslead.getSalesActivity(ActivityType.Disconect).ActivityDetails;
                viewSaleslead.TextCustomerFeedback.Text = modelSaleslead.CustomerFeedBack;
                viewSaleslead.TextDiscount.Text = Convert.ToString(modelSaleslead.Discount);
                viewSaleslead.TextNotes.Text = modelSaleslead.Notes;


                Rules.nullDateTimePick(viewSaleslead.DateIssue, modelSaleslead.getSalesActivity(ActivityType.SalesIssue).ActivityDate);
                Rules.nullDateTimePick(viewSaleslead.DateCustomerConfirm, modelSaleslead.getSalesActivity(ActivityType.CustomerConfirm).ActivityDate);
                Rules.nullDateTimePick(viewSaleslead.DateAgreementSign, modelSaleslead.getSalesActivity(ActivityType.AgreementSign).ActivityDate);
                Rules.nullDateTimePick(viewSaleslead.DSP, modelSaleslead.getSalesActivity(ActivityType.DSP).ActivityDate);
                Rules.nullDateTimePick(viewSaleslead.DateBillIssue, modelSaleslead.getSalesActivity(ActivityType.BillIssue).ActivityDate);
                Rules.nullDateTimePick(viewSaleslead.DateClosed, modelSaleslead.getSalesActivity(ActivityType.SalesClose).ActivityDate);
                Rules.nullDateTimePick(viewSaleslead.DateDiscon, modelSaleslead.getSalesActivity(ActivityType.Disconect).ActivityDate);
            }
            else
            {
                //MessageBox.Show("No Sales with ID " + this.selectedSalesID);
                //this.Close();
            }
        }

        public void newSaleslead()
        {
            this.refreshModel();
            modelSaleslead.create();
        }

        public void updateSaleslead()
        {
            this.refreshModel();
            modelSaleslead.SalesID = viewSaleslead.SelectedSalesLeadID;
            modelSaleslead.update();
        }

        private void refreshModel()
        {
            int cutomerID=Convert.ToInt32(viewSaleslead.TextCustomerID.Text);
            int productID=Convert.ToInt32(viewSaleslead.TextProductID.Text);
            modelSaleslead.Customer = Administration.Customer.CustomerDA.getInstance().readFromDatabase(cutomerID);
            modelSaleslead.Product = Administration.Product.ProductDA.getInstance().readFromDatabase(productID);
            modelSaleslead.getSalesActivity(ActivityType.SalesIssue).ActivityDate = getDate(viewSaleslead.DateIssue);
            modelSaleslead.RevenueType = viewSaleslead.ComboRevType.Text;
            modelSaleslead.MonthlyRevenue = Rules.textToPrice(viewSaleslead.TextMonthlyRev.Text);
            modelSaleslead.HadTest = Convert.ToBoolean(viewSaleslead.ComboHadTest.SelectedIndex);
            modelSaleslead.ProjectRevenue = Rules.textToPrice(viewSaleslead.TextProjectRev.Text);
            modelSaleslead.ProjectPaid = Rules.textToPrice(viewSaleslead.TextProjectPaid.Text);
            modelSaleslead.getSalesActivity(ActivityType.CustomerConfirm).ActivityDate = getDate(viewSaleslead.DateCustomerConfirm);
            modelSaleslead.PurchaseOrderData = Rules.fileToBytes(this.purchaseOrderFilePath);
            modelSaleslead.getSalesActivity(ActivityType.AgreementSign).ActivityDate = getDate(viewSaleslead.DateAgreementSign);
            modelSaleslead.getSalesActivity(ActivityType.DSP).ActivityDate = getDate(viewSaleslead.DSP);
            modelSaleslead.getSalesActivity(ActivityType.BillIssue).ActivityDetails =viewSaleslead.ComboFirstBill.Text;
            modelSaleslead.getSalesActivity(ActivityType.BillIssue).ActivityDate = getDate(viewSaleslead.DateBillIssue);
            modelSaleslead.getSalesActivity(ActivityType.SalesClose).ActivityDetails = viewSaleslead.TextCloseReason.Text;
            modelSaleslead.getSalesActivity(ActivityType.SalesClose).ActivityDate = getDate(viewSaleslead.DateClosed);
            modelSaleslead.getSalesActivity(ActivityType.Disconect).ActivityDate = getDate(viewSaleslead.DateDiscon);
            modelSaleslead.getSalesActivity(ActivityType.Disconect).ActivityDetails = viewSaleslead.TextDisconReason.Text;
            modelSaleslead.CustomerFeedBack = viewSaleslead.TextCustomerFeedback.Text;
            modelSaleslead.Discount = Rules.textToPrice(viewSaleslead.TextDiscount.Text);
            modelSaleslead.Notes = viewSaleslead.TextNotes.Text;
        }

        private DateTime getDate(System.Windows.Forms.DateTimePicker datePicker)
        {
            if (datePicker.Checked == false)
                return new DateTime(1, 1, 1);
            else
                return datePicker.Value;
        }

        public void showPurchaseOrderFile()
        {
            if (modelSaleslead.PurchaseOrderData.Length > 1)
            {
                string tmpFilePath = System.Windows.Forms.Application.StartupPath + @"\temp.pdf";
                Rules.bytesToFile(tmpFilePath, modelSaleslead.PurchaseOrderData);
                System.Diagnostics.Process.Start(tmpFilePath);
            }
            else
                System.Windows.Forms.MessageBox.Show("No files attached.", "WARNING", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
            
        }

        public static System.Data.DataView getAllSales()
        {
            return SalesLeadDA.getInstance().readAllSales();
        }
    }
}
