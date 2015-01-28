
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.OrderTempManager
'===============================================================================
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using LayerHelper.ShopCake.BLL;
using LayerHelper.ShopCake.DAL;
using LayerHelper.ShopCake.DAL.EntityClasses;
using LayerHelper.ShopCake.DAL.FactoryClasses;
using LayerHelper.ShopCake.DAL.HelperClasses;
using Library.Tools;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LayerHelper.ShopCake.BLL
{
	public class OrderTempManager : OrderTempManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public OrderTempManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of OrderTempManager
		/// </summary>
		/// <returns>An instant of OrderTempManager class</returns>
		public static OrderTempManager CreateInstant()
		{
			return new OrderTempManager();
		}

        public DataTable GetAll(string customer, string product, string date, string phone)
        {
            string strSQL = "Select t.ProductName, Amount, Discount, c.Name as CustomerName, e.Name as EmployeeName, c.Phone, b.Name as BranchName, CONVERT(VARCHAR(19),[OrderDate], 105) + ' ' + CONVERT(VARCHAR(19),[OrderDate], 108) as OrderDate " +
                            "From OrderTemp t INNER JOIN CustomerCollection c ON t.CustomerId = c.Id " +
                            "    LEFT JOIN Employee e ON t.EmployeeId = e.Id " +
                            "    LEFT JOIN Branch b ON e.BranchId = b.Id " +
                            "{0} " +
                            "Order By t.OrderDate desc";
            List<string> where = new List<string>();
            Hashtable param = new Hashtable();

            if (customer != string.Empty)
            {
                where.Add("c.Name LIKE '%' + @customer + '%'");
                param["customer"] = customer;
            }

            if (phone != string.Empty)
            {
                where.Add("c.Phone LIKE '%' + @phone + '%'");
                param["phone"] = phone;
            }

            if (product != string.Empty)
            {
                where.Add("t.ProductName LIKE '%' + @product + '%'");
                param["product"] = product;
            }

            if (date != string.Empty)
            {
                where.Add("DATEDIFF(Day, OrderDate, @date) = 0");
                param["date"] = FDateTime.ConvertDate(date);
            }

            if (where.Count > 0)
            {
                strSQL = string.Format(strSQL, "where " + string.Join(" and ", where.ToArray()));
            }
            else
            {
                strSQL = string.Format(strSQL, "");
            }

            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, param, CommandType.Text, strSQL);
        }
	}
}
