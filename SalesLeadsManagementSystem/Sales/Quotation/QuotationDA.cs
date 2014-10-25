using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesLeadsManagementSystem.General;
using MySql.Data.MySqlClient;
namespace SalesLeadsManagementSystem.Sales.Quotation
{
    class QuotationDA:IDatabaseCommunication<Quotation,int>
    {
        private static QuotationDA instance = null;

        private QuotationDA() { }

        public static QuotationDA getInstance()
        {
            if (instance == null)
            {
                instance = new QuotationDA();
            }
            return instance;
        }

        public bool addToDatabase(Quotation newQuotation)
        {
            string sqlAddQuotation = "INSERT INTO `salesleads`.`quatation` (`SalesLeadsID`, `QuatationDate`, `QuotationStatus`, `QuotationLocation`) VALUES ('" + newQuotation.SalesleadID + "', " + Rules.toSQLDate(newQuotation.QuotationDate) + ", '" + newQuotation.QuotationStatus + "', ?FileData);";
            DBLink.openConnection();
            bool result = DBLink.executeWriteQuarry(sqlAddQuotation, "?FileData", newQuotation.QuotationData);           
            DBLink.closeConnection();
            return result;
        }

        public bool updateToDatabase(Quotation existingQuotation)
        {
            string sqlUpdateQuotation = "UPDATE `salesleads`.`quatation` SET `SalesLeadsID` = '" + existingQuotation.SalesleadID + "', `QuatationDate` = '" + existingQuotation.QuotationDate + "', `QuotationStatus` = '" + existingQuotation.QuotationStatus + "' WHERE `quatation`.`QuatationID` = " + existingQuotation.QuotationID + ";";
            DBLink.openConnection();
            bool result = DBLink.executeWriteQuarry(sqlUpdateQuotation);
            DBLink.closeConnection();
            return result;
        }

        public bool updateToDatabaseQuotationData(Quotation existingQuotation)
        {
            string sqlUpdateQuotation = "UPDATE `salesleads`.`quatation` SET `QuotationLocation` = ?FileData  WHERE `quatation`.`QuatationID` = " + existingQuotation.QuotationID + ";";
            DBLink.openConnection();
            bool result = DBLink.executeWriteQuarry(sqlUpdateQuotation, "?FileData", existingQuotation.QuotationData);
            DBLink.closeConnection();
            return result;
        }


        /// <summary>
        /// gives the quotation corresponding to quotation ID
        /// </summary>
        /// <param name="QuotationID"></param>
        /// <returns></returns>
        public Quotation readFromDatabase(int QuotationID)
        {
            DBLink.openConnection();

            string sqlUser = "SELECT `QuatationID`,`SalesLeadsID`,`QuatationDate`,`QuotationStatus`,LENGTH(`QuotationLocation`) FROM `salesleads`.`quatation` WHERE `QuatationID`='" + QuotationID + "';";

            MySqlDataReader quotationData = DBLink.executeReadQuarry(sqlUser);


            if (quotationData.Read())
            {
                Quotation existingQuotation = new Quotation();
                existingQuotation.QuotationID = quotationData.GetInt32(0);
                existingQuotation.SalesleadID = quotationData.GetInt32(1);
                existingQuotation.QuotationDate = quotationData.GetDateTime(2);
                existingQuotation.QuotationStatus = quotationData.GetString(3);


                return existingQuotation;
            }

            return null;
        }

        public System.Data.DataView readAllQuotations(int salesID)
        {
            return General.DBLink.executeTableQuarry("SELECT `QuatationID`,`SalesLeadsID`,`QuatationDate`,`QuotationStatus` FROM `quatation` WHERE `SalesLeadsID`=" + salesID.ToString());
        }

        public byte[] getQuotationData(int qID)
        {
            DBLink.openConnection();

            string sqlUser = "SELECT `QuotationLocation`,LENGTH(`QuotationLocation`) FROM `salesleads`.`quatation` WHERE `QuatationID`='" + qID + "';";

            MySqlDataReader quotationData = DBLink.executeReadQuarry(sqlUser);


            if (quotationData.Read() && !quotationData.IsDBNull(1))
            {

                int quotationFileSize = quotationData.GetInt32(1);
                byte[] binaryData = new byte[quotationFileSize];
                if (quotationFileSize > 0)
                    quotationData.GetBytes(0, 0, binaryData, 0, quotationFileSize);
               return binaryData;
                
            }

            return null;
            

        }

    }
}
