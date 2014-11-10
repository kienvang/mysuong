
/*
'===============================================================================
'  LayerHelper.Service.BL.AspnetPersonalizationAllUsersManager
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
	public class AspnetPersonalizationAllUsersManager : AspnetPersonalizationAllUsersManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public AspnetPersonalizationAllUsersManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of AspnetPersonalizationAllUsersManager
		/// </summary>
		/// <returns>An instant of AspnetPersonalizationAllUsersManager class</returns>
		public static AspnetPersonalizationAllUsersManager CreateInstant()
		{
			return new AspnetPersonalizationAllUsersManager();
		}
	}
}
