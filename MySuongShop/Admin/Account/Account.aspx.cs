using System;
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

using LayerHelper.Service.BLL;

public partial class Admin_Account_Account : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CGridView1.Init(this);
        if (!IsPostBack)
        {
            LoadData();
        }
    }

    public void LoadData()
    {
        DataTable users = AspnetMembershipManager.CreateInstant().GetAll();
        CGridView1.CDataBind(users);
    }
}
