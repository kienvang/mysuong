
/*
'===============================================================================
'  LayerHelper.Service.BL.AspnetSchemaVersionsManager
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
	public class AspnetSchemaVersionsManager : AspnetSchemaVersionsManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public AspnetSchemaVersionsManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of AspnetSchemaVersionsManager
		/// </summary>
		/// <returns>An instant of AspnetSchemaVersionsManager class</returns>
		public static AspnetSchemaVersionsManager CreateInstant()
		{
			return new AspnetSchemaVersionsManager();
		}
	}
}
