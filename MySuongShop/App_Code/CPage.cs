using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Modules.Resource;

/// <summary>
/// Summary description for CPage
/// </summary>
public partial class CPage : System.Web.UI.Page
{
    protected string homeTitle { get; set; }
    protected string homeDescription { get; set; }
    protected string homeKeyword { get; set; }

    protected string fbTitle { get; set; }
    protected string fbUrl { get; set; }
    protected string fbDescription { get; set; }
    protected string fbImage { get; set; }

    protected override void OnLoad(EventArgs e)
    {
        LoadMetaTags();
        LoadMetaFacebook();
        base.OnLoad(e);
        UpdateMetaTags();
    }

    private void LoadMetaTags()
    {
        homeTitle = GetGlobalResourceObject(EnumsResourcesName.HeaderTags, "Home" + ResourcesEntity.STitle).ToString();
        homeDescription = GetGlobalResourceObject(EnumsResourcesName.HeaderTags, "Home" + ResourcesEntity.SDescription).ToString();
        homeKeyword = GetGlobalResourceObject(EnumsResourcesName.HeaderTags, "Home" + ResourcesEntity.SKeyWords).ToString();
    }

    private void LoadMetaFacebook()
    {
        fbTitle = "Cửa hàng bánh kẹo Mỹ Sướng";
        fbDescription = "";
        fbUrl = "http://mysuong.com.vn";
        fbImage = "http://mysuong.com.vn/logo.png";
    }

    public void UpdateMetaTags()
    {
        ResourcesEntity.CreateInstant().SetPage(Page, homeTitle, homeDescription, homeKeyword);
        ResourcesEntity.CreateInstant().SetFB(Page, fbTitle, fbDescription, fbUrl, fbImage);
    }
}
