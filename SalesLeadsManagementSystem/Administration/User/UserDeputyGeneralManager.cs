using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLeadsManagementSystem.Administration.User
{
    class UserDeputyGeneralManager:UserManager
    {
        public new string[] getSuccesors()
        {
            return UserDA.getInstance().getSuccesors((Security.Permissions)Permissions, this.UserName);
        }
    }
}
