
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.NewsletterInProductManager
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
	public class NewsletterInProductManager : NewsletterInProductManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NewsletterInProductManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of NewsletterInProductManager
		/// </summary>
		/// <returns>An instant of NewsletterInProductManager class</returns>
		public static NewsletterInProductManager CreateInstant()
		{
			return new NewsletterInProductManager();
		}
	}
}
