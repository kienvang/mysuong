
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.CartsManager
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
	public class CartsManager : CartsManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public CartsManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of CartsManager
		/// </summary>
		/// <returns>An instant of CartsManager class</returns>
		public static CartsManager CreateInstant()
		{
			return new CartsManager();
		}
	}
}
