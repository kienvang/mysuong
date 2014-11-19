using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ExportExcel
/// </summary>
public class ExportExcel
{
	public ExportExcel()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static void Export(DataTable tbl, string filename, Dictionary<string, string> header)
    {
        HttpResponse response = HttpContext.Current.Response;
        string attachment = "attachment; filename=" + filename;
        response.ClearContent();

        response.Charset = "Unicode";
        response.ContentEncoding = System.Text.Encoding.GetEncoding("Unicode");
        response.BinaryWrite(System.Text.Encoding.Unicode.GetPreamble());

        response.AddHeader("content-disposition", attachment);
        response.ContentType = "application/ms-excel";
        response.AppendHeader("ACCEPT-CHARSET", "UTF-8");
        response.AppendHeader("ACCEPT-ENCODING", "UTF-8");
        string tab = string.Empty;
        if (header != null)
        {
            foreach (DataColumn dtcol in tbl.Columns)
            {
                response.Write(tab + (header.ContainsKey(dtcol.ColumnName) ? header[dtcol.ColumnName] : dtcol.ColumnName));
                tab = "\t";
            }
        }
        else
        {
            foreach (DataColumn dtcol in tbl.Columns)
            {
                response.Write(tab + dtcol.ColumnName);
                tab = "\t";
            }
        }

        response.Write("\n");
        foreach (DataRow dr in tbl.Rows)
        {
            tab = "";
            for (int j = 0; j < tbl.Columns.Count; j++)
            {
                response.Write(tab + Convert.ToString(dr[j]));
                tab = "\t";
            }
            response.Write("\n");
        }
        response.End();
    }

    public static void Export(DataTable tbl, string filename)
    {
        Export(tbl, filename, null);
    }
}