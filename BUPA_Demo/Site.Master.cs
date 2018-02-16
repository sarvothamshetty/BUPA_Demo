using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BUPA_Demo
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ToggleLoginMenu();

        }
        private void ToggleLoginMenu()
        {
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                login.Visible = false;
                register.Visible = false;
                Manage.Visible = true;
            }
            else
            {
                btnLogout.Visible = false;
                Manage.Visible = false;
            }
        }
       protected void btnLogout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }

    }
}