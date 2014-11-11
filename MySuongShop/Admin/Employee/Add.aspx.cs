using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using LayerHelper.ShopCake.BLL;
using LayerHelper.ShopCake.DAL.EntityClasses;
using Library.Tools;

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

            if (hidId.Value == "")
            {

            }
            else
            {
            }
        }
    }

    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {

    }
}