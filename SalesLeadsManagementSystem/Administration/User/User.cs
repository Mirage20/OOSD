using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLeadsManagementSystem.Administration.User
{

    //must be abstract
    class User :IUser
    {
        private String userName = "";
        private String name = "";
        private int permissions = 0;
        private String userRating = "";
        private decimal monthlyRevenue = 0;
        private String predecessor = "";
        private String notes = "";

        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }       
        public String Name
        {
            get { return name; }
            set { name = value; }
        }        
        public int Permissions
        {
            get { return permissions; }
            set { permissions = value; }
        }        
        public String UserRating
        {
            get { return userRating; }
            set { userRating = value; }
        }       
        public decimal MonthlyRevnue
        {
            get { return monthlyRevenue; }
            set { monthlyRevenue = value; }
        }        
        public String Predecessor
        {
            get { return predecessor; }
            set { predecessor = value; }
        }        
        public String Notes
        {
            get { return notes; }
            set { notes = value; }
        }



        

        public bool create()
        {
            bool userSuccess=UserDA.getInstance().addToDatabase(this);
            Security.Secure userSensitive=new Security.Secure();
            userSensitive.Username=this.userName;
            userSensitive.Password = Security.Cryptography.Encrypt("1234");
            bool secureSuccess=Security.SecureDA.getInstance().addToDatabase(userSensitive);
            return userSuccess && secureSuccess;
        }

        public bool update()
        {
            return UserDA.getInstance().updateToDatabase(this);
        }

        public Security.Permissions getPermissionLevel()
        {
            return (Security.Permissions)permissions;
        }
        


        //Chamil
        public List<String> getPredecessorList()
        {
            return UserDA.getInstance().getPredecessorList(permissions);
        }
        //Chamil

        public string[] getSuccesors()
        {
            return UserDA.getInstance().getSuccesors(this.permissions, this.userName);
        }
    }
}
