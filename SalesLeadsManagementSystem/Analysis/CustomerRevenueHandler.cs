using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SalesLeadsManagementSystem.Sales;
using MySql.Data.MySqlClient;

namespace SalesLeadsManagementSystem.Analysis
{
    class CustomerRevenueHandler
    {
        private frmCustomerReport viewCustomerReport = null;
        private CustomerRevenue modelCustomerRevenue = null;
        private CalculateRevenue calculator = new CalculateRevenue();
        private frmGraph viewGraph = null;

        public frmGraph ViewGraph
        {
            get { return viewGraph; }
            set { viewGraph = value; }
        }

        internal CustomerRevenue ModelCustomerRevenue
        {
            get { return modelCustomerRevenue; }
            
        }



        public CustomerRevenueHandler(frmCustomerReport viewCustomerReport, CustomerRevenue modelCustomerRevenue)
        {
            this.viewCustomerReport = viewCustomerReport;
            this.modelCustomerRevenue = modelCustomerRevenue;
            this.viewCustomerReport.CRHandler = this;
            this.viewGraph = new frmGraph(viewCustomerReport.StartDate.Value);
        }

        public void newCustomerRevenue(int salesID)
        {
            
            int customerID = Int32.Parse(viewCustomerReport.RevenueGrid.SelectedRows[0].Cells[1].Value.ToString());
            DateTime startDate = viewCustomerReport.StartDate.Value;
            DateTime endDate = viewCustomerReport.EndDate.Value;
            calculator.getRevenue(customerID,startDate,endDate,viewCustomerReport.NeddAllRevenue.Checked);
            modelCustomerRevenue.TotalRevenue = calculator.Revenue;
            modelCustomerRevenue.CustomerID = customerID;
            modelCustomerRevenue.CustomerName = viewCustomerReport.RevenueGrid.SelectedRows[0].Cells[2].Value.ToString();
            
        }

        public DataView getAllRevenue()
        {
            return SalesLeadDA.getInstance().readAllSales();
        }
    }
}
