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

public partial class manage_customer_order : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            OrderTempEntity ob = new OrderTempEntity();
            ob.CustomerId = FGuid.ToGuid(ddlCustomerId.Text);
            ob.ProductName = txtProductName.Text;
            ob.Amount = FNumber.ConvertDecimal(txtAmount.Text);
            ob.Discount = FNumber.ConvertDecimal(txtDiscount.Text);
            ob.EmployeeId = Util.CurrentUserId;
            ob.Description = txtDecription.Text;
            OrderTempManager.CreateInstant().Insert(ob);
            CookieManager.setCookie(this, "state", "1");
            WebUtility.Refesh(this);
        }
    }

    [System.Web.Services.WebMethod]
    public static List<ECustomer> customers(string keyword)
    {
        List<ECustomer> cus = new List<ECustomer>();
        DataTable tbl = CustomerCollectionManager.CreateInstant().GetByKeyword(keyword);
        if (tbl != null)
        {
            foreach (DataRow r in tbl.Rows)
            {
                cus.Add(new ECustomer { id = r["Id"].ToString(), text = r["Name"].ToString(), phone = r["Phone"].ToString() });
            }
        }
        return cus;
    }
}