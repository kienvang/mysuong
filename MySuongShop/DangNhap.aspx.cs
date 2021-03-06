﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Modules.Role;

public partial class DangNhap : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Library.Tools.Util.CurrentUserName))
        {
            if (CheckRoles.CreateInstant().IsRoles(EnumsRoles.Employee))
            {
                Response.Redirect("/manage");
            }
            else
                Response.Redirect("/");

        }
    }

    protected void Login1_LoggedIn(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request["ReturnUrl"]))
            Response.Redirect(Request["ReturnUrl"]);
        else
            Response.Redirect("/");
    }
}
