using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LayerHelper.ShopCake.DAL.EntityClasses;
using Library.Tools;

public partial class manage_customer_add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    CustomerCollectionEntity getObj()
    {
        CustomerCollectionEntity ob = new CustomerCollectionEntity();
        ob.Name = txtName.Text.Trim();
        ob.Phone = txtPhone.Text.Trim();
        ob.Email = txtEmail.Text.Trim();
        ob.Birthday = FDateTime.ConvertDate(txtBirthday.Text.Trim());
        ob.Address = txtAddress.Text.Trim();
        ob.Information = txtInformation.Text.Trim();
        ob.CreatedDate = DateTime.Now;
        ob.EmployeeId = Util
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {

        }
    }
}