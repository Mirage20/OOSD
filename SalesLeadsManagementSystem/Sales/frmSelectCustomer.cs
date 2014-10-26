using SalesLeadsManagementSystem.Administration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesLeadsManagementSystem.Sales
{
    public partial class frmSelectCustomer : Form
    {
        private frmAddUpdateSalesLead baseSalesLeadForm;


        public frmAddUpdateSalesLead BaseSalesLeadForm
        {
            get { return baseSalesLeadForm; }
            set { baseSalesLeadForm = value; }
        }
    
        public frmSelectCustomer()
        {

            InitializeComponent();
            cmbCusSearch.SelectedIndex=0;
            updatecontrols();
            
        }
      

        private void updatecontrols()
        {
            if(General.frmMain.AppUser.Permissions==2)
            {
                dataGridViewselectcus.DataSource = General.DBLink.executeTableQuarry("SELECT * FROM `salesleads`.`customer` WHERE `AccManager`= '"+ General.frmMain.AppUser.UserName +"' AND `salesleads`.`customer`.`" + getColumnName_Customer(cmbCusSearch.SelectedIndex) + "` LIKE '%" + txtSerchCus.Text + "%';");
            }
            else
                dataGridViewselectcus.DataSource = General.DBLink.executeTableQuarry("SELECT * FROM `salesleads`.`customer` WHERE `salesleads`.`customer`.`" +getColumnName_Customer(cmbCusSearch.SelectedIndex) + "` LIKE '%" + txtSerchCus.Text + "%';");
        }

       

        private void txtSerchCus_TextChanged(object sender, EventArgs e)
        {
           
            updatecontrols();
        }

        private void cmbCusSearch_TextChanged(object sender, EventArgs e)
        {
            updatecontrols();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        public void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            baseSalesLeadForm.updateCustomerID((int)dataGridViewselectcus.SelectedRows[0].Cells[0].Value);
            this.Hide();
           
        }

        private string getColumnName_Customer(int index)
        {
            
            switch (index)
            {
                case 0:
                    return "Name";
                case 1:
                    return "ShortName";
                case 2:
                    return "Address";
                case 3:
                    return "Email";
                case 4:
                    return "PhoneNo";
                case 5:
                    return "AccManager";
                default:
                    return null;
            }
                    
        }
        
    }
}
