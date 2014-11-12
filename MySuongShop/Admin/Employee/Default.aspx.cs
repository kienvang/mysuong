using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using LayerHelper.ShopCake.BLL;
using LayerHelper.ShopCake.DAL.EntityClasses;
using Library.Tools;

public partial class Admin_Employee_Default : System.Web.UI.Page
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
        DataTable data = EmployeeManager.CreateInstant().GetAll();
        CGridView1.CDataBind(data);
    }

    protected void CGridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        switch (e.CommandName)
        {
            case "ddel":
                Guid id = FGuid.ToGuid(e.CommandArgument);
                EmployeeEntity emp = EmployeeManager.CreateInstant().SelectOne(id);
                if (emp != null)
                {
                    Membership.DeleteUser(emp.Username);
                    EmployeeManager.CreateInstant().DeleteById(id);
                }
                
                WebUtility.Refesh(Page);
                break;
        }
    }

    public string BranchName(Guid id)
    {
        return BranchManager.CreateInstant().GetName(id);
    }

    [System.Web.Services.WebMethod]
    public static string ChangePass(string username)
    {
        MembershipUser u = Membership.GetUser(username);
        u.ChangePassword(u.ResetPassword(), "123456");
        return "";
    }
}