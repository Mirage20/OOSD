using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesLeadsManagementSystem.Security;
namespace SalesLeadsManagementSystem.Administration.User
{
    abstract class FactoryUser
    {
        public static User getUserObj(Permissions permissionLevel)
        {
            User userObj = null;

            switch (permissionLevel)
            {
                case Permissions.NoPermissions:
                    break;
                case Permissions.Engineer:
                    userObj = new UserEngineer();
                    break;
                case Permissions.AccountManager:
                    userObj = new UserAccountManager();
                    break;
                case Permissions.Manager:
                    userObj = new UserManager();
                    break;
                case Permissions.DeputyGeneralManager:
                    userObj = new UserDeputyGeneralManager();
                    break;
                case Permissions.GeneralManager:
                    userObj = new UserGeneralManager();
                    break;
                default:
                    break;
            }
            return userObj;
        }
    }
}
