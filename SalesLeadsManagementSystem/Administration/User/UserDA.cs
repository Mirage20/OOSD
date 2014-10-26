using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesLeadsManagementSystem.General;
using MySql.Data.MySqlClient;
namespace SalesLeadsManagementSystem.Administration.User
{
    class UserDA:IDatabaseCommunication<User,string>
    {


        private static UserDA instance = null;

        private UserDA() { }

        public static UserDA getInstance()
        {
            if(instance==null)
            {
                instance = new UserDA();
            }
            return instance;
        }

        public bool addToDatabase(User newUser)
        {
            string sqlAddUser = "INSERT INTO `salesleads`.`user` (`UserName`, `RealName`, `Permissions`, `UserRating`, `SalingsPerMonth`, `Predecessor`, `Notes`) VALUES ('" + newUser.UserName + "', '" + newUser.Name + "', '" + newUser.Permissions + "', '" + newUser.UserRating + "', '" + newUser.MonthlyRevnue + "','" + newUser.Predecessor + "', '" + newUser.Notes + "');";
            DBLink.openConnection();
            bool result = DBLink.executeWriteQuarry(sqlAddUser);
            DBLink.closeConnection();
            return result;
        }

        public bool updateToDatabase(User existingUser)
        {
            string sqlUpdateUser = "UPDATE `salesleads`.`user` SET `RealName` = '" + existingUser.Name + "', `Permissions` = '" + existingUser.Permissions + "', `UserRating` = '" + existingUser.UserRating + "', `SalingsPerMonth` = '" + existingUser.MonthlyRevnue + "', `Predecessor` = '" + existingUser.Predecessor + "', `Notes` = '" + existingUser.Notes + "' WHERE `user`.`UserName` = '" + existingUser.UserName + "';";
            DBLink.openConnection();
            bool result = DBLink.executeWriteQuarry(sqlUpdateUser);
            DBLink.closeConnection();
            return result;
        }

        public  User readFromDatabase(String userName)
        {
            string sqlUser = "SELECT * FROM `salesleads`.`user` WHERE `UserName`='" + userName + "';";

            DBLink.openConnection();

            MySqlDataReader userData = DBLink.executeReadQuarry(sqlUser);


            if (userData.Read())
            {
                User existingUser = FactoryUser.getUserObj((Security.Permissions)userData.GetInt32(2));
                existingUser.UserName = userData.GetString(0);
                existingUser.Name = userData.GetString(1);
                existingUser.Permissions = userData.GetInt32(2);
                existingUser.UserRating = userData.GetString(3);
                existingUser.MonthlyRevnue = userData.GetDecimal(4);
                existingUser.Predecessor = userData.GetString(5);
                existingUser.Notes = userData.GetString(6);

                return existingUser;
            }

            return null;
        }

        //Chamil
        public  List<String> getPredecessorList(int permission)
        {

            DBLink.openConnection();
            string query = "SELECT * FROM `salesleads`.`user` WHERE `Permissions`>'" + permission + "';";

            System.Data.DataTable predecessorTable = DBLink.executeTableQuarry(query).Table;
            List<String> predecessorList = new List<String>();


            for (int i = 0; i < predecessorTable.Rows.Count; i++)
            {
                predecessorList.Add((String)predecessorTable.Rows[i].ItemArray[0]);
            }

            DBLink.closeConnection();
            return predecessorList;
        }
        //Chamil
        /// <summary>
        /// returns the successor array when permission level and username is given.
        /// </summary>
        /// <param name="permissionLevel"></param>
        /// <param name="username"></param>
        /// <returns>if user is engineer returns null</returns>
        public string[] getSuccesors(Security.Permissions permissionLevel,string username)
        {
            
            switch (permissionLevel)
            {
                
                case SalesLeadsManagementSystem.Security.Permissions.NoPermissions:
                    return null;
                    
                case SalesLeadsManagementSystem.Security.Permissions.Engineer:
                    return null;
                    
                case SalesLeadsManagementSystem.Security.Permissions.AccountManager:
                    return null;
                    
                case SalesLeadsManagementSystem.Security.Permissions.Manager:
                    string sqlUser1 = "SELECT `UserName` FROM `salesleads`.`user` WHERE `Predecessor`='" + username + "';";
                    List<string> successorArray1 = new List<string>();
                    DBLink.openConnection();

                    MySqlDataReader userData1 = DBLink.executeReadQuarry(sqlUser1);

                    while (userData1.Read())
                    {
                        successorArray1.Add(userData1.GetString(0));
       
                    }
                    return successorArray1.ToArray();
                    
                case SalesLeadsManagementSystem.Security.Permissions.DeputyGeneralManager:
                    string sqlUser2 = "SELECT `UserName` FROM `salesleads`.`user` WHERE `Permissions` >2 AND `Permissions` <4 ;";
                    List<string> successorArray2 = new List<string>();
                    DBLink.openConnection();

                    MySqlDataReader userData2 = DBLink.executeReadQuarry(sqlUser2);

                    while (userData2.Read())
                    {
                        successorArray2.Add(userData2.GetString(0));
                    }
                    return successorArray2.ToArray();
                    
                case SalesLeadsManagementSystem.Security.Permissions.GeneralManager:
                    string sqlUser3 = "SELECT `UserName` FROM `salesleads`.`user` WHERE `Permissions` >2 AND `Permissions` <5 ;";
                    List<string> successorArray3 = new List<string>();
                    DBLink.openConnection();

                    MySqlDataReader userData3 = DBLink.executeReadQuarry(sqlUser3);

                    while (userData3.Read())
                    {
                        successorArray3.Add(userData3.GetString(0));
                    }
                    return successorArray3.ToArray();
                    
                
                    
            }
            return null;
        }
    }
}
