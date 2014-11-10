
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.MenuDefaultManager
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
	public class MenuDefaultManager : MenuDefaultManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public MenuDefaultManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of MenuDefaultManager
		/// </summary>
		/// <returns>An instant of MenuDefaultManager class</returns>
		public static MenuDefaultManager CreateInstant()
		{
			return new MenuDefaultManager();
		}
	}
}
