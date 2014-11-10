
/*
'===============================================================================
'  LayerHelper.Service.BL.AspnetProfileManager
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
	public class AspnetProfileManager : AspnetProfileManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public AspnetProfileManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of AspnetProfileManager
		/// </summary>
		/// <returns>An instant of AspnetProfileManager class</returns>
		public static AspnetProfileManager CreateInstant()
		{
			return new AspnetProfileManager();
		}
	}
}
