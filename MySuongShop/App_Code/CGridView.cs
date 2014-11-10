using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Reflection;

/// <summary>
/// Summary description for CGridView
/// </summary>
/// 
namespace CommonClassLibrary
{
    public class CGridView : GridView
    {
        private const string ASCENDING = " ASC";
        private const string DESCENDING = " DESC";
        public Object CContainer {get;set;}
        private string funcName = "LoadData";

        public string SortExpression
        {
            get
            {
                if (ViewState["sortExpression"] == null)
                    ViewState["sortExpression"] = "";

                return ViewState["sortExpression"].ToString();
            }
            set { ViewState["sortExpression"] = value; }
        }

        public string GridViewSortDirection
        {
            get
            {
                if (ViewState["sortDirection"] == null)
                    ViewState["sortDirection"] = ASCENDING;

                return ViewState["sortDirection"].ToString();
            }
            set { ViewState["sortDirection"] = value; }
        }

        public CGridView()
        {
            CssClass = "grid";
            AutoGenerateColumns = false;
            EmptyDataText = "Không có dữ liệu";
            AllowPaging = true;
            AllowSorting = true;
            PageSize = 20;
            HeaderStyle.CssClass = "title";
            RowStyle.CssClass = "row alpha-2";
        }

        public void Init(Object container)
        {
            CContainer = container;
        }

        public void Init(Object container, string func)
        {
            CContainer = container;
            funcName = func;
        }

        void CallLoadData()
        {
            if (CContainer != null)
            {
                MethodInfo mi = CContainer.GetType().GetMethod(funcName);
                mi.Invoke(CContainer, null);
            }
        }

        public void CDataBind(Object data)
        {
            if (data.GetType() == typeof(DataTable))
            {
                DataTable tbl = (DataTable)data;
                if (SortExpression != "")
                    tbl.DefaultView.Sort = SortExpression + " " + GridViewSortDirection;

                // Show data empty
                if (!(tbl != null && tbl.Rows.Count > 0))
                {
                    this.DataSource = CreateEmptyData(tbl);
                    this.DataBind();
                    
                    // Get the total number of columns in the GridView to know what the Column Span should be
                    int columnsCount = this.Columns.Count;
                    this.Rows[0].Cells.Clear();// clear all the cells in the row
                    this.Rows[0].Cells.Add(new TableCell()); //add a new blank cell
                    this.Rows[0].Cells[0].ColumnSpan = columnsCount; //set the column span to the new added cell

                    //You can set the styles here
                    this.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;
                    this.Rows[0].Cells[0].ForeColor = System.Drawing.Color.Red;
                    this.Rows[0].Cells[0].Font.Bold = true;
                    //set No Results found to the new added cell
                    this.Rows[0].Cells[0].Text = "Không có dữ liệu";
                }
                else
                {
                    this.DataSource = tbl;
                    this.DataBind();
                }
            }
            else
            {
                this.DataSource = data;
                this.DataBind();
            }
        }

        DataTable CreateEmptyData(DataTable data)
        {
            data.Rows.Add(data.NewRow());

            foreach (DataColumn col in data.Columns)
            {
                if (col.DataType == typeof(int) || col.DataType == typeof(long) || col.DataType == typeof(double) || col.DataType == typeof(Decimal))
                {
                    data.Rows[0][col] = 0;
                }
                else if (col.DataType == typeof(DateTime))
                {
                    data.Rows[0][col] = DateTime.Now;
                }
                else if (col.DataType == typeof(Boolean))
                {
                    data.Rows[0][col] = false;
                }
                else if (col.DataType == typeof(Guid))
                {
                    data.Rows[0][col] = Guid.Empty;
                }
                else
                {
                    data.Rows[0][col] = "";
                }
            }

            return data;
        }

        #region Override Evenr
        protected override void OnPageIndexChanging(GridViewPageEventArgs e)
        {
            this.PageIndex = e.NewPageIndex;
            CallLoadData();
        }

        protected override void OnRowCreated(GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header && SortExpression != String.Empty)
            {
                foreach (DataControlFieldHeaderCell headerCell in e.Row.Cells)
                {
                    int columnIndex = 0;
                    if (headerCell.ContainingField.SortExpression == SortExpression)
                    {
                        columnIndex = e.Row.Cells.GetCellIndex(headerCell);

                        Image sortImage = new Image();
                        if (GridViewSortDirection == ASCENDING)
                        {
                            sortImage.ImageUrl = "~/images/down.gif";
                            sortImage.AlternateText = "Ascending Order";
                        }
                        else
                        {
                            sortImage.ImageUrl = "~/images/up.gif";
                            sortImage.AlternateText = "Descending Order";
                        }

                        e.Row.Cells[columnIndex].Controls.Add(sortImage);
                    }
                }
            }
        }

        protected override void OnSorting(GridViewSortEventArgs e)
        {
            string sortExpression = e.SortExpression;
            if (SortExpression == "" || SortExpression != e.SortExpression)
                GridViewSortDirection = ASCENDING;
            else
            {

                if (GridViewSortDirection == ASCENDING)
                {
                    GridViewSortDirection = DESCENDING;
                }
                else
                {
                    GridViewSortDirection = ASCENDING;
                }
            }
            SortExpression = e.SortExpression;
            CallLoadData();
        }
        #endregion
    }
}