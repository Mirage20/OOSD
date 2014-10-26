using SalesLeadsManagementSystem.Sales.Comment;
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
    public partial class frmViewSalesLeads : Form
    {
        private DataView dataFilterSalesleads;
        private string filterString = null;
        public frmViewSalesLeads()
        {
            InitializeComponent();
        }

        private void frmViewSalesLeads_Load(object sender, EventArgs e)
        {
            this.refreshControls();
            txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection autoCustomerList = new AutoCompleteStringCollection();
            for (int i = 0; i < dataFilterSalesleads.Table.Rows.Count;i++ )
                autoCustomerList.Add(dataFilterSalesleads.Table.Rows[i][3].ToString());

            txtSearch.AutoCompleteCustomSource = autoCustomerList;
            this.loadColumnVisibilitySettings();
            this.selectVisibleColumns();


            
        }

        public void loadColumnVisibilitySettings()
        {
            chkSalesID.Checked=Properties.Settings.Default.Col1;
            chkCustomerID.Checked = Properties.Settings.Default.Col2;
            chkCustomerName.Checked = Properties.Settings.Default.Col3;
            chkCustomerShortName.Checked = Properties.Settings.Default.Col4;
            chkProductID.Checked = Properties.Settings.Default.Col5;
            chkProductName.Checked = Properties.Settings.Default.Col6;
            chkIssueDate.Checked = Properties.Settings.Default.Col7;
            chkRevenueType.Checked = Properties.Settings.Default.Col8;
            chkMonthlyRevenue.Checked = Properties.Settings.Default.Col9;
            chkHadTest.Checked = Properties.Settings.Default.Col10;
            chkProjectRevenue.Checked = Properties.Settings.Default.Col11;
            chkProjectPaid.Checked = Properties.Settings.Default.Col12;
            chkCustomerConfirmDate.Checked = Properties.Settings.Default.Col13;
            chkAgreementSignDate.Checked = Properties.Settings.Default.Col14;
            chkDSP.Checked = Properties.Settings.Default.Col15;
            chkFirstBillIssued.Checked = Properties.Settings.Default.Col16;
            chkBillIssueDate.Checked = Properties.Settings.Default.Col17;
            chkCloseReason.Checked = Properties.Settings.Default.Col18;
            chkClosedDate.Checked = Properties.Settings.Default.Col19;
            chkDisconnectedDate.Checked = Properties.Settings.Default.Col20;
            chkDisconnectReason.Checked = Properties.Settings.Default.Col21;
            chkCoustomerFeedBack.Checked = Properties.Settings.Default.Col22;
            chkDiscount.Checked = Properties.Settings.Default.Col23;
            chkNotes.Checked = Properties.Settings.Default.Col24;
            chkAccManager.Checked = Properties.Settings.Default.Col25;
        }


        public void saveColumnVisibilitySettings()
        {
            Properties.Settings.Default.Col1=chkSalesID.Checked ;
            Properties.Settings.Default.Col2=chkCustomerID.Checked;
            Properties.Settings.Default.Col3=chkCustomerName.Checked;
            Properties.Settings.Default.Col4=chkCustomerShortName.Checked;
            Properties.Settings.Default.Col5= chkProductID.Checked;
            Properties.Settings.Default.Col6=chkProductName.Checked;
            Properties.Settings.Default.Col7=chkIssueDate.Checked;
            Properties.Settings.Default.Col8=chkRevenueType.Checked;
            Properties.Settings.Default.Col9=chkMonthlyRevenue.Checked;
            Properties.Settings.Default.Col10=chkHadTest.Checked;
            Properties.Settings.Default.Col11=chkProjectRevenue.Checked;
            Properties.Settings.Default.Col12=chkProjectPaid.Checked;
            Properties.Settings.Default.Col13=chkCustomerConfirmDate.Checked;
            Properties.Settings.Default.Col14=chkAgreementSignDate.Checked;
            Properties.Settings.Default.Col15=chkDSP.Checked;
            Properties.Settings.Default.Col16=chkFirstBillIssued.Checked;
            Properties.Settings.Default.Col17=chkBillIssueDate.Checked;
            Properties.Settings.Default.Col18=chkCloseReason.Checked;
            Properties.Settings.Default.Col19=chkClosedDate.Checked;
            Properties.Settings.Default.Col20=chkDisconnectedDate.Checked;
            Properties.Settings.Default.Col21=chkDisconnectReason.Checked;
            Properties.Settings.Default.Col22=chkCoustomerFeedBack.Checked;
            Properties.Settings.Default.Col23=chkDiscount.Checked;
            Properties.Settings.Default.Col24=chkNotes.Checked;
            Properties.Settings.Default.Col25=chkAccManager.Checked;

            Properties.Settings.Default.Save();
        }

        public void refreshControls()
        {
            //dataFilterSalesleads = General.DBLink.executeTableQuarry("SELECT `SalesLeadsID`,`CustomerID`,`ProductID`,DATE_FORMAT(`IssueDate`,'%Y-%m-%d') AS `IssueDate`,`RevenueType`,`MonthlyRevenue`,`HadTest`,`ProjectRevenue`,`ProjectPaid`,DATE_FORMAT(`CustomerConfirmDate`,'%Y-%m-%d') AS `CustomerConfirmDate`,DATE_FORMAT(`AgreementSignDate`,'%Y-%m-%d') AS `AgreementSignDate`,DATE_FORMAT(`DSP`,'%Y-%m-%d') AS `DSP`,`FirstBillIssued`,DATE_FORMAT(`BillIssueDate`,'%Y-%m-%d') AS `BillIssueDate`,`SuccessfullClose`,DATE_FORMAT(`ClosedDate`,'%Y-%m-%d') AS `ClosedDate`,DATE_FORMAT(`DisconnectedDate`,'%Y-%m-%d') AS `DisconnectedDate`,`DisconnectReason`,`CoustomerFeedBack`,`Discount`,`Notes` FROM `customerproduct`");
            dataFilterSalesleads = SalesleadsHandler.getAllSales();
            dataFilterSalesleads.RowFilter = "ShortName LIKE '%" + txtSearch.Text + "%'";
            dataGridViewSalesLeads.DataSource = dataFilterSalesleads;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewSalesLeads.SelectedRows.Count != 0)
            {
                frmAddUpdateSalesLead updateSalesleadForm = new frmAddUpdateSalesLead();
                updateSalesleadForm.IsAdd = false;
                updateSalesleadForm.BaseSalesLeadForm = this;
                updateSalesleadForm.SelectedSalesLeadID=(int) dataGridViewSalesLeads.SelectedRows[0].Cells[0].Value;
                SalesleadsHandler updateSalesleadHandler = new SalesleadsHandler(updateSalesleadForm);
                
                updateSalesleadForm.Show();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {       
             this.updateDataGrid();         
        }


        private void updateDataGrid()
        {
            if(chkShowUnclosed.Checked)
                this.filterString = "ShortName LIKE '%" + txtSearch.Text + "%' AND Isnull(ClosedDate,'Null Column') = 'Null Column'";
            else
                this.filterString = "ShortName LIKE '%" + txtSearch.Text + "%'";

            dataFilterSalesleads.RowFilter = this.filterString;
            dataGridViewSalesLeads.DataSource = dataFilterSalesleads;
        }
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            //if(txtSearch.Text.Equals(""))
            //{
            //    txtSearch.ForeColor = Color.Gray;
            //    txtSearch.Text = "Quick Search by Customer";
            //}
        }

        

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            //txtSearch.ForeColor = Color.Black;
            //txtSearch.Clear();
        }

        private void chkShowUnclosed_CheckedChanged(object sender, EventArgs e)
        {
            this.updateDataGrid();
        }

        

        #region ColumnVisibilityControl

        private void selectVisibleColumns()
        {
            dataGridViewSalesLeads.Columns[0].Visible = chkSalesID.Checked;
            dataGridViewSalesLeads.Columns[1].Visible = chkCustomerID.Checked;
            dataGridViewSalesLeads.Columns[2].Visible = chkCustomerName.Checked;
            dataGridViewSalesLeads.Columns[3].Visible = chkCustomerShortName.Checked;
            dataGridViewSalesLeads.Columns[4].Visible = chkProductID.Checked;
            dataGridViewSalesLeads.Columns[5].Visible = chkProductName.Checked;
            dataGridViewSalesLeads.Columns[6].Visible = chkIssueDate.Checked;
            dataGridViewSalesLeads.Columns[7].Visible = chkRevenueType.Checked;
            dataGridViewSalesLeads.Columns[8].Visible = chkMonthlyRevenue.Checked;
            dataGridViewSalesLeads.Columns[9].Visible = chkHadTest.Checked;
            dataGridViewSalesLeads.Columns[10].Visible = chkProjectRevenue.Checked;
            dataGridViewSalesLeads.Columns[11].Visible = chkProjectPaid.Checked;
            dataGridViewSalesLeads.Columns[12].Visible = chkCustomerConfirmDate.Checked;
            dataGridViewSalesLeads.Columns[13].Visible = chkAgreementSignDate.Checked;
            dataGridViewSalesLeads.Columns[14].Visible = chkDSP.Checked;
            dataGridViewSalesLeads.Columns[15].Visible = chkFirstBillIssued.Checked;
            dataGridViewSalesLeads.Columns[16].Visible = chkBillIssueDate.Checked;
            dataGridViewSalesLeads.Columns[17].Visible = chkCloseReason.Checked;
            dataGridViewSalesLeads.Columns[18].Visible = chkClosedDate.Checked;
            dataGridViewSalesLeads.Columns[19].Visible = chkDisconnectedDate.Checked;
            dataGridViewSalesLeads.Columns[20].Visible = chkDisconnectReason.Checked;
            dataGridViewSalesLeads.Columns[21].Visible = chkCoustomerFeedBack.Checked;
            dataGridViewSalesLeads.Columns[22].Visible = chkDiscount.Checked;
            dataGridViewSalesLeads.Columns[23].Visible = chkNotes.Checked;
            dataGridViewSalesLeads.Columns[24].Visible = chkAccManager.Checked;
        }

        private void chkSalesID_CheckedChanged(object sender, EventArgs e)
        {
            this.selectVisibleColumns();
        }

        private void chkCustomerID_CheckedChanged(object sender, EventArgs e)
        {
            this.selectVisibleColumns();
        }

        private void chkCustomerName_CheckedChanged(object sender, EventArgs e)
        {
            this.selectVisibleColumns();
        }

        private void chkProductID_CheckedChanged(object sender, EventArgs e)
        {
            this.selectVisibleColumns();
        }

        private void chkProductName_CheckedChanged(object sender, EventArgs e)
        {
            this.selectVisibleColumns();
        }

        private void chkIssueDate_CheckedChanged(object sender, EventArgs e)
        {
            this.selectVisibleColumns();
        }

        private void chkRevenueType_CheckedChanged(object sender, EventArgs e)
        {
            this.selectVisibleColumns();
        }

        private void chkMonthlyRevenue_CheckedChanged(object sender, EventArgs e)
        {
            this.selectVisibleColumns();
        }

        private void chkHadTest_CheckedChanged(object sender, EventArgs e)
        {
            this.selectVisibleColumns();
        }

        private void chkProjectRevenue_CheckedChanged(object sender, EventArgs e)
        {
            this.selectVisibleColumns();
        }

        private void chkProjectPaid_CheckedChanged(object sender, EventArgs e)
        {
            this.selectVisibleColumns();
        }

        private void chkCustomerConfirmDate_CheckedChanged(object sender, EventArgs e)
        {
            this.selectVisibleColumns();
        }

        private void chkAgreementSignDate_CheckedChanged(object sender, EventArgs e)
        {
            this.selectVisibleColumns();
        }

        private void chkDSP_CheckedChanged(object sender, EventArgs e)
        {
            this.selectVisibleColumns();
        }

        private void chkFirstBillIssued_CheckedChanged(object sender, EventArgs e)
        {
            this.selectVisibleColumns();
        }

        private void chkBillIssueDate_CheckedChanged(object sender, EventArgs e)
        {
            this.selectVisibleColumns();
        }

        private void chkCloseReason_CheckedChanged(object sender, EventArgs e)
        {
            this.selectVisibleColumns();
        }

        private void chkClosedDate_CheckedChanged(object sender, EventArgs e)
        {
            this.selectVisibleColumns();
        }

        private void chkDisconnectedDate_CheckedChanged(object sender, EventArgs e)
        {
            this.selectVisibleColumns();
        }

        private void chkDisconnectReason_CheckedChanged(object sender, EventArgs e)
        {
            this.selectVisibleColumns();
        }

        private void chkCoustomerFeedBack_CheckedChanged(object sender, EventArgs e)
        {
            this.selectVisibleColumns();
        }

        private void chkDiscount_CheckedChanged(object sender, EventArgs e)
        {
            this.selectVisibleColumns();
        }

        private void chkNotes_CheckedChanged(object sender, EventArgs e)
        {
            this.selectVisibleColumns();
        }

        private void chkAccManager_CheckedChanged(object sender, EventArgs e)
        {
            this.selectVisibleColumns();
        }

        private void chkCustomerShortName_CheckedChanged(object sender, EventArgs e)
        {
            this.selectVisibleColumns();
        }
        #endregion

        private void dataGridViewSalesLeads_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmComment newCommnt = new frmComment();
            CommentHandler newhandler = new CommentHandler(newCommnt, new Comment.Comment());
            newCommnt.SelectedSalesLeadsID = (int)dataGridViewSalesLeads.SelectedRows[0].Cells[0].Value;
            newCommnt.Show();
        }

        private void frmViewSalesLeads_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveColumnVisibilitySettings();
        }
    }
}
