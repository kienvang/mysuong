using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library.Tools;

public partial class Admin_Profile_Controls_ChangePassword : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        MembershipUser u = Membership.GetUser(Util.CurrentUserName);
        if (u.ChangePassword(txtPassCurrent.Text, txtPass.Text))
        {
            FormsAuthentication.SignOut();
            Response.Redirect("/");
        }
        else
        {
            CustomValidator1.ErrorMessage = "Mật khẩu không chính xác";
            CustomValidator1.IsValid = false;
        }
    }

    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {

    }
}