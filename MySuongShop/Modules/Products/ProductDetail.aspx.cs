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
using Modules.Resource;

public partial class Modules_Products_ProductDetail : CPage
{
    public int IntId
    {
        get
        {
            return !string.IsNullOrEmpty(Request["IntId"]) ? FNumber.ConvertInt(Request["IntId"]) : 0;
        }
    }

    public string TextId
    {
        get
        {
            return !string.IsNullOrEmpty(Request["textId"]) ? Request["textId"] : "";
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        ProductsEntity product = ProductsManager.CreateInstant().GetProductByIntIdTextId(IntId, TextId);
        if (product != null)
        {
            CatalogsEntity cat = CatalogsManager.CreateInstant().SelectOne(product.CatalogId);

            homeTitle = product.ProductName;
            homeDescription = product.Abstract;

            fbTitle = product.ProductName;
            fbDescription = product.Abstract;
            //fbImage = Library.Tools.UrlBuilder.RootUrl + product.Thumbnail + "?w=180&h=180&c=0";
            fbImage = Library.Tools.UrlBuilder.RootUrl + ProductsManager.CreateInstant().Resize(200,200, product);
            fbUrl = Modules.Products.UrlBuilder.ViewDetail(product.CatalogId, cat.TextId, int.Parse(product.IntId.ToString()), product.TextId);

            //UpdateMetaTags();
        }
    }
}
