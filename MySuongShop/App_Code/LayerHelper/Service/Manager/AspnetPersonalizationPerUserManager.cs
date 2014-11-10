
/*
'===============================================================================
'  LayerHelper.Service.BL.AspnetPersonalizationPerUserManager
'===============================================================================
*/

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using LayerHelper.Service.BLL;
using LayerHelper.Service.DAL;
using LayerHelper.Service.DAL.EntityClasses;
using LayerHelper.Service.DAL.FactoryClasses;
using LayerHelper.Service.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LayerHelper.Service.BLL
{
	public class AspnetPersonalizationPerUserManager : AspnetPersonalizationPerUserManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public AspnetPersonalizationPerUserManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of AspnetPersonalizationPerUserManager
		/// </summary>
		/// <returns>An instant of AspnetPersonalizationPerUserManager class</returns>
		public static AspnetPersonalizationPerUserManager CreateInstant()
		{
			return new AspnetPersonalizationPerUserManager();
		}
	}
}
