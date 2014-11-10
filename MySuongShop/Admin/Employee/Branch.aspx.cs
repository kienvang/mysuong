using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LayerHelper.ShopCake.BLL;
using LayerHelper.ShopCake.DAL.EntityClasses;
using Library.Tools;

public partial class Admin_Employee_Branch : System.Web.UI.Page
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
        DataTable data = BranchManager.CreateInstant().GetAll();
        CGridView1.CDataBind(data);
    }

    BranchEntity GetObject()
    {
        BranchEntity g = new BranchEntity();
        g.Name = txtName.Text;
        g.Address = txtAddress.Text;
        return g;
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            BranchEntity group = GetObject();
            if (hidId.Value == string.Empty)
            {
                BranchManager.CreateInstant().Insert(group);
            }
            else
            {
                group.Id = FGuid.ToGuid(hidId.Value);
                BranchManager.CreateInstant().Update(group);
            }
            WebUtility.Refesh(Page);
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        WebUtility.Refesh(Page);
    }

    protected void CGridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        switch (e.CommandName)
        {
            case "eedit":
                BranchEntity gr = BranchManager.CreateInstant().SelectOne(FGuid.ToGuid(e.CommandArgument));
                if (gr != null)
                {
                    hidId.Value = gr.Id.ToString();
                    txtName.Text = gr.Name;
                    txtAddress.Text = gr.Address;
                    btnSave.Text = "Cập nhật";
                    btnCancel.Visible = true;
                }
                break;
            case "ddel":
                Guid id = FGuid.ToGuid(e.CommandArgument);
                BranchManager.CreateInstant().DeleteById(id);
                WebUtility.Refesh(Page);
                break;
        }
    }
}