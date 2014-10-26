using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLeadsManagementSystem.Security
{
    class Secure
    {
        private string username = "";
        private string password = "";
        private string question = "";
        private string answer = "";

        public string Username
        {
            get { return username; }
            set { username = value; }
        }        
        public string Password
        {
            get { return password; }
            set { password = value; }
        }        
        public string Question
        {
            get { return question; }
            set { question = value; }
        }       
        public string Answer
        {
            get { return answer; }
            set { answer = value; }
        }


        public bool create()  // add to database using secure Data Acess
        {
            return SecureDA.getInstance().addToDatabase(this);
        }

        public bool update()  //update to database using secure Data Acess
        {
            return SecureDA.getInstance().updateToDatabase(this);
        }
    }
}
