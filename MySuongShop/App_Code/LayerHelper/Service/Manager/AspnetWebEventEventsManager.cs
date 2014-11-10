
/*
'===============================================================================
'  LayerHelper.Service.BL.AspnetWebEventEventsManager
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
	public class AspnetWebEventEventsManager : AspnetWebEventEventsManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public AspnetWebEventEventsManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of AspnetWebEventEventsManager
		/// </summary>
		/// <returns>An instant of AspnetWebEventEventsManager class</returns>
		public static AspnetWebEventEventsManager CreateInstant()
		{
			return new AspnetWebEventEventsManager();
		}
	}
}
