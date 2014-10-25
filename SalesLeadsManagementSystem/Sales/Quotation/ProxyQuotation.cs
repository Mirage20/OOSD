using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLeadsManagementSystem.Sales.Quotation
{
    class ProxyQuotation:IQuotation
    {
        private Quotation quotation;
        private int quotationID;
        private int salesID;
        public DateTime getQuotationDate()
        {
            return quotation == null ? DateTime.Today : quotation.QuotationDate;
        }

        public string getQstatus()
        {
            return quotation == null ? "" : quotation.QuotationStatus;
        }

        public ProxyQuotation(int quotationID,int salesID)
        {
            // TODO: Complete member initialization
            this.quotationID = quotationID;
            quotation = QuotationDA.getInstance().readFromDatabase(quotationID);
            this.salesID = salesID;
        }

        public ProxyQuotation(int salesID)
        {
            quotation = new Quotation();
            this.salesID = salesID;
            quotation.SalesleadID = this.salesID;
        }

        //get quotation byte array (if exist just return other wise call qutation original methord getQutationData )
        public byte[] getQuotationData()
        {
            if (quotation.QuotationData != null)
            {
                return quotation.QuotationData;
            }
            else
            {
                return quotation.getQuotationData();
            }
            
        }

        public bool create()
        {
            return quotation.create();
        }


        public bool update(bool isQuotationFileChanged)
        {
            if(!isQuotationFileChanged)
            {
                return quotation.update();
            }
            else
            {
                bool qUpdate = quotation.update();
                bool qFileChange = quotation.updateQuotationData();
                return qUpdate && qFileChange;
            }
            
        }

        

        //pass parameters to the qutation and update this.quotation
        public void setQuotationData(byte[] qDataArray)
        {
            quotation.QuotationData = qDataArray;
        }
        public void setQID(int qID)
        {
            quotation.QuotationID = qID;
        }
        public void setSalesID(int salesID)
        {
            quotation.SalesleadID = salesID;
        }

        public void setQstatus(string qStatus)
        {
            quotation.QuotationStatus = qStatus;
        }

        public void setQDate(DateTime qDate)
        {
            quotation.QuotationDate = qDate;
        }

        
    }
}
