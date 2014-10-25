using SalesLeadsManagementSystem.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLeadsManagementSystem.Sales.Comment
{
    class CommentHandler
    {
        frmComment commentView;
        Comment modelComment;

        public CommentHandler(frmComment commentView, Comment modelComment)
        {
            this.commentView = commentView;
            this.commentView.Handler = this;
            this.modelComment = modelComment;
        }

        public void newComment()
        {
            modelComment.Content = commentView.CommentContent.Text;
            modelComment.UserName = frmMain.AppUser.UserName;
            modelComment.RealName = frmMain.AppUser.Name;
            modelComment.PostDate = DateTime.Today;
            modelComment.SalesleadsID = commentView.SelectedSalesLeadsID;
            modelComment.create();

        }
        public void viewCommentData(int commentID)
        {
            modelComment = CommentDA.getInstance().readFromDatabase(commentID);

            if (modelComment != null)
            {
                commentView.CommentContent.Text = modelComment.Content;
                commentView.Username.Text = modelComment.UserName;
                commentView.RealName.Text = modelComment.RealName;

                commentView.SalesLeadsID.Text = modelComment.SalesleadsID.ToString();

            }
            else
            {

            }
        }

        public System.Data.DataView readFromDatabase(int salesleadsID)
        {
            DBLink.openConnection();

            string sqlcomments = "SELECT * FROM `salesleads`.`comment` WHERE `SalesLeadsID`='" + salesleadsID + "';";

            DBLink.closeConnection();

            return DBLink.executeTableQuarry(sqlcomments);
        }





    }
}
