using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modules.Role;

public partial class LayoutAdmin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (CheckRoles.CreateInstant().IsRoles(EnumsRoles.Administrator))
        {
            lkChangePass.NavigateUrl = "/Admin/Profile/ChangePassword.aspx";
        }
        else
        {
            lkChangePass.NavigateUrl = "/manage/ChangePassword.aspx";
        }
    }
}
