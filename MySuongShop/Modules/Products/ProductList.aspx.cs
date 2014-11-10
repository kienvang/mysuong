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

public partial class Modules_Products_ProductList : CPage
{
    public int CatId
    {
        get
        {
            return !string.IsNullOrEmpty(Request["catId"]) ? FNumber.ConvertInt(Request["catId"]) : 0;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        CatalogsEntity cat = CatalogsManager.CreateInstant().SelectOne(CatId);
        if (cat != null)
        {
            homeTitle = cat.CatalogName;
        }
    }
}
