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


namespace SalesLeadsManagementSystem.Analysis
{
    public partial class frmCustomerReport : Form
    {
        
        private string filterString = null;
        private DataView filtered = null;
        private CustomerRevenueHandler crHandler = null;

        public DateTimePicker StartDate
        {
            get { return dateTimePickerStart; }
        }

        public DateTimePicker EndDate
        {
            get { return dateTimePickerEnd; }
        }

        public ComboBox CustomerName
        {
            get { return cmbCustomer; }
        }

        internal CustomerRevenueHandler CRHandler
        {
            set { crHandler = value; }
        }

        public DataGridView RevenueGrid
        {
            get { return dataGridViewRevenue; }
        }

        public CheckBox NeddAllRevenue
        {
            get { return checkBoxAllRev; }
        }

        public frmCustomerReport()
        {
            InitializeComponent();
            crHandler = new CustomerRevenueHandler(this, new CustomerRevenue());
            checkBoxAllRev.Checked = true;
            
        }


        private void btnSearRevenue_Click(object sender, EventArgs e)
        {
           
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            updateControls();
        }

        public void updateControls()
        {
            dataGridViewRevenue.DataSource = crHandler.getAllRevenue();
            filtered = crHandler.getAllRevenue();

            if(!checkBoxAllRev.Checked){
                filterString = "ShortName LIKE '%" +cmbCustomer.Text +"%'";
                filtered.RowFilter = filterString;
                
                
                dataGridViewRevenue.DataSource = filtered;
            }
            else
                dataGridViewRevenue.DataSource = crHandler.getAllRevenue();

        }

       
        private void cmbCustomer_TextChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.Text.Equals(""))
                checkBoxAllRev.Checked = true;
            else
                checkBoxAllRev.Checked = false;
            updateControls();
        }

        

        private void yearPicker_ValueChanged(object sender, EventArgs e)
        {
            updateControls();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            crHandler.newCustomerRevenue(Int32.Parse(dataGridViewRevenue.SelectedRows[0].Cells[1].Value.ToString()));
            crHandler.ViewGraph = new frmGraph(StartDate.Value);
            crHandler.ViewGraph.Data = crHandler.ModelCustomerRevenue.TotalRevenue;
            crHandler.ViewGraph.Series = crHandler.ModelCustomerRevenue.CustomerName;
            if(checkBoxAllRev.Checked)
                crHandler.ViewGraph.drawGraph(crHandler.ViewGraph.Data, "All Sales Revenues");
            else
                crHandler.ViewGraph.drawGraph(crHandler.ViewGraph.Data, crHandler.ViewGraph.Series);
            crHandler.ViewGraph.Show();
            
        }

        private void frmCustomerReport_Load(object sender, EventArgs e)
        {
            dateTimePickerStart.Value = new DateTime(DateTime.Today.Year, 01, 01);
            dateTimePickerEnd.Value = new DateTime(DateTime.Today.Year, 12, 31);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }
        
        
    }
}
