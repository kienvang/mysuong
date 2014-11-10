using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CGridViewBootstrap
/// </summary>
namespace CommonClassLibrary
{
    public class CGridViewBootstrap : CGridView
    {
        public CGridViewBootstrap()
        {
            CssClass = "table table-bordered";
            AutoGenerateColumns = false;
            EmptyDataText = "Không có dữ liệu";
            AllowPaging = true;
            AllowSorting = true;
            PageSize = 20;
            HeaderStyle.CssClass = "title";
            RowStyle.CssClass = "alpha-2";
        }
    }
}