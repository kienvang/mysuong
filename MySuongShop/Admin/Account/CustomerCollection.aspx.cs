using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LayerHelper.ShopCake.BLL;

public partial class Admin_Account_CustomerCollection : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CGridView1.Init(this);
        LoadData();
    }

    public void LoadData()
    {
        DataTable users = CustomerCollectionManager.CreateInstant().GetAll();
        CGridView1.CDataBind(users);
    }
}