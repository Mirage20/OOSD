using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesLeadsManagementSystem.General;
using MySql.Data.MySqlClient;

namespace SalesLeadsManagementSystem.Sales
{
    class SalesLeadDA:IDatabaseCommunication<SalesLead,int>
    {


        private static SalesLeadDA instance = null;

        private SalesLeadDA() { }

        public static SalesLeadDA getInstance()
        {
            if(instance==null)
            {
                instance = new SalesLeadDA();
            }
            return instance;
        }

        public bool addToDatabase(SalesLead newSalesLead)
        {
            string sqlAddCustomer = "INSERT INTO `salesleads`.`customerproduct` (`SalesLeadsID`,`CustomerID`, `ProductID`, `IssueDate`, `RevenueType`, `MonthlyRevenue`, `HadTest`, `ProjectRevenue`,`ProjectPaid`, `CustomerConfirmDate`, `PurchaseOrderLocation`, `AgreementSignDate`,`DSP`,`FirstBillIssued`,`BillIssueDate`,`SuccessfullClose`,`ClosedDate`,`DisconnectedDate`,`DisconnectReason`,`CoustomerFeedBack`,`Discount`,`Notes`) VALUES (NULL, '" + newSalesLead.Customer.CustomerID + "', '" + newSalesLead.Product.ProductID + "', " + Rules.toSQLDate(newSalesLead.getSalesActivity(ActivityType.SalesIssue).ActivityDate) + ", '" + newSalesLead.RevenueType + "', '" + newSalesLead.MonthlyRevenue + "', '" + Rules.boolToYesNo(newSalesLead.HadTest) + "', '" + newSalesLead.ProjectRevenue + "', '" + newSalesLead.ProjectPaid + "', " + Rules.toSQLDate(newSalesLead.getSalesActivity(ActivityType.CustomerConfirm).ActivityDate) + ", ?FileData, " + Rules.toSQLDate(newSalesLead.getSalesActivity(ActivityType.AgreementSign).ActivityDate) + ", " + Rules.toSQLDate(newSalesLead.getSalesActivity(ActivityType.DSP).ActivityDate) + ", '" + newSalesLead.getSalesActivity(ActivityType.BillIssue).ActivityDetails + "', " + Rules.toSQLDate(newSalesLead.getSalesActivity(ActivityType.BillIssue).ActivityDate) + ", '" + newSalesLead.getSalesActivity(ActivityType.SalesClose).ActivityDetails + "', " + Rules.toSQLDate(newSalesLead.getSalesActivity(ActivityType.SalesClose).ActivityDate) + ", " + Rules.toSQLDate(newSalesLead.getSalesActivity(ActivityType.Disconect).ActivityDate) + ", '" + newSalesLead.getSalesActivity(ActivityType.Disconect).ActivityDetails + "', '" + newSalesLead.CustomerFeedBack + "', '" + newSalesLead.Discount + "', '" + newSalesLead.Notes + "');";
            DBLink.openConnection();
            bool result = DBLink.executeWriteQuarry(sqlAddCustomer, "?FileData", newSalesLead.PurchaseOrderData);
            DBLink.closeConnection();
            return result;
        }

        public bool updateToDatabase(SalesLead existingSalesLead)
        {
            string sqlUpdateCustomer = "UPDATE `salesleads`.`customerproduct` SET `CustomerID` = '" + existingSalesLead.Customer.CustomerID + "',`ProductID` = '" + existingSalesLead.Product.ProductID + "', `IssueDate` = " + Rules.toSQLDate(existingSalesLead.getSalesActivity(ActivityType.SalesIssue).ActivityDate) + ", `RevenueType` = '" + existingSalesLead.RevenueType + "', `MonthlyRevenue` = '" + existingSalesLead.MonthlyRevenue + "', `HadTest` = '" + Rules.boolToYesNo(existingSalesLead.HadTest) + "', `ProjectRevenue` = '" + existingSalesLead.ProjectRevenue + "', `ProjectPaid` = '" + existingSalesLead.ProjectPaid + "', `CustomerConfirmDate` = " + Rules.toSQLDate(existingSalesLead.getSalesActivity(ActivityType.CustomerConfirm).ActivityDate) + ",`PurchaseOrderLocation`=?FileData, `AgreementSignDate` = " + Rules.toSQLDate(existingSalesLead.getSalesActivity(ActivityType.AgreementSign).ActivityDate) + ", `DSP` = " + Rules.toSQLDate(existingSalesLead.getSalesActivity(ActivityType.DSP).ActivityDate) + ", `FirstBillIssued` = '" + existingSalesLead.getSalesActivity(ActivityType.BillIssue).ActivityDetails + "', `BillIssueDate` = " + Rules.toSQLDate(existingSalesLead.getSalesActivity(ActivityType.BillIssue).ActivityDate) + ", `SuccessfullClose` = '" + existingSalesLead.getSalesActivity(ActivityType.SalesClose).ActivityDetails + "', `ClosedDate` = " + Rules.toSQLDate(existingSalesLead.getSalesActivity(ActivityType.SalesClose).ActivityDate) + ", `DisconnectedDate` = " + Rules.toSQLDate(existingSalesLead.getSalesActivity(ActivityType.Disconect).ActivityDate) + ", `DisconnectReason` = '" + existingSalesLead.getSalesActivity(ActivityType.Disconect).ActivityDetails + "', `CoustomerFeedBack` = '" + existingSalesLead.CustomerFeedBack + "', `Discount` = '" + existingSalesLead.Discount + "', `Notes` = '" + existingSalesLead.Notes + "' WHERE `customerproduct`.`SalesLeadsID` = " + existingSalesLead.SalesID + ";";
            DBLink.openConnection();
            bool result = DBLink.executeWriteQuarry(sqlUpdateCustomer, "?FileData", existingSalesLead.PurchaseOrderData);
            DBLink.closeConnection();
            return result;
        }

        public string[] quotationIDToArray(int salesLeadsID)
        {
            DBLink.openConnection();
            string sqlUser = @"SELECT `QuatationID` FROM `salesleads` . `quatation` WHERE `SalesLeadsID` =" + "'" + salesLeadsID + "'";
            MySql.Data.MySqlClient.MySqlDataReader quotationData = DBLink.executeReadQuarry(sqlUser);

            String[] quotaion_Array = new string[15];
            int i = 0;
            if (quotationData.Read())
            {
                quotaion_Array[i] = quotationData.GetString(0);
                i++;

            }

            int arraylength = i;
            Array.Resize(ref quotaion_Array, arraylength);

            return quotaion_Array;
        }


        /// <summary>
        /// has to return all salesLeadsID of a specific customer
        /// </summary>
        /// <param name="SalesLeadsID"></param>
        /// <returns></returns>
        public int[] returnSalesLeadsArrayForCustomer(int CustomerID)
        {
            DBLink.openConnection();
            string sqlUser = @"Select `SalesLeadsID` FROM `salesleads`.`customerproduct` WHERE `CustomerID` = " + "'" + CustomerID + "'";
            MySqlDataReader salesLeadsIDdata = DBLink.executeReadQuarry(sqlUser);

            Int32[] salesLeadsID_Array = new Int32[10000];
            int i = 0;
            if (salesLeadsIDdata.Read())
            {
                salesLeadsID_Array[i] = salesLeadsIDdata.GetInt32(0);
                i++;

            }

            int arraylength = i;
            Array.Resize(ref salesLeadsID_Array, arraylength);

            return salesLeadsID_Array;
        }
        /// <summary>
        /// has to return all salesLeadsID of a specific Product
        /// </summary>
        /// <param name="ProductID"></param>
        /// <returns></returns>
        public int[] returnSalesLeadsIDArrayForProducts(int ProductID)
        {
            DBLink.openConnection();
            string sqlUser = @"Select `SalesLeadsID` FROM `salesleads`.`customerproduct` WHERE `ProductID` = " + "'" + ProductID + "'";
            MySqlDataReader salesLeadsIDdata = DBLink.executeReadQuarry(sqlUser);

            Int32[] salesLeadsID_Array = new Int32[10000];
            int i = 0;
            if (salesLeadsIDdata.Read())
            {
                salesLeadsID_Array[i] = salesLeadsIDdata.GetInt32(0);
                i++;

            }

            int arraylength = i;
            Array.Resize(ref salesLeadsID_Array, arraylength);

            return salesLeadsID_Array;
        }


        public SalesLead readFromDatabase(int salesLeadsID)
        {
            DBLink.openConnection();

            string sqlUser = "SELECT *,LENGTH(`PurchaseOrderLocation`) FROM `salesleads`.`customerproduct` WHERE `SalesLeadsID` = " + salesLeadsID + ";";

            MySqlDataReader salesleadData = DBLink.executeReadQuarry(sqlUser);


            if (salesleadData.Read())
            {
     
                int customerID = salesleadData.GetInt32(1);
                int productID = salesleadData.GetInt32(2);

                SalesLead existingSalesLead = new SalesLead(null,null,null);
                existingSalesLead.SalesID = salesleadData.GetInt32(0);
                
                existingSalesLead.getSalesActivity(ActivityType.SalesIssue).ActivityDate = Rules.dbNullDateField(salesleadData, 3);
                existingSalesLead.RevenueType = salesleadData.GetString(4);
                existingSalesLead.MonthlyRevenue = salesleadData.GetDecimal(5);
                existingSalesLead.HadTest = Rules.yesnoToBoolean(salesleadData.GetString(6));
                existingSalesLead.ProjectRevenue = salesleadData.GetDecimal(7);
                existingSalesLead.ProjectPaid = salesleadData.GetDecimal(8);
                existingSalesLead.getSalesActivity(ActivityType.CustomerConfirm).ActivityDate = Rules.dbNullDateField(salesleadData, 9);
                existingSalesLead.getSalesActivity(ActivityType.AgreementSign).ActivityDate = Rules.dbNullDateField(salesleadData, 11);
                existingSalesLead.getSalesActivity(ActivityType.DSP).ActivityDate = Rules.dbNullDateField(salesleadData, 12);
                existingSalesLead.getSalesActivity(ActivityType.BillIssue).ActivityDetails = salesleadData.GetString(13);
                existingSalesLead.getSalesActivity(ActivityType.BillIssue).ActivityDate = Rules.dbNullDateField(salesleadData, 14);
                existingSalesLead.getSalesActivity(ActivityType.SalesClose).ActivityDetails = salesleadData.GetString(15);
                existingSalesLead.getSalesActivity(ActivityType.SalesClose).ActivityDate = Rules.dbNullDateField(salesleadData, 16);
                existingSalesLead.getSalesActivity(ActivityType.Disconect).ActivityDate = Rules.dbNullDateField(salesleadData, 17);
                existingSalesLead.getSalesActivity(ActivityType.Disconect).ActivityDetails = salesleadData.GetString(18);
                existingSalesLead.CustomerFeedBack = salesleadData.GetString(19);
                existingSalesLead.Discount = salesleadData.GetDecimal(20);
                existingSalesLead.Notes = salesleadData.GetString(21);

                int purchaseOrderFileSize = salesleadData.GetInt32(22);
                byte[] binaryData = new byte[purchaseOrderFileSize];
                if (purchaseOrderFileSize > 0)
                    salesleadData.GetBytes(10, 0, binaryData, 0, purchaseOrderFileSize);
                existingSalesLead.PurchaseOrderData = binaryData;

                Administration.Customer.Customer customer=Administration.Customer.CustomerDA.getInstance().readFromDatabase(customerID);
                Administration.Product.Product product=Administration.Product.ProductDA.getInstance().readFromDatabase(productID);
                Administration.User.User accManager= Administration.User.UserDA.getInstance().readFromDatabase(customer.AccountManager);

                existingSalesLead.Customer = customer;
                existingSalesLead.Product = product;
                existingSalesLead.AccountManager = accManager;

                return existingSalesLead;
            }

            return null;
        }

        public  System.Data.DataView readAllSales()
        {
            Security.Permissions permission = (Security.Permissions)frmMain.AppUser.Permissions;
            string username = frmMain.AppUser.UserName;
            if (permission == Security.Permissions.NoPermissions)
            {
                return null;
            }
            else if (permission == Security.Permissions.Engineer)
            {
                return General.DBLink.executeTableQuarry("SELECT * FROM `salesleads`;");
            }
            else if (permission == Security.Permissions.AccountManager)
            {
                return General.DBLink.executeTableQuarry("SELECT * FROM `salesleads` WHERE `AccManager` = '"+ username + "';");
            }
            else if (permission == Security.Permissions.Manager)
            {
                string[] successorList = Administration.User.UserDA.getInstance().getSuccesors(permission,username);
                string sqlAccManagerlist = "";
                for (int i = 0; i < successorList.Length; i++)
                {
                    if (i == (successorList.Length - 1))
                    {
                        sqlAccManagerlist += "`AccManager` = '" + successorList[i] + "';";
                    }
                    else
                    {
                        sqlAccManagerlist += "`AccManager` = '" + successorList[i] + "' OR";
                    }
                }
                return General.DBLink.executeTableQuarry("SELECT * FROM `salesleads` WHERE "+sqlAccManagerlist);
            }
           
            return General.DBLink.executeTableQuarry("SELECT * FROM `salesleads`;");
            
            
        }
    }
}
