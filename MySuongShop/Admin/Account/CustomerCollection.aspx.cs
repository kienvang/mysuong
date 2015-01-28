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

    protected void btnExport_Click(object sender, EventArgs e)
    {
        DataTable users = CustomerCollectionManager.CreateInstant().GetAll();
        Dictionary<string, string> col = new Dictionary<string,string>();
        col.Add("Name", "Tên khách hàng");
        col.Add("Address", "Địa chỉ");
        col.Add("Phone", "Điện thoại");
        col.Add("Email", "Email");
        col.Add("date", "Ngày đăng ký");
        ExportExcel.Export(users, "Customer.xls", col);
    }
}