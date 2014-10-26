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
    public partial class frmMain : Form
    {

        private static Administration.User.User appUser;

        internal static Administration.User.User AppUser
        {
            get { return frmMain.appUser; }
            set { frmMain.appUser = value; }
        }


        internal Administration.User.User ApplicationUser
        {
            get { return appUser; }
            set { appUser = value; }
        }

        
        public frmMain()
        {
            InitializeComponent();

        }

        

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administration.Customer.frmCustomer customerForm = new Administration.Customer.frmCustomer();
            customerForm.MdiParent = this;
            Administration.Customer.CustomerHandler customerHandler = new Administration.Customer.CustomerHandler(customerForm, new Administration.Customer.Customer());
            customerForm.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administration.Product.frmProduct productForm = new Administration.Product.frmProduct();
            productForm.MdiParent = this;
            Administration.Product.ProductHandler productHandler = new Administration.Product.ProductHandler(productForm, new Administration.Product.Product());
            productForm.Show();
        }

        private void addSalesLeadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales.frmAddUpdateSalesLead newSalesLead = new Sales.frmAddUpdateSalesLead();
            newSalesLead.IsAdd = true;
            newSalesLead.MdiParent = this;
            Sales.SalesleadsHandler addSalesleadHandler = new Sales.SalesleadsHandler(newSalesLead);

            newSalesLead.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administration.User.frmUser userForm = new Administration.User.frmUser();
            userForm.MdiParent = this;
            Administration.User.UserHandler userHandler = new Administration.User.UserHandler(userForm, new Administration.User.User());
            userForm.Show();
        }

        private void viewSalesLeadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales.frmViewSalesLeads viewSalesLeads = new Sales.frmViewSalesLeads();
            viewSalesLeads.MdiParent = this;
            viewSalesLeads.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            statusStripMain.Items[0].Text = "Username: " + ApplicationUser.Name;
            statusStripMain.Items[1].Text = "PermissionLevel: " +  ApplicationUser.getPermissionLevel();
           
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings newSettings = new frmSettings();
            Security.SecureHandler secHandler = new Security.SecureHandler(newSettings);
            newSettings.ShowDialog();
        }

       
    }
}
