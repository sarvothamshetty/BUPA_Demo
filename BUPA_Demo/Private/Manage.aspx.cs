using BUPA_Demo.Model;
using BUPA_Demo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BUPA_Demo.Private
{
    public partial class Manage : System.Web.UI.Page
    {
        User objUser = new User();
        UserRepository objUserRepository = new UserRepository();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                objUser = GetUserDetails();
                if (objUser != null)
                {
                    BindData(objUser);
                }
            }
            
        }

       
        private User GetUserDetails()
        {
            string userName = HttpContext.Current.User.Identity.Name;

            if (userName != null)
            {
                objUser = objUserRepository.GetUserByName(userName);
            }
           

            return objUser;
        }

        private void BindData(User objUser)
        {
            lblusername.Text = objUser.Username;
            hdnUserID.Value = objUser.UserId.ToString();
            FirstName.Text = objUser.Firstname;
            LastName.Text = objUser.Lastname;
            ConfirmPassword.TextMode = TextBoxMode.Password;
            Password.TextMode = TextBoxMode.Password;
            Password.Attributes.Add("value", objUser.Password);
            ConfirmPassword.Attributes.Add("value", objUser.Password);
            Password.Text = objUser.Password;
            ConfirmPassword.Text = objUser.Password;
            Email.Text = objUser.Email;
        }

        protected void UpdateUser(object sender, EventArgs e)
        {        

            try
            {

                objUser.UserId = Convert.ToInt32(hdnUserID.Value.ToString());
                objUser.Username = lblusername.Text;
                objUser.Firstname = FirstName.Text;
                objUser.Lastname = LastName.Text;
                objUser.Email = Email.Text;
                objUser.Password = Password.Text;
                if (objUserRepository.UpdateUser(objUser))
                {
                    lblerror.Text = "Data Saved";
                }
                else
                {
                    lblerror.Text = "Error while saving data.";

                }
                
            }
            catch (Exception ex)
            {
                lblerror.Text = "Error while saving data";
                //throw new NotImplementedException();
                // Here we can retore the Exception in DB 
            }
            finally
            {
                objUser = null;
                objUserRepository = null;

            }


        }
    }
}