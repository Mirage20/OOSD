using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesLeadsManagementSystem.Sales.Comment
{
    public partial class frmComment : Form
    {

        bool isAddMode = false;
        int selectedcommentID = 0;
        int selectedSalesLeadsID = 0;

        public int SelectedSalesLeadsID
        {
            get { return selectedSalesLeadsID; }
            set { selectedSalesLeadsID = value; }
        }


        private CommentHandler Commenthandler;

        internal CommentHandler Handler
        {
            get { return Commenthandler; }
            set { Commenthandler = value; }
        }
        public TextBox CommentContent
        {
            get { return txtContent; }
        }
        public Label Username
        {
            get { return lblUserName; }
        }
        public Label SalesLeadsID
        {
            set { SLID = value; }
            get { return SLID; }
        }
        public Label RealName
        {
            get { return lblRealName; }
        }
        public DateTimePicker PostDate
        {
            get { return PostDate; }
        }

        public frmComment()
        {
            InitializeComponent();


        }

        private void updateControls()
        {
            dataGridViewComments.DataSource = Handler.readFromDatabase(selectedSalesLeadsID);

            if (isAddMode == false)
            {
                btnPost.Visible = false;
                label1.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                lblRealName.Visible = true;
                lblUserName.Visible = true;
                this.Text = "View Comments";
            }
            else
            {
                btnPost.Visible = true;
                label1.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                lblRealName.Visible = false;
                lblUserName.Visible = false;
                btnPost.Text = "&Post";
                this.Text = "Add New Comments";

                txtContent.Clear();
                SLID.Text = (this.selectedSalesLeadsID).ToString();

            }
        }

        private void dataGridViewComments_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewComments.SelectedRows.Count != 0 && !this.isAddMode)
            {
                this.selectedcommentID = (int)dataGridViewComments.SelectedRows[0].Cells[0].Value;
                Handler.viewCommentData(this.selectedcommentID);
            }
        }

        private void chkAddMode_CheckedChanged(object sender, EventArgs e)
        {
            isAddMode = chkAddMode.Checked;
            this.updateControls();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (isAddMode == true)
            {
                Handler.newComment();
            }
            this.updateControls();

        }

        private void frmComment_Load(object sender, EventArgs e)
        {
            this.updateControls();
            SLID.Text = selectedSalesLeadsID.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }




    }
}
