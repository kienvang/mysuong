
/*
'===============================================================================
'  LayerHelper.Service.BL.AspnetUsersInRolesManager
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
	public class AspnetUsersInRolesManager : AspnetUsersInRolesManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public AspnetUsersInRolesManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of AspnetUsersInRolesManager
		/// </summary>
		/// <returns>An instant of AspnetUsersInRolesManager class</returns>
		public static AspnetUsersInRolesManager CreateInstant()
		{
			return new AspnetUsersInRolesManager();
		}
	}
}
