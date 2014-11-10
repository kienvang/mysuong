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
using Library.Tools;
using Modules;

public partial class Modules_News_Controls_NewsList : System.Web.UI.UserControl
{
    PagedDataSource pagedata = new PagedDataSource();
    private int pageNumber;
    private int pageSize;

    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable table = NewsManager.CreateInstant().GetNewsList();

        //smartPager.Visible = true;
        if ((table == null && table.Rows.Count == 0) || (table != null && table.Rows.Count == 0))
        {
            smartPager.Visible = false;
            this.Visible = false;
            return;
        }

        pagedata = Func.GetPaging(table, Request["page"], Config.GetPagging());

        this.smartPager.RowCount = pagedata.DataSourceCount;
        this.smartPager.CurrentPage = pagedata.CurrentPageIndex + 1;
        this.smartPager.PageSize = pagedata.PageSize;
        this.smartPager.Visible = this.smartPager.RowCount > this.smartPager.PageSize;
        this.smartPager.UrlFormatString = Modules.News.UrlBuilder.GetNewsPagging();

        repNews.DataSource = pagedata;
        repNews.DataBind();
    }
}
