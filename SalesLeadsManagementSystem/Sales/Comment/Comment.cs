using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLeadsManagementSystem.Sales.Comment
{
    class Comment
    {
        private int commentID;

        public int CommentID
        {
            get { return commentID; }
            set { commentID = value; }
        }

        private String content;

        public String Content
        {
            get { return content; }
            set { content = value; }
        }
        private String userName;

        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private String realName;

        public String RealName
        {
            get { return realName; }
            set { realName = value; }
        }
        private int salesleadsID;

        public int SalesleadsID
        {
            get { return salesleadsID; }
            set { salesleadsID = value; }
        }
        private DateTime postDate;

        public DateTime PostDate
        {
            get { return postDate; }
            set { postDate = value; }
        }

        public bool create()
        {
            return CommentDA.getInstance().addToDatabase(this);
        }


    }
}
