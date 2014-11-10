
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.OrderCodeManager
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

namespace LayerHelper.ShopCake.BLL
{
	public class OrderCodeManager : OrderCodeManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public OrderCodeManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of OrderCodeManager
		/// </summary>
		/// <returns>An instant of OrderCodeManager class</returns>
		public static OrderCodeManager CreateInstant()
		{
			return new OrderCodeManager();
		}
	}
}
