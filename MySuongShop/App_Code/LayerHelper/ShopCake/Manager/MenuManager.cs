
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.MenuManager
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
	public class MenuManager : MenuManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public MenuManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of MenuManager
		/// </summary>
		/// <returns>An instant of MenuManager class</returns>
		public static MenuManager CreateInstant()
		{
			return new MenuManager();
		}
	}
}
