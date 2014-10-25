using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLeadsManagementSystem.Administration.User
{
    class UserGeneralManager:UserManager
    {
        public string[] getSuccesors()
        {
            return UserDA.getInstance().getSuccesors(Permissions, this.UserName);
        }
    }
}
