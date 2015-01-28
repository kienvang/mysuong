using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LayerHelper.ShopCake.BLL;

public partial class Admin_Employee_Order : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LoadData();
    }

    void LoadData()
    {
        DataTable data = OrderTempManager.CreateInstant().GetAll(txtCustomer.Text, txtProduct.Text, txtDate.Text, txtPhone.Text);
        CGridView1.CDataBind(data);
    }

    protected void btnExport_Click(object sender, EventArgs e)
    {
        DataTable data = OrderTempManager.CreateInstant().GetAll(txtCustomer.Text, txtProduct.Text, txtDate.Text, txtPhone.Text);
        ExportExcel.Export(data, "Order.xls");
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        LoadData();
    }
}