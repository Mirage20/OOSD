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
            throw new NotImplementedException();
        }

        public bool updateToDatabase(Quotation existingQuotation)
        {
            throw new NotImplementedException();
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
    }
}
