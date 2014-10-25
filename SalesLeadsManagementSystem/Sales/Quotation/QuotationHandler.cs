using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLeadsManagementSystem.Sales.Quotation
{
    class QuotationHandler
    {
        private string quotationPath = null;
        private bool isQpathChanged = false;

        public bool IsQpathChanged
        {
          get { return isQpathChanged; }
          set { isQpathChanged = value; }
        }
        public string QuotationPath
        {
          get { return quotationPath; }
          set { quotationPath = value; }
        }
        private frmQuotation frmQuotation = null;
        private ProxyQuotation proxyQuotation = null;
        public frmQuotation FrmQuotation
        {
            get { return frmQuotation; }
            set { frmQuotation = value; }
        }

        public System.Data.DataView viewQuotationData(int salesID)
        {
            return QuotationDA.getInstance().readAllQuotations(salesID);

        }




        public void viewQuotation(int quotationID)
        {
            proxyQuotation = new ProxyQuotation(quotationID,frmQuotation.SalesID);

            if (proxyQuotation != null)
            {
                frmQuotation.PickerQuoatationDate.Value = proxyQuotation.getQuotationDate();
                frmQuotation.QuoatationStatus.Text = proxyQuotation.getQstatus();

            }
            else
            {
                //MessageBox.Show("No Customer with ID " + this.selectedCustomerID);
                //this.Close();
            }
        }


        public void newQuotation()
        {
            proxyQuotation = new ProxyQuotation(frmQuotation.SalesID);
            proxyQuotation.setQDate(frmQuotation.PickerQuoatationDate.Value);
            proxyQuotation.setQstatus(frmQuotation.QuoatationStatus.Text);
            proxyQuotation.setSalesID(frmQuotation.SalesID);
            if(isQpathChanged)
            {
                proxyQuotation.setQuotationData(General.Rules.fileToBytes(quotationPath));

                isQpathChanged = false;
            }


            proxyQuotation.create();
        }

        public void updateQuotation()
        {
            proxyQuotation.setQDate(frmQuotation.PickerQuoatationDate.Value);
            proxyQuotation.setQstatus(frmQuotation.QuoatationStatus.Text);
            if (isQpathChanged)
            {
                proxyQuotation.setQuotationData(General.Rules.fileToBytes(quotationPath));
                
            }
            proxyQuotation.update(isQpathChanged);
            isQpathChanged = false;
        }
        public void showQuotationFile(int selectedQuotationID)
        {
            if (proxyQuotation != null)
            {
                if (proxyQuotation.getQuotationData() != null)
                {
                    string tmpFilePath = System.Windows.Forms.Application.StartupPath + @"\tempQ.pdf";
                    General.Rules.bytesToFile(tmpFilePath, proxyQuotation.getQuotationData());
                    System.Diagnostics.Process.Start(tmpFilePath);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("No Quotation Files attached", "WARNING", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please select a Quotation","Error",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Exclamation);
            }
            //System.Windows.Forms.MessageBox.Show("hsgdfhshjfhjsdf");
        }
    }
}
