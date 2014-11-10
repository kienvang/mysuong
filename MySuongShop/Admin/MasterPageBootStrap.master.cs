using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Modules.Role;

public partial class Admin_MasterPageBootStrap : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!CheckRoles.CreateInstant().IsRoles(EnumsRoles.Administrator))
        {
            Response.Redirect(CheckRoles.CreateInstant().GetUrlDirect(Request.RawUrl));
        }
    }
}
