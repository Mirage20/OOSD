using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLeadsManagementSystem.Administration.User
{
    class UserHandler
    {
        private frmUser viewUser;
        private User modelUser;

        public UserHandler(frmUser view,User model)
        {
            this.viewUser = view;
            this.viewUser.UserHandler = this;
            this.modelUser = model;
        }


        public void newUser()
        {
            modelUser.UserName = viewUser.UserName.Text;
            modelUser.Name = viewUser.RealName.Text;
            modelUser.Permissions = viewUser.UserPermissions.SelectedIndex;
            modelUser.UserRating = viewUser.UserRating.Text;
            modelUser.MonthlyRevnue = Convert.ToDecimal(General.Rules.textToPrice(viewUser.UserMonthlyRevenue.Text));
            modelUser.Predecessor = viewUser.UserPredecessor.Text;
            modelUser.Notes = viewUser.UserNotes.Text;
            modelUser.create();
        }

        public void updateUser()
        {
            
            modelUser.UserName = viewUser.SelectedUserName;
            modelUser.Name = viewUser.RealName.Text;
            modelUser.Permissions = viewUser.UserPermissions.SelectedIndex;
            modelUser.UserRating = viewUser.UserRating.Text;
            modelUser.MonthlyRevnue = Convert.ToDecimal(General.Rules.textToPrice(viewUser.UserMonthlyRevenue.Text));
            modelUser.Predecessor = viewUser.UserPredecessor.Text;
            modelUser.Notes = viewUser.UserNotes.Text;
            modelUser.update();
        }

        public void viewUserData(string userName)
        {
            modelUser = UserDA.getInstance().readFromDatabase(userName);

            if (modelUser != null)
            {
                viewUser.UserName.Text = modelUser.UserName;
                viewUser.RealName.Text = modelUser.Name;
                viewUser.UserPermissions.SelectedIndex = modelUser.Permissions;
                viewUser.UserRating.Text = modelUser.UserRating;
                viewUser.UserPredecessor.Text = modelUser.Predecessor;
                viewUser.UserMonthlyRevenue.Text = modelUser.MonthlyRevnue.ToString();
                viewUser.UserNotes.Text = modelUser.Notes;
            }
            else
            {
                //MessageBox.Show("No User with ID " + this.selectedUserName);
                //this.Close();
            }
        }

        public System.Data.DataView getAllUsers()
        {
            return General.DBLink.executeTableQuarry("SELECT * FROM `salesleads`.`user`;");
        }

        //chamil
        public List<string> getPredecessors()
        {                 
            return UserDA.getInstance().getPredecessorList(viewUser.UserPermissions.SelectedIndex);
        }
        //chamil
    }
}
