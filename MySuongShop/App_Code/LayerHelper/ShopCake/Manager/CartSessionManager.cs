
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.CartSessionManager
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
	public class CartSessionManager : CartSessionManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public CartSessionManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of CartSessionManager
		/// </summary>
		/// <returns>An instant of CartSessionManager class</returns>
		public static CartSessionManager CreateInstant()
		{
			return new CartSessionManager();
		}
	}
}
