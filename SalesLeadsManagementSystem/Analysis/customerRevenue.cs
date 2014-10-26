using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesLeadsManagementSystem.Sales;

namespace SalesLeadsManagementSystem.Analysis
{
    class CustomerRevenue
    {
        private int customerID = 0;
        private string customerName = "";
        
        private DateTime Date;
        private List<float> totalRevenue = new List<float>();

        public CustomerRevenue()
        {
            Date = new DateTime();
            Date = Convert.ToDateTime(Date.ToString("dd-MM-yyyy"));
        }

        public List<float> TotalRevenue
        {
            get { return totalRevenue; }
            set { totalRevenue = value; }
        }
        

        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public CustomerRevenue getRevenue()
        {
            return this;
        }
    }
}
