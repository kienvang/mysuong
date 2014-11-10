
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.SystemCacheManager
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
	public class SystemCacheManager : SystemCacheManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public SystemCacheManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of SystemCacheManager
		/// </summary>
		/// <returns>An instant of SystemCacheManager class</returns>
		public static SystemCacheManager CreateInstant()
		{
			return new SystemCacheManager();
		}
	}
}
