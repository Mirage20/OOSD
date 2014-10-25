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
            proxyQuotation = new ProxyQuotation(quotationID);

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
    }
}
