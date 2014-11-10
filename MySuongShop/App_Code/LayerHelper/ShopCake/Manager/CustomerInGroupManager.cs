
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.CustomerInGroupManager
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
using SD.LLBLGen.Pro.ORMSupportClasses;
using Library.Tools;

namespace LayerHelper.ShopCake.BLL
{
	public class CustomerInGroupManager : CustomerInGroupManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public CustomerInGroupManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of CustomerInGroupManager
		/// </summary>
		/// <returns>An instant of CustomerInGroupManager class</returns>
		public static CustomerInGroupManager CreateInstant()
		{
			return new CustomerInGroupManager();
		}

        public void DeleteCustomer(Guid CustomerId, Guid GroupId)
        {
            string strSQL = "Delete From CustomerInGroup Where CustomerId = @CustomerId and GroupId = @GroupId";
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@CustomerId", CustomerId);
            param[1] = new SqlParameter("@GroupId", GroupId);
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, param);
        }
	}
}
