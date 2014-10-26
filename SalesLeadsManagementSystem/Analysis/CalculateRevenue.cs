using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesLeadsManagementSystem.Sales;
using SalesLeadsManagementSystem.General;
using MySql.Data.MySqlClient;

namespace SalesLeadsManagementSystem.Analysis
{
    class CalculateRevenue
    {

        List<float> revenue = new List<float>();

        public List<float> Revenue
        {
            get { return revenue; }
            set { revenue = value; }
        }

        //modify more
        public float calcRevenuePerMonth(int customerID, DateTime startDate, DateTime endDate,bool needAll)
        {
            
            DateTime start;
            
            MySqlDataReader sales = SalesLeadDA.getInstance().sales(customerID,startDate,endDate,needAll);
            start = Convert.ToDateTime(startDate);
            float monthly = 0f;
            while(sales.Read()){
                
                monthly += sales.GetFloat(8) + sales.GetFloat(10);
            }

            return monthly;
        }

        public void getRevenue(int customerID, DateTime start, DateTime end,bool needAll)
        {
            revenue.Clear();
            DateTime date = start;
            DateTime next;
            
            while(DateTime.Compare(date,end)<0)
            {
                next = date.AddMonths(1);
                revenue.Add(calcRevenuePerMonth(customerID, date, next,needAll));
                date = date.AddMonths(1);
                
            }

            //while (count > 0)
            //{   
            //    DateTime Date = Convert.ToDateTime(start.Year+"-"+start.Month+1+"-01");
            //    Date = Date.AddMonths(1);
            //    revenue.Add(calcRevenuePerMonth(customerID,start.Year+"-"+start.Month+"-01",Date.ToString("yyyy-MM-dd")));
            //    count--;
            //}
        }

        
    }
}
