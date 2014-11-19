
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.CustomerCollectionManager
'===============================================================================
*/

using System;
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
	public class CustomerCollectionManager : CustomerCollectionManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public CustomerCollectionManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of CustomerCollectionManager
		/// </summary>
		/// <returns>An instant of CustomerCollectionManager class</returns>
		public static CustomerCollectionManager CreateInstant()
		{
			return new CustomerCollectionManager();
		}

        public DataTable GetAll()
        {
            string strSQL = "Select * From CustomerCollection";
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL);
        }

        public DataTable GetByKeyword(string keyword)
        {
            string strSQL = "Select * From CustomerCollection Where Name LIKE '%' + @keyword + '%' OR Phone LIKE '%' + @keyword + '%'";
            SqlParameter param = new SqlParameter("@keyword", keyword);
            return SqlHelper.ExecuteDataTable(CommandType.Text, strSQL, param);
        }
	}
}
