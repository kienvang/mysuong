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

public partial class Admin_Account_GroupInCustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        cgridInGroup.Init(this, "LoadCustomerInGroup");
        cgridCustomer.Init(this, "LoadCustomer");

        CustomerGroupEntity g = CustomerGroupManager.CreateInstant().SelectOne(getId());
        if (g != null)
        {
            lblGroupName.Text = g.Name;
        }

        if (!IsPostBack)
        {
            LoadCustomerInGroup();
            LoadCustomer();
        }
    }

    Guid getId()
    {
        return FGuid.ToGuid(Request["id"]);
    }

    public void LoadCustomerInGroup()
    {
        cgridInGroup.CDataBind(CustomersManager.CreateInstant().GetCustomerInGroup(getId()));
    }

    public void LoadCustomer()
    {
        cgridCustomer.CDataBind(CustomersManager.CreateInstant().GetCustomerSearchGroup(getId(), txtCustomerName.Text.Trim(), txtCustomerEmail.Text.Trim(), txtTotalFrom.Text.Trim(), txtTotalTo.Text.Trim()));
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        LoadCustomerInGroup();
        cgridCustomer.CDataBind(CustomersManager.CreateInstant().GetCustomerSearchGroup(getId(), txtCustomerName.Text.Trim(), txtCustomerEmail.Text.Trim(), txtTotalFrom.Text.Trim(), txtTotalTo.Text.Trim()));
    }

    protected void btnDel_Click(object sender, EventArgs e)
    {
        foreach (GridViewRow r in cgridInGroup.Rows)
        {
            CheckBox chk = (CheckBox)r.FindControl("chk");
            if (chk.Checked)
            {
                CustomerInGroupManager.CreateInstant().DeleteCustomer(FGuid.ToGuid(chk.Attributes["CustomerId"]), getId());
            }
        }
        WebUtility.Refesh(Page);
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        foreach (GridViewRow r in cgridCustomer.Rows)
        {
            CheckBox chk = (CheckBox)r.FindControl("chkCustomer");
            if (chk.Checked)
            {
                CustomerInGroupEntity cg = new CustomerInGroupEntity();
                cg.CustomerId = FGuid.ToGuid(chk.Attributes["CustomerId"]);
                cg.GroupId = getId();
                CustomerInGroupManager.CreateInstant().Insert(cg);
            }
        }
        WebUtility.Refesh(Page);
    }
}
