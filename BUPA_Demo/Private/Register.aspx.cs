using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUPA_Demo.Model;
using BUPA_Demo.Repository;

namespace BUPA_Demo
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           string userName= HttpContext.Current.User.Identity.Name;
        }

        protected void UpdateUser(object sender, EventArgs e)
        {
            User objUser = new User();
            UserRepository objUserRepository = new UserRepository();

            try
            { 
            
            objUser.Username = UserName.Text;
            objUser.Firstname = FirstName.Text;
            objUser.Lastname = LastName.Text;
            objUser.Email = Email.Text;
            objUser.Password = Password.Text;
                //check user exsits or not in DB
                if(objUserRepository.CheckUserExsits(objUser))
                {
                    objUserRepository.InsertUser(objUser);
                    lblerror.Text = "Data Saved ";

                }
                else
                {
                    lblerror.Text = "User name alredy exsits please try other user name.";
                }
                         
            
            }
            catch (Exception ex)
            {
                lblerror.Text = "Error while saving data";
                throw new NotImplementedException();
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