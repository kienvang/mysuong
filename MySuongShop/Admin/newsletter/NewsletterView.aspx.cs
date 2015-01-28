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

using Library.Tools;
using LayerHelper.ShopCake.BLL;
using LayerHelper.ShopCake.DAL.EntityClasses;

public partial class Admin_Account_NewsletterView : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LoadData();
    }

    Guid getId()
    {
        return FGuid.ToGuid(Request["id"]);
    }

    void LoadData()
    {
        DataList1.DataSource = NewsletterManager.CreateInstant().GetInProuct(getId());
        DataList1.DataBind();

        NewsletterEntity nl = NewsletterManager.CreateInstant().SelectOne(getId());
        EmailTemplatesEntity template = EmailTemplatesManager.CreateInstant().GetFormatEmailNewsletter(nl.Body, Util.RenderControl((Control)control));
        Response.Write(template.Body);
        Response.End();
    }
}
