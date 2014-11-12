using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using LayerHelper.ShopCake.BLL;
using LayerHelper.ShopCake.DAL.EntityClasses;
using Library.Tools;
using Modules.Role;

public partial class Admin_Employee_Add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadData();
        }
    }

    void LoadData()
    {
        ddlBranch.DataTextField = "Name";
        ddlBranch.DataValueField = "Id";
        ddlBranch.DataSource = BranchManager.CreateInstant().GetAll();
        ddlBranch.DataBind();

        if (Request.QueryString["id"] != "")
        {
            EmployeeEntity ob = EmployeeManager.CreateInstant().SelectOne(FGuid.ToGuid(Request.QueryString["id"]));
            if (ob != null)
            {
                hidId.Value = ob.Id.ToString();
                txtUsername.Text = ob.Username;
                txtName.Text = ob.Name;
                txtAddress.Text = ob.Address;
                txtPhone.Text = ob.Phone;
                ddlBranch.SelectedValue = ob.BranchId.ToString();

                txtUsername.Enabled = false;
            }
        }
    }

    EmployeeEntity GetObject()
    {
        EmployeeEntity ob = new EmployeeEntity();
        ob.Username = txtUsername.Text.Trim();
        ob.Name = txtName.Text.Trim();
        ob.Address = txtAddress.Text.Trim();
        ob.Phone = txtPhone.Text.Trim();
        return ob;
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            EmployeeEntity ob = GetObject();
            if (hidId.Value == string.Empty)
            {
                MembershipUser u = Membership.CreateUser(txtUsername.Text.Trim(), "123456");
                if (!Roles.RoleExists(EnumsRoles.Employee)) Roles.CreateRole(EnumsRoles.Employee);
                Roles.AddUserToRole(u.UserName, EnumsRoles.Employee);
                
                ob.Id = FGuid.ToGuid(u.ProviderUserKey.ToString());
                EmployeeManager.CreateInstant().Insert(ob);
            }
            else
            {
                ob.Id = FGuid.ToGuid(hidId.Value);
                EmployeeManager.CreateInstant().Update(ob);
            }
            Response.Redirect("Default.aspx");
        }
    }

    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        if (hidId.Value == string.Empty)
        {
            MembershipUser u = Membership.GetUser(txtUsername.Text.Trim());
            if (u != null)
            {
                args.IsValid = false;
                CustomValidator1.ErrorMessage = "Tài khoản đã tồn tại.";
            }
        }
    }
}