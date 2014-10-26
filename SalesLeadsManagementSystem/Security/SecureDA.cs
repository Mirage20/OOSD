using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesLeadsManagementSystem.General;
using MySql.Data.MySqlClient;
namespace SalesLeadsManagementSystem.Security
{
    class SecureDA:IDatabaseCommunication<Secure,string>
    {


        private static SecureDA instance = null;            // Singleton pattern Implementation

        private SecureDA() { }

        public static SecureDA getInstance()
        {
            if(instance==null)
            {
                instance = new SecureDA();
            }
            return instance;
        }

        public bool addToDatabase(Secure newSecureData)  // Add to database newSecureDAta
        {
            string sqlAddSecureUser = "INSERT INTO `salesleads`.`secure` (`UserName`, `Password`, `SecurityQuestion`, `Answer`) VALUES ('" + newSecureData.Username + "', '" + newSecureData.Password + "', '" + newSecureData.Question + "', '" + newSecureData.Answer + "');";
            DBLink.openConnection();
            bool result = DBLink.executeWriteQuarry(sqlAddSecureUser);
            DBLink.closeConnection();
            return result;
        }

        public bool updateToDatabase(Secure existingSecureData) // Update to database existingSecureData
        {
            string sqlUpdateSecureUser = "UPDATE `salesleads`.`secure` SET `Password` = '" + existingSecureData.Password + "', `SecurityQuestion` = '" + existingSecureData.Question + "', `Answer` = '" + existingSecureData.Answer + "' WHERE `secure`.`UserName` = '" + existingSecureData.Username + "';";
            DBLink.openConnection();
            bool result = DBLink.executeWriteQuarry(sqlUpdateSecureUser);
            DBLink.closeConnection();
            return result;
        }

        public Secure readFromDatabase(string username) // Read the Secure data from the database by the username
        {
            DBLink.openConnection();

            string sqlUser = "SELECT * FROM `secure` WHERE `UserName`='" + username + "';";

            MySqlDataReader secureUserData = DBLink.executeReadQuarry(sqlUser);


            if (secureUserData.Read())
            {
                Secure existingData = new Secure();

                //get the sensitive data from database
                existingData.Username = secureUserData.GetString(0);
                existingData.Password = secureUserData.GetString(1);
                existingData.Question = secureUserData.GetString(2);
                existingData.Answer = secureUserData.GetString(3);
                return existingData;
            }

            return null;
        }
    }
}
