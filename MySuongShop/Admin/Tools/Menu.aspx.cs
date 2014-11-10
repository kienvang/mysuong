using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using LayerHelper.ShopCake.BLL;

public partial class Admin_Tools_Menu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadData();
            loadDDL();
        }
    }

    public void LoadData()
    {
        DataTable menus = MenuManager.CreateInstant().SelectAllRDT();
        menus.DefaultView.Sort = "SortOrder, Name";
        CGridView1.CDataBind(menus);
    }

    public void loadDDL()
    {
        ddlLink.DataTextField = "Name";
        ddlLink.DataValueField = "Id";
        ddlLink.DataSource = MenuDefaultManager.CreateInstant().SelectAllRDT();
        ddlLink.DataBind();


    }

    protected void btnSave_Click(object sender, EventArgs e)
    {

    }
}