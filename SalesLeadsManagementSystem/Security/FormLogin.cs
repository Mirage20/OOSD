#define DevoloperMode         //Set DevoloperMode to bypass login.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace SalesLeadsManagementSystem.Security
{
    
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

       

        private void btnViewPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar='\0';
        }

        private void btnViewPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
#if DevoloperMode
            MessageBox.Show("Elaz..(y)");
            General.frmMain mainForm = new General.frmMain();
            Administration.User.User devUser= new Administration.User.User();
            devUser.Permissions = 5;
            devUser.Name = "Developer";
            devUser.UserName = "sudaraka";
            
            General.frmMain.AppUser = devUser;

            mainForm.Show();
            this.Hide();
#else
            UserLogin user = new UserLogin(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            if(user.Login())
            {
                MessageBox.Show("Elaz..(y)");
                General.frmMain mainForm = new General.frmMain();
                General.frmMain.AppUser = Administration.User.UserDA.getInstance().readFromDatabase(txtUsername.Text.Trim());
                mainForm.Show();
                this.Hide();
            }
            else
            {
                if(user.hasLoginError())
                {
                    if(MessageBox.Show(this, user.ErrorDetails(), "Login Failed", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)==System.Windows.Forms.DialogResult.Yes)
                    {
                        user.resetPassword();
                    }
                }
                else
                    MessageBox.Show(this, user.ErrorDetails(), "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
#endif
        }

       
    }
}
