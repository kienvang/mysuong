﻿using System;
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

public partial class Modules_Adverts_Controls_Adverts2 : System.Web.UI.UserControl
{
    public int Width = 195;
    public int Height = 0;
    public string PositionId = "ALL";
    public string PositionType = "L";

    public int Total = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        PositionTypeEntity type = PositionTypeManager.CreateInstant().SelectOne(PositionType);

        if (type != null)
        {
            Width = type.Width;
            Height = type.Height;
        }

        DataTable table = AdvertsManager.CreateInstant().GetAdvertGroupByPositionId(PositionId, PositionType);

        if (table != null && table.Rows.Count > 0)
        {
            Total = table.Rows.Count;
            if (PositionType == "L")
            {
                repAdverts.DataSource = table;
                repAdverts.DataBind();
            }
            else if (PositionType == "T")
            {
                repAdverts2.DataSource = table;
                repAdverts2.DataBind();
            }
            else if (PositionType == "H")
            {
                Width = 750;
                Height = 177;

                advHeader.Visible = false;
                repAdverts3.DataSource = table;
                repAdverts3.DataBind();
            }
        }
        else
            this.Visible = false;

        //}
    }
}
