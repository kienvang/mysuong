
/*
'===============================================================================
'  LayerHelper.Service.BL.AspnetRolesManager
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
	public class AspnetRolesManager : AspnetRolesManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public AspnetRolesManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of AspnetRolesManager
		/// </summary>
		/// <returns>An instant of AspnetRolesManager class</returns>
		public static AspnetRolesManager CreateInstant()
		{
			return new AspnetRolesManager();
		}
	}
}
