using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LayerHelper.ShopCake.BLL;
using LayerHelper.ShopCake.DAL.EntityClasses;
using Library.Tools;
using Modules;

public partial class manage_customer_add : System.Web.UI.Page
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
        ddlDistrict.DataSource = DistrictManager.CreateInstant().GetAll();
        ddlDistrict.DataTextField = "Name";
        ddlDistrict.DataValueField = "Id";
        ddlDistrict.DataBind();
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
        ob.EmployeeId = Util.CurrentUserId;
        ob.DistrictId = FNumber.ConvertInt(ddlDistrict.SelectedValue);
        return ob;
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            CustomerCollectionEntity ob = getObj();

            if (ob.Email != string.Empty)
            {
                EmailTemplatesEntity template = EmailTemplatesManager.CreateInstant().GetTemplateByTemplateCode("CustomerRegister");
                HistoryEmail.SendMailHistory("", GetEmail.EmailFrom, ob.Email, "", GetEmail.EmailTo, template.Subject, template.Body);
            }
            CustomerCollectionManager.CreateInstant().Insert(ob);

            CookieManager.setCookie(this, "state", "1");
            WebUtility.Refesh(this);
        }
    }
}