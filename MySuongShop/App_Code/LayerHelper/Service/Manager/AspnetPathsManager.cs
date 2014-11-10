
/*
'===============================================================================
'  LayerHelper.Service.BL.AspnetPathsManager
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
	public class AspnetPathsManager : AspnetPathsManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public AspnetPathsManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of AspnetPathsManager
		/// </summary>
		/// <returns>An instant of AspnetPathsManager class</returns>
		public static AspnetPathsManager CreateInstant()
		{
			return new AspnetPathsManager();
		}
	}
}
