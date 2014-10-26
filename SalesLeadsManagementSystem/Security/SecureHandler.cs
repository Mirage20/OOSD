using SalesLeadsManagementSystem.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesLeadsManagementSystem.Security
{
    class SecureHandler

    {
        Secure ModelUser;           // securedata referance
        

        public SecureHandler(frmSettings settings)
        {
            
            settings.ResetHandler = this;
        }

        public void ChangePassword(String currentPW, String newPassword) // Change the password
        {
            if (VerifyPassword(currentPW))
            {
                ModelUser.Password = Cryptography.Encrypt(newPassword);

                ModelUser.update();

                MessageBox.Show("Sucessfull");
            }


        }

        public void ChangeSecurityQ(String currentPW, String newQ, String newA) // Change the Security credentials
        {

            if (VerifyPassword(currentPW))
            {
                ModelUser.Question = newQ;
                ModelUser.Answer = Cryptography.Encrypt(newA);

                ModelUser.update();

                MessageBox.Show("Sucessfull");
            }
        }

        private bool VerifyPassword(String Password)            // verify the current password retun true if ok else false
        {
            ModelUser = SecureDA.getInstance().readFromDatabase(frmMain.AppUser.UserName);

            if ((ModelUser.Password).Equals(Cryptography.Encrypt(Password)))
            {

                return true;
            }
            else
            {
                MessageBox.Show("Wrong Password");
                return false;

            }

        }
    }
}
