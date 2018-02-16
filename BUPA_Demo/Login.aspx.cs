using System;
using System.Web;
using System.Web.UI;
using BUPA_Demo.Model;
using BUPA_Demo.Repository;
using System.Web.Security;

namespace BUPA_Demo
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        
        protected void Login_Click(object sender, EventArgs e)
        {

            if (IsValid)
            {

                UserRepository objUserRepository = new UserRepository();
                if (objUserRepository.UserAuthentication(Name.Text, Password.Text))
                {

                    //Forms Authentication

                    HttpCookie AuthCookie;
                    AuthCookie = FormsAuthentication.GetAuthCookie(Name.Text, true);
                    AuthCookie.Expires = DateTime.Now.AddMinutes(5);
                    Response.Cookies.Add(AuthCookie);
                    Response.Redirect(FormsAuthentication.GetRedirectUrl(Name.Text, true));

                    Response.Redirect("Privateprogram.aspx");
                }
                else
                {
                    lblerror.Text = "Please enter valid credentails.";
                }
            }


        }
    }
}