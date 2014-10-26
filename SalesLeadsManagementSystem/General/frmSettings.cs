using SalesLeadsManagementSystem.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesLeadsManagementSystem.General
{
    public partial class frmSettings : Form
    {

        SecureHandler resetHandler;

        internal SecureHandler ResetHandler  // SecureHandler Referance
        {
            get { return resetHandler; }
            set { resetHandler = value; }
        }
        



        public frmSettings()
        {
            InitializeComponent();
        }

        public void update()                // update the form according to the the inputs of the user
        {
           
            if(!(txtNew1.Text).Equals(txtNew2.Text))
            {
                btnConfirmPW.Visible = false;
                lblNotify.Text = "Passwords does not match";
            }
            else if (txtNew1.Text.Length < 5)
            {
                btnConfirmPW.Visible = false;
                lblNotify.Text = "Please enter a Password with atleast 5 characters";
            }
            else
            {
                btnConfirmPW.Visible = true;
                lblNotify.Text = "Press Confirm to change your password";

            }
        }

        private void txtNew1_TextChanged(object sender, EventArgs e)
        {
            update();
            
        }

        private void txtNew2_TextChanged(object sender, EventArgs e)
        {
            update();
        }

        private void btnConfirmPW_Click(object sender, EventArgs e)  // Change the password on this event
        {

            resetHandler.ChangePassword(txtCurrent.Text,txtNew1.Text);
            txtCurrent.Clear();
            txtCurrentPWsq.Clear();
            txtNew1.Clear();
            txtNew2.Clear();
            txtSecurityAns.Clear();
            txtSecurityQ.Clear();
        }

        private void btnConfirmSQ_Click(object sender, EventArgs e) // Change the Security credentials on this event
        {
            resetHandler.ChangeSecurityQ(txtCurrentPWsq.Text,txtSecurityQ.Text,txtSecurityAns.Text);

            txtCurrent.Clear();
            txtCurrentPWsq.Clear();
            txtNew1.Clear();
            txtNew2.Clear();
            txtSecurityAns.Clear();
            txtSecurityQ.Clear();
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        

        

        
        
        


        
    }
}
