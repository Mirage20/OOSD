using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLeadsManagementSystem.Sales.Quotation
{
    class Quotation:IQuotation
    {
        private int quotationID = 0;

        public int QuotationID
        {
            get { return quotationID; }
            set { quotationID = value; }
        }
        private int salesleadID = 0;

        public int SalesleadID
        {
            get { return salesleadID; }
            set { salesleadID = value; }
        }
        private DateTime quotationDate;

        public DateTime QuotationDate
        {
            get { return quotationDate; }
            set { quotationDate = value; }
        }
        private string quotationStatus = "";

        public string QuotationStatus
        {
            get { return quotationStatus; }
            set { quotationStatus = value; }
        }
        private byte[] quotationData = null;

        public byte[] QuotationData
        {
            get { return quotationData; }
            set { quotationData = value; }
        }


        public bool create()
        {
            return QuotationDA.getInstance().addToDatabase(this);
        }

        public bool update()
        {
            return QuotationDA.getInstance().updateToDatabase(this);
        }

        public bool updateQuotationData()
        {
            return QuotationDA.getInstance().updateToDatabaseQuotationData(this);
        }



        public byte[] getQuotationData()
        {
            return QuotationDA.getInstance().getQuotationData(this.quotationID);
        }

    }
}
