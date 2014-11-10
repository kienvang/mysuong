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

public partial class Admin_Account_Newsletter : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        cgridNewsletter.Init(Page);
        LoadData();
    }

    public void LoadData()
    {
        cgridNewsletter.CDataBind(NewsletterManager.CreateInstant().GetAll());
    }

    public string getState(string state)
    {
        if (state == NewsletterManager.NEW)
            return "Mới";
        if (state == NewsletterManager.PENDING)
            return "Đang gửi";
        return "Hoàn tất";
    }
}
