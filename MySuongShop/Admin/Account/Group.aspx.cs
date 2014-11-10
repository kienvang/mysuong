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

public partial class Admin_Account_Group : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadData();
        }
    }

    public void LoadData()
    {
        CGridView1.CDataBind(CustomerGroupManager.CreateInstant().GetAll());
    }

    CustomerGroupEntity GetGroup()
    {
        CustomerGroupEntity g = new CustomerGroupEntity();
        g.Name = txtName.Text.Trim();
        g.IsEnable = chkEnable.Checked;
        return g;
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            CustomerGroupEntity group = GetGroup();
            if (hidId.Value == string.Empty)
            {
                CustomerGroupManager.CreateInstant().Insert(group);
            }
            else
            {
                group.Id = FGuid.ToGuid(hidId.Value);
                CustomerGroupManager.CreateInstant().Update(group);
            }
            WebUtility.Refesh(Page);
        }
    }

    protected void CGridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        switch (e.CommandName)
        {
            case "eedit":
                CustomerGroupEntity gr = CustomerGroupManager.CreateInstant().SelectOne(FGuid.ToGuid(e.CommandArgument));
                if (gr != null)
                {
                    hidId.Value = gr.Id.ToString();
                    txtName.Text = gr.Name;
                    chkEnable.Checked = gr.IsEnable;
                    btnSave.Text = "Cập nhật";
                    btnCancel.Visible = true;
                }
                break;
            case "ddel":
                Guid id = FGuid.ToGuid(e.CommandArgument);
                CustomerInGroupManager.CreateInstant().DeleteByGroupId(id);
                NewsletterInGroupManager.CreateInstant().DeleteByGroupId(id);
                CustomerGroupManager.CreateInstant().DeleteById(id);
                WebUtility.Refesh(Page);
                break;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        WebUtility.Refesh(Page);
    }
}
