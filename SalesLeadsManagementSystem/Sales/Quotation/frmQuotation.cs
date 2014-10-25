using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        }

        private void frmQuotation_Load(object sender, EventArgs e)
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
    }
}
