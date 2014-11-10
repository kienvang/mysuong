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

using LayerHelper.ShopCake.BLL;
using LayerHelper.ShopCake.DAL.EntityClasses;
using Library.Tools;

public partial class Admin_Account_Control_NewsletterProduct : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        cgridInGroup.Init(this, "LoadInGroup");
        cgridProduct.Init(this, "LoadNewsletter");
        if (!IsPostBack)
        {
            LoadInGroup();
            LoadNewsletter();
        }
    }

    Guid getId()
    {
        return FGuid.ToGuid(Request["id"]);
    }

    public void LoadInGroup()
    {
        cgridInGroup.CDataBind(NewsletterManager.CreateInstant().GetInProuct(getId()));
    }

    public void LoadNewsletter()
    {
        cgridProduct.CDataBind(NewsletterManager.CreateInstant().GetProductSearch(getId(), txtProductName.Text.Trim(), txtCatName.Text.Trim(), txtPriceFrom.Text.Trim(), txtPriceTo.Text.Trim()));
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        LoadInGroup();
        LoadNewsletter();
    }

    protected void btnDel_Click(object sender, EventArgs e)
    {
        foreach (GridViewRow r in cgridInGroup.Rows)
        {
            CheckBox chk = (CheckBox)r.FindControl("chk");
            if (chk.Checked)
            {
                NewsletterManager.CreateInstant().DeleteGroup(getId(), FGuid.ToGuid(chk.Attributes["ProductId"]));
            }
        }
        WebUtility.Refesh(Page);
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        foreach (GridViewRow r in cgridProduct.Rows)
        {
            CheckBox chk = (CheckBox)r.FindControl("chkProduct");
            if (chk.Checked)
            {
                NewsletterInProductEntity cg = new NewsletterInProductEntity();
                cg.ProductId = FGuid.ToGuid(chk.Attributes["ProductId"]);
                cg.NewsletterId = getId();
                NewsletterInProductManager.CreateInstant().Insert(cg);
            }
        }
        WebUtility.Refesh(Page);
    }
}
