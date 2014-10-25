using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesLeadsManagementSystem.General;
using MySql.Data.MySqlClient;

namespace SalesLeadsManagementSystem.Sales.Comment
{
    class CommentDA : IDatabaseCommunication<Comment, int>
    {


        private static CommentDA instance = null;

        private CommentDA() { }

        public static CommentDA getInstance()
        {
            if (instance == null)
            {
                instance = new CommentDA();
            }
            return instance;
        }

        public bool addToDatabase(Comment newComment)
        {
            string sqlAddComment = "INSERT INTO `salesleads`.`comment` (`Content`, `UserName`, `SalesLeadsID`, `PostDate`, `RealName`) VALUES ('" + newComment.Content + "', '" + newComment.UserName + "', " + newComment.SalesleadsID + ", " + Rules.toSQLDate(newComment.PostDate) + ", '" + newComment.RealName + "');";
            DBLink.openConnection();
            bool result = DBLink.executeWriteQuarry(sqlAddComment);
            DBLink.closeConnection();
            return result;
        }

        public bool updateToDatabase(Comment existingComment)
        {
            throw new NotImplementedException();
        }


        public Comment readFromDatabase(int commentID)
        {
            DBLink.openConnection();

            string sqlcomments = "SELECT * FROM `salesleads`.`comment` WHERE `CommentID`='" + commentID + "';";

            MySqlDataReader commentData = DBLink.executeReadQuarry(sqlcomments);


            if (commentData.Read())
            {
                Comment existingComment = new Comment();
                existingComment.CommentID = commentData.GetInt32(0);
                existingComment.Content = commentData.GetString(1);
                existingComment.UserName = commentData.GetString(2);
                existingComment.SalesleadsID = commentData.GetInt32(3);
                existingComment.PostDate = commentData.GetDateTime(4);
                existingComment.RealName = commentData.GetString(5);

                return existingComment;
            }

            return null;
        }










       
    }
}
