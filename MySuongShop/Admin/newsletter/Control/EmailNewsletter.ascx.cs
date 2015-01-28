using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LayerHelper.ShopCake.BLL;
using LayerHelper.ShopCake.DAL.EntityClasses;
using Library.Tools;

public partial class Admin_newsletter_Control_EmailNewsletter : System.Web.UI.UserControl
{
    public Guid Id;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public string Content()
    {
        LoadData();
        NewsletterEntity nl = NewsletterManager.CreateInstant().SelectOne(Id);
        EmailTemplatesEntity template = EmailTemplatesManager.CreateInstant().GetFormatEmailNewsletter(nl, Util.RenderControl((Control)control));
        return template.Body;
    }

    public void LoadData()
    {
        DataTable tbl = NewsletterManager.CreateInstant().GetInProuct(Id);
        DataList1.DataSource = tbl;
        DataList1.DataBind();
        if (tbl.Rows.Count == 0) control.Visible = false;
    }
}