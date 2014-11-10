
/*
'===============================================================================
'  LayerHelper.Service.BL.AspnetApplicationsManager
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
	public class AspnetApplicationsManager : AspnetApplicationsManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public AspnetApplicationsManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of AspnetApplicationsManager
		/// </summary>
		/// <returns>An instant of AspnetApplicationsManager class</returns>
		public static AspnetApplicationsManager CreateInstant()
		{
			return new AspnetApplicationsManager();
		}
	}
}
